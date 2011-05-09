using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concordance.model
{
    /// <summary>
    /// Класс-контейнер для сериализации и десериалицации коллекций ContextEntity и WordEntity
    /// </summary>
    [Serializable]
    public class EntityContainer
    {
        /// <summary>
        /// Коллекция контекстов
        /// </summary>
        public List<ContextEntity> ContextCollection { get; set; }
        /// <summary>
        /// Коллекция слов
        /// </summary>
        public List<WordEntity> WordCollection { get; set; }

        public EntityContainer()
        {
            ContextCollection = new List<ContextEntity>();
            WordCollection = new List<WordEntity>();
        }
    }
}
