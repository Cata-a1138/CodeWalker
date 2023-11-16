namespace CodeWalker.Project.Panels
{
    partial class EditYnvPortalPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYnvPortalPanel));
            this.AngleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.DeletePortalButton = new System.Windows.Forms.Button();
            this.AddToProjectButton = new System.Windows.Forms.Button();
            this.GoToButton = new System.Windows.Forms.Button();
            this.PositionFromTextBox = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.PositionToTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AreaIDFromUpDown = new System.Windows.Forms.NumericUpDown();
            this.label92 = new System.Windows.Forms.Label();
            this.AreaIDToUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.PolyIDTo1UpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.PolyIDFrom1UpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.PolyIDTo2UpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.PolyIDFrom2UpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Unk2UpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Unk1UpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AngleUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaIDFromUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaIDToUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolyIDTo1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolyIDFrom1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolyIDTo2UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolyIDFrom2UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unk2UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unk1UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AngleUpDown
            // 
            this.AngleUpDown.Location = new System.Drawing.Point(112, 78);
            this.AngleUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AngleUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AngleUpDown.Name = "AngleUpDown";
            this.AngleUpDown.Size = new System.Drawing.Size(108, 23);
            this.AngleUpDown.TabIndex = 13;
            this.AngleUpDown.ValueChanged += new System.EventHandler(this.AngleUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "旋转：";
            // 
            // TypeUpDown
            // 
            this.TypeUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeUpDown.Location = new System.Drawing.Point(327, 78);
            this.TypeUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TypeUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.TypeUpDown.Name = "TypeUpDown";
            this.TypeUpDown.Size = new System.Drawing.Size(109, 23);
            this.TypeUpDown.TabIndex = 15;
            this.TypeUpDown.ValueChanged += new System.EventHandler(this.TypeUpDown_ValueChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(283, 80);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(44, 17);
            this.label49.TabIndex = 14;
            this.label49.Text = "类型：";
            // 
            // DeletePortalButton
            // 
            this.DeletePortalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePortalButton.Enabled = false;
            this.DeletePortalButton.Location = new System.Drawing.Point(331, 233);
            this.DeletePortalButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeletePortalButton.Name = "DeletePortalButton";
            this.DeletePortalButton.Size = new System.Drawing.Size(105, 30);
            this.DeletePortalButton.TabIndex = 17;
            this.DeletePortalButton.Text = "删除门户";
            this.DeletePortalButton.UseVisualStyleBackColor = true;
            this.DeletePortalButton.Click += new System.EventHandler(this.DeletePortalButton_Click);
            // 
            // AddToProjectButton
            // 
            this.AddToProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToProjectButton.Enabled = false;
            this.AddToProjectButton.Location = new System.Drawing.Point(219, 233);
            this.AddToProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddToProjectButton.Name = "AddToProjectButton";
            this.AddToProjectButton.Size = new System.Drawing.Size(105, 30);
            this.AddToProjectButton.TabIndex = 16;
            this.AddToProjectButton.Text = "添加到项目";
            this.AddToProjectButton.UseVisualStyleBackColor = true;
            this.AddToProjectButton.Click += new System.EventHandler(this.AddToProjectButton_Click);
            // 
            // GoToButton
            // 
            this.GoToButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToButton.Location = new System.Drawing.Point(357, 12);
            this.GoToButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoToButton.Name = "GoToButton";
            this.GoToButton.Size = new System.Drawing.Size(79, 30);
            this.GoToButton.TabIndex = 11;
            this.GoToButton.Text = "传送";
            this.GoToButton.UseVisualStyleBackColor = true;
            this.GoToButton.Click += new System.EventHandler(this.GoToButton_Click);
            // 
            // PositionFromTextBox
            // 
            this.PositionFromTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionFromTextBox.Location = new System.Drawing.Point(112, 16);
            this.PositionFromTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PositionFromTextBox.Name = "PositionFromTextBox";
            this.PositionFromTextBox.Size = new System.Drawing.Size(237, 23);
            this.PositionFromTextBox.TabIndex = 10;
            this.PositionFromTextBox.TextChanged += new System.EventHandler(this.PositionFromTextBox_TextChanged);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(41, 19);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(68, 17);
            this.label55.TabIndex = 9;
            this.label55.Text = "起始位置：";
            // 
            // PositionToTextBox
            // 
            this.PositionToTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionToTextBox.Location = new System.Drawing.Point(112, 47);
            this.PositionToTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PositionToTextBox.Name = "PositionToTextBox";
            this.PositionToTextBox.Size = new System.Drawing.Size(324, 23);
            this.PositionToTextBox.TabIndex = 19;
            this.PositionToTextBox.TextChanged += new System.EventHandler(this.PositionToTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "结束位置：";
            // 
            // AreaIDFromUpDown
            // 
            this.AreaIDFromUpDown.Location = new System.Drawing.Point(112, 109);
            this.AreaIDFromUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AreaIDFromUpDown.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.AreaIDFromUpDown.Name = "AreaIDFromUpDown";
            this.AreaIDFromUpDown.Size = new System.Drawing.Size(108, 23);
            this.AreaIDFromUpDown.TabIndex = 21;
            this.AreaIDFromUpDown.ValueChanged += new System.EventHandler(this.AreaIDFromUpDown_ValueChanged);
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(36, 111);
            this.label92.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(73, 17);
            this.label92.TabIndex = 20;
            this.label92.Text = "从区域 ID：";
            // 
            // AreaIDToUpDown
            // 
            this.AreaIDToUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaIDToUpDown.Location = new System.Drawing.Point(327, 109);
            this.AreaIDToUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AreaIDToUpDown.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.AreaIDToUpDown.Name = "AreaIDToUpDown";
            this.AreaIDToUpDown.Size = new System.Drawing.Size(109, 23);
            this.AreaIDToUpDown.TabIndex = 23;
            this.AreaIDToUpDown.ValueChanged += new System.EventHandler(this.AreaIDToUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "到区域 ID：";
            // 
            // PolyIDTo1UpDown
            // 
            this.PolyIDTo1UpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PolyIDTo1UpDown.Location = new System.Drawing.Point(327, 140);
            this.PolyIDTo1UpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PolyIDTo1UpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PolyIDTo1UpDown.Name = "PolyIDTo1UpDown";
            this.PolyIDTo1UpDown.Size = new System.Drawing.Size(109, 23);
            this.PolyIDTo1UpDown.TabIndex = 27;
            this.PolyIDTo1UpDown.ValueChanged += new System.EventHandler(this.PolyIDTo1UpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "到多边形 ID 1：";
            // 
            // PolyIDFrom1UpDown
            // 
            this.PolyIDFrom1UpDown.Location = new System.Drawing.Point(112, 140);
            this.PolyIDFrom1UpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PolyIDFrom1UpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PolyIDFrom1UpDown.Name = "PolyIDFrom1UpDown";
            this.PolyIDFrom1UpDown.Size = new System.Drawing.Size(108, 23);
            this.PolyIDFrom1UpDown.TabIndex = 25;
            this.PolyIDFrom1UpDown.ValueChanged += new System.EventHandler(this.PolyIDFrom1UpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "从多边形 ID 1：";
            // 
            // PolyIDTo2UpDown
            // 
            this.PolyIDTo2UpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PolyIDTo2UpDown.Location = new System.Drawing.Point(327, 171);
            this.PolyIDTo2UpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PolyIDTo2UpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PolyIDTo2UpDown.Name = "PolyIDTo2UpDown";
            this.PolyIDTo2UpDown.Size = new System.Drawing.Size(109, 23);
            this.PolyIDTo2UpDown.TabIndex = 31;
            this.PolyIDTo2UpDown.ValueChanged += new System.EventHandler(this.PolyIDTo2UpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "到多边形 ID 2：";
            // 
            // PolyIDFrom2UpDown
            // 
            this.PolyIDFrom2UpDown.Location = new System.Drawing.Point(112, 171);
            this.PolyIDFrom2UpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PolyIDFrom2UpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PolyIDFrom2UpDown.Name = "PolyIDFrom2UpDown";
            this.PolyIDFrom2UpDown.Size = new System.Drawing.Size(108, 23);
            this.PolyIDFrom2UpDown.TabIndex = 29;
            this.PolyIDFrom2UpDown.ValueChanged += new System.EventHandler(this.PolyIDFrom2UpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "从多边形 ID 2：";
            // 
            // Unk2UpDown
            // 
            this.Unk2UpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Unk2UpDown.Location = new System.Drawing.Point(327, 202);
            this.Unk2UpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Unk2UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Unk2UpDown.Name = "Unk2UpDown";
            this.Unk2UpDown.Size = new System.Drawing.Size(109, 23);
            this.Unk2UpDown.TabIndex = 35;
            this.Unk2UpDown.ValueChanged += new System.EventHandler(this.Unk2UpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 204);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Unk 2：";
            // 
            // Unk1UpDown
            // 
            this.Unk1UpDown.Location = new System.Drawing.Point(112, 202);
            this.Unk1UpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Unk1UpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Unk1UpDown.Name = "Unk1UpDown";
            this.Unk1UpDown.Size = new System.Drawing.Size(108, 23);
            this.Unk1UpDown.TabIndex = 33;
            this.Unk1UpDown.ValueChanged += new System.EventHandler(this.Unk1UpDown_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Unk 1：";
            // 
            // EditYnvPortalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 276);
            this.Controls.Add(this.Unk2UpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Unk1UpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PolyIDTo2UpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PolyIDFrom2UpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PolyIDTo1UpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PolyIDFrom1UpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AreaIDToUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AreaIDFromUpDown);
            this.Controls.Add(this.label92);
            this.Controls.Add(this.PositionToTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AngleUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeUpDown);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.DeletePortalButton);
            this.Controls.Add(this.AddToProjectButton);
            this.Controls.Add(this.GoToButton);
            this.Controls.Add(this.PositionFromTextBox);
            this.Controls.Add(this.label55);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditYnvPortalPanel";
            this.Text = "编辑 Ynv 门户";
            ((System.ComponentModel.ISupportInitialize)(this.AngleUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaIDFromUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaIDToUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolyIDTo1UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolyIDFrom1UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolyIDTo2UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolyIDFrom2UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unk2UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Unk1UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown AngleUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TypeUpDown;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button DeletePortalButton;
        private System.Windows.Forms.Button AddToProjectButton;
        private System.Windows.Forms.Button GoToButton;
        private System.Windows.Forms.TextBox PositionFromTextBox;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox PositionToTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AreaIDFromUpDown;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.NumericUpDown AreaIDToUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PolyIDTo1UpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PolyIDFrom1UpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PolyIDTo2UpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PolyIDFrom2UpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Unk2UpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Unk1UpDown;
        private System.Windows.Forms.Label label9;
    }
}