namespace CodeWalker.Project.Panels
{
    partial class EditYtypMloRoomPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYtypMloRoomPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinBoundsTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.MaxBoundsTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.FlagsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FlagsTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BlendTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.label4 = new System.Windows.Forms.Label();
            this.TimecycleTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.label5 = new System.Windows.Forms.Label();
            this.Timecycle2TextBox = new CodeWalker.WinForms.TextBoxFix();
            this.label6 = new System.Windows.Forms.Label();
            this.PortalCountTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.label7 = new System.Windows.Forms.Label();
            this.FloorIDTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.label8 = new System.Windows.Forms.Label();
            this.ExteriorVisDepthTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddEntityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "最小边界：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "最大边界：";
            // 
            // MinBoundsTextBox
            // 
            this.MinBoundsTextBox.Location = new System.Drawing.Point(98, 51);
            this.MinBoundsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinBoundsTextBox.Name = "MinBoundsTextBox";
            this.MinBoundsTextBox.Size = new System.Drawing.Size(237, 23);
            this.MinBoundsTextBox.TabIndex = 4;
            this.MinBoundsTextBox.TextChanged += new System.EventHandler(this.MinBoundsTextBox_TextChanged);
            // 
            // MaxBoundsTextBox
            // 
            this.MaxBoundsTextBox.Location = new System.Drawing.Point(98, 82);
            this.MaxBoundsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxBoundsTextBox.Name = "MaxBoundsTextBox";
            this.MaxBoundsTextBox.Size = new System.Drawing.Size(237, 23);
            this.MaxBoundsTextBox.TabIndex = 6;
            this.MaxBoundsTextBox.TextChanged += new System.EventHandler(this.MaxBoundsTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "名称：";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(98, 20);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(237, 23);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // FlagsCheckedListBox
            // 
            this.FlagsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlagsCheckedListBox.CheckOnClick = true;
            this.FlagsCheckedListBox.FormattingEnabled = true;
            this.FlagsCheckedListBox.Items.AddRange(new object[] {
            "1 - Unk01",
            "2 - 禁用通缉等级",
            "4 - 禁用外部阴影",
            "8 - Unk04",
            "16 - Unk05",
            "32 - 减少载具生成",
            "64 - 减少人物生成",
            "128 - Unk08",
            "256 - 禁用不确定边缘的门户",
            "512 - Unk10"});
            this.FlagsCheckedListBox.Location = new System.Drawing.Point(343, 54);
            this.FlagsCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlagsCheckedListBox.Name = "FlagsCheckedListBox";
            this.FlagsCheckedListBox.Size = new System.Drawing.Size(281, 202);
            this.FlagsCheckedListBox.TabIndex = 21;
            this.FlagsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FlagsCheckedListBox_ItemCheck);
            // 
            // FlagsTextBox
            // 
            this.FlagsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlagsTextBox.Location = new System.Drawing.Point(389, 21);
            this.FlagsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlagsTextBox.Name = "FlagsTextBox";
            this.FlagsTextBox.Size = new System.Drawing.Size(235, 23);
            this.FlagsTextBox.TabIndex = 20;
            this.FlagsTextBox.TextChanged += new System.EventHandler(this.FlagsTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(340, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Flags：";
            // 
            // BlendTextBox
            // 
            this.BlendTextBox.Location = new System.Drawing.Point(98, 113);
            this.BlendTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BlendTextBox.Name = "BlendTextBox";
            this.BlendTextBox.Size = new System.Drawing.Size(237, 23);
            this.BlendTextBox.TabIndex = 8;
            this.BlendTextBox.TextChanged += new System.EventHandler(this.BlendTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "混合：";
            // 
            // TimecycleTextBox
            // 
            this.TimecycleTextBox.Location = new System.Drawing.Point(98, 144);
            this.TimecycleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimecycleTextBox.Name = "TimecycleTextBox";
            this.TimecycleTextBox.Size = new System.Drawing.Size(237, 23);
            this.TimecycleTextBox.TabIndex = 10;
            this.TimecycleTextBox.TextChanged += new System.EventHandler(this.TimecycleTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Timecycle：";
            // 
            // Timecycle2TextBox
            // 
            this.Timecycle2TextBox.Location = new System.Drawing.Point(98, 175);
            this.Timecycle2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Timecycle2TextBox.Name = "Timecycle2TextBox";
            this.Timecycle2TextBox.Size = new System.Drawing.Size(237, 23);
            this.Timecycle2TextBox.TabIndex = 12;
            this.Timecycle2TextBox.TextChanged += new System.EventHandler(this.Timecycle2TextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Timecycle 2：";
            // 
            // PortalCountTextBox
            // 
            this.PortalCountTextBox.Location = new System.Drawing.Point(98, 206);
            this.PortalCountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PortalCountTextBox.Name = "PortalCountTextBox";
            this.PortalCountTextBox.Size = new System.Drawing.Size(237, 23);
            this.PortalCountTextBox.TabIndex = 14;
            this.PortalCountTextBox.TextChanged += new System.EventHandler(this.PortalCountTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "门户数量：";
            // 
            // FloorIDTextBox
            // 
            this.FloorIDTextBox.Location = new System.Drawing.Point(98, 237);
            this.FloorIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FloorIDTextBox.Name = "FloorIDTextBox";
            this.FloorIDTextBox.Size = new System.Drawing.Size(237, 23);
            this.FloorIDTextBox.TabIndex = 16;
            this.FloorIDTextBox.TextChanged += new System.EventHandler(this.FloorIDTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "地板 ID：";
            // 
            // ExteriorVisDepthTextBox
            // 
            this.ExteriorVisDepthTextBox.Location = new System.Drawing.Point(98, 268);
            this.ExteriorVisDepthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExteriorVisDepthTextBox.Name = "ExteriorVisDepthTextBox";
            this.ExteriorVisDepthTextBox.Size = new System.Drawing.Size(237, 23);
            this.ExteriorVisDepthTextBox.TabIndex = 18;
            this.ExteriorVisDepthTextBox.TextChanged += new System.EventHandler(this.ExteriorVisDepthTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 271);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "外部可见深度：";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(490, 264);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(134, 30);
            this.DeleteButton.TabIndex = 23;
            this.DeleteButton.Text = "删除房间";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddEntityButton
            // 
            this.AddEntityButton.Location = new System.Drawing.Point(343, 264);
            this.AddEntityButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddEntityButton.Name = "AddEntityButton";
            this.AddEntityButton.Size = new System.Drawing.Size(134, 30);
            this.AddEntityButton.TabIndex = 22;
            this.AddEntityButton.Text = "添加实体";
            this.AddEntityButton.UseVisualStyleBackColor = true;
            this.AddEntityButton.Click += new System.EventHandler(this.AddEntityButton_Click);
            // 
            // EditYtypMloRoomPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 317);
            this.Controls.Add(this.AddEntityButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ExteriorVisDepthTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FloorIDTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PortalCountTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Timecycle2TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimecycleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BlendTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FlagsCheckedListBox);
            this.Controls.Add(this.FlagsTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxBoundsTextBox);
            this.Controls.Add(this.MinBoundsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditYtypMloRoomPanel";
            this.Text = "房间";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WinForms.TextBoxFix MinBoundsTextBox;
        private WinForms.TextBoxFix MaxBoundsTextBox;
        private System.Windows.Forms.Label label3;
        private WinForms.TextBoxFix NameTextBox;
        private System.Windows.Forms.CheckedListBox FlagsCheckedListBox;
        private System.Windows.Forms.TextBox FlagsTextBox;
        private System.Windows.Forms.Label label14;
        private WinForms.TextBoxFix BlendTextBox;
        private System.Windows.Forms.Label label4;
        private WinForms.TextBoxFix TimecycleTextBox;
        private System.Windows.Forms.Label label5;
        private WinForms.TextBoxFix Timecycle2TextBox;
        private System.Windows.Forms.Label label6;
        private WinForms.TextBoxFix PortalCountTextBox;
        private System.Windows.Forms.Label label7;
        private WinForms.TextBoxFix FloorIDTextBox;
        private System.Windows.Forms.Label label8;
        private WinForms.TextBoxFix ExteriorVisDepthTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddEntityButton;
    }
}