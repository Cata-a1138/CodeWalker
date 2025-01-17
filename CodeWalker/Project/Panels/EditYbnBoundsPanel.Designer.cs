﻿namespace CodeWalker.Project.Panels
{
    partial class EditYbnBoundsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYbnBoundsPanel));
            this.BoundsTabControl = new System.Windows.Forms.TabControl();
            this.BoundsTabPage = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddToProjectButton = new System.Windows.Forms.Button();
            this.MaterialCombo = new System.Windows.Forms.ComboBox();
            this.UnkTypeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.UnkVectorTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.VolumeTextBox = new System.Windows.Forms.TextBox();
            this.UnkFlagsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.PolyFlagsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.MaterialColourUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.PedDensityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomIDUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ProceduralIDUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MarginTextBox = new System.Windows.Forms.TextBox();
            this.BBCenterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BSRadiusTextBox = new System.Windows.Forms.TextBox();
            this.BSCenterTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BBMaxTextBox = new System.Windows.Forms.TextBox();
            this.BBMinTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GeometryTabPage = new System.Windows.Forms.TabPage();
            this.UnkFloat2TextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.UnkFloat1TextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.QuantumTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.CenterGeomTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CompositeFlagsTabPage = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.CompFlags2CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CompFlags1CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.CompositeXformTabPage = new System.Windows.Forms.TabPage();
            this.CompRotationQuatBox = new CodeWalker.WinForms.QuaternionBox();
            this.CompScaleTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.CompPositionTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PolyCountLabel = new System.Windows.Forms.Label();
            this.VertexCountLabel = new System.Windows.Forms.Label();
            this.BoundsTabControl.SuspendLayout();
            this.BoundsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnkTypeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnkFlagsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolyFlagsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialColourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedDensityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomIDUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProceduralIDUpDown)).BeginInit();
            this.GeometryTabPage.SuspendLayout();
            this.CompositeFlagsTabPage.SuspendLayout();
            this.CompositeXformTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoundsTabControl
            // 
            this.BoundsTabControl.Controls.Add(this.BoundsTabPage);
            this.BoundsTabControl.Controls.Add(this.GeometryTabPage);
            this.BoundsTabControl.Controls.Add(this.CompositeFlagsTabPage);
            this.BoundsTabControl.Controls.Add(this.CompositeXformTabPage);
            this.BoundsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoundsTabControl.Location = new System.Drawing.Point(0, 0);
            this.BoundsTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoundsTabControl.Name = "BoundsTabControl";
            this.BoundsTabControl.SelectedIndex = 0;
            this.BoundsTabControl.Size = new System.Drawing.Size(681, 537);
            this.BoundsTabControl.TabIndex = 0;
            // 
            // BoundsTabPage
            // 
            this.BoundsTabPage.Controls.Add(this.DeleteButton);
            this.BoundsTabPage.Controls.Add(this.AddToProjectButton);
            this.BoundsTabPage.Controls.Add(this.MaterialCombo);
            this.BoundsTabPage.Controls.Add(this.UnkTypeUpDown);
            this.BoundsTabPage.Controls.Add(this.label16);
            this.BoundsTabPage.Controls.Add(this.label15);
            this.BoundsTabPage.Controls.Add(this.UnkVectorTextBox);
            this.BoundsTabPage.Controls.Add(this.label14);
            this.BoundsTabPage.Controls.Add(this.VolumeTextBox);
            this.BoundsTabPage.Controls.Add(this.UnkFlagsUpDown);
            this.BoundsTabPage.Controls.Add(this.label9);
            this.BoundsTabPage.Controls.Add(this.PolyFlagsUpDown);
            this.BoundsTabPage.Controls.Add(this.label8);
            this.BoundsTabPage.Controls.Add(this.MaterialColourUpDown);
            this.BoundsTabPage.Controls.Add(this.label7);
            this.BoundsTabPage.Controls.Add(this.PedDensityUpDown);
            this.BoundsTabPage.Controls.Add(this.label6);
            this.BoundsTabPage.Controls.Add(this.RoomIDUpDown);
            this.BoundsTabPage.Controls.Add(this.label4);
            this.BoundsTabPage.Controls.Add(this.ProceduralIDUpDown);
            this.BoundsTabPage.Controls.Add(this.label3);
            this.BoundsTabPage.Controls.Add(this.label10);
            this.BoundsTabPage.Controls.Add(this.label2);
            this.BoundsTabPage.Controls.Add(this.MarginTextBox);
            this.BoundsTabPage.Controls.Add(this.BBCenterTextBox);
            this.BoundsTabPage.Controls.Add(this.label1);
            this.BoundsTabPage.Controls.Add(this.label13);
            this.BoundsTabPage.Controls.Add(this.BSRadiusTextBox);
            this.BoundsTabPage.Controls.Add(this.BSCenterTextBox);
            this.BoundsTabPage.Controls.Add(this.label12);
            this.BoundsTabPage.Controls.Add(this.BBMaxTextBox);
            this.BoundsTabPage.Controls.Add(this.BBMinTextBox);
            this.BoundsTabPage.Controls.Add(this.label11);
            this.BoundsTabPage.Controls.Add(this.label5);
            this.BoundsTabPage.Location = new System.Drawing.Point(4, 26);
            this.BoundsTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoundsTabPage.Name = "BoundsTabPage";
            this.BoundsTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoundsTabPage.Size = new System.Drawing.Size(673, 507);
            this.BoundsTabPage.TabIndex = 0;
            this.BoundsTabPage.Text = "边界";
            this.BoundsTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(551, 259);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 30);
            this.DeleteButton.TabIndex = 36;
            this.DeleteButton.Text = "删除边界";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddToProjectButton
            // 
            this.AddToProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToProjectButton.Location = new System.Drawing.Point(433, 259);
            this.AddToProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddToProjectButton.Name = "AddToProjectButton";
            this.AddToProjectButton.Size = new System.Drawing.Size(111, 30);
            this.AddToProjectButton.TabIndex = 35;
            this.AddToProjectButton.Text = "添加到项目";
            this.AddToProjectButton.UseVisualStyleBackColor = true;
            this.AddToProjectButton.Click += new System.EventHandler(this.AddToProjectButton_Click);
            // 
            // MaterialCombo
            // 
            this.MaterialCombo.FormattingEnabled = true;
            this.MaterialCombo.Location = new System.Drawing.Point(106, 256);
            this.MaterialCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaterialCombo.Name = "MaterialCombo";
            this.MaterialCombo.Size = new System.Drawing.Size(227, 25);
            this.MaterialCombo.TabIndex = 18;
            this.MaterialCombo.SelectedIndexChanged += new System.EventHandler(this.MaterialCombo_SelectedIndexChanged);
            // 
            // UnkTypeUpDown
            // 
            this.UnkTypeUpDown.Location = new System.Drawing.Point(106, 475);
            this.UnkTypeUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnkTypeUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.UnkTypeUpDown.Name = "UnkTypeUpDown";
            this.UnkTypeUpDown.Size = new System.Drawing.Size(227, 23);
            this.UnkTypeUpDown.TabIndex = 32;
            this.UnkTypeUpDown.ValueChanged += new System.EventHandler(this.UnkTypeUpDown_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 477);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "未知类型：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 228);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "未知向量：";
            // 
            // UnkVectorTextBox
            // 
            this.UnkVectorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnkVectorTextBox.Location = new System.Drawing.Point(106, 225);
            this.UnkVectorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnkVectorTextBox.Name = "UnkVectorTextBox";
            this.UnkVectorTextBox.Size = new System.Drawing.Size(556, 23);
            this.UnkVectorTextBox.TabIndex = 16;
            this.UnkVectorTextBox.TextChanged += new System.EventHandler(this.UnkVectorTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "体积：";
            // 
            // VolumeTextBox
            // 
            this.VolumeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeTextBox.Location = new System.Drawing.Point(106, 194);
            this.VolumeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VolumeTextBox.Name = "VolumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(556, 23);
            this.VolumeTextBox.TabIndex = 14;
            this.VolumeTextBox.TextChanged += new System.EventHandler(this.VolumeTextBox_TextChanged);
            // 
            // UnkFlagsUpDown
            // 
            this.UnkFlagsUpDown.Location = new System.Drawing.Point(106, 444);
            this.UnkFlagsUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnkFlagsUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.UnkFlagsUpDown.Name = "UnkFlagsUpDown";
            this.UnkFlagsUpDown.Size = new System.Drawing.Size(227, 23);
            this.UnkFlagsUpDown.TabIndex = 30;
            this.UnkFlagsUpDown.ValueChanged += new System.EventHandler(this.UnkFlagsUpDown_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 446);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "未知 Flags：";
            // 
            // PolyFlagsUpDown
            // 
            this.PolyFlagsUpDown.Location = new System.Drawing.Point(106, 413);
            this.PolyFlagsUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PolyFlagsUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PolyFlagsUpDown.Name = "PolyFlagsUpDown";
            this.PolyFlagsUpDown.Size = new System.Drawing.Size(227, 23);
            this.PolyFlagsUpDown.TabIndex = 28;
            this.PolyFlagsUpDown.ValueChanged += new System.EventHandler(this.PolyFlagsUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 415);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "多边形 Flags：";
            // 
            // MaterialColourUpDown
            // 
            this.MaterialColourUpDown.Location = new System.Drawing.Point(106, 289);
            this.MaterialColourUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaterialColourUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MaterialColourUpDown.Name = "MaterialColourUpDown";
            this.MaterialColourUpDown.Size = new System.Drawing.Size(227, 23);
            this.MaterialColourUpDown.TabIndex = 20;
            this.MaterialColourUpDown.ValueChanged += new System.EventHandler(this.MaterialColourUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "材质颜色：";
            // 
            // PedDensityUpDown
            // 
            this.PedDensityUpDown.Location = new System.Drawing.Point(106, 382);
            this.PedDensityUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PedDensityUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PedDensityUpDown.Name = "PedDensityUpDown";
            this.PedDensityUpDown.Size = new System.Drawing.Size(227, 23);
            this.PedDensityUpDown.TabIndex = 26;
            this.PedDensityUpDown.ValueChanged += new System.EventHandler(this.PedDensityUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 384);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "人口密度：";
            // 
            // RoomIDUpDown
            // 
            this.RoomIDUpDown.Location = new System.Drawing.Point(106, 351);
            this.RoomIDUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RoomIDUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RoomIDUpDown.Name = "RoomIDUpDown";
            this.RoomIDUpDown.Size = new System.Drawing.Size(227, 23);
            this.RoomIDUpDown.TabIndex = 24;
            this.RoomIDUpDown.ValueChanged += new System.EventHandler(this.RoomIDUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "房间 ID：";
            // 
            // ProceduralIDUpDown
            // 
            this.ProceduralIDUpDown.Location = new System.Drawing.Point(106, 320);
            this.ProceduralIDUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProceduralIDUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ProceduralIDUpDown.Name = "ProceduralIDUpDown";
            this.ProceduralIDUpDown.Size = new System.Drawing.Size(227, 23);
            this.ProceduralIDUpDown.TabIndex = 22;
            this.ProceduralIDUpDown.ValueChanged += new System.EventHandler(this.ProceduralIDUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "程序化 ID：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 259);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "材质：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "边距：";
            // 
            // MarginTextBox
            // 
            this.MarginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MarginTextBox.Location = new System.Drawing.Point(106, 163);
            this.MarginTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MarginTextBox.Name = "MarginTextBox";
            this.MarginTextBox.Size = new System.Drawing.Size(556, 23);
            this.MarginTextBox.TabIndex = 12;
            this.MarginTextBox.TextChanged += new System.EventHandler(this.MarginTextBox_TextChanged);
            // 
            // BBCenterTextBox
            // 
            this.BBCenterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BBCenterTextBox.Location = new System.Drawing.Point(106, 70);
            this.BBCenterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BBCenterTextBox.Name = "BBCenterTextBox";
            this.BBCenterTextBox.Size = new System.Drawing.Size(556, 23);
            this.BBCenterTextBox.TabIndex = 6;
            this.BBCenterTextBox.TextChanged += new System.EventHandler(this.BBCenterTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "方框中心点：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 135);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "球体范围：";
            // 
            // BSRadiusTextBox
            // 
            this.BSRadiusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BSRadiusTextBox.Location = new System.Drawing.Point(106, 132);
            this.BSRadiusTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BSRadiusTextBox.Name = "BSRadiusTextBox";
            this.BSRadiusTextBox.Size = new System.Drawing.Size(556, 23);
            this.BSRadiusTextBox.TabIndex = 10;
            this.BSRadiusTextBox.TextChanged += new System.EventHandler(this.BSRadiusTextBox_TextChanged);
            // 
            // BSCenterTextBox
            // 
            this.BSCenterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BSCenterTextBox.Location = new System.Drawing.Point(106, 101);
            this.BSCenterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BSCenterTextBox.Name = "BSCenterTextBox";
            this.BSCenterTextBox.Size = new System.Drawing.Size(556, 23);
            this.BSCenterTextBox.TabIndex = 8;
            this.BSCenterTextBox.TextChanged += new System.EventHandler(this.BSCenterTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 104);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "球体中心点：";
            // 
            // BBMaxTextBox
            // 
            this.BBMaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BBMaxTextBox.Location = new System.Drawing.Point(106, 39);
            this.BBMaxTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BBMaxTextBox.Name = "BBMaxTextBox";
            this.BBMaxTextBox.Size = new System.Drawing.Size(556, 23);
            this.BBMaxTextBox.TabIndex = 4;
            this.BBMaxTextBox.TextChanged += new System.EventHandler(this.BBMaxTextBox_TextChanged);
            // 
            // BBMinTextBox
            // 
            this.BBMinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BBMinTextBox.Location = new System.Drawing.Point(106, 8);
            this.BBMinTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BBMinTextBox.Name = "BBMinTextBox";
            this.BBMinTextBox.Size = new System.Drawing.Size(556, 23);
            this.BBMinTextBox.TabIndex = 2;
            this.BBMinTextBox.TextChanged += new System.EventHandler(this.BBMinTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "方框最大值：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "方框最小值：";
            // 
            // GeometryTabPage
            // 
            this.GeometryTabPage.Controls.Add(this.groupBox1);
            this.GeometryTabPage.Controls.Add(this.UnkFloat2TextBox);
            this.GeometryTabPage.Controls.Add(this.label20);
            this.GeometryTabPage.Controls.Add(this.UnkFloat1TextBox);
            this.GeometryTabPage.Controls.Add(this.label19);
            this.GeometryTabPage.Controls.Add(this.QuantumTextBox);
            this.GeometryTabPage.Controls.Add(this.label18);
            this.GeometryTabPage.Controls.Add(this.CenterGeomTextBox);
            this.GeometryTabPage.Controls.Add(this.label17);
            this.GeometryTabPage.Location = new System.Drawing.Point(4, 26);
            this.GeometryTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GeometryTabPage.Name = "GeometryTabPage";
            this.GeometryTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GeometryTabPage.Size = new System.Drawing.Size(673, 507);
            this.GeometryTabPage.TabIndex = 1;
            this.GeometryTabPage.Text = "几何体";
            this.GeometryTabPage.UseVisualStyleBackColor = true;
            // 
            // UnkFloat2TextBox
            // 
            this.UnkFloat2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnkFloat2TextBox.Location = new System.Drawing.Point(106, 101);
            this.UnkFloat2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnkFloat2TextBox.Name = "UnkFloat2TextBox";
            this.UnkFloat2TextBox.Size = new System.Drawing.Size(556, 23);
            this.UnkFloat2TextBox.TabIndex = 10;
            this.UnkFloat2TextBox.TextChanged += new System.EventHandler(this.UnkFloat2TextBox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 104);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 17);
            this.label20.TabIndex = 9;
            this.label20.Text = "未知浮点数 2：";
            // 
            // UnkFloat1TextBox
            // 
            this.UnkFloat1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnkFloat1TextBox.Location = new System.Drawing.Point(106, 70);
            this.UnkFloat1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnkFloat1TextBox.Name = "UnkFloat1TextBox";
            this.UnkFloat1TextBox.Size = new System.Drawing.Size(556, 23);
            this.UnkFloat1TextBox.TabIndex = 8;
            this.UnkFloat1TextBox.TextChanged += new System.EventHandler(this.UnkFloat1TextBox_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 73);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 17);
            this.label19.TabIndex = 7;
            this.label19.Text = "未知浮点数 1：";
            // 
            // QuantumTextBox
            // 
            this.QuantumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantumTextBox.Location = new System.Drawing.Point(106, 39);
            this.QuantumTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuantumTextBox.Name = "QuantumTextBox";
            this.QuantumTextBox.Size = new System.Drawing.Size(556, 23);
            this.QuantumTextBox.TabIndex = 6;
            this.QuantumTextBox.TextChanged += new System.EventHandler(this.QuantumTextBox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(62, 42);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 17);
            this.label18.TabIndex = 5;
            this.label18.Text = "定量：";
            // 
            // CenterGeomTextBox
            // 
            this.CenterGeomTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterGeomTextBox.Location = new System.Drawing.Point(106, 8);
            this.CenterGeomTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CenterGeomTextBox.Name = "CenterGeomTextBox";
            this.CenterGeomTextBox.Size = new System.Drawing.Size(556, 23);
            this.CenterGeomTextBox.TabIndex = 4;
            this.CenterGeomTextBox.TextChanged += new System.EventHandler(this.CenterGeomTextBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 11);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "几何中心：";
            // 
            // CompositeFlagsTabPage
            // 
            this.CompositeFlagsTabPage.Controls.Add(this.label22);
            this.CompositeFlagsTabPage.Controls.Add(this.CompFlags2CheckedListBox);
            this.CompositeFlagsTabPage.Controls.Add(this.label21);
            this.CompositeFlagsTabPage.Controls.Add(this.CompFlags1CheckedListBox);
            this.CompositeFlagsTabPage.Location = new System.Drawing.Point(4, 26);
            this.CompositeFlagsTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompositeFlagsTabPage.Name = "CompositeFlagsTabPage";
            this.CompositeFlagsTabPage.Size = new System.Drawing.Size(673, 507);
            this.CompositeFlagsTabPage.TabIndex = 2;
            this.CompositeFlagsTabPage.Text = "复合体 Flags";
            this.CompositeFlagsTabPage.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(299, 4);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 17);
            this.label22.TabIndex = 35;
            this.label22.Text = "Flags 2:";
            // 
            // CompFlags2CheckedListBox
            // 
            this.CompFlags2CheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CompFlags2CheckedListBox.CheckOnClick = true;
            this.CompFlags2CheckedListBox.FormattingEnabled = true;
            this.CompFlags2CheckedListBox.Items.AddRange(new object[] {
            "0 - Unknown",
            "1 - Map Weapon",
            "2 - Map Dynamic",
            "3 - Map Animal",
            "4 - Map Cover",
            "5 - Map Vehicle",
            "6 - Vehicle Not BVH",
            "7 - Vehicle BVH",
            "8 - Vehicle Box",
            "9 - Ped",
            "10 - Ragdoll",
            "11 - Animal",
            "12 - Animal Ragdoll",
            "13 - Object",
            "14 - Object Env Cloth",
            "15 - Plant",
            "16 - Projectile",
            "17 - Explosion",
            "18 - Pickup",
            "19 - Foliage",
            "20 - Forklift Forks",
            "21 - Test Weapon",
            "22 - Test Camera",
            "23 - Test AI",
            "24 - Test Script",
            "25 - Test Vehicle Wheel",
            "26 - Glass",
            "27 - Map River",
            "28 - Smoke",
            "29 - Unsmashed",
            "30 - Map Stairs",
            "31 - Map Deep Surface"});
            this.CompFlags2CheckedListBox.Location = new System.Drawing.Point(357, 4);
            this.CompFlags2CheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompFlags2CheckedListBox.Name = "CompFlags2CheckedListBox";
            this.CompFlags2CheckedListBox.Size = new System.Drawing.Size(202, 472);
            this.CompFlags2CheckedListBox.TabIndex = 34;
            this.CompFlags2CheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CompFlags2CheckedListBox_ItemCheck);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 4);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 17);
            this.label21.TabIndex = 33;
            this.label21.Text = "Flags 1:";
            // 
            // CompFlags1CheckedListBox
            // 
            this.CompFlags1CheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CompFlags1CheckedListBox.CheckOnClick = true;
            this.CompFlags1CheckedListBox.FormattingEnabled = true;
            this.CompFlags1CheckedListBox.Items.AddRange(new object[] {
            "0 - Unknown",
            "1 - Map Weapon",
            "2 - Map Dynamic",
            "3 - Map Animal",
            "4 - Map Cover",
            "5 - Map Vehicle",
            "6 - Vehicle Not BVH",
            "7 - Vehicle BVH",
            "8 - Vehicle Box",
            "9 - Ped",
            "10 - Ragdoll",
            "11 - Animal",
            "12 - Animal Ragdoll",
            "13 - Object",
            "14 - Object Env Cloth",
            "15 - Plant",
            "16 - Projectile",
            "17 - Explosion",
            "18 - Pickup",
            "19 - Foliage",
            "20 - Forklift Forks",
            "21 - Test Weapon",
            "22 - Test Camera",
            "23 - Test AI",
            "24 - Test Script",
            "25 - Test Vehicle Wheel",
            "26 - Glass",
            "27 - Map River",
            "28 - Smoke",
            "29 - Unsmashed",
            "30 - Map Stairs",
            "31 - Map Deep Surface"});
            this.CompFlags1CheckedListBox.Location = new System.Drawing.Point(62, 4);
            this.CompFlags1CheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompFlags1CheckedListBox.Name = "CompFlags1CheckedListBox";
            this.CompFlags1CheckedListBox.Size = new System.Drawing.Size(202, 472);
            this.CompFlags1CheckedListBox.TabIndex = 32;
            this.CompFlags1CheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CompFlags1CheckedListBox_ItemCheck);
            // 
            // CompositeXformTabPage
            // 
            this.CompositeXformTabPage.Controls.Add(this.CompRotationQuatBox);
            this.CompositeXformTabPage.Controls.Add(this.CompScaleTextBox);
            this.CompositeXformTabPage.Controls.Add(this.label23);
            this.CompositeXformTabPage.Controls.Add(this.CompPositionTextBox);
            this.CompositeXformTabPage.Controls.Add(this.label24);
            this.CompositeXformTabPage.Controls.Add(this.label25);
            this.CompositeXformTabPage.Location = new System.Drawing.Point(4, 26);
            this.CompositeXformTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompositeXformTabPage.Name = "CompositeXformTabPage";
            this.CompositeXformTabPage.Size = new System.Drawing.Size(673, 507);
            this.CompositeXformTabPage.TabIndex = 3;
            this.CompositeXformTabPage.Text = "复合体变换";
            this.CompositeXformTabPage.UseVisualStyleBackColor = true;
            // 
            // CompRotationQuatBox
            // 
            this.CompRotationQuatBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompRotationQuatBox.Location = new System.Drawing.Point(84, 47);
            this.CompRotationQuatBox.Margin = new System.Windows.Forms.Padding(0);
            this.CompRotationQuatBox.Name = "CompRotationQuatBox";
            this.CompRotationQuatBox.Size = new System.Drawing.Size(556, 31);
            this.CompRotationQuatBox.TabIndex = 10;
            this.CompRotationQuatBox.ValueChanged += new System.EventHandler(this.CompRotationQuatBox_ValueChanged);
            // 
            // CompScaleTextBox
            // 
            this.CompScaleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompScaleTextBox.Location = new System.Drawing.Point(84, 84);
            this.CompScaleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompScaleTextBox.Name = "CompScaleTextBox";
            this.CompScaleTextBox.Size = new System.Drawing.Size(556, 23);
            this.CompScaleTextBox.TabIndex = 12;
            this.CompScaleTextBox.TextChanged += new System.EventHandler(this.CompScaleTextBox_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(32, 87);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 17);
            this.label23.TabIndex = 11;
            this.label23.Text = "缩放：";
            // 
            // CompPositionTextBox
            // 
            this.CompPositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompPositionTextBox.Location = new System.Drawing.Point(84, 16);
            this.CompPositionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompPositionTextBox.Name = "CompPositionTextBox";
            this.CompPositionTextBox.Size = new System.Drawing.Size(556, 23);
            this.CompPositionTextBox.TabIndex = 8;
            this.CompPositionTextBox.TextChanged += new System.EventHandler(this.CompPositionTextBox_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(32, 53);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 17);
            this.label24.TabIndex = 9;
            this.label24.Text = "旋转：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(32, 19);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 17);
            this.label25.TabIndex = 7;
            this.label25.Text = "位置：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PolyCountLabel);
            this.groupBox1.Controls.Add(this.VertexCountLabel);
            this.groupBox1.Location = new System.Drawing.Point(18, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 98);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计信息";
            // 
            // PolyCountLabel
            // 
            this.PolyCountLabel.AutoSize = true;
            this.PolyCountLabel.Location = new System.Drawing.Point(20, 56);
            this.PolyCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PolyCountLabel.Name = "PolyCountLabel";
            this.PolyCountLabel.Size = new System.Drawing.Size(67, 17);
            this.PolyCountLabel.TabIndex = 14;
            this.PolyCountLabel.Text = "0 个多边形";
            // 
            // VertexCountLabel
            // 
            this.VertexCountLabel.AutoSize = true;
            this.VertexCountLabel.Location = new System.Drawing.Point(20, 30);
            this.VertexCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VertexCountLabel.Name = "VertexCountLabel";
            this.VertexCountLabel.Size = new System.Drawing.Size(55, 17);
            this.VertexCountLabel.TabIndex = 13;
            this.VertexCountLabel.Text = "0 个顶点";
            // 
            // EditYbnBoundsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 537);
            this.Controls.Add(this.BoundsTabControl);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditYbnBoundsPanel";
            this.Text = "EditYbnBoundsPanel";
            this.BoundsTabControl.ResumeLayout(false);
            this.BoundsTabPage.ResumeLayout(false);
            this.BoundsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnkTypeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnkFlagsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolyFlagsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialColourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PedDensityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomIDUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProceduralIDUpDown)).EndInit();
            this.GeometryTabPage.ResumeLayout(false);
            this.GeometryTabPage.PerformLayout();
            this.CompositeFlagsTabPage.ResumeLayout(false);
            this.CompositeFlagsTabPage.PerformLayout();
            this.CompositeXformTabPage.ResumeLayout(false);
            this.CompositeXformTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl BoundsTabControl;
        private System.Windows.Forms.TabPage BoundsTabPage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox UnkVectorTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox VolumeTextBox;
        private System.Windows.Forms.NumericUpDown UnkFlagsUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown PolyFlagsUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown MaterialColourUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown PedDensityUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown RoomIDUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ProceduralIDUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MarginTextBox;
        private System.Windows.Forms.TextBox BBCenterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox BSRadiusTextBox;
        private System.Windows.Forms.TextBox BSCenterTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox BBMaxTextBox;
        private System.Windows.Forms.TextBox BBMinTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage GeometryTabPage;
        private System.Windows.Forms.NumericUpDown UnkTypeUpDown;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox MaterialCombo;
        private System.Windows.Forms.TextBox QuantumTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox CenterGeomTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox UnkFloat2TextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox UnkFloat1TextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddToProjectButton;
        private System.Windows.Forms.TabPage CompositeFlagsTabPage;
        private System.Windows.Forms.CheckedListBox CompFlags1CheckedListBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckedListBox CompFlags2CheckedListBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage CompositeXformTabPage;
        private System.Windows.Forms.TextBox CompScaleTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox CompPositionTextBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private WinForms.QuaternionBox CompRotationQuatBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PolyCountLabel;
        private System.Windows.Forms.Label VertexCountLabel;
    }
}