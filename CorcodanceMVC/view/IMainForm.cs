using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Concordance.view
{
    public interface IMainForm : IForm
    {
        /// <summary>
        /// Задаёт или возвращает путь к файлу сканирования
        /// </summary>
        string FilePath { get; set; }
        /// <summary>
        /// Задает или возвращает регулярное выражение поиска слов
        /// </summary>
        string WordRegex { get; set; }
        /// <summary>
        /// Задает или возвращает регулярное выражение поиска контекстов
        /// </summary>
        string ContextRegex { get; set; }
        /// <summary>
        /// Задаёт или возвращает значение элемента управления для отображения анализируемого текста
        /// </summary>
        string ScaningText { get; set; }
        /// <summary>
        /// Возвращает выбранное слово для получения контекста
        /// </summary>
        string SelectedWord { get; }

        /// <summary>
        /// Задаёт или возвращает значение статусной строки
        /// </summary>
        string StatusText { get; set; }
        /// <summary>
        /// Задаёт или возвращает значение элемента управления для отображения кол-ва слов в конкордансе
        /// </summary>
        string WordsCountText { get; set; }
        /// <summary>
        /// Задаёт или возвращает значение элемента управления для отображения кол-ва контекстов
        /// </summary>
        string ContextCountText { get; set; }

        /// <summary>
        /// Задаёт или возвращает источник данных элемента управления для отображения слов
        /// </summary>
        IList WordsDatasource { get; set; }
        /// <summary>
        /// Задаёт или возвращает источник данных элемента управления для отображения контекстов
        /// </summary>
        IList ContextsDatasource { get; set; }

        #region Кнопки панели управления
        /// <summary>
        /// Задаёт или возвращает доступность кнопки Scan
        /// </summary>
        bool EnabledScanButton { get; set; }
        /// <summary>
        /// Задаёт или возвращает доступность кнопки Clear results
        /// </summary>
        bool EnabledClearButton { get; set; }
        /// <summary>
        /// Задаёт или возвращает доступность кнопки Export
        /// </summary>
        bool EnabledExportButton { get; set; }
        #endregion
    }
}
