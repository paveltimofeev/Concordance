using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Concordance.model
{
    /// <summary>
    /// Класс представляющий контекст слова (предложение)
    /// </summary>
    [Serializable]
    public class ContextEntity
    {
        /// <summary>
        /// Предложение
        /// </summary>
        [XmlAttribute]
        public string Context { get; set; }

        /// <summary>
        /// Позиция в тексте
        /// </summary>
        [XmlAttribute]
        public int Position { get; set; }

        /// <summary>
        /// Конструктор без указания позиции контекста. Будет указана позиция по умолчанию (0).
        /// </summary>
        /// <param name="context">Контекст (предложение)</param>
        public ContextEntity(string context) : this(context, 0) { ;}

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="context">Контекст (предложение)</param>
        /// <param name="position">Позиция первого символа контекста в тексте</param>
        public ContextEntity(string context, int position)
        {
            Context = context;
            Position = position;
        }

        /// <summary>
        /// Конструктор без параметров для возможности сереализовать класс в xml
        /// </summary>
        public ContextEntity() : this("") { ;}

        /// <summary>
        /// Переопределяем методы ToString, Equals, GetHashCode для выполнения сравнения экземпляров классов ContextEntity на основании значения поля Context.
        /// </summary>
        public override bool Equals(object obj)
        {
            ContextEntity temp = obj as ContextEntity;
            if (temp != null)
                return Context.ToUpperInvariant().Equals(temp.Context.ToUpperInvariant());
            else
                return false;
        }

        public override int GetHashCode()
        {
            return Context.GetHashCode();
        }

        public override string ToString()
        {
            return Context.ToString();
        }
    }
}
