namespace CodeWalker.Project.Panels
{
    partial class EditYmapGrassPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYmapGrassPanel));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GrassBatchTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.OrientToTerrainNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ScaleRangeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LodFadeRangeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.LodFadeStartDistanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.LodDistNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BrushTab = new System.Windows.Forms.TabPage();
            this.brushModeGroupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BrushModeCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GrassColorLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PadTextBox = new System.Windows.Forms.TextBox();
            this.ScaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RandomizeScaleCheckBox = new System.Windows.Forms.CheckBox();
            this.brushSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.DensityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.OptimizeBatchButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.OptimizeBatchButton = new System.Windows.Forms.Button();
            this.ExtentsMinTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ExtentsMaxTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.GrassDeleteButton = new System.Windows.Forms.Button();
            this.GrassAddToProjectButton = new System.Windows.Forms.Button();
            this.HashLabel = new System.Windows.Forms.Label();
            this.ArchetypeNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrassGoToButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.OptmizationThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.GrassBatchTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrientToTerrainNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LodFadeRangeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LodFadeStartDistanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LodDistNumericUpDown)).BeginInit();
            this.BrushTab.SuspendLayout();
            this.brushModeGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNumericUpDown)).BeginInit();
            this.brushSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptmizationThresholdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.GrassBatchTab);
            this.tabControl1.Controls.Add(this.BrushTab);
            this.tabControl1.Location = new System.Drawing.Point(14, 78);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 227);
            this.tabControl1.TabIndex = 37;
            // 
            // GrassBatchTab
            // 
            this.GrassBatchTab.Controls.Add(this.groupBox1);
            this.GrassBatchTab.Location = new System.Drawing.Point(4, 26);
            this.GrassBatchTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrassBatchTab.Name = "GrassBatchTab";
            this.GrassBatchTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrassBatchTab.Size = new System.Drawing.Size(612, 197);
            this.GrassBatchTab.TabIndex = 0;
            this.GrassBatchTab.Text = "实例草";
            this.GrassBatchTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.OrientToTerrainNumericUpDown);
            this.groupBox1.Controls.Add(this.ScaleRangeTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.LodFadeRangeNumericUpDown);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LodFadeStartDistanceNumericUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LodDistNumericUpDown);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(584, 177);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实例草";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(241, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "缩放范围：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "吸附到地形：";
            // 
            // OrientToTerrainNumericUpDown
            // 
            this.OrientToTerrainNumericUpDown.DecimalPlaces = 1;
            this.OrientToTerrainNumericUpDown.Location = new System.Drawing.Point(141, 130);
            this.OrientToTerrainNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrientToTerrainNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OrientToTerrainNumericUpDown.Name = "OrientToTerrainNumericUpDown";
            this.OrientToTerrainNumericUpDown.Size = new System.Drawing.Size(71, 23);
            this.OrientToTerrainNumericUpDown.TabIndex = 6;
            this.OrientToTerrainNumericUpDown.ValueChanged += new System.EventHandler(this.OrientToTerrainNumericUpDown_ValueChanged);
            // 
            // ScaleRangeTextBox
            // 
            this.ScaleRangeTextBox.Location = new System.Drawing.Point(315, 27);
            this.ScaleRangeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScaleRangeTextBox.Name = "ScaleRangeTextBox";
            this.ScaleRangeTextBox.Size = new System.Drawing.Size(193, 23);
            this.ScaleRangeTextBox.TabIndex = 46;
            this.ScaleRangeTextBox.TextChanged += new System.EventHandler(this.ScaleRangeTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Lod 瞬间淡出范围：";
            // 
            // LodFadeRangeNumericUpDown
            // 
            this.LodFadeRangeNumericUpDown.DecimalPlaces = 4;
            this.LodFadeRangeNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.LodFadeRangeNumericUpDown.Location = new System.Drawing.Point(141, 96);
            this.LodFadeRangeNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LodFadeRangeNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.LodFadeRangeNumericUpDown.Name = "LodFadeRangeNumericUpDown";
            this.LodFadeRangeNumericUpDown.Size = new System.Drawing.Size(71, 23);
            this.LodFadeRangeNumericUpDown.TabIndex = 4;
            this.LodFadeRangeNumericUpDown.ValueChanged += new System.EventHandler(this.LodFadeRangeNumericUpDown_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Lod 淡出开始距离：";
            // 
            // LodFadeStartDistanceNumericUpDown
            // 
            this.LodFadeStartDistanceNumericUpDown.DecimalPlaces = 4;
            this.LodFadeStartDistanceNumericUpDown.Location = new System.Drawing.Point(141, 62);
            this.LodFadeStartDistanceNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LodFadeStartDistanceNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.LodFadeStartDistanceNumericUpDown.Name = "LodFadeStartDistanceNumericUpDown";
            this.LodFadeStartDistanceNumericUpDown.Size = new System.Drawing.Size(71, 23);
            this.LodFadeStartDistanceNumericUpDown.TabIndex = 2;
            this.LodFadeStartDistanceNumericUpDown.ValueChanged += new System.EventHandler(this.LodFadeStartDistanceNumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lod 距离：";
            // 
            // LodDistNumericUpDown
            // 
            this.LodDistNumericUpDown.Location = new System.Drawing.Point(141, 28);
            this.LodDistNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LodDistNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.LodDistNumericUpDown.Name = "LodDistNumericUpDown";
            this.LodDistNumericUpDown.Size = new System.Drawing.Size(71, 23);
            this.LodDistNumericUpDown.TabIndex = 0;
            this.LodDistNumericUpDown.ValueChanged += new System.EventHandler(this.LodDistNumericUpDown_ValueChanged);
            // 
            // BrushTab
            // 
            this.BrushTab.Controls.Add(this.brushModeGroupBox);
            this.BrushTab.Controls.Add(this.groupBox2);
            this.BrushTab.Controls.Add(this.brushSettingsGroupBox);
            this.BrushTab.Location = new System.Drawing.Point(4, 26);
            this.BrushTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrushTab.Name = "BrushTab";
            this.BrushTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrushTab.Size = new System.Drawing.Size(612, 197);
            this.BrushTab.TabIndex = 1;
            this.BrushTab.Text = "笔刷";
            this.BrushTab.UseVisualStyleBackColor = true;
            // 
            // brushModeGroupBox
            // 
            this.brushModeGroupBox.Controls.Add(this.label16);
            this.brushModeGroupBox.Controls.Add(this.BrushModeCheckBox);
            this.brushModeGroupBox.Location = new System.Drawing.Point(13, 78);
            this.brushModeGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brushModeGroupBox.Name = "brushModeGroupBox";
            this.brushModeGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brushModeGroupBox.Size = new System.Drawing.Size(288, 109);
            this.brushModeGroupBox.TabIndex = 69;
            this.brushModeGroupBox.TabStop = false;
            this.brushModeGroupBox.Text = "笔刷模式";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(10, 49);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(270, 52);
            this.label16.TabIndex = 69;
            this.label16.Text = "按住 CTRL 键可绘制该批处理中的实例。按住 CTRL+SHIFT 可在此批处理中删除。打开“工具”菜单以选择批量删除选项。";
            // 
            // BrushModeCheckBox
            // 
            this.BrushModeCheckBox.AutoSize = true;
            this.BrushModeCheckBox.Location = new System.Drawing.Point(13, 24);
            this.BrushModeCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrushModeCheckBox.Name = "BrushModeCheckBox";
            this.BrushModeCheckBox.Size = new System.Drawing.Size(99, 21);
            this.BrushModeCheckBox.TabIndex = 68;
            this.BrushModeCheckBox.Text = "启用笔刷模式";
            this.BrushModeCheckBox.UseVisualStyleBackColor = true;
            this.BrushModeCheckBox.CheckedChanged += new System.EventHandler(this.BrushModeCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.GrassColorLabel);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.AoNumericUpDown);
            this.groupBox2.Controls.Add(this.PadTextBox);
            this.groupBox2.Controls.Add(this.ScaleNumericUpDown);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RandomizeScaleCheckBox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(311, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(290, 179);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "实例设置";
            // 
            // GrassColorLabel
            // 
            this.GrassColorLabel.BackColor = System.Drawing.Color.White;
            this.GrassColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrassColorLabel.Location = new System.Drawing.Point(98, 29);
            this.GrassColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrassColorLabel.Name = "GrassColorLabel";
            this.GrassColorLabel.Size = new System.Drawing.Size(125, 28);
            this.GrassColorLabel.TabIndex = 12;
            this.GrassColorLabel.Click += new System.EventHandler(this.GrassColorLabel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 139);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 17);
            this.label15.TabIndex = 46;
            this.label15.Text = "填充：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "缩放：";
            // 
            // AoNumericUpDown
            // 
            this.AoNumericUpDown.Location = new System.Drawing.Point(98, 67);
            this.AoNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AoNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AoNumericUpDown.Name = "AoNumericUpDown";
            this.AoNumericUpDown.Size = new System.Drawing.Size(125, 23);
            this.AoNumericUpDown.TabIndex = 15;
            this.AoNumericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // PadTextBox
            // 
            this.PadTextBox.Location = new System.Drawing.Point(98, 136);
            this.PadTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PadTextBox.Name = "PadTextBox";
            this.PadTextBox.Size = new System.Drawing.Size(125, 23);
            this.PadTextBox.TabIndex = 45;
            this.PadTextBox.Text = "0, 0, 0";
            // 
            // ScaleNumericUpDown
            // 
            this.ScaleNumericUpDown.Location = new System.Drawing.Point(98, 101);
            this.ScaleNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScaleNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ScaleNumericUpDown.Name = "ScaleNumericUpDown";
            this.ScaleNumericUpDown.Size = new System.Drawing.Size(125, 23);
            this.ScaleNumericUpDown.TabIndex = 17;
            this.ScaleNumericUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "环境光遮蔽：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "颜色：";
            // 
            // RandomizeScaleCheckBox
            // 
            this.RandomizeScaleCheckBox.AutoSize = true;
            this.RandomizeScaleCheckBox.Location = new System.Drawing.Point(231, 103);
            this.RandomizeScaleCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RandomizeScaleCheckBox.Name = "RandomizeScaleCheckBox";
            this.RandomizeScaleCheckBox.Size = new System.Drawing.Size(51, 21);
            this.RandomizeScaleCheckBox.TabIndex = 18;
            this.RandomizeScaleCheckBox.Text = "随机";
            this.RandomizeScaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // brushSettingsGroupBox
            // 
            this.brushSettingsGroupBox.Controls.Add(this.DensityNumericUpDown);
            this.brushSettingsGroupBox.Controls.Add(this.RadiusNumericUpDown);
            this.brushSettingsGroupBox.Controls.Add(this.label5);
            this.brushSettingsGroupBox.Controls.Add(this.radiusLabel);
            this.brushSettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushSettingsGroupBox.Location = new System.Drawing.Point(13, 8);
            this.brushSettingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brushSettingsGroupBox.Name = "brushSettingsGroupBox";
            this.brushSettingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brushSettingsGroupBox.Size = new System.Drawing.Size(287, 64);
            this.brushSettingsGroupBox.TabIndex = 38;
            this.brushSettingsGroupBox.TabStop = false;
            this.brushSettingsGroupBox.Text = "笔刷设置";
            // 
            // DensityNumericUpDown
            // 
            this.DensityNumericUpDown.Location = new System.Drawing.Point(195, 27);
            this.DensityNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DensityNumericUpDown.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.DensityNumericUpDown.Name = "DensityNumericUpDown";
            this.DensityNumericUpDown.Size = new System.Drawing.Size(74, 23);
            this.DensityNumericUpDown.TabIndex = 20;
            this.DensityNumericUpDown.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // RadiusNumericUpDown
            // 
            this.RadiusNumericUpDown.DecimalPlaces = 1;
            this.RadiusNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RadiusNumericUpDown.Location = new System.Drawing.Point(46, 27);
            this.RadiusNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadiusNumericUpDown.Name = "RadiusNumericUpDown";
            this.RadiusNumericUpDown.Size = new System.Drawing.Size(99, 23);
            this.RadiusNumericUpDown.TabIndex = 11;
            this.RadiusNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RadiusNumericUpDown.ValueChanged += new System.EventHandler(this.RadiusNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "密度：";
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(8, 29);
            this.radiusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(44, 17);
            this.radiusLabel.TabIndex = 10;
            this.radiusLabel.Text = "范围：";
            // 
            // OptimizeBatchButton
            // 
            this.OptimizeBatchButton.Location = new System.Drawing.Point(14, 312);
            this.OptimizeBatchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OptimizeBatchButton.Name = "OptimizeBatchButton";
            this.OptimizeBatchButton.Size = new System.Drawing.Size(126, 31);
            this.OptimizeBatchButton.TabIndex = 70;
            this.OptimizeBatchButton.Text = "优化批处理";
            this.OptimizeBatchButtonTooltip.SetToolTip(this.OptimizeBatchButton, "Will split your batch into multiple different batches based on the threshold. If " +
        "your threshold is 5.0 then each batch will have a size of 5.0 meters.");
            this.OptimizeBatchButton.UseVisualStyleBackColor = true;
            this.OptimizeBatchButton.Click += new System.EventHandler(this.OptimizeBatchButton_Click);
            // 
            // ExtentsMinTextBox
            // 
            this.ExtentsMinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtentsMinTextBox.Location = new System.Drawing.Point(100, 351);
            this.ExtentsMinTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExtentsMinTextBox.Name = "ExtentsMinTextBox";
            this.ExtentsMinTextBox.ReadOnly = true;
            this.ExtentsMinTextBox.Size = new System.Drawing.Size(530, 23);
            this.ExtentsMinTextBox.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 390);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 54;
            this.label14.Text = "最大范围：";
            // 
            // ExtentsMaxTextBox
            // 
            this.ExtentsMaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtentsMaxTextBox.Location = new System.Drawing.Point(100, 385);
            this.ExtentsMaxTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExtentsMaxTextBox.Name = "ExtentsMaxTextBox";
            this.ExtentsMaxTextBox.ReadOnly = true;
            this.ExtentsMaxTextBox.Size = new System.Drawing.Size(530, 23);
            this.ExtentsMaxTextBox.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 355);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 52;
            this.label13.Text = "最小范围：";
            // 
            // GrassDeleteButton
            // 
            this.GrassDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrassDeleteButton.Location = new System.Drawing.Point(519, 312);
            this.GrassDeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrassDeleteButton.Name = "GrassDeleteButton";
            this.GrassDeleteButton.Size = new System.Drawing.Size(111, 30);
            this.GrassDeleteButton.TabIndex = 51;
            this.GrassDeleteButton.Text = "删除批处理";
            this.GrassDeleteButton.UseVisualStyleBackColor = true;
            this.GrassDeleteButton.Click += new System.EventHandler(this.GrassDeleteButton_Click);
            // 
            // GrassAddToProjectButton
            // 
            this.GrassAddToProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrassAddToProjectButton.Location = new System.Drawing.Point(405, 312);
            this.GrassAddToProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrassAddToProjectButton.Name = "GrassAddToProjectButton";
            this.GrassAddToProjectButton.Size = new System.Drawing.Size(111, 30);
            this.GrassAddToProjectButton.TabIndex = 50;
            this.GrassAddToProjectButton.Text = "添加到项目";
            this.GrassAddToProjectButton.UseVisualStyleBackColor = true;
            this.GrassAddToProjectButton.Click += new System.EventHandler(this.GrassAddToProjectButton_Click);
            // 
            // HashLabel
            // 
            this.HashLabel.AutoSize = true;
            this.HashLabel.Location = new System.Drawing.Point(290, 20);
            this.HashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HashLabel.Name = "HashLabel";
            this.HashLabel.Size = new System.Drawing.Size(51, 17);
            this.HashLabel.TabIndex = 61;
            this.HashLabel.Text = "哈希：0";
            // 
            // ArchetypeNameTextBox
            // 
            this.ArchetypeNameTextBox.Location = new System.Drawing.Point(77, 16);
            this.ArchetypeNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ArchetypeNameTextBox.Name = "ArchetypeNameTextBox";
            this.ArchetypeNameTextBox.Size = new System.Drawing.Size(167, 23);
            this.ArchetypeNameTextBox.TabIndex = 60;
            this.ArchetypeNameTextBox.TextChanged += new System.EventHandler(this.ArchetypeNameTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "名称：";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionTextBox.Location = new System.Drawing.Point(77, 47);
            this.PositionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.ReadOnly = true;
            this.PositionTextBox.Size = new System.Drawing.Size(454, 23);
            this.PositionTextBox.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "位置：";
            // 
            // GrassGoToButton
            // 
            this.GrassGoToButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrassGoToButton.Location = new System.Drawing.Point(539, 44);
            this.GrassGoToButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrassGoToButton.Name = "GrassGoToButton";
            this.GrassGoToButton.Size = new System.Drawing.Size(91, 30);
            this.GrassGoToButton.TabIndex = 56;
            this.GrassGoToButton.Text = "传送";
            this.GrassGoToButton.UseVisualStyleBackColor = true;
            this.GrassGoToButton.Click += new System.EventHandler(this.GrassGoToButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(148, 319);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 17);
            this.label17.TabIndex = 71;
            this.label17.Text = "阈值：";
            // 
            // OptmizationThresholdNumericUpDown
            // 
            this.OptmizationThresholdNumericUpDown.Location = new System.Drawing.Point(196, 317);
            this.OptmizationThresholdNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OptmizationThresholdNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.OptmizationThresholdNumericUpDown.Name = "OptmizationThresholdNumericUpDown";
            this.OptmizationThresholdNumericUpDown.Size = new System.Drawing.Size(80, 23);
            this.OptmizationThresholdNumericUpDown.TabIndex = 69;
            this.OptmizationThresholdNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 72;
            this.label8.Text = ".ydr";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditYmapGrassPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 423);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.OptmizationThresholdNumericUpDown);
            this.Controls.Add(this.OptimizeBatchButton);
            this.Controls.Add(this.HashLabel);
            this.Controls.Add(this.ExtentsMinTextBox);
            this.Controls.Add(this.ArchetypeNameTextBox);
            this.Controls.Add(this.ExtentsMaxTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrassGoToButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.GrassDeleteButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.GrassAddToProjectButton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditYmapGrassPanel";
            this.Text = "批处理实例草";
            this.tabControl1.ResumeLayout(false);
            this.GrassBatchTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrientToTerrainNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LodFadeRangeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LodFadeStartDistanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LodDistNumericUpDown)).EndInit();
            this.BrushTab.ResumeLayout(false);
            this.brushModeGroupBox.ResumeLayout(false);
            this.brushModeGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleNumericUpDown)).EndInit();
            this.brushSettingsGroupBox.ResumeLayout(false);
            this.brushSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DensityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptmizationThresholdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GrassBatchTab;
        private System.Windows.Forms.TabPage BrushTab;
        private System.Windows.Forms.GroupBox brushSettingsGroupBox;
        private System.Windows.Forms.NumericUpDown RadiusNumericUpDown;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.NumericUpDown DensityNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown LodDistNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown LodFadeStartDistanceNumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown LodFadeRangeNumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown OrientToTerrainNumericUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ScaleRangeTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PadTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GrassColorLabel;
        private System.Windows.Forms.CheckBox RandomizeScaleCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ScaleNumericUpDown;
        private System.Windows.Forms.NumericUpDown AoNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip OptimizeBatchButtonTooltip;
        private System.Windows.Forms.TextBox ExtentsMinTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ExtentsMaxTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button GrassDeleteButton;
        private System.Windows.Forms.Button GrassAddToProjectButton;
        private System.Windows.Forms.Label HashLabel;
        private System.Windows.Forms.TextBox ArchetypeNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GrassGoToButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown OptmizationThresholdNumericUpDown;
        private System.Windows.Forms.Button OptimizeBatchButton;
        private System.Windows.Forms.CheckBox BrushModeCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox brushModeGroupBox;
        private System.Windows.Forms.Label label16;
    }
}