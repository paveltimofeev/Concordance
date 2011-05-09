using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security;
using System.Collections;
using Concordance.view;
using Concordance.presenter;

namespace Concordance
{
    public partial class MainForm : Form, IMainForm
    {
        private MainFormPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
            _presenter = new MainFormPresenter(this);
        }

        public string ShowFileDialog(FileDialog dialog, string title, string filepattern, bool CheckFileExists = true)
        {
            dialog.Title = title;
            dialog.Filter = filepattern;
            dialog.CheckFileExists = CheckFileExists;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return dialog.FileName;
            else
                return string.Empty;
        }

        public DialogResult ShowMessage(string message, string title = "Error", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Error)
        {
            return MessageBox.Show(message, string.Format("{0} - {1}", Application.ProductName, title), buttons, icon);
        }

        #region Обработчики событий элементов управления

        private void tsbOpenfile_Click(object sender, EventArgs e)
        {
            _presenter.OpenFile();
        }

        private void tsbScan_Click(object sender, EventArgs e)
        {
            _presenter.Scan();
        }

        private void tsbClearresults_Click(object sender, EventArgs e)
        {
            _presenter.Clear();
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            _presenter.Export();
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
            _presenter.Import();
        }

        private void dgvWords_SelectionChanged(object sender, EventArgs e)
        {
            _presenter.GetWordContexts();
        }

        ///Реализация Drag and Drop
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? e.Effect = DragDropEffects.All : e.Effect = DragDropEffects.None;
        }

        ///Реализация Drag and Drop
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files != null)
            {
                FilePath = files[0];
                _presenter.OpenExistingFile();
            }
        }

        ///Открытие или закрытие панели настроек
        private void tsShowParameters_Click(object sender, EventArgs e)
        {
            splitContainerParameterPanel.Panel1Collapsed = !splitContainerParameterPanel.Panel1Collapsed;
        }

        ///Открытие окна "О программе"
        private void tsbAbout_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        #endregion

        #region IMainForm Members

        public string FilePath { get; set; }
        public string WordRegex
        {
            get { return tbWordRegEx.Text; }
            set { tbWordRegEx.Text = value; }
        }
        public string ContextRegex
        {
            get { return tbContextRegEx.Text; }
            set { tbContextRegEx.Text = value; }
        }
        public string StatusText
        {
            get { return tsStatusMessage.Text; }
            set { tsStatusMessage.Text = value; }
        }
        public string WordsCountText
        {
            get { return tsWords.Text; }
            set { tsWords.Text = value; }
        }
        public string ContextCountText
        {
            get { return tsContexts.Text; }
            set { tsContexts.Text = value; }
        }

        public bool EnabledScanButton { get { return tsbScan.Enabled; } set { tsbScan.Enabled = value; } }
        public bool EnabledClearButton { get { return tsbClearresults.Enabled; } set { tsbClearresults.Enabled = value; } }
        public bool EnabledExportButton { get { return tsbExport.Enabled; } set { tsbExport.Enabled = value; } }

        public IList WordsDatasource
        {
            get { return (IList)dgvWords.DataSource; }
            set { dgvWords.DataSource = value; }
        }
        public IList ContextsDatasource
        {
            get { return (IList)dgvContexts.DataSource; }
            set { dgvContexts.DataSource = value; }
        }

        public string SelectedWord
        {
            get
            {
                if (dgvWords.SelectedRows.Count > 0)
                    return dgvWords.SelectedRows[0].Cells[0].Value.ToString();
                else
                    return string.Empty;
            }
        }
        public string ScaningText
        {
            get { return tbText.Text; }
            set { tbText.Text = value; }
        }

        #endregion
    }
}