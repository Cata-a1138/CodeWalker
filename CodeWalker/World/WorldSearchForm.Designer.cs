namespace CodeWalker.World
{
    partial class WorldSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldSearchForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.EntitySearchTabPage = new System.Windows.Forms.TabPage();
            this.EntitySearchSetMarkersButton = new System.Windows.Forms.Button();
            this.EntitySearchExportResultsButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.EntityResultsListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EntityResultPanel = new System.Windows.Forms.Panel();
            this.EntityResultViewModelButton = new System.Windows.Forms.Button();
            this.EntityResultPropertyGrid = new CodeWalker.WinForms.ReadOnlyPropertyGrid();
            this.label7 = new System.Windows.Forms.Label();
            this.EntityResultGoToButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.EntityResultYmapTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EntityResultNameTextBox = new System.Windows.Forms.TextBox();
            this.EntitySearchStatusLabel = new System.Windows.Forms.Label();
            this.EntitySearchAbortButton = new System.Windows.Forms.Button();
            this.EntitySearchButton = new System.Windows.Forms.Button();
            this.EntitySearchLoadedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.EntitySearchHashLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EntitySearchTextBox = new System.Windows.Forms.TextBox();
            this.ArchetypeSearchTabPage = new System.Windows.Forms.TabPage();
            this.ArchetypeSearchExportResultsButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ArchetypeResultsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArchetypeResultPanel = new System.Windows.Forms.Panel();
            this.ArchetypeResultPropertyGrid = new CodeWalker.WinForms.ReadOnlyPropertyGrid();
            this.label6 = new System.Windows.Forms.Label();
            this.ArchetypeResultViewModelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ArchetypeResultFindEntitiesButton = new System.Windows.Forms.Button();
            this.ArchetypeResultYtypTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ArchetypeResultNameTextBox = new System.Windows.Forms.TextBox();
            this.ArchetypeSearchStatusLabel = new System.Windows.Forms.Label();
            this.ArchetypeSearchAbortButton = new System.Windows.Forms.Button();
            this.ArchetypeSearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ArchetypeSearchTextBox = new System.Windows.Forms.TextBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainTabControl.SuspendLayout();
            this.EntitySearchTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.EntityResultPanel.SuspendLayout();
            this.ArchetypeSearchTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ArchetypeResultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.EntitySearchTabPage);
            this.MainTabControl.Controls.Add(this.ArchetypeSearchTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(5, 6);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(738, 510);
            this.MainTabControl.TabIndex = 0;
            // 
            // EntitySearchTabPage
            // 
            this.EntitySearchTabPage.Controls.Add(this.EntitySearchSetMarkersButton);
            this.EntitySearchTabPage.Controls.Add(this.EntitySearchExportResultsButton);
            this.EntitySearchTabPage.Controls.Add(this.splitContainer2);
            this.EntitySearchTabPage.Controls.Add(this.EntitySearchStatusLabel);
            this.EntitySearchTabPage.Controls.Add(this.EntitySearchAbortButton);
            this.EntitySearchTabPage.Controls.Add(this.EntitySearchButton);
            this.EntitySearchTabPage.Controls.Add(this.EntitySearchLoadedOnlyCheckBox);
            this.EntitySearchTabPage.Controls.Add(this.EntitySearchHashLabel);
            this.EntitySearchTabPage.Controls.Add(this.label1);
            this.EntitySearchTabPage.Controls.Add(this.EntitySearchTextBox);
            this.EntitySearchTabPage.Location = new System.Drawing.Point(4, 26);
            this.EntitySearchTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntitySearchTabPage.Name = "EntitySearchTabPage";
            this.EntitySearchTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntitySearchTabPage.Size = new System.Drawing.Size(730, 480);
            this.EntitySearchTabPage.TabIndex = 0;
            this.EntitySearchTabPage.Text = "实体搜索";
            this.EntitySearchTabPage.UseVisualStyleBackColor = true;
            // 
            // EntitySearchSetMarkersButton
            // 
            this.EntitySearchSetMarkersButton.Enabled = false;
            this.EntitySearchSetMarkersButton.Location = new System.Drawing.Point(617, 13);
            this.EntitySearchSetMarkersButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntitySearchSetMarkersButton.Name = "EntitySearchSetMarkersButton";
            this.EntitySearchSetMarkersButton.Size = new System.Drawing.Size(104, 30);
            this.EntitySearchSetMarkersButton.TabIndex = 9;
            this.EntitySearchSetMarkersButton.Text = "设置标记...";
            this.EntitySearchSetMarkersButton.UseVisualStyleBackColor = true;
            this.EntitySearchSetMarkersButton.Click += new System.EventHandler(this.EntitySearchSetMarkersButton_Click);
            // 
            // EntitySearchExportResultsButton
            // 
            this.EntitySearchExportResultsButton.Enabled = false;
            this.EntitySearchExportResultsButton.Location = new System.Drawing.Point(505, 13);
            this.EntitySearchExportResultsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntitySearchExportResultsButton.Name = "EntitySearchExportResultsButton";
            this.EntitySearchExportResultsButton.Size = new System.Drawing.Size(104, 30);
            this.EntitySearchExportResultsButton.TabIndex = 6;
            this.EntitySearchExportResultsButton.Text = "导出结果...";
            this.EntitySearchExportResultsButton.UseVisualStyleBackColor = true;
            this.EntitySearchExportResultsButton.Click += new System.EventHandler(this.EntitySearchExportResultsButton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 110);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.EntityResultsListView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.EntityResultPanel);
            this.splitContainer2.Size = new System.Drawing.Size(729, 362);
            this.splitContainer2.SplitterDistance = 453;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 8;
            // 
            // EntityResultsListView
            // 
            this.EntityResultsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.EntityResultsListView.FullRowSelect = true;
            this.EntityResultsListView.HideSelection = false;
            this.EntityResultsListView.Location = new System.Drawing.Point(4, 0);
            this.EntityResultsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntityResultsListView.MultiSelect = false;
            this.EntityResultsListView.Name = "EntityResultsListView";
            this.EntityResultsListView.Size = new System.Drawing.Size(446, 356);
            this.EntityResultsListView.TabIndex = 8;
            this.EntityResultsListView.UseCompatibleStateImageBehavior = false;
            this.EntityResultsListView.View = System.Windows.Forms.View.Details;
            this.EntityResultsListView.VirtualMode = true;
            this.EntityResultsListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.EntityResultsListView_RetrieveVirtualItem);
            this.EntityResultsListView.SelectedIndexChanged += new System.EventHandler(this.EntityResultsListView_SelectedIndexChanged);
            this.EntityResultsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EntityResultsListView_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "名称";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "文件";
            this.columnHeader4.Width = 161;
            // 
            // EntityResultPanel
            // 
            this.EntityResultPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityResultPanel.Controls.Add(this.EntityResultViewModelButton);
            this.EntityResultPanel.Controls.Add(this.EntityResultPropertyGrid);
            this.EntityResultPanel.Controls.Add(this.label7);
            this.EntityResultPanel.Controls.Add(this.EntityResultGoToButton);
            this.EntityResultPanel.Controls.Add(this.label8);
            this.EntityResultPanel.Controls.Add(this.EntityResultYmapTextBox);
            this.EntityResultPanel.Controls.Add(this.label9);
            this.EntityResultPanel.Controls.Add(this.EntityResultNameTextBox);
            this.EntityResultPanel.Enabled = false;
            this.EntityResultPanel.Location = new System.Drawing.Point(4, 0);
            this.EntityResultPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntityResultPanel.Name = "EntityResultPanel";
            this.EntityResultPanel.Size = new System.Drawing.Size(264, 358);
            this.EntityResultPanel.TabIndex = 9;
            // 
            // EntityResultViewModelButton
            // 
            this.EntityResultViewModelButton.Location = new System.Drawing.Point(110, 119);
            this.EntityResultViewModelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntityResultViewModelButton.Name = "EntityResultViewModelButton";
            this.EntityResultViewModelButton.Size = new System.Drawing.Size(104, 30);
            this.EntityResultViewModelButton.TabIndex = 5;
            this.EntityResultViewModelButton.Text = "查看模型";
            this.EntityResultViewModelButton.UseVisualStyleBackColor = true;
            this.EntityResultViewModelButton.Click += new System.EventHandler(this.EntityResultViewModelButton_Click);
            // 
            // EntityResultPropertyGrid
            // 
            this.EntityResultPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityResultPropertyGrid.HelpVisible = false;
            this.EntityResultPropertyGrid.Location = new System.Drawing.Point(4, 174);
            this.EntityResultPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntityResultPropertyGrid.Name = "EntityResultPropertyGrid";
            this.EntityResultPropertyGrid.ReadOnly = true;
            this.EntityResultPropertyGrid.Size = new System.Drawing.Size(257, 183);
            this.EntityResultPropertyGrid.TabIndex = 7;
            this.EntityResultPropertyGrid.ToolbarVisible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "实体信息：";
            // 
            // EntityResultGoToButton
            // 
            this.EntityResultGoToButton.Location = new System.Drawing.Point(4, 119);
            this.EntityResultGoToButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntityResultGoToButton.Name = "EntityResultGoToButton";
            this.EntityResultGoToButton.Size = new System.Drawing.Size(104, 30);
            this.EntityResultGoToButton.TabIndex = 4;
            this.EntityResultGoToButton.Text = "传送到实体";
            this.EntityResultGoToButton.UseVisualStyleBackColor = true;
            this.EntityResultGoToButton.Click += new System.EventHandler(this.EntityResultGoToButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ymap 文件：";
            // 
            // EntityResultYmapTextBox
            // 
            this.EntityResultYmapTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityResultYmapTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EntityResultYmapTextBox.Location = new System.Drawing.Point(4, 84);
            this.EntityResultYmapTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntityResultYmapTextBox.Name = "EntityResultYmapTextBox";
            this.EntityResultYmapTextBox.ReadOnly = true;
            this.EntityResultYmapTextBox.Size = new System.Drawing.Size(255, 23);
            this.EntityResultYmapTextBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "搜索结果：";
            // 
            // EntityResultNameTextBox
            // 
            this.EntityResultNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityResultNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EntityResultNameTextBox.Location = new System.Drawing.Point(4, 30);
            this.EntityResultNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntityResultNameTextBox.Name = "EntityResultNameTextBox";
            this.EntityResultNameTextBox.ReadOnly = true;
            this.EntityResultNameTextBox.Size = new System.Drawing.Size(255, 23);
            this.EntityResultNameTextBox.TabIndex = 1;
            // 
            // EntitySearchStatusLabel
            // 
            this.EntitySearchStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntitySearchStatusLabel.AutoEllipsis = true;
            this.EntitySearchStatusLabel.Location = new System.Drawing.Point(7, 82);
            this.EntitySearchStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EntitySearchStatusLabel.Name = "EntitySearchStatusLabel";
            this.EntitySearchStatusLabel.Size = new System.Drawing.Size(715, 24);
            this.EntitySearchStatusLabel.TabIndex = 7;
            this.EntitySearchStatusLabel.Text = "就绪";
            // 
            // EntitySearchAbortButton
            // 
            this.EntitySearchAbortButton.Enabled = false;
            this.EntitySearchAbortButton.Location = new System.Drawing.Point(226, 48);
            this.EntitySearchAbortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntitySearchAbortButton.Name = "EntitySearchAbortButton";
            this.EntitySearchAbortButton.Size = new System.Drawing.Size(88, 30);
            this.EntitySearchAbortButton.TabIndex = 4;
            this.EntitySearchAbortButton.Text = "取消";
            this.EntitySearchAbortButton.UseVisualStyleBackColor = true;
            this.EntitySearchAbortButton.Click += new System.EventHandler(this.EntitySearchAbortButton_Click);
            // 
            // EntitySearchButton
            // 
            this.EntitySearchButton.Location = new System.Drawing.Point(132, 48);
            this.EntitySearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntitySearchButton.Name = "EntitySearchButton";
            this.EntitySearchButton.Size = new System.Drawing.Size(88, 30);
            this.EntitySearchButton.TabIndex = 3;
            this.EntitySearchButton.Text = "搜索";
            this.EntitySearchButton.UseVisualStyleBackColor = true;
            this.EntitySearchButton.Click += new System.EventHandler(this.EntitySearchButton_Click);
            // 
            // EntitySearchLoadedOnlyCheckBox
            // 
            this.EntitySearchLoadedOnlyCheckBox.AutoSize = true;
            this.EntitySearchLoadedOnlyCheckBox.Checked = true;
            this.EntitySearchLoadedOnlyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EntitySearchLoadedOnlyCheckBox.Location = new System.Drawing.Point(322, 19);
            this.EntitySearchLoadedOnlyCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntitySearchLoadedOnlyCheckBox.Name = "EntitySearchLoadedOnlyCheckBox";
            this.EntitySearchLoadedOnlyCheckBox.Size = new System.Drawing.Size(111, 21);
            this.EntitySearchLoadedOnlyCheckBox.TabIndex = 5;
            this.EntitySearchLoadedOnlyCheckBox.Text = "仅限已加载文件";
            this.EntitySearchLoadedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // EntitySearchHashLabel
            // 
            this.EntitySearchHashLabel.AutoSize = true;
            this.EntitySearchHashLabel.Location = new System.Drawing.Point(322, 21);
            this.EntitySearchHashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EntitySearchHashLabel.Name = "EntitySearchHashLabel";
            this.EntitySearchHashLabel.Size = new System.Drawing.Size(28, 17);
            this.EntitySearchHashLabel.TabIndex = 1;
            this.EntitySearchHashLabel.Text = "     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "搜索内容：";
            // 
            // EntitySearchTextBox
            // 
            this.EntitySearchTextBox.Location = new System.Drawing.Point(83, 17);
            this.EntitySearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntitySearchTextBox.Name = "EntitySearchTextBox";
            this.EntitySearchTextBox.Size = new System.Drawing.Size(231, 23);
            this.EntitySearchTextBox.TabIndex = 0;
            this.EntitySearchTextBox.TextChanged += new System.EventHandler(this.EntitySearchTextBox_TextChanged);
            this.EntitySearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntitySearchTextBox_KeyPress);
            // 
            // ArchetypeSearchTabPage
            // 
            this.ArchetypeSearchTabPage.Controls.Add(this.ArchetypeSearchExportResultsButton);
            this.ArchetypeSearchTabPage.Controls.Add(this.splitContainer1);
            this.ArchetypeSearchTabPage.Controls.Add(this.ArchetypeSearchStatusLabel);
            this.ArchetypeSearchTabPage.Controls.Add(this.ArchetypeSearchAbortButton);
            this.ArchetypeSearchTabPage.Controls.Add(this.ArchetypeSearchButton);
            this.ArchetypeSearchTabPage.Controls.Add(this.label3);
            this.ArchetypeSearchTabPage.Controls.Add(this.ArchetypeSearchTextBox);
            this.ArchetypeSearchTabPage.Location = new System.Drawing.Point(4, 26);
            this.ArchetypeSearchTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeSearchTabPage.Name = "ArchetypeSearchTabPage";
            this.ArchetypeSearchTabPage.Size = new System.Drawing.Size(730, 480);
            this.ArchetypeSearchTabPage.TabIndex = 1;
            this.ArchetypeSearchTabPage.Text = "定义类型搜索";
            this.ArchetypeSearchTabPage.UseVisualStyleBackColor = true;
            // 
            // ArchetypeSearchExportResultsButton
            // 
            this.ArchetypeSearchExportResultsButton.Enabled = false;
            this.ArchetypeSearchExportResultsButton.Location = new System.Drawing.Point(619, 14);
            this.ArchetypeSearchExportResultsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeSearchExportResultsButton.Name = "ArchetypeSearchExportResultsButton";
            this.ArchetypeSearchExportResultsButton.Size = new System.Drawing.Size(104, 30);
            this.ArchetypeSearchExportResultsButton.TabIndex = 5;
            this.ArchetypeSearchExportResultsButton.Text = "导出结果...";
            this.ArchetypeSearchExportResultsButton.UseVisualStyleBackColor = true;
            this.ArchetypeSearchExportResultsButton.Click += new System.EventHandler(this.ArchetypeSearchExportResultsButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 110);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ArchetypeResultsListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ArchetypeResultPanel);
            this.splitContainer1.Size = new System.Drawing.Size(729, 362);
            this.splitContainer1.SplitterDistance = 453;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 7;
            // 
            // ArchetypeResultsListView
            // 
            this.ArchetypeResultsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArchetypeResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ArchetypeResultsListView.FullRowSelect = true;
            this.ArchetypeResultsListView.HideSelection = false;
            this.ArchetypeResultsListView.Location = new System.Drawing.Point(4, 0);
            this.ArchetypeResultsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeResultsListView.MultiSelect = false;
            this.ArchetypeResultsListView.Name = "ArchetypeResultsListView";
            this.ArchetypeResultsListView.Size = new System.Drawing.Size(446, 356);
            this.ArchetypeResultsListView.TabIndex = 6;
            this.ArchetypeResultsListView.UseCompatibleStateImageBehavior = false;
            this.ArchetypeResultsListView.View = System.Windows.Forms.View.Details;
            this.ArchetypeResultsListView.VirtualMode = true;
            this.ArchetypeResultsListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.ArchetypeResultsListView_RetrieveVirtualItem);
            this.ArchetypeResultsListView.SelectedIndexChanged += new System.EventHandler(this.ArchetypeResultsListView_SelectedIndexChanged);
            this.ArchetypeResultsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ArchetypeResultsListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "文件";
            this.columnHeader2.Width = 161;
            // 
            // ArchetypeResultPanel
            // 
            this.ArchetypeResultPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArchetypeResultPanel.Controls.Add(this.ArchetypeResultPropertyGrid);
            this.ArchetypeResultPanel.Controls.Add(this.label6);
            this.ArchetypeResultPanel.Controls.Add(this.ArchetypeResultViewModelButton);
            this.ArchetypeResultPanel.Controls.Add(this.label5);
            this.ArchetypeResultPanel.Controls.Add(this.ArchetypeResultFindEntitiesButton);
            this.ArchetypeResultPanel.Controls.Add(this.ArchetypeResultYtypTextBox);
            this.ArchetypeResultPanel.Controls.Add(this.label4);
            this.ArchetypeResultPanel.Controls.Add(this.ArchetypeResultNameTextBox);
            this.ArchetypeResultPanel.Enabled = false;
            this.ArchetypeResultPanel.Location = new System.Drawing.Point(4, 0);
            this.ArchetypeResultPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeResultPanel.Name = "ArchetypeResultPanel";
            this.ArchetypeResultPanel.Size = new System.Drawing.Size(264, 358);
            this.ArchetypeResultPanel.TabIndex = 7;
            // 
            // ArchetypeResultPropertyGrid
            // 
            this.ArchetypeResultPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArchetypeResultPropertyGrid.HelpVisible = false;
            this.ArchetypeResultPropertyGrid.Location = new System.Drawing.Point(4, 174);
            this.ArchetypeResultPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeResultPropertyGrid.Name = "ArchetypeResultPropertyGrid";
            this.ArchetypeResultPropertyGrid.ReadOnly = true;
            this.ArchetypeResultPropertyGrid.Size = new System.Drawing.Size(257, 183);
            this.ArchetypeResultPropertyGrid.TabIndex = 7;
            this.ArchetypeResultPropertyGrid.ToolbarVisible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "定义类型信息：";
            // 
            // ArchetypeResultViewModelButton
            // 
            this.ArchetypeResultViewModelButton.Location = new System.Drawing.Point(110, 119);
            this.ArchetypeResultViewModelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeResultViewModelButton.Name = "ArchetypeResultViewModelButton";
            this.ArchetypeResultViewModelButton.Size = new System.Drawing.Size(104, 30);
            this.ArchetypeResultViewModelButton.TabIndex = 5;
            this.ArchetypeResultViewModelButton.Text = "查看模型";
            this.ArchetypeResultViewModelButton.UseVisualStyleBackColor = true;
            this.ArchetypeResultViewModelButton.Click += new System.EventHandler(this.ArchetypeResultViewModelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ytyp 文件：";
            // 
            // ArchetypeResultFindEntitiesButton
            // 
            this.ArchetypeResultFindEntitiesButton.Location = new System.Drawing.Point(4, 119);
            this.ArchetypeResultFindEntitiesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeResultFindEntitiesButton.Name = "ArchetypeResultFindEntitiesButton";
            this.ArchetypeResultFindEntitiesButton.Size = new System.Drawing.Size(104, 30);
            this.ArchetypeResultFindEntitiesButton.TabIndex = 4;
            this.ArchetypeResultFindEntitiesButton.Text = "查找实体";
            this.ArchetypeResultFindEntitiesButton.UseVisualStyleBackColor = true;
            this.ArchetypeResultFindEntitiesButton.Click += new System.EventHandler(this.ArchetypeResultFindEntitiesButton_Click);
            // 
            // ArchetypeResultYtypTextBox
            // 
            this.ArchetypeResultYtypTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArchetypeResultYtypTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ArchetypeResultYtypTextBox.Location = new System.Drawing.Point(4, 84);
            this.ArchetypeResultYtypTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeResultYtypTextBox.Name = "ArchetypeResultYtypTextBox";
            this.ArchetypeResultYtypTextBox.ReadOnly = true;
            this.ArchetypeResultYtypTextBox.Size = new System.Drawing.Size(255, 23);
            this.ArchetypeResultYtypTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "搜索结果：";
            // 
            // ArchetypeResultNameTextBox
            // 
            this.ArchetypeResultNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArchetypeResultNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ArchetypeResultNameTextBox.Location = new System.Drawing.Point(4, 30);
            this.ArchetypeResultNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeResultNameTextBox.Name = "ArchetypeResultNameTextBox";
            this.ArchetypeResultNameTextBox.ReadOnly = true;
            this.ArchetypeResultNameTextBox.Size = new System.Drawing.Size(255, 23);
            this.ArchetypeResultNameTextBox.TabIndex = 1;
            // 
            // ArchetypeSearchStatusLabel
            // 
            this.ArchetypeSearchStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArchetypeSearchStatusLabel.AutoEllipsis = true;
            this.ArchetypeSearchStatusLabel.Location = new System.Drawing.Point(7, 82);
            this.ArchetypeSearchStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArchetypeSearchStatusLabel.Name = "ArchetypeSearchStatusLabel";
            this.ArchetypeSearchStatusLabel.Size = new System.Drawing.Size(715, 24);
            this.ArchetypeSearchStatusLabel.TabIndex = 6;
            this.ArchetypeSearchStatusLabel.Text = "就绪";
            // 
            // ArchetypeSearchAbortButton
            // 
            this.ArchetypeSearchAbortButton.Enabled = false;
            this.ArchetypeSearchAbortButton.Location = new System.Drawing.Point(226, 48);
            this.ArchetypeSearchAbortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeSearchAbortButton.Name = "ArchetypeSearchAbortButton";
            this.ArchetypeSearchAbortButton.Size = new System.Drawing.Size(88, 30);
            this.ArchetypeSearchAbortButton.TabIndex = 4;
            this.ArchetypeSearchAbortButton.Text = "取消";
            this.ArchetypeSearchAbortButton.UseVisualStyleBackColor = true;
            this.ArchetypeSearchAbortButton.Click += new System.EventHandler(this.ArchetypeSearchAbortButton_Click);
            // 
            // ArchetypeSearchButton
            // 
            this.ArchetypeSearchButton.Location = new System.Drawing.Point(132, 48);
            this.ArchetypeSearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeSearchButton.Name = "ArchetypeSearchButton";
            this.ArchetypeSearchButton.Size = new System.Drawing.Size(88, 30);
            this.ArchetypeSearchButton.TabIndex = 3;
            this.ArchetypeSearchButton.Text = "搜索";
            this.ArchetypeSearchButton.UseVisualStyleBackColor = true;
            this.ArchetypeSearchButton.Click += new System.EventHandler(this.ArchetypeSearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "搜索内容：";
            // 
            // ArchetypeSearchTextBox
            // 
            this.ArchetypeSearchTextBox.Location = new System.Drawing.Point(83, 17);
            this.ArchetypeSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeSearchTextBox.Name = "ArchetypeSearchTextBox";
            this.ArchetypeSearchTextBox.Size = new System.Drawing.Size(231, 23);
            this.ArchetypeSearchTextBox.TabIndex = 0;
            this.ArchetypeSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ArchetypeSearchTextBox_KeyPress);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.AddExtension = false;
            this.SaveFileDialog.Filter = "Text files|*.txt|CSV files|*.csv|All files|*.*";
            // 
            // WorldSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 519);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WorldSearchForm";
            this.Text = "世界搜索 - CodeWalker by dexyfex";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorldSearchForm_FormClosed);
            this.MainTabControl.ResumeLayout(false);
            this.EntitySearchTabPage.ResumeLayout(false);
            this.EntitySearchTabPage.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.EntityResultPanel.ResumeLayout(false);
            this.EntityResultPanel.PerformLayout();
            this.ArchetypeSearchTabPage.ResumeLayout(false);
            this.ArchetypeSearchTabPage.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ArchetypeResultPanel.ResumeLayout(false);
            this.ArchetypeResultPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage EntitySearchTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EntitySearchTextBox;
        private System.Windows.Forms.Label EntitySearchHashLabel;
        private System.Windows.Forms.TabPage ArchetypeSearchTabPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ArchetypeSearchTextBox;
        private System.Windows.Forms.CheckBox EntitySearchLoadedOnlyCheckBox;
        private System.Windows.Forms.Panel ArchetypeResultPanel;
        private System.Windows.Forms.Button ArchetypeSearchButton;
        private System.Windows.Forms.ListView ArchetypeResultsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button ArchetypeResultFindEntitiesButton;
        private System.Windows.Forms.TextBox ArchetypeResultYtypTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ArchetypeResultNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ArchetypeSearchAbortButton;
        private System.Windows.Forms.Label ArchetypeSearchStatusLabel;
        private WinForms.ReadOnlyPropertyGrid ArchetypeResultPropertyGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ArchetypeResultViewModelButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView EntityResultsListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel EntityResultPanel;
        private WinForms.ReadOnlyPropertyGrid EntityResultPropertyGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button EntityResultGoToButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EntityResultYmapTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EntityResultNameTextBox;
        private System.Windows.Forms.Label EntitySearchStatusLabel;
        private System.Windows.Forms.Button EntitySearchAbortButton;
        private System.Windows.Forms.Button EntitySearchButton;
        private System.Windows.Forms.Button EntityResultViewModelButton;
        private System.Windows.Forms.Button EntitySearchExportResultsButton;
        private System.Windows.Forms.Button ArchetypeSearchExportResultsButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button EntitySearchSetMarkersButton;
    }
}