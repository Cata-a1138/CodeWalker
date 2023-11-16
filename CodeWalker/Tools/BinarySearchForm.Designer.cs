namespace CodeWalker.Tools
{
    partial class BinarySearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinarySearchForm));
            this.FileSearchTextRadio = new System.Windows.Forms.RadioButton();
            this.FileSearchHexRadio = new System.Windows.Forms.RadioButton();
            this.FileSearchAbortButton = new System.Windows.Forms.Button();
            this.FileSearchResultsTextBox = new System.Windows.Forms.TextBox();
            this.FileSearchTextBox = new System.Windows.Forms.TextBox();
            this.FileSearchFolderBrowseButton = new System.Windows.Forms.Button();
            this.FileSearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FileSearchFolderTextBox = new System.Windows.Forms.TextBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.SearchRPFTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RpfSearchOnlyTextBox = new System.Windows.Forms.TextBox();
            this.RpfSearchOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.RpfSearchSaveResultsButton = new System.Windows.Forms.Button();
            this.RpfSearchIgnoreTextBox = new System.Windows.Forms.TextBox();
            this.RpfSearchIgnoreCheckBox = new System.Windows.Forms.CheckBox();
            this.RpfSearchBothDirectionsCheckBox = new System.Windows.Forms.CheckBox();
            this.RpfSearchCaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.RpfSearchHexRadioButton = new System.Windows.Forms.RadioButton();
            this.RpfSearchTextRadioButton = new System.Windows.Forms.RadioButton();
            this.RpfSearchResultsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RpfSearchAbortButton = new System.Windows.Forms.Button();
            this.RpfSearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RpfSearchTextBox = new System.Windows.Forms.TextBox();
            this.ExportCompressCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.FileInfoLabel = new System.Windows.Forms.Label();
            this.ShowLargeFileContentsCheckBox = new System.Windows.Forms.CheckBox();
            this.DataHexLineCombo = new System.Windows.Forms.ComboBox();
            this.DataTextRadio = new System.Windows.Forms.RadioButton();
            this.DataHexRadio = new System.Windows.Forms.RadioButton();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.SearchFileSystemTab = new System.Windows.Forms.TabPage();
            this.FileSearchPanel = new System.Windows.Forms.Panel();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainTabControl.SuspendLayout();
            this.SearchRPFTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SearchFileSystemTab.SuspendLayout();
            this.FileSearchPanel.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileSearchTextRadio
            // 
            this.FileSearchTextRadio.AutoSize = true;
            this.FileSearchTextRadio.Location = new System.Drawing.Point(189, 44);
            this.FileSearchTextRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileSearchTextRadio.Name = "FileSearchTextRadio";
            this.FileSearchTextRadio.Size = new System.Drawing.Size(50, 21);
            this.FileSearchTextRadio.TabIndex = 45;
            this.FileSearchTextRadio.Text = "文本";
            this.FileSearchTextRadio.UseVisualStyleBackColor = true;
            // 
            // FileSearchHexRadio
            // 
            this.FileSearchHexRadio.AutoSize = true;
            this.FileSearchHexRadio.Checked = true;
            this.FileSearchHexRadio.Location = new System.Drawing.Point(99, 44);
            this.FileSearchHexRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileSearchHexRadio.Name = "FileSearchHexRadio";
            this.FileSearchHexRadio.Size = new System.Drawing.Size(74, 21);
            this.FileSearchHexRadio.TabIndex = 44;
            this.FileSearchHexRadio.TabStop = true;
            this.FileSearchHexRadio.Text = "十六进制";
            this.FileSearchHexRadio.UseVisualStyleBackColor = true;
            // 
            // FileSearchAbortButton
            // 
            this.FileSearchAbortButton.Location = new System.Drawing.Point(492, 38);
            this.FileSearchAbortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileSearchAbortButton.Name = "FileSearchAbortButton";
            this.FileSearchAbortButton.Size = new System.Drawing.Size(88, 30);
            this.FileSearchAbortButton.TabIndex = 43;
            this.FileSearchAbortButton.Text = "取消";
            this.FileSearchAbortButton.UseVisualStyleBackColor = true;
            this.FileSearchAbortButton.Click += new System.EventHandler(this.FileSearchAbortButton_Click);
            // 
            // FileSearchResultsTextBox
            // 
            this.FileSearchResultsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSearchResultsTextBox.Location = new System.Drawing.Point(11, 102);
            this.FileSearchResultsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileSearchResultsTextBox.Multiline = true;
            this.FileSearchResultsTextBox.Name = "FileSearchResultsTextBox";
            this.FileSearchResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FileSearchResultsTextBox.Size = new System.Drawing.Size(901, 443);
            this.FileSearchResultsTextBox.TabIndex = 42;
            this.FileSearchResultsTextBox.WordWrap = false;
            // 
            // FileSearchTextBox
            // 
            this.FileSearchTextBox.Location = new System.Drawing.Point(250, 42);
            this.FileSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileSearchTextBox.Name = "FileSearchTextBox";
            this.FileSearchTextBox.Size = new System.Drawing.Size(138, 23);
            this.FileSearchTextBox.TabIndex = 41;
            this.FileSearchTextBox.Text = "4a03746e";
            // 
            // FileSearchFolderBrowseButton
            // 
            this.FileSearchFolderBrowseButton.Location = new System.Drawing.Point(396, 1);
            this.FileSearchFolderBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileSearchFolderBrowseButton.Name = "FileSearchFolderBrowseButton";
            this.FileSearchFolderBrowseButton.Size = new System.Drawing.Size(31, 30);
            this.FileSearchFolderBrowseButton.TabIndex = 40;
            this.FileSearchFolderBrowseButton.Text = "...";
            this.FileSearchFolderBrowseButton.UseVisualStyleBackColor = true;
            this.FileSearchFolderBrowseButton.Click += new System.EventHandler(this.FileSearchFolderBrowseButton_Click);
            // 
            // FileSearchButton
            // 
            this.FileSearchButton.Location = new System.Drawing.Point(396, 38);
            this.FileSearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileSearchButton.Name = "FileSearchButton";
            this.FileSearchButton.Size = new System.Drawing.Size(88, 30);
            this.FileSearchButton.TabIndex = 39;
            this.FileSearchButton.Text = "搜索";
            this.FileSearchButton.UseVisualStyleBackColor = true;
            this.FileSearchButton.Click += new System.EventHandler(this.FileSearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "搜索文件夹：";
            // 
            // FileSearchFolderTextBox
            // 
            this.FileSearchFolderTextBox.Location = new System.Drawing.Point(96, 4);
            this.FileSearchFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileSearchFolderTextBox.Name = "FileSearchFolderTextBox";
            this.FileSearchFolderTextBox.Size = new System.Drawing.Size(292, 23);
            this.FileSearchFolderTextBox.TabIndex = 37;
            this.FileSearchFolderTextBox.Text = "Compiled944";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.SearchRPFTabPage);
            this.MainTabControl.Controls.Add(this.SearchFileSystemTab);
            this.MainTabControl.Location = new System.Drawing.Point(4, 7);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(952, 584);
            this.MainTabControl.TabIndex = 46;
            // 
            // SearchRPFTabPage
            // 
            this.SearchRPFTabPage.Controls.Add(this.splitContainer1);
            this.SearchRPFTabPage.Location = new System.Drawing.Point(4, 26);
            this.SearchRPFTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchRPFTabPage.Name = "SearchRPFTabPage";
            this.SearchRPFTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchRPFTabPage.Size = new System.Drawing.Size(944, 554);
            this.SearchRPFTabPage.TabIndex = 0;
            this.SearchRPFTabPage.Text = "搜索 RPF 内容";
            this.SearchRPFTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchOnlyTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchOnlyCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchSaveResultsButton);
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchIgnoreTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchIgnoreCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchBothDirectionsCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchCaseSensitiveCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchHexRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchTextRadioButton);
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchResultsListView);
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchAbortButton);
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchButton);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.RpfSearchTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ExportCompressCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.ExportButton);
            this.splitContainer1.Panel2.Controls.Add(this.FileInfoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ShowLargeFileContentsCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.DataHexLineCombo);
            this.splitContainer1.Panel2.Controls.Add(this.DataTextRadio);
            this.splitContainer1.Panel2.Controls.Add(this.DataHexRadio);
            this.splitContainer1.Panel2.Controls.Add(this.DataTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(936, 546);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // RpfSearchOnlyTextBox
            // 
            this.RpfSearchOnlyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RpfSearchOnlyTextBox.Enabled = false;
            this.RpfSearchOnlyTextBox.Location = new System.Drawing.Point(79, 120);
            this.RpfSearchOnlyTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchOnlyTextBox.Name = "RpfSearchOnlyTextBox";
            this.RpfSearchOnlyTextBox.Size = new System.Drawing.Size(218, 23);
            this.RpfSearchOnlyTextBox.TabIndex = 66;
            this.RpfSearchOnlyTextBox.Text = ".ysc, .rel";
            // 
            // RpfSearchOnlyCheckBox
            // 
            this.RpfSearchOnlyCheckBox.AutoSize = true;
            this.RpfSearchOnlyCheckBox.Location = new System.Drawing.Point(10, 123);
            this.RpfSearchOnlyCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchOnlyCheckBox.Name = "RpfSearchOnlyCheckBox";
            this.RpfSearchOnlyCheckBox.Size = new System.Drawing.Size(63, 21);
            this.RpfSearchOnlyCheckBox.TabIndex = 65;
            this.RpfSearchOnlyCheckBox.Text = "仅限：";
            this.RpfSearchOnlyCheckBox.UseVisualStyleBackColor = true;
            this.RpfSearchOnlyCheckBox.CheckedChanged += new System.EventHandler(this.RpfSearchOnlyCheckBox_CheckedChanged);
            // 
            // RpfSearchSaveResultsButton
            // 
            this.RpfSearchSaveResultsButton.Enabled = false;
            this.RpfSearchSaveResultsButton.Location = new System.Drawing.Point(196, 155);
            this.RpfSearchSaveResultsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchSaveResultsButton.Name = "RpfSearchSaveResultsButton";
            this.RpfSearchSaveResultsButton.Size = new System.Drawing.Size(100, 28);
            this.RpfSearchSaveResultsButton.TabIndex = 62;
            this.RpfSearchSaveResultsButton.Text = "保存结果...";
            this.RpfSearchSaveResultsButton.UseVisualStyleBackColor = true;
            this.RpfSearchSaveResultsButton.Click += new System.EventHandler(this.RpfSearchSaveResultsButton_Click);
            // 
            // RpfSearchIgnoreTextBox
            // 
            this.RpfSearchIgnoreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RpfSearchIgnoreTextBox.Location = new System.Drawing.Point(79, 89);
            this.RpfSearchIgnoreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchIgnoreTextBox.Name = "RpfSearchIgnoreTextBox";
            this.RpfSearchIgnoreTextBox.Size = new System.Drawing.Size(218, 23);
            this.RpfSearchIgnoreTextBox.TabIndex = 59;
            this.RpfSearchIgnoreTextBox.Text = ".ydr, .ydd, .ytd, .yft, .ybn, .ycd, .awc, .bik";
            // 
            // RpfSearchIgnoreCheckBox
            // 
            this.RpfSearchIgnoreCheckBox.AutoSize = true;
            this.RpfSearchIgnoreCheckBox.Checked = true;
            this.RpfSearchIgnoreCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RpfSearchIgnoreCheckBox.Location = new System.Drawing.Point(10, 92);
            this.RpfSearchIgnoreCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchIgnoreCheckBox.Name = "RpfSearchIgnoreCheckBox";
            this.RpfSearchIgnoreCheckBox.Size = new System.Drawing.Size(63, 21);
            this.RpfSearchIgnoreCheckBox.TabIndex = 58;
            this.RpfSearchIgnoreCheckBox.Text = "忽略：";
            this.RpfSearchIgnoreCheckBox.UseVisualStyleBackColor = true;
            this.RpfSearchIgnoreCheckBox.CheckedChanged += new System.EventHandler(this.RpfSearchIgnoreCheckBox_CheckedChanged);
            // 
            // RpfSearchBothDirectionsCheckBox
            // 
            this.RpfSearchBothDirectionsCheckBox.AutoSize = true;
            this.RpfSearchBothDirectionsCheckBox.Checked = true;
            this.RpfSearchBothDirectionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RpfSearchBothDirectionsCheckBox.Location = new System.Drawing.Point(127, 62);
            this.RpfSearchBothDirectionsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchBothDirectionsCheckBox.Name = "RpfSearchBothDirectionsCheckBox";
            this.RpfSearchBothDirectionsCheckBox.Size = new System.Drawing.Size(75, 21);
            this.RpfSearchBothDirectionsCheckBox.TabIndex = 57;
            this.RpfSearchBothDirectionsCheckBox.Text = "双向搜索";
            this.RpfSearchBothDirectionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // RpfSearchCaseSensitiveCheckBox
            // 
            this.RpfSearchCaseSensitiveCheckBox.AutoSize = true;
            this.RpfSearchCaseSensitiveCheckBox.Location = new System.Drawing.Point(10, 62);
            this.RpfSearchCaseSensitiveCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchCaseSensitiveCheckBox.Name = "RpfSearchCaseSensitiveCheckBox";
            this.RpfSearchCaseSensitiveCheckBox.Size = new System.Drawing.Size(87, 21);
            this.RpfSearchCaseSensitiveCheckBox.TabIndex = 56;
            this.RpfSearchCaseSensitiveCheckBox.Text = "区分大小写";
            this.RpfSearchCaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // RpfSearchHexRadioButton
            // 
            this.RpfSearchHexRadioButton.AutoSize = true;
            this.RpfSearchHexRadioButton.Location = new System.Drawing.Point(184, 7);
            this.RpfSearchHexRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchHexRadioButton.Name = "RpfSearchHexRadioButton";
            this.RpfSearchHexRadioButton.Size = new System.Drawing.Size(74, 21);
            this.RpfSearchHexRadioButton.TabIndex = 55;
            this.RpfSearchHexRadioButton.Text = "十六进制";
            this.RpfSearchHexRadioButton.UseVisualStyleBackColor = true;
            // 
            // RpfSearchTextRadioButton
            // 
            this.RpfSearchTextRadioButton.AutoSize = true;
            this.RpfSearchTextRadioButton.Checked = true;
            this.RpfSearchTextRadioButton.Location = new System.Drawing.Point(124, 7);
            this.RpfSearchTextRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchTextRadioButton.Name = "RpfSearchTextRadioButton";
            this.RpfSearchTextRadioButton.Size = new System.Drawing.Size(50, 21);
            this.RpfSearchTextRadioButton.TabIndex = 54;
            this.RpfSearchTextRadioButton.TabStop = true;
            this.RpfSearchTextRadioButton.Text = "文本";
            this.RpfSearchTextRadioButton.UseVisualStyleBackColor = true;
            this.RpfSearchTextRadioButton.CheckedChanged += new System.EventHandler(this.RpfSearchTextRadioButton_CheckedChanged);
            // 
            // RpfSearchResultsListView
            // 
            this.RpfSearchResultsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RpfSearchResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.RpfSearchResultsListView.FullRowSelect = true;
            this.RpfSearchResultsListView.HideSelection = false;
            this.RpfSearchResultsListView.Location = new System.Drawing.Point(4, 191);
            this.RpfSearchResultsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchResultsListView.MultiSelect = false;
            this.RpfSearchResultsListView.Name = "RpfSearchResultsListView";
            this.RpfSearchResultsListView.Size = new System.Drawing.Size(294, 345);
            this.RpfSearchResultsListView.TabIndex = 63;
            this.RpfSearchResultsListView.UseCompatibleStateImageBehavior = false;
            this.RpfSearchResultsListView.View = System.Windows.Forms.View.Details;
            this.RpfSearchResultsListView.VirtualMode = true;
            this.RpfSearchResultsListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.RpfSearchResultsListView_RetrieveVirtualItem);
            this.RpfSearchResultsListView.SelectedIndexChanged += new System.EventHandler(this.RpfSearchResultsListView_SelectedIndexChanged);
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
            // RpfSearchAbortButton
            // 
            this.RpfSearchAbortButton.Location = new System.Drawing.Point(100, 155);
            this.RpfSearchAbortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchAbortButton.Name = "RpfSearchAbortButton";
            this.RpfSearchAbortButton.Size = new System.Drawing.Size(88, 28);
            this.RpfSearchAbortButton.TabIndex = 61;
            this.RpfSearchAbortButton.Text = "取消";
            this.RpfSearchAbortButton.UseVisualStyleBackColor = true;
            this.RpfSearchAbortButton.Click += new System.EventHandler(this.RpfSearchAbortButton_Click);
            // 
            // RpfSearchButton
            // 
            this.RpfSearchButton.Location = new System.Drawing.Point(4, 155);
            this.RpfSearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchButton.Name = "RpfSearchButton";
            this.RpfSearchButton.Size = new System.Drawing.Size(88, 28);
            this.RpfSearchButton.TabIndex = 60;
            this.RpfSearchButton.Text = "搜索";
            this.RpfSearchButton.UseVisualStyleBackColor = true;
            this.RpfSearchButton.Click += new System.EventHandler(this.RpfSearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "搜索类型：";
            // 
            // RpfSearchTextBox
            // 
            this.RpfSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RpfSearchTextBox.Location = new System.Drawing.Point(4, 30);
            this.RpfSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RpfSearchTextBox.Name = "RpfSearchTextBox";
            this.RpfSearchTextBox.Size = new System.Drawing.Size(294, 23);
            this.RpfSearchTextBox.TabIndex = 53;
            // 
            // ExportCompressCheckBox
            // 
            this.ExportCompressCheckBox.AutoSize = true;
            this.ExportCompressCheckBox.Location = new System.Drawing.Point(102, 45);
            this.ExportCompressCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportCompressCheckBox.Name = "ExportCompressCheckBox";
            this.ExportCompressCheckBox.Size = new System.Drawing.Size(99, 21);
            this.ExportCompressCheckBox.TabIndex = 112;
            this.ExportCompressCheckBox.Text = "压缩导出内容";
            this.ExportCompressCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(7, 41);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(88, 30);
            this.ExportButton.TabIndex = 111;
            this.ExportButton.Text = "导出...";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // FileInfoLabel
            // 
            this.FileInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileInfoLabel.AutoEllipsis = true;
            this.FileInfoLabel.Location = new System.Drawing.Point(4, 8);
            this.FileInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileInfoLabel.Name = "FileInfoLabel";
            this.FileInfoLabel.Size = new System.Drawing.Size(597, 21);
            this.FileInfoLabel.TabIndex = 110;
            this.FileInfoLabel.Text = "[未选择对象]";
            // 
            // ShowLargeFileContentsCheckBox
            // 
            this.ShowLargeFileContentsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowLargeFileContentsCheckBox.AutoSize = true;
            this.ShowLargeFileContentsCheckBox.Location = new System.Drawing.Point(513, 80);
            this.ShowLargeFileContentsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowLargeFileContentsCheckBox.Name = "ShowLargeFileContentsCheckBox";
            this.ShowLargeFileContentsCheckBox.Size = new System.Drawing.Size(111, 21);
            this.ShowLargeFileContentsCheckBox.TabIndex = 109;
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
            this.DataHexLineCombo.Location = new System.Drawing.Point(91, 76);
            this.DataHexLineCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataHexLineCombo.Name = "DataHexLineCombo";
            this.DataHexLineCombo.Size = new System.Drawing.Size(56, 25);
            this.DataHexLineCombo.TabIndex = 106;
            this.DataHexLineCombo.SelectedIndexChanged += new System.EventHandler(this.DataHexLineCombo_SelectedIndexChanged);
            // 
            // DataTextRadio
            // 
            this.DataTextRadio.AutoSize = true;
            this.DataTextRadio.Location = new System.Drawing.Point(158, 79);
            this.DataTextRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataTextRadio.Name = "DataTextRadio";
            this.DataTextRadio.Size = new System.Drawing.Size(50, 21);
            this.DataTextRadio.TabIndex = 107;
            this.DataTextRadio.Text = "文本";
            this.DataTextRadio.UseVisualStyleBackColor = true;
            // 
            // DataHexRadio
            // 
            this.DataHexRadio.AutoSize = true;
            this.DataHexRadio.Checked = true;
            this.DataHexRadio.Location = new System.Drawing.Point(7, 79);
            this.DataHexRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataHexRadio.Name = "DataHexRadio";
            this.DataHexRadio.Size = new System.Drawing.Size(74, 21);
            this.DataHexRadio.TabIndex = 105;
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
            this.DataTextBox.Location = new System.Drawing.Point(5, 120);
            this.DataTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataTextBox.Multiline = true;
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DataTextBox.Size = new System.Drawing.Size(619, 415);
            this.DataTextBox.TabIndex = 108;
            this.DataTextBox.Text = "[请选择一个搜索结果]";
            this.DataTextBox.WordWrap = false;
            // 
            // SearchFileSystemTab
            // 
            this.SearchFileSystemTab.Controls.Add(this.FileSearchPanel);
            this.SearchFileSystemTab.Controls.Add(this.FileSearchResultsTextBox);
            this.SearchFileSystemTab.Location = new System.Drawing.Point(4, 26);
            this.SearchFileSystemTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchFileSystemTab.Name = "SearchFileSystemTab";
            this.SearchFileSystemTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchFileSystemTab.Size = new System.Drawing.Size(919, 525);
            this.SearchFileSystemTab.TabIndex = 1;
            this.SearchFileSystemTab.Text = "搜索文件系统";
            this.SearchFileSystemTab.UseVisualStyleBackColor = true;
            // 
            // FileSearchPanel
            // 
            this.FileSearchPanel.Controls.Add(this.FileSearchFolderTextBox);
            this.FileSearchPanel.Controls.Add(this.FileSearchFolderBrowseButton);
            this.FileSearchPanel.Controls.Add(this.FileSearchTextRadio);
            this.FileSearchPanel.Controls.Add(this.FileSearchTextBox);
            this.FileSearchPanel.Controls.Add(this.FileSearchButton);
            this.FileSearchPanel.Controls.Add(this.FileSearchHexRadio);
            this.FileSearchPanel.Controls.Add(this.FileSearchAbortButton);
            this.FileSearchPanel.Controls.Add(this.label2);
            this.FileSearchPanel.Location = new System.Drawing.Point(4, 8);
            this.FileSearchPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileSearchPanel.Name = "FileSearchPanel";
            this.FileSearchPanel.Size = new System.Drawing.Size(908, 86);
            this.FileSearchPanel.TabIndex = 46;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 600);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.MainStatusStrip.Size = new System.Drawing.Size(959, 22);
            this.MainStatusStrip.TabIndex = 47;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(942, 17);
            this.StatusLabel.Spring = true;
            this.StatusLabel.Text = "初始化中...";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.AddExtension = false;
            // 
            // BinarySearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 622);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BinarySearchForm";
            this.Text = "二进制搜索 - CodeWalker by dexyfex";
            this.Load += new System.EventHandler(this.BinarySearchForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.SearchRPFTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.SearchFileSystemTab.ResumeLayout(false);
            this.SearchFileSystemTab.PerformLayout();
            this.FileSearchPanel.ResumeLayout(false);
            this.FileSearchPanel.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton FileSearchTextRadio;
        private System.Windows.Forms.RadioButton FileSearchHexRadio;
        private System.Windows.Forms.Button FileSearchAbortButton;
        private System.Windows.Forms.TextBox FileSearchResultsTextBox;
        private System.Windows.Forms.TextBox FileSearchTextBox;
        private System.Windows.Forms.Button FileSearchFolderBrowseButton;
        private System.Windows.Forms.Button FileSearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileSearchFolderTextBox;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage SearchRPFTabPage;
        private System.Windows.Forms.TabPage SearchFileSystemTab;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Panel FileSearchPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button RpfSearchSaveResultsButton;
        private System.Windows.Forms.TextBox RpfSearchIgnoreTextBox;
        private System.Windows.Forms.CheckBox RpfSearchIgnoreCheckBox;
        private System.Windows.Forms.CheckBox RpfSearchBothDirectionsCheckBox;
        private System.Windows.Forms.CheckBox RpfSearchCaseSensitiveCheckBox;
        private System.Windows.Forms.RadioButton RpfSearchHexRadioButton;
        private System.Windows.Forms.RadioButton RpfSearchTextRadioButton;
        private System.Windows.Forms.ListView RpfSearchResultsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button RpfSearchAbortButton;
        private System.Windows.Forms.Button RpfSearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RpfSearchTextBox;
        private System.Windows.Forms.TextBox RpfSearchOnlyTextBox;
        private System.Windows.Forms.CheckBox RpfSearchOnlyCheckBox;
        private System.Windows.Forms.CheckBox ShowLargeFileContentsCheckBox;
        private System.Windows.Forms.ComboBox DataHexLineCombo;
        private System.Windows.Forms.RadioButton DataTextRadio;
        private System.Windows.Forms.RadioButton DataHexRadio;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Label FileInfoLabel;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.CheckBox ExportCompressCheckBox;
        private System.Windows.Forms.Button ExportButton;
    }
}