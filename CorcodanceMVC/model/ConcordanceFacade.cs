using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace Concordance.model
{
    /// <summary>
    /// Фасадный класс для построения конкорданса (частотного словаря) слов в тексте и выполнения основных функций над ним.
    /// </summary>
    public class ConcordanceFacade
    {
        #region Поля и свойства класса

        /// <summary>
        /// Текст для поиска
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Регулярное выражение для поиска контекстов (предложений)
        /// </summary>
        public string ContexRegex { get; set; }

        /// <summary>
        /// Регулярное выражение для поиска слов в предложении
        /// </summary>
        public string WordRegex { get; set; }

        /// <summary>
        /// Список слов
        /// </summary>
        public IList WordList
        {
            get { return _wordCollection; }
        }

        /// <summary>
        /// Список контекстов
        /// </summary>
        public IList ContextList
        {
            get { return _contextCollection; }
        }

        /// Коллекция контекстов
        private List<ContextEntity> _contextCollection = new List<ContextEntity>();
        /// Коллекция слов
        private List<WordEntity> _wordCollection = new List<WordEntity>();

        #endregion

        /// <summary>
        /// Конструктор принимающий основные параметры
        /// </summary>
        /// <param name="text">Текст для поиска</param>
        /// <param name="contextRegex">Регулярное выражение для поиска контекстов (предложений)</param>
        /// <param name="wordRegex">Регулярное выражение для поиска слов в предложении</param>
        public ConcordanceFacade(string text, string wordRegex, string contextRegex)
        {
            ContexRegex = contextRegex;
            WordRegex = wordRegex;

            Text = Regex.Replace(text, @"[-|,|\s*]+\r\n(?<z>[а-яaz])", " ${z}"); //убираем переносы слов
            Text = Regex.Replace(Text, @"\r\n(?<z>[А-ЯA-Z])", ". ${z}");         //считаем новые строки с большой буквы началом нового предложения
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ConcordanceFacade() : this("", "", "") { ;}

        /// <summary>
        /// Сканирование файла
        /// </summary>
        /// <param name="sort">Сортировать найденные слова по алфавиту. Увеличивает время сканирования примерно на 7% (в зависимости от конфигурации рабочей станции).</param>
        public void Scan(bool sort)
        {
            Clear();

            ///Ищем контексты
            Read(ContexRegex, "sentance", Text, new ReadHandler(ReadContext), null);

            onContextListUpdated(EventArgs.Empty);

            ///В каждом контексте ищем слова
            for (int i = 0; i < _contextCollection.Count; i++)
            {
                Read(WordRegex, "word", _contextCollection[i].Context, new ReadHandler(ReadWord), i);
            }
            if (sort)
                _wordCollection.Sort();

            onWordListUpdated(EventArgs.Empty);
        }

        /// <summary>
        /// Очистка списков слов и контекстов
        /// </summary>
        public void Clear()
        {
            _contextCollection.Clear();
            _wordCollection.Clear();

            onCleared(EventArgs.Empty);
        }

        /// <summary>
        /// Возвращает список контекстов определённого слова
        /// </summary>
        /// <param name="word">Слово</param>
        public IList ContextOfWord(string word)
        {
            int wordId = _wordCollection.IndexOf(word);
            List<int> contexts = _wordCollection[wordId].Contexts;

            List<ContextEntity> result = new List<ContextEntity>();
            for (int i = 0; i < contexts.Count; i++)
            {
                result.Add(_contextCollection[contexts[i]]);
            }

            return result;
        }

        /// <summary>
        /// Выгрузка в xml
        /// </summary>
        public void Export(string path)
        {
            using (FileStream streamXml = new FileStream(path, FileMode.Create))
            {
                EntityContainer container = new EntityContainer();
                container.WordCollection = _wordCollection;
                container.ContextCollection = _contextCollection;

                XmlSerializer sr = new XmlSerializer(typeof(EntityContainer));
                sr.Serialize(streamXml, container);
                streamXml.Flush();
                streamXml.Close();
            }
        }

        /// <summary>
        /// Чтение из xml
        /// </summary>
        /// <param name="path"></param>
        public void Import(string path)
        {
            using (FileStream streamXml = new FileStream(path, FileMode.Open))
            {
                XmlSerializer sr = new XmlSerializer(typeof(EntityContainer));
                EntityContainer container = (EntityContainer)sr.Deserialize(streamXml);
                streamXml.Flush();
                streamXml.Close();

                _contextCollection = container.ContextCollection;
                _wordCollection = container.WordCollection;
            }

            onContextListUpdated(EventArgs.Empty);
            onWordListUpdated(EventArgs.Empty);
        }

        #region Операции чтения и поиска
        delegate void ReadHandler(string value, int position, object state);

        /// <summary>
        /// Поиск именованных групп в тексте с помощью регулярного выражения
        /// </summary>
        /// <param name="regex">Регулярное выражение</param>
        /// <param name="groupname">Имя группы</param>
        /// <param name="text">Текст</param>
        /// <param name="handler">Делегат вызываемый при обраружении соответствия</param>
        /// <param name="state">Дополнительные параметры</param>
        private void Read(string regex, string groupname, string text, ReadHandler handler, object state)
        {
            Regex reg = new Regex(regex, RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
            Match m = reg.Match(text);
            while (m.Success)
            {
                handler.Invoke(m.Groups[groupname].Value, m.Index, state);
                m = m.NextMatch();
            }
        }

        /// <summary>
        /// Добавление контекста в коллекцию
        /// </summary>
        private void ReadContext(string context, int position, object state)
        {
            _contextCollection.Add(new ContextEntity(context, position));
        }

        /// <summary>
        /// Добавление слова в коллекцию если такого слова еще нет, инкриментация счётчика вхождений если такое слово в коллекции уже есть.
        /// </summary>
        private void ReadWord(string word, int position, object state)
        {
            if (!_wordCollection.Contains(word))
                _wordCollection.Add(new WordEntity(word, (int)state));
            else
            {
                WordEntity entity = _wordCollection[_wordCollection.IndexOf(word)];
                entity.Count++;
                if (!entity.Contexts.Contains((int)state))
                    entity.Contexts.Add((int)state);
            }
        }
        #endregion

        #region События

        /// <summary>
        /// Событие возникает после обновления списка слов
        /// </summary>
        public event EventHandler WordListUpdated;
        /// <summary>
        /// Событие возникает после обновления списка контекстов
        /// </summary>
        public event EventHandler ContextListUpdated;
        /// <summary>
        /// Событие возникает после завершения очистки коллекций
        /// </summary>
        public event EventHandler Cleared;

        protected virtual void onWordListUpdated(EventArgs e)
        {
            if (WordListUpdated != null)
                WordListUpdated(this, e);
        }
        protected virtual void onContextListUpdated(EventArgs e)
        {
            EventHandler hdlr = ContextListUpdated;
            if (hdlr != null)
                hdlr(this, e);
        }
        protected virtual void onCleared(EventArgs e)
        {
            EventHandler hdlr = Cleared;
            if (hdlr != null)
                hdlr(this, e);
        }

        #endregion
    }
}