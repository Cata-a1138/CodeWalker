namespace CodeWalker.Project.Panels
{
    partial class EditYnvPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYnvPanel));
            this.YnvAABBSizeTextBox = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.YnvAreaIDYUpDown = new System.Windows.Forms.NumericUpDown();
            this.label90 = new System.Windows.Forms.Label();
            this.YnvAreaIDXUpDown = new System.Windows.Forms.NumericUpDown();
            this.YnvAreaIDInfoLabel = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.YnvVertexCountLabel = new System.Windows.Forms.Label();
            this.YnvPolyCountLabel = new System.Windows.Forms.Label();
            this.YnvPortalCountLabel = new System.Windows.Forms.Label();
            this.YnvPortalLinkCountLabel = new System.Windows.Forms.Label();
            this.YnvPointCountLabel = new System.Windows.Forms.Label();
            this.YnvByteCountLabel = new System.Windows.Forms.Label();
            this.YnvFlagsGroupBox = new System.Windows.Forms.GroupBox();
            this.YnvFlagsUnknown16CheckBox = new System.Windows.Forms.CheckBox();
            this.YnvFlagsUnknown8CheckBox = new System.Windows.Forms.CheckBox();
            this.YnvFlagsVehicleCheckBox = new System.Windows.Forms.CheckBox();
            this.YnvFlagsPortalsCheckBox = new System.Windows.Forms.CheckBox();
            this.YnvFlagsPolygonsCheckBox = new System.Windows.Forms.CheckBox();
            this.YnvVersionUnkHashTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.YnvAdjAreaIDsTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.label48 = new System.Windows.Forms.Label();
            this.YnvProjectPathTextBox = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.YnvRpfPathTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.YnvAreaIDYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YnvAreaIDXUpDown)).BeginInit();
            this.YnvFlagsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // YnvAABBSizeTextBox
            // 
            this.YnvAABBSizeTextBox.Location = new System.Drawing.Point(106, 47);
            this.YnvAABBSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvAABBSizeTextBox.Name = "YnvAABBSizeTextBox";
            this.YnvAABBSizeTextBox.Size = new System.Drawing.Size(189, 23);
            this.YnvAABBSizeTextBox.TabIndex = 37;
            this.YnvAABBSizeTextBox.TextChanged += new System.EventHandler(this.YnvAABBSizeTextBox_TextChanged);
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(20, 50);
            this.label91.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(80, 17);
            this.label91.TabIndex = 38;
            this.label91.Text = "AABB 大小：";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(193, 18);
            this.label89.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(27, 17);
            this.label89.TabIndex = 36;
            this.label89.Text = "Y：";
            // 
            // YnvAreaIDYUpDown
            // 
            this.YnvAreaIDYUpDown.Location = new System.Drawing.Point(220, 16);
            this.YnvAreaIDYUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvAreaIDYUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.YnvAreaIDYUpDown.Name = "YnvAreaIDYUpDown";
            this.YnvAreaIDYUpDown.Size = new System.Drawing.Size(75, 23);
            this.YnvAreaIDYUpDown.TabIndex = 35;
            this.YnvAreaIDYUpDown.ValueChanged += new System.EventHandler(this.YnvAreaIDYUpDown_ValueChanged);
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(72, 18);
            this.label90.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(28, 17);
            this.label90.TabIndex = 34;
            this.label90.Text = "X：";
            // 
            // YnvAreaIDXUpDown
            // 
            this.YnvAreaIDXUpDown.Location = new System.Drawing.Point(106, 16);
            this.YnvAreaIDXUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvAreaIDXUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.YnvAreaIDXUpDown.Name = "YnvAreaIDXUpDown";
            this.YnvAreaIDXUpDown.Size = new System.Drawing.Size(79, 23);
            this.YnvAreaIDXUpDown.TabIndex = 33;
            this.YnvAreaIDXUpDown.ValueChanged += new System.EventHandler(this.YnvAreaIDXUpDown_ValueChanged);
            // 
            // YnvAreaIDInfoLabel
            // 
            this.YnvAreaIDInfoLabel.AutoSize = true;
            this.YnvAreaIDInfoLabel.Location = new System.Drawing.Point(313, 18);
            this.YnvAreaIDInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YnvAreaIDInfoLabel.Name = "YnvAreaIDInfoLabel";
            this.YnvAreaIDInfoLabel.Size = new System.Drawing.Size(40, 17);
            this.YnvAreaIDInfoLabel.TabIndex = 32;
            this.YnvAreaIDInfoLabel.Text = "ID：0";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(19, 18);
            this.label92.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(61, 17);
            this.label92.TabIndex = 31;
            this.label92.Text = "区域 ID：";
            // 
            // YnvVertexCountLabel
            // 
            this.YnvVertexCountLabel.AutoSize = true;
            this.YnvVertexCountLabel.Location = new System.Drawing.Point(440, 53);
            this.YnvVertexCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YnvVertexCountLabel.Name = "YnvVertexCountLabel";
            this.YnvVertexCountLabel.Size = new System.Drawing.Size(75, 17);
            this.YnvVertexCountLabel.TabIndex = 39;
            this.YnvVertexCountLabel.Text = "顶点数量：0";
            // 
            // YnvPolyCountLabel
            // 
            this.YnvPolyCountLabel.AutoSize = true;
            this.YnvPolyCountLabel.Location = new System.Drawing.Point(440, 76);
            this.YnvPolyCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YnvPolyCountLabel.Name = "YnvPolyCountLabel";
            this.YnvPolyCountLabel.Size = new System.Drawing.Size(87, 17);
            this.YnvPolyCountLabel.TabIndex = 40;
            this.YnvPolyCountLabel.Text = "多边形数量：0";
            // 
            // YnvPortalCountLabel
            // 
            this.YnvPortalCountLabel.AutoSize = true;
            this.YnvPortalCountLabel.Location = new System.Drawing.Point(440, 100);
            this.YnvPortalCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YnvPortalCountLabel.Name = "YnvPortalCountLabel";
            this.YnvPortalCountLabel.Size = new System.Drawing.Size(75, 17);
            this.YnvPortalCountLabel.TabIndex = 41;
            this.YnvPortalCountLabel.Text = "门户数量：0";
            // 
            // YnvPortalLinkCountLabel
            // 
            this.YnvPortalLinkCountLabel.AutoSize = true;
            this.YnvPortalLinkCountLabel.Location = new System.Drawing.Point(440, 124);
            this.YnvPortalLinkCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YnvPortalLinkCountLabel.Name = "YnvPortalLinkCountLabel";
            this.YnvPortalLinkCountLabel.Size = new System.Drawing.Size(99, 17);
            this.YnvPortalLinkCountLabel.TabIndex = 42;
            this.YnvPortalLinkCountLabel.Text = "门户链接数量：0";
            // 
            // YnvPointCountLabel
            // 
            this.YnvPointCountLabel.AutoSize = true;
            this.YnvPointCountLabel.Location = new System.Drawing.Point(440, 147);
            this.YnvPointCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YnvPointCountLabel.Name = "YnvPointCountLabel";
            this.YnvPointCountLabel.Size = new System.Drawing.Size(63, 17);
            this.YnvPointCountLabel.TabIndex = 43;
            this.YnvPointCountLabel.Text = "点数量：0";
            // 
            // YnvByteCountLabel
            // 
            this.YnvByteCountLabel.AutoSize = true;
            this.YnvByteCountLabel.Location = new System.Drawing.Point(440, 171);
            this.YnvByteCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YnvByteCountLabel.Name = "YnvByteCountLabel";
            this.YnvByteCountLabel.Size = new System.Drawing.Size(75, 17);
            this.YnvByteCountLabel.TabIndex = 44;
            this.YnvByteCountLabel.Text = "字节数量：0";
            // 
            // YnvFlagsGroupBox
            // 
            this.YnvFlagsGroupBox.Controls.Add(this.YnvFlagsUnknown16CheckBox);
            this.YnvFlagsGroupBox.Controls.Add(this.YnvFlagsUnknown8CheckBox);
            this.YnvFlagsGroupBox.Controls.Add(this.YnvFlagsVehicleCheckBox);
            this.YnvFlagsGroupBox.Controls.Add(this.YnvFlagsPortalsCheckBox);
            this.YnvFlagsGroupBox.Controls.Add(this.YnvFlagsPolygonsCheckBox);
            this.YnvFlagsGroupBox.Location = new System.Drawing.Point(312, 47);
            this.YnvFlagsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvFlagsGroupBox.Name = "YnvFlagsGroupBox";
            this.YnvFlagsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvFlagsGroupBox.Size = new System.Drawing.Size(120, 150);
            this.YnvFlagsGroupBox.TabIndex = 45;
            this.YnvFlagsGroupBox.TabStop = false;
            this.YnvFlagsGroupBox.Text = "内容 flags";
            // 
            // YnvFlagsUnknown16CheckBox
            // 
            this.YnvFlagsUnknown16CheckBox.AutoSize = true;
            this.YnvFlagsUnknown16CheckBox.Location = new System.Drawing.Point(14, 125);
            this.YnvFlagsUnknown16CheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvFlagsUnknown16CheckBox.Name = "YnvFlagsUnknown16CheckBox";
            this.YnvFlagsUnknown16CheckBox.Size = new System.Drawing.Size(103, 21);
            this.YnvFlagsUnknown16CheckBox.TabIndex = 4;
            this.YnvFlagsUnknown16CheckBox.Text = "[Unknown16]";
            this.YnvFlagsUnknown16CheckBox.UseVisualStyleBackColor = true;
            this.YnvFlagsUnknown16CheckBox.CheckedChanged += new System.EventHandler(this.YnvFlagsUnknown16CheckBox_CheckedChanged);
            // 
            // YnvFlagsUnknown8CheckBox
            // 
            this.YnvFlagsUnknown8CheckBox.AutoSize = true;
            this.YnvFlagsUnknown8CheckBox.Location = new System.Drawing.Point(14, 99);
            this.YnvFlagsUnknown8CheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvFlagsUnknown8CheckBox.Name = "YnvFlagsUnknown8CheckBox";
            this.YnvFlagsUnknown8CheckBox.Size = new System.Drawing.Size(96, 21);
            this.YnvFlagsUnknown8CheckBox.TabIndex = 3;
            this.YnvFlagsUnknown8CheckBox.Text = "[Unknown8]";
            this.YnvFlagsUnknown8CheckBox.UseVisualStyleBackColor = true;
            this.YnvFlagsUnknown8CheckBox.CheckedChanged += new System.EventHandler(this.YnvFlagsUnknown8CheckBox_CheckedChanged);
            // 
            // YnvFlagsVehicleCheckBox
            // 
            this.YnvFlagsVehicleCheckBox.AutoSize = true;
            this.YnvFlagsVehicleCheckBox.Location = new System.Drawing.Point(14, 75);
            this.YnvFlagsVehicleCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvFlagsVehicleCheckBox.Name = "YnvFlagsVehicleCheckBox";
            this.YnvFlagsVehicleCheckBox.Size = new System.Drawing.Size(51, 21);
            this.YnvFlagsVehicleCheckBox.TabIndex = 2;
            this.YnvFlagsVehicleCheckBox.Text = "载具";
            this.YnvFlagsVehicleCheckBox.UseVisualStyleBackColor = true;
            this.YnvFlagsVehicleCheckBox.CheckedChanged += new System.EventHandler(this.YnvFlagsVehicleCheckBox_CheckedChanged);
            // 
            // YnvFlagsPortalsCheckBox
            // 
            this.YnvFlagsPortalsCheckBox.AutoSize = true;
            this.YnvFlagsPortalsCheckBox.Location = new System.Drawing.Point(14, 50);
            this.YnvFlagsPortalsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvFlagsPortalsCheckBox.Name = "YnvFlagsPortalsCheckBox";
            this.YnvFlagsPortalsCheckBox.Size = new System.Drawing.Size(51, 21);
            this.YnvFlagsPortalsCheckBox.TabIndex = 1;
            this.YnvFlagsPortalsCheckBox.Text = "门户";
            this.YnvFlagsPortalsCheckBox.UseVisualStyleBackColor = true;
            this.YnvFlagsPortalsCheckBox.CheckedChanged += new System.EventHandler(this.YnvFlagsPortalsCheckBox_CheckedChanged);
            // 
            // YnvFlagsPolygonsCheckBox
            // 
            this.YnvFlagsPolygonsCheckBox.AutoSize = true;
            this.YnvFlagsPolygonsCheckBox.Location = new System.Drawing.Point(14, 26);
            this.YnvFlagsPolygonsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvFlagsPolygonsCheckBox.Name = "YnvFlagsPolygonsCheckBox";
            this.YnvFlagsPolygonsCheckBox.Size = new System.Drawing.Size(63, 21);
            this.YnvFlagsPolygonsCheckBox.TabIndex = 0;
            this.YnvFlagsPolygonsCheckBox.Text = "多边形";
            this.YnvFlagsPolygonsCheckBox.UseVisualStyleBackColor = true;
            this.YnvFlagsPolygonsCheckBox.CheckedChanged += new System.EventHandler(this.YnvFlagsVerticesCheckBox_CheckedChanged);
            // 
            // YnvVersionUnkHashTextBox
            // 
            this.YnvVersionUnkHashTextBox.Location = new System.Drawing.Point(106, 78);
            this.YnvVersionUnkHashTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvVersionUnkHashTextBox.Name = "YnvVersionUnkHashTextBox";
            this.YnvVersionUnkHashTextBox.Size = new System.Drawing.Size(189, 23);
            this.YnvVersionUnkHashTextBox.TabIndex = 46;
            this.YnvVersionUnkHashTextBox.TextChanged += new System.EventHandler(this.YnvVersionUnkHashTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "未知哈希：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "(2244687201 for global, 0 for vehicle)";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(15, 113);
            this.label78.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(85, 17);
            this.label78.TabIndex = 53;
            this.label78.Text = "调整区域 ID：";
            // 
            // YnvAdjAreaIDsTextBox
            // 
            this.YnvAdjAreaIDsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.YnvAdjAreaIDsTextBox.Location = new System.Drawing.Point(106, 113);
            this.YnvAdjAreaIDsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvAdjAreaIDsTextBox.Multiline = true;
            this.YnvAdjAreaIDsTextBox.Name = "YnvAdjAreaIDsTextBox";
            this.YnvAdjAreaIDsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.YnvAdjAreaIDsTextBox.Size = new System.Drawing.Size(189, 224);
            this.YnvAdjAreaIDsTextBox.TabIndex = 52;
            this.YnvAdjAreaIDsTextBox.WordWrap = false;
            this.YnvAdjAreaIDsTextBox.TextChanged += new System.EventHandler(this.YnvAdjAreaIDsTextBox_TextChanged);
            // 
            // label48
            // 
            this.label48.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(32, 382);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(68, 17);
            this.label48.TabIndex = 57;
            this.label48.Text = "项目路径：";
            // 
            // YnvProjectPathTextBox
            // 
            this.YnvProjectPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YnvProjectPathTextBox.Location = new System.Drawing.Point(106, 379);
            this.YnvProjectPathTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvProjectPathTextBox.Name = "YnvProjectPathTextBox";
            this.YnvProjectPathTextBox.ReadOnly = true;
            this.YnvProjectPathTextBox.Size = new System.Drawing.Size(481, 23);
            this.YnvProjectPathTextBox.TabIndex = 56;
            // 
            // label47
            // 
            this.label47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(32, 348);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(68, 17);
            this.label47.TabIndex = 55;
            this.label47.Text = "Rpf 路径：";
            // 
            // YnvRpfPathTextBox
            // 
            this.YnvRpfPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YnvRpfPathTextBox.Location = new System.Drawing.Point(106, 345);
            this.YnvRpfPathTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvRpfPathTextBox.Name = "YnvRpfPathTextBox";
            this.YnvRpfPathTextBox.ReadOnly = true;
            this.YnvRpfPathTextBox.Size = new System.Drawing.Size(481, 23);
            this.YnvRpfPathTextBox.TabIndex = 54;
            // 
            // EditYnvPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 424);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.YnvProjectPathTextBox);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.YnvRpfPathTextBox);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.YnvAdjAreaIDsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YnvVersionUnkHashTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YnvFlagsGroupBox);
            this.Controls.Add(this.YnvByteCountLabel);
            this.Controls.Add(this.YnvPointCountLabel);
            this.Controls.Add(this.YnvPortalLinkCountLabel);
            this.Controls.Add(this.YnvPortalCountLabel);
            this.Controls.Add(this.YnvPolyCountLabel);
            this.Controls.Add(this.YnvVertexCountLabel);
            this.Controls.Add(this.YnvAABBSizeTextBox);
            this.Controls.Add(this.label91);
            this.Controls.Add(this.label89);
            this.Controls.Add(this.YnvAreaIDYUpDown);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.YnvAreaIDXUpDown);
            this.Controls.Add(this.YnvAreaIDInfoLabel);
            this.Controls.Add(this.label92);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditYnvPanel";
            this.Text = "编辑 Ynv";
            ((System.ComponentModel.ISupportInitialize)(this.YnvAreaIDYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YnvAreaIDXUpDown)).EndInit();
            this.YnvFlagsGroupBox.ResumeLayout(false);
            this.YnvFlagsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox YnvAABBSizeTextBox;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.NumericUpDown YnvAreaIDYUpDown;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.NumericUpDown YnvAreaIDXUpDown;
        private System.Windows.Forms.Label YnvAreaIDInfoLabel;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label YnvVertexCountLabel;
        private System.Windows.Forms.Label YnvPolyCountLabel;
        private System.Windows.Forms.Label YnvPortalCountLabel;
        private System.Windows.Forms.Label YnvPortalLinkCountLabel;
        private System.Windows.Forms.Label YnvPointCountLabel;
        private System.Windows.Forms.Label YnvByteCountLabel;
        private System.Windows.Forms.GroupBox YnvFlagsGroupBox;
        private System.Windows.Forms.CheckBox YnvFlagsUnknown8CheckBox;
        private System.Windows.Forms.CheckBox YnvFlagsVehicleCheckBox;
        private System.Windows.Forms.CheckBox YnvFlagsPortalsCheckBox;
        private System.Windows.Forms.CheckBox YnvFlagsPolygonsCheckBox;
        private System.Windows.Forms.TextBox YnvVersionUnkHashTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label78;
        private WinForms.TextBoxFix YnvAdjAreaIDsTextBox;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox YnvProjectPathTextBox;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox YnvRpfPathTextBox;
        private System.Windows.Forms.CheckBox YnvFlagsUnknown16CheckBox;
    }
}