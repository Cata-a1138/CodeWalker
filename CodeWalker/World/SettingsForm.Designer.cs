namespace CodeWalker.World
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ControlsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MouseInvertCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CameraSmoothingUpDown = new System.Windows.Forms.NumericUpDown();
            this.CameraSensitivityUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KeyBindingNameLabel = new System.Windows.Forms.Label();
            this.KeyBindingsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyBindingComboBox = new System.Windows.Forms.ComboBox();
            this.KeyBindButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdvancedTabPage = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.CollisionCacheSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TextureCacheSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.GeometryCacheSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.GPUFlushTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.GPUCacheTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ExcludeFoldersTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CacheTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CacheSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShadowCascadesUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FolderBrowseButton = new System.Windows.Forms.Button();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.ControlsTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraSmoothingUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraSensitivityUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.AdvancedTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CollisionCacheSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureCacheSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeometryCacheSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPUFlushTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPUCacheTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CacheTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CacheSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowCascadesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.ControlsTabPage);
            this.MainTabControl.Controls.Add(this.AdvancedTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(14, 16);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(537, 573);
            this.MainTabControl.TabIndex = 0;
            // 
            // ControlsTabPage
            // 
            this.ControlsTabPage.Controls.Add(this.groupBox2);
            this.ControlsTabPage.Controls.Add(this.groupBox1);
            this.ControlsTabPage.Location = new System.Drawing.Point(4, 26);
            this.ControlsTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControlsTabPage.Name = "ControlsTabPage";
            this.ControlsTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControlsTabPage.Size = new System.Drawing.Size(529, 543);
            this.ControlsTabPage.TabIndex = 0;
            this.ControlsTabPage.Text = "控制";
            this.ControlsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.MouseInvertCheckBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CameraSmoothingUpDown);
            this.groupBox2.Controls.Add(this.CameraSensitivityUpDown);
            this.groupBox2.Location = new System.Drawing.Point(7, 401);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(513, 118);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "鼠标设置";
            // 
            // MouseInvertCheckBox
            // 
            this.MouseInvertCheckBox.AutoSize = true;
            this.MouseInvertCheckBox.Location = new System.Drawing.Point(280, 72);
            this.MouseInvertCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MouseInvertCheckBox.Name = "MouseInvertCheckBox";
            this.MouseInvertCheckBox.Size = new System.Drawing.Size(102, 21);
            this.MouseInvertCheckBox.TabIndex = 9;
            this.MouseInvertCheckBox.Text = "反转鼠标 Y 轴";
            this.MouseInvertCheckBox.UseVisualStyleBackColor = true;
            this.MouseInvertCheckBox.CheckedChanged += new System.EventHandler(this.MouseInvertCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "改变速度 / 缩放：鼠标滚轮\r\n旋转相机：按住左键";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "相机平滑度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "相机灵敏度：";
            // 
            // CameraSmoothingUpDown
            // 
            this.CameraSmoothingUpDown.DecimalPlaces = 1;
            this.CameraSmoothingUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CameraSmoothingUpDown.Location = new System.Drawing.Point(135, 71);
            this.CameraSmoothingUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CameraSmoothingUpDown.Name = "CameraSmoothingUpDown";
            this.CameraSmoothingUpDown.Size = new System.Drawing.Size(90, 23);
            this.CameraSmoothingUpDown.TabIndex = 7;
            this.CameraSmoothingUpDown.ValueChanged += new System.EventHandler(this.CameraSmoothingUpDown_ValueChanged);
            // 
            // CameraSensitivityUpDown
            // 
            this.CameraSensitivityUpDown.DecimalPlaces = 1;
            this.CameraSensitivityUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CameraSensitivityUpDown.Location = new System.Drawing.Point(135, 37);
            this.CameraSensitivityUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CameraSensitivityUpDown.Name = "CameraSensitivityUpDown";
            this.CameraSensitivityUpDown.Size = new System.Drawing.Size(90, 23);
            this.CameraSensitivityUpDown.TabIndex = 6;
            this.CameraSensitivityUpDown.ValueChanged += new System.EventHandler(this.CameraSensitivityUpDown_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.KeyBindingNameLabel);
            this.groupBox1.Controls.Add(this.KeyBindingsListView);
            this.groupBox1.Controls.Add(this.KeyBindingComboBox);
            this.groupBox1.Controls.Add(this.KeyBindButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(513, 384);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按键绑定";
            // 
            // KeyBindingNameLabel
            // 
            this.KeyBindingNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyBindingNameLabel.AutoSize = true;
            this.KeyBindingNameLabel.Location = new System.Drawing.Point(302, 37);
            this.KeyBindingNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyBindingNameLabel.Name = "KeyBindingNameLabel";
            this.KeyBindingNameLabel.Size = new System.Drawing.Size(76, 17);
            this.KeyBindingNameLabel.TabIndex = 6;
            this.KeyBindingNameLabel.Text = "(未选择绑定)";
            // 
            // KeyBindingsListView
            // 
            this.KeyBindingsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyBindingsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.KeyBindingsListView.FullRowSelect = true;
            this.KeyBindingsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.KeyBindingsListView.HideSelection = false;
            this.KeyBindingsListView.Location = new System.Drawing.Point(7, 26);
            this.KeyBindingsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KeyBindingsListView.Name = "KeyBindingsListView";
            this.KeyBindingsListView.Size = new System.Drawing.Size(276, 350);
            this.KeyBindingsListView.TabIndex = 3;
            this.KeyBindingsListView.UseCompatibleStateImageBehavior = false;
            this.KeyBindingsListView.View = System.Windows.Forms.View.Details;
            this.KeyBindingsListView.SelectedIndexChanged += new System.EventHandler(this.KeyBindingsListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "操作";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "按键";
            // 
            // KeyBindingComboBox
            // 
            this.KeyBindingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyBindingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeyBindingComboBox.Enabled = false;
            this.KeyBindingComboBox.FormattingEnabled = true;
            this.KeyBindingComboBox.Location = new System.Drawing.Point(342, 71);
            this.KeyBindingComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KeyBindingComboBox.Name = "KeyBindingComboBox";
            this.KeyBindingComboBox.Size = new System.Drawing.Size(121, 25);
            this.KeyBindingComboBox.TabIndex = 4;
            this.KeyBindingComboBox.SelectedIndexChanged += new System.EventHandler(this.KeyBindingComboBox_SelectedIndexChanged);
            // 
            // KeyBindButton
            // 
            this.KeyBindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyBindButton.Enabled = false;
            this.KeyBindButton.Location = new System.Drawing.Point(470, 69);
            this.KeyBindButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KeyBindButton.Name = "KeyBindButton";
            this.KeyBindButton.Size = new System.Drawing.Size(36, 30);
            this.KeyBindButton.TabIndex = 5;
            this.KeyBindButton.Text = "...";
            this.KeyBindButton.UseVisualStyleBackColor = true;
            this.KeyBindButton.Click += new System.EventHandler(this.KeyBindButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "按键：";
            // 
            // AdvancedTabPage
            // 
            this.AdvancedTabPage.Controls.Add(this.label22);
            this.AdvancedTabPage.Controls.Add(this.CollisionCacheSizeUpDown);
            this.AdvancedTabPage.Controls.Add(this.label23);
            this.AdvancedTabPage.Controls.Add(this.label20);
            this.AdvancedTabPage.Controls.Add(this.TextureCacheSizeUpDown);
            this.AdvancedTabPage.Controls.Add(this.label21);
            this.AdvancedTabPage.Controls.Add(this.label18);
            this.AdvancedTabPage.Controls.Add(this.GeometryCacheSizeUpDown);
            this.AdvancedTabPage.Controls.Add(this.label19);
            this.AdvancedTabPage.Controls.Add(this.label16);
            this.AdvancedTabPage.Controls.Add(this.GPUFlushTimeUpDown);
            this.AdvancedTabPage.Controls.Add(this.label17);
            this.AdvancedTabPage.Controls.Add(this.label14);
            this.AdvancedTabPage.Controls.Add(this.GPUCacheTimeUpDown);
            this.AdvancedTabPage.Controls.Add(this.label15);
            this.AdvancedTabPage.Controls.Add(this.label13);
            this.AdvancedTabPage.Controls.Add(this.ExcludeFoldersTextBox);
            this.AdvancedTabPage.Controls.Add(this.label11);
            this.AdvancedTabPage.Controls.Add(this.CacheTimeUpDown);
            this.AdvancedTabPage.Controls.Add(this.label12);
            this.AdvancedTabPage.Controls.Add(this.label9);
            this.AdvancedTabPage.Controls.Add(this.CacheSizeUpDown);
            this.AdvancedTabPage.Controls.Add(this.label10);
            this.AdvancedTabPage.Controls.Add(this.label8);
            this.AdvancedTabPage.Controls.Add(this.ShadowCascadesUpDown);
            this.AdvancedTabPage.Controls.Add(this.label7);
            this.AdvancedTabPage.Controls.Add(this.label6);
            this.AdvancedTabPage.Controls.Add(this.FolderBrowseButton);
            this.AdvancedTabPage.Controls.Add(this.FolderTextBox);
            this.AdvancedTabPage.Controls.Add(this.label5);
            this.AdvancedTabPage.Location = new System.Drawing.Point(4, 26);
            this.AdvancedTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdvancedTabPage.Name = "AdvancedTabPage";
            this.AdvancedTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdvancedTabPage.Size = new System.Drawing.Size(529, 543);
            this.AdvancedTabPage.TabIndex = 1;
            this.AdvancedTabPage.Text = "高级";
            this.AdvancedTabPage.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(207, 440);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(342, 17);
            this.label22.TabIndex = 76;
            this.label22.Text = "Maximum collisions graphics memory usage, in MB.";
            // 
            // CollisionCacheSizeUpDown
            // 
            this.CollisionCacheSizeUpDown.Increment = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.CollisionCacheSizeUpDown.Location = new System.Drawing.Point(128, 438);
            this.CollisionCacheSizeUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CollisionCacheSizeUpDown.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.CollisionCacheSizeUpDown.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.CollisionCacheSizeUpDown.Name = "CollisionCacheSizeUpDown";
            this.CollisionCacheSizeUpDown.Size = new System.Drawing.Size(75, 23);
            this.CollisionCacheSizeUpDown.TabIndex = 77;
            this.CollisionCacheSizeUpDown.ThousandsSeparator = true;
            this.CollisionCacheSizeUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.CollisionCacheSizeUpDown.ValueChanged += new System.EventHandler(this.CollisionCacheSizeUpDown_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 441);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 17);
            this.label23.TabIndex = 75;
            this.label23.Text = "Collision cache:";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(207, 399);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(321, 17);
            this.label20.TabIndex = 73;
            this.label20.Text = "Maximum texture graphics memory usage, in MB.";
            // 
            // TextureCacheSizeUpDown
            // 
            this.TextureCacheSizeUpDown.Increment = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.TextureCacheSizeUpDown.Location = new System.Drawing.Point(128, 397);
            this.TextureCacheSizeUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextureCacheSizeUpDown.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.TextureCacheSizeUpDown.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.TextureCacheSizeUpDown.Name = "TextureCacheSizeUpDown";
            this.TextureCacheSizeUpDown.Size = new System.Drawing.Size(75, 23);
            this.TextureCacheSizeUpDown.TabIndex = 74;
            this.TextureCacheSizeUpDown.ThousandsSeparator = true;
            this.TextureCacheSizeUpDown.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.TextureCacheSizeUpDown.ValueChanged += new System.EventHandler(this.TextureCacheSizeUpDown_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 400);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 17);
            this.label21.TabIndex = 72;
            this.label21.Text = "Texture cache:";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(207, 357);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(328, 17);
            this.label18.TabIndex = 70;
            this.label18.Text = "Maximum geometry graphics memory usage, in MB.";
            // 
            // GeometryCacheSizeUpDown
            // 
            this.GeometryCacheSizeUpDown.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.GeometryCacheSizeUpDown.Location = new System.Drawing.Point(128, 354);
            this.GeometryCacheSizeUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GeometryCacheSizeUpDown.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.GeometryCacheSizeUpDown.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.GeometryCacheSizeUpDown.Name = "GeometryCacheSizeUpDown";
            this.GeometryCacheSizeUpDown.Size = new System.Drawing.Size(75, 23);
            this.GeometryCacheSizeUpDown.TabIndex = 71;
            this.GeometryCacheSizeUpDown.ThousandsSeparator = true;
            this.GeometryCacheSizeUpDown.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.GeometryCacheSizeUpDown.ValueChanged += new System.EventHandler(this.GeometryCacheSizeUpDown_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 357);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 17);
            this.label19.TabIndex = 69;
            this.label19.Text = "Geometry cache:";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(207, 309);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(314, 44);
            this.label16.TabIndex = 68;
            this.label16.Text = "The minimum duration, in seconds, between unloading batches of resources from gra" +
    "phics memory.";
            // 
            // GPUFlushTimeUpDown
            // 
            this.GPUFlushTimeUpDown.DecimalPlaces = 2;
            this.GPUFlushTimeUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GPUFlushTimeUpDown.Location = new System.Drawing.Point(128, 313);
            this.GPUFlushTimeUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPUFlushTimeUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.GPUFlushTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.GPUFlushTimeUpDown.Name = "GPUFlushTimeUpDown";
            this.GPUFlushTimeUpDown.Size = new System.Drawing.Size(75, 23);
            this.GPUFlushTimeUpDown.TabIndex = 67;
            this.GPUFlushTimeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GPUFlushTimeUpDown.ValueChanged += new System.EventHandler(this.GPUFlushTimeUpDown_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 314);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 17);
            this.label17.TabIndex = 66;
            this.label17.Text = "GPU flush time:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(207, 265);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(308, 44);
            this.label14.TabIndex = 65;
            this.label14.Text = "The minimum duration, in seconds, that resources will remain loaded in graphics m" +
    "emory.";
            // 
            // GPUCacheTimeUpDown
            // 
            this.GPUCacheTimeUpDown.DecimalPlaces = 1;
            this.GPUCacheTimeUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GPUCacheTimeUpDown.Location = new System.Drawing.Point(128, 271);
            this.GPUCacheTimeUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GPUCacheTimeUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.GPUCacheTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GPUCacheTimeUpDown.Name = "GPUCacheTimeUpDown";
            this.GPUCacheTimeUpDown.Size = new System.Drawing.Size(75, 23);
            this.GPUCacheTimeUpDown.TabIndex = 64;
            this.GPUCacheTimeUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.GPUCacheTimeUpDown.ValueChanged += new System.EventHandler(this.GPUCacheTimeUpDown_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 273);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 17);
            this.label15.TabIndex = 63;
            this.label15.Text = "GPU cache time:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 62;
            this.label13.Text = "排除文件夹：";
            // 
            // ExcludeFoldersTextBox
            // 
            this.ExcludeFoldersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcludeFoldersTextBox.Location = new System.Drawing.Point(128, 79);
            this.ExcludeFoldersTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExcludeFoldersTextBox.Name = "ExcludeFoldersTextBox";
            this.ExcludeFoldersTextBox.Size = new System.Drawing.Size(353, 23);
            this.ExcludeFoldersTextBox.TabIndex = 50;
            this.ExcludeFoldersTextBox.TextChanged += new System.EventHandler(this.ExcludeFoldersTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(207, 172);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(308, 44);
            this.label11.TabIndex = 59;
            this.label11.Text = "The minimum duration, in seconds, that resources will remain loaded in memory.";
            // 
            // CacheTimeUpDown
            // 
            this.CacheTimeUpDown.DecimalPlaces = 1;
            this.CacheTimeUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CacheTimeUpDown.Location = new System.Drawing.Point(128, 177);
            this.CacheTimeUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CacheTimeUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.CacheTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CacheTimeUpDown.Name = "CacheTimeUpDown";
            this.CacheTimeUpDown.Size = new System.Drawing.Size(75, 23);
            this.CacheTimeUpDown.TabIndex = 58;
            this.CacheTimeUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CacheTimeUpDown.ValueChanged += new System.EventHandler(this.CacheTimeUpDown_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 57;
            this.label12.Text = "Main cache time:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(207, 221);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(293, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Maximum cache system memory usage, in MB.";
            // 
            // CacheSizeUpDown
            // 
            this.CacheSizeUpDown.Increment = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.CacheSizeUpDown.Location = new System.Drawing.Point(128, 218);
            this.CacheSizeUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CacheSizeUpDown.Maximum = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.CacheSizeUpDown.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.CacheSizeUpDown.Name = "CacheSizeUpDown";
            this.CacheSizeUpDown.Size = new System.Drawing.Size(75, 23);
            this.CacheSizeUpDown.TabIndex = 60;
            this.CacheSizeUpDown.ThousandsSeparator = true;
            this.CacheSizeUpDown.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.CacheSizeUpDown.ValueChanged += new System.EventHandler(this.CacheSizeUpDown_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 221);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Main cache size:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(207, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 34);
            this.label8.TabIndex = 53;
            this.label8.Text = "The total number of shadow cascades to render.\r\nLess cascades = better performanc" +
    "e";
            // 
            // ShadowCascadesUpDown
            // 
            this.ShadowCascadesUpDown.Location = new System.Drawing.Point(128, 128);
            this.ShadowCascadesUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShadowCascadesUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.ShadowCascadesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ShadowCascadesUpDown.Name = "ShadowCascadesUpDown";
            this.ShadowCascadesUpDown.Size = new System.Drawing.Size(75, 23);
            this.ShadowCascadesUpDown.TabIndex = 52;
            this.ShadowCascadesUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.ShadowCascadesUpDown.ValueChanged += new System.EventHandler(this.ShadowCascadesUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Shadow cascades:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "GTA V 目录：";
            // 
            // FolderBrowseButton
            // 
            this.FolderBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderBrowseButton.Location = new System.Drawing.Point(489, 35);
            this.FolderBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderBrowseButton.Name = "FolderBrowseButton";
            this.FolderBrowseButton.Size = new System.Drawing.Size(31, 30);
            this.FolderBrowseButton.TabIndex = 49;
            this.FolderBrowseButton.Text = "...";
            this.FolderBrowseButton.UseVisualStyleBackColor = true;
            this.FolderBrowseButton.Click += new System.EventHandler(this.FolderBrowseButton_Click);
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderTextBox.Location = new System.Drawing.Point(128, 37);
            this.FolderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.ReadOnly = true;
            this.FolderTextBox.Size = new System.Drawing.Size(353, 23);
            this.FolderTextBox.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "注意：以下设定需要重启 CodeWalker 才会生效。";
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.Location = new System.Drawing.Point(463, 600);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(88, 30);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "完成";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(331, 600);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(125, 30);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "保存设置";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(184, 600);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(125, 30);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "恢复默认设置";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 643);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingsForm";
            this.Text = "设置 - CodeWalker by dexyfex";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.MainTabControl.ResumeLayout(false);
            this.ControlsTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraSmoothingUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraSensitivityUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AdvancedTabPage.ResumeLayout(false);
            this.AdvancedTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CollisionCacheSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextureCacheSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeometryCacheSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPUFlushTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPUCacheTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CacheTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CacheSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShadowCascadesUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ControlsTabPage;
        private System.Windows.Forms.TabPage AdvancedTabPage;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox KeyBindingComboBox;
        private System.Windows.Forms.Button KeyBindButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView KeyBindingsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.NumericUpDown CameraSensitivityUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CameraSmoothingUpDown;
        private System.Windows.Forms.Label KeyBindingNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FolderBrowseButton;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ShadowCascadesUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown CacheSizeUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown CacheTimeUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ExcludeFoldersTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown GPUCacheTimeUpDown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown GPUFlushTimeUpDown;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown GeometryCacheSizeUpDown;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown CollisionCacheSizeUpDown;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown TextureCacheSizeUpDown;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox MouseInvertCheckBox;
    }
}