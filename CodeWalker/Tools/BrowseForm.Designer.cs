﻿namespace CodeWalker.Tools
{
    partial class BrowseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.FolderBrowseButton = new System.Windows.Forms.Button();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.ScanButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FlattenStructureCheckBox = new System.Windows.Forms.CheckBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SearchSaveResultsButton = new System.Windows.Forms.Button();
            this.SearchIgnoreTextBox = new System.Windows.Forms.TextBox();
            this.SearchIgnoreCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchBothDirectionsCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchCaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchHexRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchTextRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchResultsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchAbortButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ExportCompressCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.FileInfoLabel = new System.Windows.Forms.Label();
            this.SelectionTabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ShowLargeFileContentsCheckBox = new System.Windows.Forms.CheckBox();
            this.DataHexLineCombo = new System.Windows.Forms.ComboBox();
            this.DataTextRadio = new System.Windows.Forms.RadioButton();
            this.DataHexRadio = new System.Windows.Forms.RadioButton();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DetailsPropertyGrid = new CodeWalker.WinForms.PropertyGridFix();
            this.TexturesTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SelTexturesListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelTextureMipLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SelTextureDimensionsLabel = new System.Windows.Forms.Label();
            this.SelTextureMipTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.SelTextureNameTextBox = new System.Windows.Forms.TextBox();
            this.SelTexturePictureBox = new System.Windows.Forms.PictureBox();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TestAllButton = new System.Windows.Forms.Button();
            this.AbortButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SelectionTabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.TexturesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelTextureMipTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelTexturePictureBox)).BeginInit();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "GTAV 目录：";
            // 
            // FolderBrowseButton
            // 
            this.FolderBrowseButton.Location = new System.Drawing.Point(405, 6);
            this.FolderBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderBrowseButton.Name = "FolderBrowseButton";
            this.FolderBrowseButton.Size = new System.Drawing.Size(31, 30);
            this.FolderBrowseButton.TabIndex = 2;
            this.FolderBrowseButton.Text = "...";
            this.FolderBrowseButton.UseVisualStyleBackColor = true;
            this.FolderBrowseButton.Click += new System.EventHandler(this.FolderBrowseButton_Click);
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(105, 8);
            this.FolderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.ReadOnly = true;
            this.FolderTextBox.Size = new System.Drawing.Size(292, 23);
            this.FolderTextBox.TabIndex = 1;
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(443, 6);
            this.ScanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(88, 30);
            this.ScanButton.TabIndex = 0;
            this.ScanButton.Text = "扫描";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ExportCompressCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.ExportButton);
            this.splitContainer1.Panel2.Controls.Add(this.FileInfoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.SelectionTabControl);
            this.splitContainer1.Size = new System.Drawing.Size(994, 557);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(322, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FlattenStructureCheckBox);
            this.tabPage1.Controls.Add(this.FindButton);
            this.tabPage1.Controls.Add(this.MainTreeView);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.FindTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(314, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "浏览";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FlattenStructureCheckBox
            // 
            this.FlattenStructureCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FlattenStructureCheckBox.AutoSize = true;
            this.FlattenStructureCheckBox.Location = new System.Drawing.Point(4, 491);
            this.FlattenStructureCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlattenStructureCheckBox.Name = "FlattenStructureCheckBox";
            this.FlattenStructureCheckBox.Size = new System.Drawing.Size(116, 21);
            this.FlattenStructureCheckBox.TabIndex = 50;
            this.FlattenStructureCheckBox.Text = "扁平化 RPF 结构";
            this.FlattenStructureCheckBox.UseVisualStyleBackColor = true;
            this.FlattenStructureCheckBox.CheckedChanged += new System.EventHandler(this.FlattenStructureCheckBox_CheckedChanged);
            // 
            // FindButton
            // 
            this.FindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindButton.Location = new System.Drawing.Point(278, 6);
            this.FindButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(31, 28);
            this.FindButton.TabIndex = 11;
            this.FindButton.Text = ">";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // MainTreeView
            // 
            this.MainTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTreeView.HideSelection = false;
            this.MainTreeView.Location = new System.Drawing.Point(0, 42);
            this.MainTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(309, 442);
            this.MainTreeView.TabIndex = 12;
            this.MainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeView_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "查找";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.Location = new System.Drawing.Point(44, 7);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(229, 23);
            this.FindTextBox.TabIndex = 10;
            this.FindTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FindTextBox_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SearchSaveResultsButton);
            this.tabPage2.Controls.Add(this.SearchIgnoreTextBox);
            this.tabPage2.Controls.Add(this.SearchIgnoreCheckBox);
            this.tabPage2.Controls.Add(this.SearchBothDirectionsCheckBox);
            this.tabPage2.Controls.Add(this.SearchCaseSensitiveCheckBox);
            this.tabPage2.Controls.Add(this.SearchHexRadioButton);
            this.tabPage2.Controls.Add(this.SearchTextRadioButton);
            this.tabPage2.Controls.Add(this.SearchResultsListView);
            this.tabPage2.Controls.Add(this.SearchAbortButton);
            this.tabPage2.Controls.Add(this.SearchButton);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.SearchTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(314, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "搜索";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SearchSaveResultsButton
            // 
            this.SearchSaveResultsButton.Enabled = false;
            this.SearchSaveResultsButton.Location = new System.Drawing.Point(208, 125);
            this.SearchSaveResultsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchSaveResultsButton.Name = "SearchSaveResultsButton";
            this.SearchSaveResultsButton.Size = new System.Drawing.Size(100, 28);
            this.SearchSaveResultsButton.TabIndex = 19;
            this.SearchSaveResultsButton.Text = "保存结果...";
            this.SearchSaveResultsButton.UseVisualStyleBackColor = true;
            this.SearchSaveResultsButton.Click += new System.EventHandler(this.SearchSaveResultsButton_Click);
            // 
            // SearchIgnoreTextBox
            // 
            this.SearchIgnoreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchIgnoreTextBox.Location = new System.Drawing.Point(76, 92);
            this.SearchIgnoreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchIgnoreTextBox.Name = "SearchIgnoreTextBox";
            this.SearchIgnoreTextBox.Size = new System.Drawing.Size(233, 23);
            this.SearchIgnoreTextBox.TabIndex = 16;
            this.SearchIgnoreTextBox.Text = ".ydr, .ydd, .ytd, .yft, .ybn, .ycd, .awc, .bik";
            // 
            // SearchIgnoreCheckBox
            // 
            this.SearchIgnoreCheckBox.AutoSize = true;
            this.SearchIgnoreCheckBox.Checked = true;
            this.SearchIgnoreCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchIgnoreCheckBox.Location = new System.Drawing.Point(7, 94);
            this.SearchIgnoreCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchIgnoreCheckBox.Name = "SearchIgnoreCheckBox";
            this.SearchIgnoreCheckBox.Size = new System.Drawing.Size(63, 21);
            this.SearchIgnoreCheckBox.TabIndex = 15;
            this.SearchIgnoreCheckBox.Text = "忽略：";
            this.SearchIgnoreCheckBox.UseVisualStyleBackColor = true;
            this.SearchIgnoreCheckBox.CheckedChanged += new System.EventHandler(this.SearchIgnoreCheckBox_CheckedChanged);
            // 
            // SearchBothDirectionsCheckBox
            // 
            this.SearchBothDirectionsCheckBox.AutoSize = true;
            this.SearchBothDirectionsCheckBox.Checked = true;
            this.SearchBothDirectionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchBothDirectionsCheckBox.Location = new System.Drawing.Point(124, 65);
            this.SearchBothDirectionsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBothDirectionsCheckBox.Name = "SearchBothDirectionsCheckBox";
            this.SearchBothDirectionsCheckBox.Size = new System.Drawing.Size(75, 21);
            this.SearchBothDirectionsCheckBox.TabIndex = 14;
            this.SearchBothDirectionsCheckBox.Text = "双向搜索";
            this.SearchBothDirectionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchCaseSensitiveCheckBox
            // 
            this.SearchCaseSensitiveCheckBox.AutoSize = true;
            this.SearchCaseSensitiveCheckBox.Location = new System.Drawing.Point(7, 65);
            this.SearchCaseSensitiveCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchCaseSensitiveCheckBox.Name = "SearchCaseSensitiveCheckBox";
            this.SearchCaseSensitiveCheckBox.Size = new System.Drawing.Size(87, 21);
            this.SearchCaseSensitiveCheckBox.TabIndex = 13;
            this.SearchCaseSensitiveCheckBox.Text = "区分大小写";
            this.SearchCaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchHexRadioButton
            // 
            this.SearchHexRadioButton.AutoSize = true;
            this.SearchHexRadioButton.Location = new System.Drawing.Point(139, 8);
            this.SearchHexRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchHexRadioButton.Name = "SearchHexRadioButton";
            this.SearchHexRadioButton.Size = new System.Drawing.Size(74, 21);
            this.SearchHexRadioButton.TabIndex = 12;
            this.SearchHexRadioButton.Text = "十六进制";
            this.SearchHexRadioButton.UseVisualStyleBackColor = true;
            this.SearchHexRadioButton.CheckedChanged += new System.EventHandler(this.SearchHexRadioButton_CheckedChanged);
            // 
            // SearchTextRadioButton
            // 
            this.SearchTextRadioButton.AutoSize = true;
            this.SearchTextRadioButton.Checked = true;
            this.SearchTextRadioButton.Location = new System.Drawing.Point(81, 8);
            this.SearchTextRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTextRadioButton.Name = "SearchTextRadioButton";
            this.SearchTextRadioButton.Size = new System.Drawing.Size(50, 21);
            this.SearchTextRadioButton.TabIndex = 11;
            this.SearchTextRadioButton.TabStop = true;
            this.SearchTextRadioButton.Text = "文本";
            this.SearchTextRadioButton.UseVisualStyleBackColor = true;
            this.SearchTextRadioButton.CheckedChanged += new System.EventHandler(this.SearchTextRadioButton_CheckedChanged);
            // 
            // SearchResultsListView
            // 
            this.SearchResultsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.SearchResultsListView.FullRowSelect = true;
            this.SearchResultsListView.HideSelection = false;
            this.SearchResultsListView.Location = new System.Drawing.Point(0, 162);
            this.SearchResultsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchResultsListView.MultiSelect = false;
            this.SearchResultsListView.Name = "SearchResultsListView";
            this.SearchResultsListView.Size = new System.Drawing.Size(309, 353);
            this.SearchResultsListView.TabIndex = 20;
            this.SearchResultsListView.UseCompatibleStateImageBehavior = false;
            this.SearchResultsListView.View = System.Windows.Forms.View.Details;
            this.SearchResultsListView.VirtualMode = true;
            this.SearchResultsListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.SearchResultsListView_RetrieveVirtualItem);
            this.SearchResultsListView.SelectedIndexChanged += new System.EventHandler(this.SearchResultsListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件";
            this.columnHeader1.Width = 176;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "偏移量";
            // 
            // SearchAbortButton
            // 
            this.SearchAbortButton.Location = new System.Drawing.Point(102, 125);
            this.SearchAbortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchAbortButton.Name = "SearchAbortButton";
            this.SearchAbortButton.Size = new System.Drawing.Size(88, 28);
            this.SearchAbortButton.TabIndex = 18;
            this.SearchAbortButton.Text = "取消";
            this.SearchAbortButton.UseVisualStyleBackColor = true;
            this.SearchAbortButton.Click += new System.EventHandler(this.SearchAbortButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(7, 125);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(88, 28);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "搜索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "搜索类型：";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(4, 35);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(305, 23);
            this.SearchTextBox.TabIndex = 10;
            // 
            // ExportCompressCheckBox
            // 
            this.ExportCompressCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportCompressCheckBox.AutoSize = true;
            this.ExportCompressCheckBox.Location = new System.Drawing.Point(514, 7);
            this.ExportCompressCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportCompressCheckBox.Name = "ExportCompressCheckBox";
            this.ExportCompressCheckBox.Size = new System.Drawing.Size(51, 21);
            this.ExportCompressCheckBox.TabIndex = 105;
            this.ExportCompressCheckBox.Text = "压缩";
            this.ExportCompressCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Location = new System.Drawing.Point(567, 3);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(88, 30);
            this.ExportButton.TabIndex = 104;
            this.ExportButton.Text = "导出...";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // FileInfoLabel
            // 
            this.FileInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileInfoLabel.AutoEllipsis = true;
            this.FileInfoLabel.Location = new System.Drawing.Point(8, 8);
            this.FileInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileInfoLabel.Name = "FileInfoLabel";
            this.FileInfoLabel.Size = new System.Drawing.Size(466, 21);
            this.FileInfoLabel.TabIndex = 51;
            this.FileInfoLabel.Text = "[未选择对象]";
            // 
            // SelectionTabControl
            // 
            this.SelectionTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectionTabControl.Controls.Add(this.tabPage3);
            this.SelectionTabControl.Controls.Add(this.tabPage4);
            this.SelectionTabControl.Controls.Add(this.TexturesTabPage);
            this.SelectionTabControl.Location = new System.Drawing.Point(4, 40);
            this.SelectionTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionTabControl.Name = "SelectionTabControl";
            this.SelectionTabControl.SelectedIndex = 0;
            this.SelectionTabControl.Size = new System.Drawing.Size(656, 518);
            this.SelectionTabControl.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ShowLargeFileContentsCheckBox);
            this.tabPage3.Controls.Add(this.DataHexLineCombo);
            this.tabPage3.Controls.Add(this.DataTextRadio);
            this.tabPage3.Controls.Add(this.DataHexRadio);
            this.tabPage3.Controls.Add(this.DataTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(648, 488);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "数据";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ShowLargeFileContentsCheckBox
            // 
            this.ShowLargeFileContentsCheckBox.AutoSize = true;
            this.ShowLargeFileContentsCheckBox.Location = new System.Drawing.Point(461, 8);
            this.ShowLargeFileContentsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowLargeFileContentsCheckBox.Name = "ShowLargeFileContentsCheckBox";
            this.ShowLargeFileContentsCheckBox.Size = new System.Drawing.Size(111, 21);
            this.ShowLargeFileContentsCheckBox.TabIndex = 104;
            this.ShowLargeFileContentsCheckBox.Text = "显示大文件内容";
            this.ShowLargeFileContentsCheckBox.UseVisualStyleBackColor = true;
            this.ShowLargeFileContentsCheckBox.CheckedChanged += new System.EventHandler(this.ShowLargeFileContentsCheckBox_CheckedChanged);
            // 
            // DataHexLineCombo
            // 
            this.DataHexLineCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataHexLineCombo.FormattingEnabled = true;
            this.DataHexLineCombo.Items.AddRange(new object[] {
            "8",
            "16",
            "32"});
            this.DataHexLineCombo.Location = new System.Drawing.Point(91, 7);
            this.DataHexLineCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataHexLineCombo.Name = "DataHexLineCombo";
            this.DataHexLineCombo.Size = new System.Drawing.Size(56, 25);
            this.DataHexLineCombo.TabIndex = 101;
            this.DataHexLineCombo.SelectedIndexChanged += new System.EventHandler(this.DataHexLineCombo_SelectedIndexChanged);
            // 
            // DataTextRadio
            // 
            this.DataTextRadio.AutoSize = true;
            this.DataTextRadio.Location = new System.Drawing.Point(205, 8);
            this.DataTextRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataTextRadio.Name = "DataTextRadio";
            this.DataTextRadio.Size = new System.Drawing.Size(50, 21);
            this.DataTextRadio.TabIndex = 102;
            this.DataTextRadio.Text = "文本";
            this.DataTextRadio.UseVisualStyleBackColor = true;
            this.DataTextRadio.CheckedChanged += new System.EventHandler(this.DataTextRadio_CheckedChanged);
            // 
            // DataHexRadio
            // 
            this.DataHexRadio.AutoSize = true;
            this.DataHexRadio.Checked = true;
            this.DataHexRadio.Location = new System.Drawing.Point(7, 8);
            this.DataHexRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataHexRadio.Name = "DataHexRadio";
            this.DataHexRadio.Size = new System.Drawing.Size(74, 21);
            this.DataHexRadio.TabIndex = 100;
            this.DataHexRadio.TabStop = true;
            this.DataHexRadio.Text = "十六进制";
            this.DataHexRadio.UseVisualStyleBackColor = true;
            this.DataHexRadio.CheckedChanged += new System.EventHandler(this.DataHexRadio_CheckedChanged);
            // 
            // DataTextBox
            // 
            this.DataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTextBox.HideSelection = false;
            this.DataTextBox.Location = new System.Drawing.Point(7, 38);
            this.DataTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataTextBox.Multiline = true;
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DataTextBox.Size = new System.Drawing.Size(632, 432);
            this.DataTextBox.TabIndex = 103;
            this.DataTextBox.Text = "[请选择一个数据文件]";
            this.DataTextBox.WordWrap = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DetailsPropertyGrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(648, 488);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "详情";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DetailsPropertyGrid
            // 
            this.DetailsPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsPropertyGrid.Location = new System.Drawing.Point(7, 8);
            this.DetailsPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DetailsPropertyGrid.Name = "DetailsPropertyGrid";
            this.DetailsPropertyGrid.Size = new System.Drawing.Size(633, 464);
            this.DetailsPropertyGrid.TabIndex = 104;
            // 
            // TexturesTabPage
            // 
            this.TexturesTabPage.Controls.Add(this.splitContainer2);
            this.TexturesTabPage.Location = new System.Drawing.Point(4, 26);
            this.TexturesTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TexturesTabPage.Name = "TexturesTabPage";
            this.TexturesTabPage.Size = new System.Drawing.Size(648, 488);
            this.TexturesTabPage.TabIndex = 2;
            this.TexturesTabPage.Text = "纹理";
            this.TexturesTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SelTexturesListView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.SelTextureMipLabel);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.SelTextureDimensionsLabel);
            this.splitContainer2.Panel2.Controls.Add(this.SelTextureMipTrackBar);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.SelTextureNameTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.SelTexturePictureBox);
            this.splitContainer2.Size = new System.Drawing.Size(648, 488);
            this.splitContainer2.SplitterDistance = 206;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // SelTexturesListView
            // 
            this.SelTexturesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelTexturesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.SelTexturesListView.FullRowSelect = true;
            this.SelTexturesListView.HideSelection = false;
            this.SelTexturesListView.Location = new System.Drawing.Point(4, 4);
            this.SelTexturesListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelTexturesListView.MultiSelect = false;
            this.SelTexturesListView.Name = "SelTexturesListView";
            this.SelTexturesListView.Size = new System.Drawing.Size(199, 479);
            this.SelTexturesListView.TabIndex = 21;
            this.SelTexturesListView.UseCompatibleStateImageBehavior = false;
            this.SelTexturesListView.View = System.Windows.Forms.View.Details;
            this.SelTexturesListView.SelectedIndexChanged += new System.EventHandler(this.SelTexturesListView_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "纹理";
            this.columnHeader5.Width = 146;
            // 
            // SelTextureMipLabel
            // 
            this.SelTextureMipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelTextureMipLabel.AutoSize = true;
            this.SelTextureMipLabel.Location = new System.Drawing.Point(48, 442);
            this.SelTextureMipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelTextureMipLabel.Name = "SelTextureMipLabel";
            this.SelTextureMipLabel.Size = new System.Drawing.Size(15, 17);
            this.SelTextureMipLabel.TabIndex = 44;
            this.SelTextureMipLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "名称：";
            // 
            // SelTextureDimensionsLabel
            // 
            this.SelTextureDimensionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelTextureDimensionsLabel.AutoSize = true;
            this.SelTextureDimensionsLabel.Location = new System.Drawing.Point(350, 442);
            this.SelTextureDimensionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelTextureDimensionsLabel.Name = "SelTextureDimensionsLabel";
            this.SelTextureDimensionsLabel.Size = new System.Drawing.Size(13, 17);
            this.SelTextureDimensionsLabel.TabIndex = 42;
            this.SelTextureDimensionsLabel.Text = "-";
            // 
            // SelTextureMipTrackBar
            // 
            this.SelTextureMipTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelTextureMipTrackBar.AutoSize = false;
            this.SelTextureMipTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelTextureMipTrackBar.LargeChange = 1;
            this.SelTextureMipTrackBar.Location = new System.Drawing.Point(70, 435);
            this.SelTextureMipTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelTextureMipTrackBar.Maximum = 0;
            this.SelTextureMipTrackBar.Name = "SelTextureMipTrackBar";
            this.SelTextureMipTrackBar.Size = new System.Drawing.Size(272, 41);
            this.SelTextureMipTrackBar.TabIndex = 41;
            this.SelTextureMipTrackBar.Scroll += new System.EventHandler(this.SelTextureMipTrackBar_Scroll);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 442);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Mip:";
            // 
            // SelTextureNameTextBox
            // 
            this.SelTextureNameTextBox.Location = new System.Drawing.Point(70, 8);
            this.SelTextureNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelTextureNameTextBox.Name = "SelTextureNameTextBox";
            this.SelTextureNameTextBox.Size = new System.Drawing.Size(223, 23);
            this.SelTextureNameTextBox.TabIndex = 39;
            // 
            // SelTexturePictureBox
            // 
            this.SelTexturePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelTexturePictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.SelTexturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelTexturePictureBox.Location = new System.Drawing.Point(4, 42);
            this.SelTexturePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelTexturePictureBox.Name = "SelTexturePictureBox";
            this.SelTexturePictureBox.Size = new System.Drawing.Size(429, 376);
            this.SelTexturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelTexturePictureBox.TabIndex = 38;
            this.SelTexturePictureBox.TabStop = false;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 610);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.MainStatusStrip.Size = new System.Drawing.Size(994, 22);
            this.MainStatusStrip.TabIndex = 50;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(977, 17);
            this.StatusLabel.Spring = true;
            this.StatusLabel.Text = "请先扫描 GTAV 目录。";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestAllButton
            // 
            this.TestAllButton.Location = new System.Drawing.Point(604, 6);
            this.TestAllButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TestAllButton.Name = "TestAllButton";
            this.TestAllButton.Size = new System.Drawing.Size(110, 30);
            this.TestAllButton.TabIndex = 3;
            this.TestAllButton.Text = "测试所有文件";
            this.TestAllButton.UseVisualStyleBackColor = true;
            this.TestAllButton.Click += new System.EventHandler(this.TestAllButton_Click);
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(721, 6);
            this.AbortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(88, 30);
            this.AbortButton.TabIndex = 4;
            this.AbortButton.Text = "取消";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.AddExtension = false;
            // 
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 632);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.TestAllButton);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderBrowseButton);
            this.Controls.Add(this.FolderTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BrowseForm";
            this.Text = "RPF 浏览器 - CodeWalker by dexyfex";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BrowseForm_FormClosed);
            this.Load += new System.EventHandler(this.BrowseForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.SelectionTabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.TexturesTabPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelTextureMipTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelTexturePictureBox)).EndInit();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FolderBrowseButton;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl SelectionTabControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton DataTextRadio;
        private System.Windows.Forms.RadioButton DataHexRadio;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.ComboBox DataHexLineCombo;
        private System.Windows.Forms.Label FileInfoLabel;
        private System.Windows.Forms.Button TestAllButton;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private CodeWalker.WinForms.PropertyGridFix DetailsPropertyGrid;
        private System.Windows.Forms.Button SearchAbortButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.RadioButton SearchHexRadioButton;
        private System.Windows.Forms.RadioButton SearchTextRadioButton;
        private System.Windows.Forms.ListView SearchResultsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox SearchBothDirectionsCheckBox;
        private System.Windows.Forms.CheckBox SearchCaseSensitiveCheckBox;
        private System.Windows.Forms.TextBox SearchIgnoreTextBox;
        private System.Windows.Forms.CheckBox SearchIgnoreCheckBox;
        private System.Windows.Forms.TabPage TexturesTabPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SelTextureDimensionsLabel;
        private System.Windows.Forms.TrackBar SelTextureMipTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SelTextureNameTextBox;
        private System.Windows.Forms.PictureBox SelTexturePictureBox;
        private System.Windows.Forms.ListView SelTexturesListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label SelTextureMipLabel;
        private System.Windows.Forms.CheckBox ShowLargeFileContentsCheckBox;
        private System.Windows.Forms.CheckBox ExportCompressCheckBox;
        private System.Windows.Forms.CheckBox FlattenStructureCheckBox;
        private System.Windows.Forms.Button SearchSaveResultsButton;
    }
}