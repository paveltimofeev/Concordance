using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Concordance.model
{
    /// <summary>
    /// Класс представляющий одно слово
    /// </summary>
    [Serializable]
    public class WordEntity : IComparable<WordEntity>
    {
        /// <summary>
        /// Слово
        /// </summary>
        [XmlAttribute]
        public string Word { get; set; }

        /// <summary>
        /// Счётчик
        /// </summary>
        [XmlAttribute]
        public int Count { get; set; }

        /// <summary>
        /// ID контекстов (предложений использующих это слово)
        /// </summary>
        public List<int> Contexts { get; set; }

        /// <summary>
        /// Конструктор без параметров для возможности сереализовать класс в xml
        /// </summary>
        public WordEntity() { ;}

        public WordEntity(string word)
        {
            this.Word = word;
            Count = 1;
            Contexts = new List<int>();
        }

        public WordEntity(string word, int contextId)
        {
            this.Word = word;
            Count = 1;
            Contexts = new List<int>();
            Contexts.Add(contextId);
        }

        /// <summary>
        /// Переопределяем методы ToString, Equals, GetHashCode для выполнения сравнения экземпляров классов WordEntity на основании значения поля Word.
        /// </summary>
        public override string ToString()
        {
            return this.Word;
        }

        public override bool Equals(object obj)
        {
            WordEntity temp = obj as WordEntity;
            if (temp != null)
                return Word.ToUpperInvariant().Equals(temp.Word.ToUpperInvariant());
            else
                return false;
        }

        public override int GetHashCode()
        {
            return this.Word.ToUpperInvariant().GetHashCode();
        }

        /// <summary>
        /// Определим возможность неявнеого преобразования типа string к типу WordEntity
        /// </summary>
        public static implicit operator WordEntity(string type)
        {
            return new WordEntity(type);
        }

        #region IComparable<WordEntity> Members

        /// <summary>
        /// Реализуем интерфейс IComparable<WordEntity> для выполнения быстрой сортировки средствами фреймворка.
        /// </summary>
        public int CompareTo(WordEntity other)
        {
            return Word.CompareTo(other.Word);
        }

        #endregion
    }
}
