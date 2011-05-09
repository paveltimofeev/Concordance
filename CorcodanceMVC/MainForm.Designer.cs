namespace Concordance
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvContexts = new System.Windows.Forms.DataGridView();
            this.Context = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsTools = new System.Windows.Forms.ToolStrip();
            this.tsbOpenfile = new System.Windows.Forms.ToolStripButton();
            this.tsbScan = new System.Windows.Forms.ToolStripButton();
            this.tsbClearresults = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsShowParameters = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsWordsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsWords = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsContextsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsContexts = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerParameterPanel = new System.Windows.Forms.SplitContainer();
            this.gbSearchParameters = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWordRegEx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContextRegEx = new System.Windows.Forms.TextBox();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.gbText = new System.Windows.Forms.GroupBox();
            this.tbText = new System.Windows.Forms.TextBox();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContexts)).BeginInit();
            this.tsTools.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.splitContainerParameterPanel.Panel1.SuspendLayout();
            this.splitContainerParameterPanel.Panel2.SuspendLayout();
            this.splitContainerParameterPanel.SuspendLayout();
            this.gbSearchParameters.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.gbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(3, 16);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvWords);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dgvContexts);
            this.splitContainer.Size = new System.Drawing.Size(805, 365);
            this.splitContainer.SplitterDistance = 230;
            this.splitContainer.TabIndex = 0;
            // 
            // dgvWords
            // 
            this.dgvWords.AllowUserToAddRows = false;
            this.dgvWords.AllowUserToDeleteRows = false;
            this.dgvWords.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.Count});
            this.dgvWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWords.Location = new System.Drawing.Point(0, 0);
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.ReadOnly = true;
            this.dgvWords.RowHeadersVisible = false;
            this.dgvWords.RowTemplate.ReadOnly = true;
            this.dgvWords.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWords.Size = new System.Drawing.Size(230, 365);
            this.dgvWords.TabIndex = 0;
            this.dgvWords.SelectionChanged += new System.EventHandler(this.dgvWords_SelectionChanged);
            // 
            // Word
            // 
            this.Word.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Word.DataPropertyName = "word";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Word.DefaultCellStyle = dataGridViewCellStyle1;
            this.Word.HeaderText = "Word";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Count.DefaultCellStyle = dataGridViewCellStyle2;
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 75;
            // 
            // dgvContexts
            // 
            this.dgvContexts.AllowUserToAddRows = false;
            this.dgvContexts.AllowUserToDeleteRows = false;
            this.dgvContexts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContexts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvContexts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContexts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Context,
            this.Position});
            this.dgvContexts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContexts.Location = new System.Drawing.Point(0, 0);
            this.dgvContexts.Name = "dgvContexts";
            this.dgvContexts.ReadOnly = true;
            this.dgvContexts.RowHeadersVisible = false;
            this.dgvContexts.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvContexts.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dgvContexts.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContexts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContexts.Size = new System.Drawing.Size(571, 365);
            this.dgvContexts.TabIndex = 0;
            // 
            // Context
            // 
            this.Context.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Context.DataPropertyName = "context";
            this.Context.HeaderText = "Context";
            this.Context.Name = "Context";
            this.Context.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Position.DefaultCellStyle = dataGridViewCellStyle3;
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // tsTools
            // 
            this.tsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenfile,
            this.tsbScan,
            this.tsbClearresults,
            this.toolStripSeparator3,
            this.tsbImport,
            this.tsbExport,
            this.toolStripSeparator1,
            this.tsShowParameters,
            this.toolStripSeparator2,
            this.tsbAbout});
            this.tsTools.Location = new System.Drawing.Point(0, 0);
            this.tsTools.Name = "tsTools";
            this.tsTools.Size = new System.Drawing.Size(811, 25);
            this.tsTools.TabIndex = 1;
            this.tsTools.Text = "toolStrip1";
            // 
            // tsbOpenfile
            // 
            this.tsbOpenfile.Image = global::Concordance.Properties.Resources.TextboxHS;
            this.tsbOpenfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenfile.Name = "tsbOpenfile";
            this.tsbOpenfile.Size = new System.Drawing.Size(87, 22);
            this.tsbOpenfile.Text = "&Open file ...";
            this.tsbOpenfile.ToolTipText = "Open file...";
            this.tsbOpenfile.Click += new System.EventHandler(this.tsbOpenfile_Click);
            // 
            // tsbScan
            // 
            this.tsbScan.Enabled = false;
            this.tsbScan.Image = global::Concordance.Properties.Resources.FormRunHS;
            this.tsbScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScan.Name = "tsbScan";
            this.tsbScan.Size = new System.Drawing.Size(52, 22);
            this.tsbScan.Text = "&Scan";
            this.tsbScan.Click += new System.EventHandler(this.tsbScan_Click);
            // 
            // tsbClearresults
            // 
            this.tsbClearresults.Enabled = false;
            this.tsbClearresults.Image = global::Concordance.Properties.Resources.DeleteHS;
            this.tsbClearresults.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearresults.Name = "tsbClearresults";
            this.tsbClearresults.Size = new System.Drawing.Size(91, 22);
            this.tsbClearresults.Text = "&Clear results";
            this.tsbClearresults.Click += new System.EventHandler(this.tsbClearresults_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbImport
            // 
            this.tsbImport.Image = global::Concordance.Properties.Resources.ImportXMLHS;
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(72, 22);
            this.tsbImport.Text = "&Import...";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.Enabled = false;
            this.tsbExport.Image = global::Concordance.Properties.Resources.XMLFileHS;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(69, 22);
            this.tsbExport.Text = "&Export...";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsShowParameters
            // 
            this.tsShowParameters.Image = global::Concordance.Properties.Resources.FillDownHS;
            this.tsShowParameters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsShowParameters.Name = "tsShowParameters";
            this.tsShowParameters.Size = new System.Drawing.Size(86, 22);
            this.tsShowParameters.Text = "&Parameters";
            this.tsShowParameters.Click += new System.EventHandler(this.tsShowParameters_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAbout
            // 
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(44, 22);
            this.tsbAbout.Text = "&About";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsWordsLabel,
            this.tsWords,
            this.tsContextsLabel,
            this.tsContexts,
            this.tsStatusMessage});
            this.ssStatus.Location = new System.Drawing.Point(0, 553);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(811, 24);
            this.ssStatus.TabIndex = 2;
            // 
            // tsWordsLabel
            // 
            this.tsWordsLabel.Name = "tsWordsLabel";
            this.tsWordsLabel.Size = new System.Drawing.Size(106, 19);
            this.tsWordsLabel.Text = "Number of words: ";
            // 
            // tsWords
            // 
            this.tsWords.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsWords.Name = "tsWords";
            this.tsWords.Size = new System.Drawing.Size(17, 19);
            this.tsWords.Text = "0";
            // 
            // tsContextsLabel
            // 
            this.tsContextsLabel.Name = "tsContextsLabel";
            this.tsContextsLabel.Size = new System.Drawing.Size(115, 19);
            this.tsContextsLabel.Text = "Number of contexts:";
            // 
            // tsContexts
            // 
            this.tsContexts.Name = "tsContexts";
            this.tsContexts.Size = new System.Drawing.Size(13, 19);
            this.tsContexts.Text = "0";
            // 
            // tsStatusMessage
            // 
            this.tsStatusMessage.Name = "tsStatusMessage";
            this.tsStatusMessage.Size = new System.Drawing.Size(545, 19);
            this.tsStatusMessage.Spring = true;
            this.tsStatusMessage.Text = "Status";
            this.tsStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainerParameterPanel
            // 
            this.splitContainerParameterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerParameterPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerParameterPanel.Location = new System.Drawing.Point(0, 25);
            this.splitContainerParameterPanel.Name = "splitContainerParameterPanel";
            this.splitContainerParameterPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerParameterPanel.Panel1
            // 
            this.splitContainerParameterPanel.Panel1.Controls.Add(this.gbSearchParameters);
            this.splitContainerParameterPanel.Panel1Collapsed = true;
            // 
            // splitContainerParameterPanel.Panel2
            // 
            this.splitContainerParameterPanel.Panel2.Controls.Add(this.gbResults);
            this.splitContainerParameterPanel.Panel2.Controls.Add(this.gbText);
            this.splitContainerParameterPanel.Size = new System.Drawing.Size(811, 528);
            this.splitContainerParameterPanel.SplitterDistance = 70;
            this.splitContainerParameterPanel.TabIndex = 3;
            // 
            // gbSearchParameters
            // 
            this.gbSearchParameters.Controls.Add(this.label2);
            this.gbSearchParameters.Controls.Add(this.tbWordRegEx);
            this.gbSearchParameters.Controls.Add(this.label1);
            this.gbSearchParameters.Controls.Add(this.tbContextRegEx);
            this.gbSearchParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearchParameters.Location = new System.Drawing.Point(0, 0);
            this.gbSearchParameters.Name = "gbSearchParameters";
            this.gbSearchParameters.Size = new System.Drawing.Size(150, 70);
            this.gbSearchParameters.TabIndex = 2;
            this.gbSearchParameters.TabStop = false;
            this.gbSearchParameters.Text = "Search parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Context\'s regular exprerssion";
            // 
            // tbWordRegEx
            // 
            this.tbWordRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWordRegEx.Location = new System.Drawing.Point(153, 15);
            this.tbWordRegEx.Name = "tbWordRegEx";
            this.tbWordRegEx.Size = new System.Drawing.Size(0, 20);
            this.tbWordRegEx.TabIndex = 0;
            this.tbWordRegEx.Text = "\\b(?<word>[\\w\\\'\\-]+)\\b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word\'s regular exprerssion";
            // 
            // tbContextRegEx
            // 
            this.tbContextRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContextRegEx.Location = new System.Drawing.Point(153, 41);
            this.tbContextRegEx.Name = "tbContextRegEx";
            this.tbContextRegEx.Size = new System.Drawing.Size(0, 20);
            this.tbContextRegEx.TabIndex = 0;
            this.tbContextRegEx.Text = "[^.!?]\\r*\\n*\\f*\\s*(?<sentance>[\\w\\s\\\'\\,\\-\\:\\(\\)]+[.!?$])";
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.splitContainer);
            this.gbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResults.Location = new System.Drawing.Point(0, 144);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(811, 384);
            this.gbResults.TabIndex = 1;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Concordance";
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.tbText);
            this.gbText.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbText.Location = new System.Drawing.Point(0, 0);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(811, 144);
            this.gbText.TabIndex = 2;
            this.gbText.TabStop = false;
            this.gbText.Text = "Text";
            // 
            // tbText
            // 
            this.tbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbText.Location = new System.Drawing.Point(3, 16);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ReadOnly = true;
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbText.Size = new System.Drawing.Size(805, 125);
            this.tbText.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 577);
            this.Controls.Add(this.splitContainerParameterPanel);
            this.Controls.Add(this.tsTools);
            this.Controls.Add(this.ssStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Concordance";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContexts)).EndInit();
            this.tsTools.ResumeLayout(false);
            this.tsTools.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.splitContainerParameterPanel.Panel1.ResumeLayout(false);
            this.splitContainerParameterPanel.Panel2.ResumeLayout(false);
            this.splitContainerParameterPanel.ResumeLayout(false);
            this.gbSearchParameters.ResumeLayout(false);
            this.gbSearchParameters.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbText.ResumeLayout(false);
            this.gbText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.ToolStrip tsTools;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusMessage;
        private System.Windows.Forms.ToolStripStatusLabel tsWords;
        private System.Windows.Forms.ToolStripStatusLabel tsContexts;
        private System.Windows.Forms.ToolStripStatusLabel tsWordsLabel;
        private System.Windows.Forms.ToolStripStatusLabel tsContextsLabel;
        private System.Windows.Forms.SplitContainer splitContainerParameterPanel;
        private System.Windows.Forms.TextBox tbContextRegEx;
        private System.Windows.Forms.TextBox tbWordRegEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSearchParameters;
        private System.Windows.Forms.ToolStripButton tsbScan;
        private System.Windows.Forms.ToolStripButton tsbOpenfile;
        private System.Windows.Forms.ToolStripButton tsbClearresults;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsShowParameters;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.GroupBox gbText;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private System.Windows.Forms.DataGridView dgvContexts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Context;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
    }
}

