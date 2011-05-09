using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Diagnostics;
using Concordance.view;
using Concordance.model;
using Concordance.Properties;

namespace Concordance.presenter
{
    /// <summary>
    /// IMainForm Presenter. Класс отвечающий за проведение представления IMainForm и взаимодействие его с моделью.
    /// </summary>
    public class MainFormPresenter
    {
        private IMainForm _view;
        private ConcordanceFacade _facade = new ConcordanceFacade();
        private delegate void ImportExportHandler(string path);

        public MainFormPresenter(IMainForm view)
        {
            _view = view;
            _facade.Cleared += new EventHandler(_facade_Cleared);
            _facade.WordListUpdated += new EventHandler(_facade_WordListUpdated);
        }

        private void _facade_WordListUpdated(object sender, EventArgs e)
        {
            _view.WordsDatasource = _facade.WordList;
            _view.WordsCountText = _facade.WordList.Count.ToString();

            _view.EnabledExportButton = true;
            _view.EnabledClearButton = true;
        }

        private void _facade_Cleared(object sender, EventArgs e)
        {
            _view.WordsDatasource = new List<WordEntity>();
            _view.WordsCountText = _facade.WordList.Count.ToString();
            _view.ContextsDatasource = new List<ContextEntity>();
            _view.ContextCountText = Resources.MainFormPresenterClearContextsValue;

            _view.EnabledExportButton = false;
            _view.EnabledClearButton = false;
        }

        /// <summary>
        /// Чтение файла с запросом имени файла
        /// </summary>
        public void OpenFile()
        {
            _view.FilePath = _view.ShowFileDialog(new OpenFileDialog(), Resources.MainFormPresenterOpenFileDialogTitle, Resources.MainFormPresenterOpenFileFilter);
            OpenExistingFile();
        }

        /// <summary>
        /// Чтение файла
        /// </summary>
        public void OpenExistingFile()
        {
            try
            {
                string file = File.ReadAllText(_view.FilePath, Encoding.Default);

                _facade.Text = file;
                _facade.WordRegex = _view.WordRegex;
                _facade.ContexRegex = _view.ContextRegex;
 
                _view.ScaningText = _facade.Text;
                _view.EnabledScanButton = true;
                _view.Text = string.Format(Resources.MainFormPresenterFormTitleMask, Application.ProductName, Path.GetFileName(_view.FilePath));
            }
            catch (UnauthorizedAccessException uex) { _view.ShowMessage(uex.Message, Resources.MainFormPresenterAccessErrorTitle); }
            catch (SecurityException sex) { _view.ShowMessage(sex.Message, Resources.MainFormPresenterSecurityErrorTitle); }
            catch (IOException iex) { _view.ShowMessage(iex.Message, Resources.MainFormPresenterIOErrorTitle); }
            catch (Exception ex) { _view.ShowMessage(ex.Message); }
        }

        /// <summary>
        /// Сканирование (анализ) файла
        /// </summary>
        public void Scan()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            try
            {
                _facade.Scan(true);
            }
            catch (Exception ex) { _view.ShowMessage(ex.Message, Resources.MainFormPresenterScanErrorTitle); }

            _view.StatusText = string.Format(Resources.MainFormPresenterStatusMask, sw.ElapsedMilliseconds / 1000F);
        }

        /// <summary>
        /// Очистка результата
        /// </summary>
        public void Clear()
        {
            _facade.Clear();
        }

        /// <summary>
        /// Получение контекста выбранного слова
        /// </summary>
        public void GetWordContexts()
        {
            if (!string.IsNullOrEmpty(_view.SelectedWord))
            {
                _view.ContextsDatasource = _facade.ContextOfWord(_view.SelectedWord);
                _view.ContextCountText = string.Format(Resources.MainFormPresenterContextsMask, _view.ContextsDatasource.Count, _facade.ContextList.Count);
            }
        }

        /// <summary>
        /// Сохранение результата в файл  с запросом имени файла
        /// </summary>
        public void Export()
        {
            string path = _view.ShowFileDialog(new SaveFileDialog(), Resources.MainFormPresenterExportFileDialogTitle, Resources.MainFormPresenterImportExportFileFilter, false);
            ImportExport(new ImportExportHandler(_facade.Export), path);
        }

        /// <summary>
        /// Загрузка данных из внешнего файла  с запросом имени файла
        /// </summary>
        public void Import()
        {
            string path = _view.ShowFileDialog(new OpenFileDialog(), Resources.MainFormPresenterImportFileDialogTitle, Resources.MainFormPresenterImportExportFileFilter);
            ImportExport(new ImportExportHandler(_facade.Import), path);
        }

        /// <summary>
        /// Реализация опрераций чтения/записи данных
        /// </summary>
        private void ImportExport(ImportExportHandler handler, string path)
        {
            if (!string.IsNullOrEmpty(path))
                try
                {
                    handler.Invoke(path);
                    _view.ShowMessage(Resources.MainFormPresenterSuccessMessage, Resources.MainFormPresenterSuccessTitle, icon: MessageBoxIcon.Information);
                }
                catch (SecurityException sex) { _view.ShowMessage(sex.Message, Resources.MainFormPresenterSecurityErrorTitle); }
                catch (IOException iex) { _view.ShowMessage(iex.Message, Resources.MainFormPresenterIOErrorTitle); }
                catch (Exception ex) { _view.ShowMessage(ex.Message); }
        }
    }
}
