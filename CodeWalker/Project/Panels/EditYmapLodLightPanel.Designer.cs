
namespace CodeWalker.Project.Panels
{
    partial class EditYmapLodLightPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYmapLodLightPanel));
            this.GoToButton = new System.Windows.Forms.Button();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddToProjectButton = new System.Windows.Forms.Button();
            this.NormalizeDirectionButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.DirectionTextBox = new System.Windows.Forms.TextBox();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IntensityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FalloffTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FalloffExponentTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HashTextBox = new System.Windows.Forms.TextBox();
            this.InnerAngleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.OuterAngleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.CoronaIntensityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.TimeFlagsAMCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.TimeFlagsPMCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TimeStateFlagsTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.StateFlags1CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.StateFlags2CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ColourRUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColourGUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColourBUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IntensityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerAngleUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OuterAngleUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoronaIntensityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourRUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourGUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // GoToButton
            // 
            this.GoToButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToButton.Location = new System.Drawing.Point(544, 6);
            this.GoToButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoToButton.Name = "GoToButton";
            this.GoToButton.Size = new System.Drawing.Size(85, 30);
            this.GoToButton.TabIndex = 87;
            this.GoToButton.Text = "传送";
            this.GoToButton.UseVisualStyleBackColor = true;
            this.GoToButton.Click += new System.EventHandler(this.GoToButton_Click);
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionTextBox.Location = new System.Drawing.Point(96, 10);
            this.PositionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(440, 23);
            this.PositionTextBox.TabIndex = 86;
            this.PositionTextBox.TextChanged += new System.EventHandler(this.PositionTextBox_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(44, 13);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(44, 17);
            this.label31.TabIndex = 85;
            this.label31.Text = "位置：";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(165, 361);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 30);
            this.DeleteButton.TabIndex = 107;
            this.DeleteButton.Text = "删除远景灯光";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddToProjectButton
            // 
            this.AddToProjectButton.Location = new System.Drawing.Point(48, 361);
            this.AddToProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddToProjectButton.Name = "AddToProjectButton";
            this.AddToProjectButton.Size = new System.Drawing.Size(111, 30);
            this.AddToProjectButton.TabIndex = 106;
            this.AddToProjectButton.Text = "添加到项目";
            this.AddToProjectButton.UseVisualStyleBackColor = true;
            this.AddToProjectButton.Click += new System.EventHandler(this.AddToProjectButton_Click);
            // 
            // NormalizeDirectionButton
            // 
            this.NormalizeDirectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NormalizeDirectionButton.Location = new System.Drawing.Point(544, 38);
            this.NormalizeDirectionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NormalizeDirectionButton.Name = "NormalizeDirectionButton";
            this.NormalizeDirectionButton.Size = new System.Drawing.Size(85, 30);
            this.NormalizeDirectionButton.TabIndex = 110;
            this.NormalizeDirectionButton.Text = "标准化";
            this.NormalizeDirectionButton.UseVisualStyleBackColor = true;
            this.NormalizeDirectionButton.Click += new System.EventHandler(this.NormalizeDirectionButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 44);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 17);
            this.label17.TabIndex = 108;
            this.label17.Text = "朝向：";
            // 
            // DirectionTextBox
            // 
            this.DirectionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectionTextBox.Location = new System.Drawing.Point(96, 41);
            this.DirectionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DirectionTextBox.Name = "DirectionTextBox";
            this.DirectionTextBox.Size = new System.Drawing.Size(440, 23);
            this.DirectionTextBox.TabIndex = 109;
            this.DirectionTextBox.TextChanged += new System.EventHandler(this.DirectionTextBox_TextChanged);
            // 
            // ColourLabel
            // 
            this.ColourLabel.BackColor = System.Drawing.Color.White;
            this.ColourLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColourLabel.Location = new System.Drawing.Point(96, 134);
            this.ColourLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(35, 28);
            this.ColourLabel.TabIndex = 111;
            this.ColourLabel.Click += new System.EventHandler(this.ColourLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 114;
            this.label2.Text = "颜色 (RGB)：";
            // 
            // IntensityUpDown
            // 
            this.IntensityUpDown.Location = new System.Drawing.Point(96, 105);
            this.IntensityUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IntensityUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IntensityUpDown.Name = "IntensityUpDown";
            this.IntensityUpDown.Size = new System.Drawing.Size(180, 23);
            this.IntensityUpDown.TabIndex = 116;
            this.IntensityUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IntensityUpDown.ValueChanged += new System.EventHandler(this.IntensityUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 115;
            this.label3.Text = "亮度：";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Point",
            "Spot",
            "Capsule"});
            this.TypeComboBox.Location = new System.Drawing.Point(96, 72);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(179, 25);
            this.TypeComboBox.TabIndex = 118;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 119;
            this.label4.Text = "光衰：";
            // 
            // FalloffTextBox
            // 
            this.FalloffTextBox.Location = new System.Drawing.Point(96, 167);
            this.FalloffTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FalloffTextBox.Name = "FalloffTextBox";
            this.FalloffTextBox.Size = new System.Drawing.Size(179, 23);
            this.FalloffTextBox.TabIndex = 120;
            this.FalloffTextBox.TextChanged += new System.EventHandler(this.FalloffTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 121;
            this.label5.Text = "光衰扩散：";
            // 
            // FalloffExponentTextBox
            // 
            this.FalloffExponentTextBox.Location = new System.Drawing.Point(96, 198);
            this.FalloffExponentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FalloffExponentTextBox.Name = "FalloffExponentTextBox";
            this.FalloffExponentTextBox.Size = new System.Drawing.Size(179, 23);
            this.FalloffExponentTextBox.TabIndex = 122;
            this.FalloffExponentTextBox.TextChanged += new System.EventHandler(this.FalloffExponentTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 123;
            this.label6.Text = "哈希：";
            // 
            // HashTextBox
            // 
            this.HashTextBox.Location = new System.Drawing.Point(96, 229);
            this.HashTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HashTextBox.Name = "HashTextBox";
            this.HashTextBox.Size = new System.Drawing.Size(179, 23);
            this.HashTextBox.TabIndex = 124;
            this.HashTextBox.TextChanged += new System.EventHandler(this.HashTextBox_TextChanged);
            // 
            // InnerAngleUpDown
            // 
            this.InnerAngleUpDown.Location = new System.Drawing.Point(96, 260);
            this.InnerAngleUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InnerAngleUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.InnerAngleUpDown.Name = "InnerAngleUpDown";
            this.InnerAngleUpDown.Size = new System.Drawing.Size(180, 23);
            this.InnerAngleUpDown.TabIndex = 126;
            this.InnerAngleUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.InnerAngleUpDown.ValueChanged += new System.EventHandler(this.InnerAngleUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 125;
            this.label7.Text = "内部角度：";
            // 
            // OuterAngleUpDown
            // 
            this.OuterAngleUpDown.Location = new System.Drawing.Point(96, 291);
            this.OuterAngleUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OuterAngleUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.OuterAngleUpDown.Name = "OuterAngleUpDown";
            this.OuterAngleUpDown.Size = new System.Drawing.Size(180, 23);
            this.OuterAngleUpDown.TabIndex = 128;
            this.OuterAngleUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.OuterAngleUpDown.ValueChanged += new System.EventHandler(this.OuterAngleUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 127;
            this.label8.Text = "外部角度：";
            // 
            // CoronaIntensityUpDown
            // 
            this.CoronaIntensityUpDown.Location = new System.Drawing.Point(96, 322);
            this.CoronaIntensityUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoronaIntensityUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CoronaIntensityUpDown.Name = "CoronaIntensityUpDown";
            this.CoronaIntensityUpDown.Size = new System.Drawing.Size(180, 23);
            this.CoronaIntensityUpDown.TabIndex = 130;
            this.CoronaIntensityUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CoronaIntensityUpDown.ValueChanged += new System.EventHandler(this.CoronaIntensityUpDown_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 324);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 129;
            this.label9.Text = "光晕：";
            // 
            // TimeFlagsAMCheckedListBox
            // 
            this.TimeFlagsAMCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeFlagsAMCheckedListBox.CheckOnClick = true;
            this.TimeFlagsAMCheckedListBox.FormattingEnabled = true;
            this.TimeFlagsAMCheckedListBox.Items.AddRange(new object[] {
            "00:00 - 01:00",
            "01:00 - 02:00",
            "02:00 - 03:00",
            "03:00 - 04:00",
            "04:00 - 05:00",
            "05:00 - 06:00",
            "06:00 - 07:00",
            "07:00 - 08:00",
            "08:00 - 09:00",
            "09:00 - 10:00",
            "10:00 - 11:00",
            "11:00 - 12:00"});
            this.TimeFlagsAMCheckedListBox.Location = new System.Drawing.Point(401, 105);
            this.TimeFlagsAMCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeFlagsAMCheckedListBox.Name = "TimeFlagsAMCheckedListBox";
            this.TimeFlagsAMCheckedListBox.Size = new System.Drawing.Size(110, 238);
            this.TimeFlagsAMCheckedListBox.TabIndex = 131;
            this.TimeFlagsAMCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TimeFlagsAMCheckedListBox_ItemCheck);
            // 
            // TimeFlagsPMCheckedListBox
            // 
            this.TimeFlagsPMCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeFlagsPMCheckedListBox.CheckOnClick = true;
            this.TimeFlagsPMCheckedListBox.FormattingEnabled = true;
            this.TimeFlagsPMCheckedListBox.Items.AddRange(new object[] {
            "12:00 - 13:00",
            "13:00 - 14:00",
            "14:00 - 15:00",
            "15:00 - 16:00",
            "16:00 - 17:00",
            "17:00 - 18:00",
            "18:00 - 19:00",
            "19:00 - 20:00",
            "20:00 - 21:00",
            "21:00 - 22:00",
            "22:00 - 23:00",
            "23:00 - 00:00"});
            this.TimeFlagsPMCheckedListBox.Location = new System.Drawing.Point(519, 105);
            this.TimeFlagsPMCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeFlagsPMCheckedListBox.Name = "TimeFlagsPMCheckedListBox";
            this.TimeFlagsPMCheckedListBox.Size = new System.Drawing.Size(110, 238);
            this.TimeFlagsPMCheckedListBox.TabIndex = 132;
            this.TimeFlagsPMCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TimeFlagsPMCheckedListBox_ItemCheck);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 134;
            this.label10.Text = "时间/状态 flags：";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TimeStateFlagsTextBox
            // 
            this.TimeStateFlagsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeStateFlagsTextBox.Location = new System.Drawing.Point(400, 72);
            this.TimeStateFlagsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeStateFlagsTextBox.Name = "TimeStateFlagsTextBox";
            this.TimeStateFlagsTextBox.Size = new System.Drawing.Size(229, 23);
            this.TimeStateFlagsTextBox.TabIndex = 135;
            this.TimeStateFlagsTextBox.TextChanged += new System.EventHandler(this.TimeStateFlagsTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 136;
            this.label11.Text = "时间 flags：";
            // 
            // StateFlags1CheckedListBox
            // 
            this.StateFlags1CheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StateFlags1CheckedListBox.CheckOnClick = true;
            this.StateFlags1CheckedListBox.FormattingEnabled = true;
            this.StateFlags1CheckedListBox.Items.AddRange(new object[] {
            "路灯",
            "Unk2"});
            this.StateFlags1CheckedListBox.Location = new System.Drawing.Point(401, 351);
            this.StateFlags1CheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StateFlags1CheckedListBox.Name = "StateFlags1CheckedListBox";
            this.StateFlags1CheckedListBox.Size = new System.Drawing.Size(110, 40);
            this.StateFlags1CheckedListBox.TabIndex = 137;
            this.StateFlags1CheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.StateFlags1CheckedListBox_ItemCheck);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(317, 351);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 138;
            this.label12.Text = "状态 flags：";
            // 
            // StateFlags2CheckedListBox
            // 
            this.StateFlags2CheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StateFlags2CheckedListBox.CheckOnClick = true;
            this.StateFlags2CheckedListBox.FormattingEnabled = true;
            this.StateFlags2CheckedListBox.Items.AddRange(new object[] {
            "Unk3",
            "Unk4",
            "Unk5"});
            this.StateFlags2CheckedListBox.Location = new System.Drawing.Point(519, 351);
            this.StateFlags2CheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StateFlags2CheckedListBox.Name = "StateFlags2CheckedListBox";
            this.StateFlags2CheckedListBox.Size = new System.Drawing.Size(110, 58);
            this.StateFlags2CheckedListBox.TabIndex = 139;
            this.StateFlags2CheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.StateFlags2CheckedListBox_ItemCheck);
            // 
            // ColourRUpDown
            // 
            this.ColourRUpDown.Location = new System.Drawing.Point(135, 136);
            this.ColourRUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColourRUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColourRUpDown.Name = "ColourRUpDown";
            this.ColourRUpDown.Size = new System.Drawing.Size(44, 23);
            this.ColourRUpDown.TabIndex = 140;
            this.ColourRUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColourRUpDown.ValueChanged += new System.EventHandler(this.ColourRUpDown_ValueChanged);
            // 
            // ColourGUpDown
            // 
            this.ColourGUpDown.Location = new System.Drawing.Point(183, 136);
            this.ColourGUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColourGUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColourGUpDown.Name = "ColourGUpDown";
            this.ColourGUpDown.Size = new System.Drawing.Size(44, 23);
            this.ColourGUpDown.TabIndex = 141;
            this.ColourGUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColourGUpDown.ValueChanged += new System.EventHandler(this.ColourGUpDown_ValueChanged);
            // 
            // ColourBUpDown
            // 
            this.ColourBUpDown.Location = new System.Drawing.Point(231, 136);
            this.ColourBUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColourBUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColourBUpDown.Name = "ColourBUpDown";
            this.ColourBUpDown.Size = new System.Drawing.Size(44, 23);
            this.ColourBUpDown.TabIndex = 142;
            this.ColourBUpDown.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColourBUpDown.ValueChanged += new System.EventHandler(this.ColourBUpDown_ValueChanged);
            // 
            // EditYmapLodLightPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 423);
            this.Controls.Add(this.ColourBUpDown);
            this.Controls.Add(this.ColourGUpDown);
            this.Controls.Add(this.ColourRUpDown);
            this.Controls.Add(this.StateFlags2CheckedListBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.StateFlags1CheckedListBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TimeStateFlagsTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TimeFlagsPMCheckedListBox);
            this.Controls.Add(this.TimeFlagsAMCheckedListBox);
            this.Controls.Add(this.CoronaIntensityUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OuterAngleUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InnerAngleUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HashTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FalloffExponentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FalloffTextBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.IntensityUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColourLabel);
            this.Controls.Add(this.NormalizeDirectionButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DirectionTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddToProjectButton);
            this.Controls.Add(this.GoToButton);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.label31);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditYmapLodLightPanel";
            this.Text = "远景灯光";
            ((System.ComponentModel.ISupportInitialize)(this.IntensityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InnerAngleUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OuterAngleUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoronaIntensityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourRUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourGUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoToButton;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddToProjectButton;
        private System.Windows.Forms.Button NormalizeDirectionButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox DirectionTextBox;
        private System.Windows.Forms.Label ColourLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IntensityUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FalloffTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FalloffExponentTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HashTextBox;
        private System.Windows.Forms.NumericUpDown InnerAngleUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown OuterAngleUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CoronaIntensityUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox TimeFlagsAMCheckedListBox;
        private System.Windows.Forms.CheckedListBox TimeFlagsPMCheckedListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TimeStateFlagsTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox StateFlags1CheckedListBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox StateFlags2CheckedListBox;
        private System.Windows.Forms.NumericUpDown ColourRUpDown;
        private System.Windows.Forms.NumericUpDown ColourGUpDown;
        private System.Windows.Forms.NumericUpDown ColourBUpDown;
    }
}