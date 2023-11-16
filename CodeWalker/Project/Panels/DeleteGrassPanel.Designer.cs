namespace CodeWalker.Project.Panels
{
    partial class DeleteGrassPanel
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
            this.brushModeGroupBox = new System.Windows.Forms.GroupBox();
            this.brushDeleteProjectRadio = new System.Windows.Forms.RadioButton();
            this.brushDeleteBatchRadio = new System.Windows.Forms.RadioButton();
            this.brushDeleteAnyRadio = new System.Windows.Forms.RadioButton();
            this.brushDeleteYmapRadio = new System.Windows.Forms.RadioButton();
            this.brushDisabledRadio = new System.Windows.Forms.RadioButton();
            this.brushSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.RadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentYmapTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.brushModeGroupBox.SuspendLayout();
            this.brushSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // brushModeGroupBox
            // 
            this.brushModeGroupBox.Controls.Add(this.brushDeleteProjectRadio);
            this.brushModeGroupBox.Controls.Add(this.brushDeleteBatchRadio);
            this.brushModeGroupBox.Controls.Add(this.brushDeleteAnyRadio);
            this.brushModeGroupBox.Controls.Add(this.brushDeleteYmapRadio);
            this.brushModeGroupBox.Controls.Add(this.brushDisabledRadio);
            this.brushModeGroupBox.Location = new System.Drawing.Point(14, 16);
            this.brushModeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.brushModeGroupBox.Name = "brushModeGroupBox";
            this.brushModeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.brushModeGroupBox.Size = new System.Drawing.Size(218, 180);
            this.brushModeGroupBox.TabIndex = 70;
            this.brushModeGroupBox.TabStop = false;
            this.brushModeGroupBox.Text = "删除实例草笔刷模式";
            // 
            // brushDeleteProjectRadio
            // 
            this.brushDeleteProjectRadio.AutoSize = true;
            this.brushDeleteProjectRadio.Location = new System.Drawing.Point(19, 113);
            this.brushDeleteProjectRadio.Margin = new System.Windows.Forms.Padding(4);
            this.brushDeleteProjectRadio.Name = "brushDeleteProjectRadio";
            this.brushDeleteProjectRadio.Size = new System.Drawing.Size(175, 21);
            this.brushDeleteProjectRadio.TabIndex = 6;
            this.brushDeleteProjectRadio.Text = "从所有项目的 Ymap 中删除";
            this.brushDeleteProjectRadio.UseVisualStyleBackColor = true;
            // 
            // brushDeleteBatchRadio
            // 
            this.brushDeleteBatchRadio.AutoSize = true;
            this.brushDeleteBatchRadio.Location = new System.Drawing.Point(19, 57);
            this.brushDeleteBatchRadio.Margin = new System.Windows.Forms.Padding(4);
            this.brushDeleteBatchRadio.Name = "brushDeleteBatchRadio";
            this.brushDeleteBatchRadio.Size = new System.Drawing.Size(122, 21);
            this.brushDeleteBatchRadio.TabIndex = 5;
            this.brushDeleteBatchRadio.Text = "从该实例组中删除";
            this.brushDeleteBatchRadio.UseVisualStyleBackColor = true;
            // 
            // brushDeleteAnyRadio
            // 
            this.brushDeleteAnyRadio.AutoSize = true;
            this.brushDeleteAnyRadio.Location = new System.Drawing.Point(19, 143);
            this.brushDeleteAnyRadio.Margin = new System.Windows.Forms.Padding(4);
            this.brushDeleteAnyRadio.Name = "brushDeleteAnyRadio";
            this.brushDeleteAnyRadio.Size = new System.Drawing.Size(139, 21);
            this.brushDeleteAnyRadio.TabIndex = 4;
            this.brushDeleteAnyRadio.Text = "从所有 Ymap 中删除";
            this.brushDeleteAnyRadio.UseVisualStyleBackColor = true;
            // 
            // brushDeleteYmapRadio
            // 
            this.brushDeleteYmapRadio.AutoSize = true;
            this.brushDeleteYmapRadio.Location = new System.Drawing.Point(19, 85);
            this.brushDeleteYmapRadio.Margin = new System.Windows.Forms.Padding(4);
            this.brushDeleteYmapRadio.Name = "brushDeleteYmapRadio";
            this.brushDeleteYmapRadio.Size = new System.Drawing.Size(127, 21);
            this.brushDeleteYmapRadio.TabIndex = 3;
            this.brushDeleteYmapRadio.Text = "从该 Ymap 中删除";
            this.brushDeleteYmapRadio.UseVisualStyleBackColor = true;
            // 
            // brushDisabledRadio
            // 
            this.brushDisabledRadio.AutoSize = true;
            this.brushDisabledRadio.Checked = true;
            this.brushDisabledRadio.Location = new System.Drawing.Point(19, 27);
            this.brushDisabledRadio.Margin = new System.Windows.Forms.Padding(4);
            this.brushDisabledRadio.Name = "brushDisabledRadio";
            this.brushDisabledRadio.Size = new System.Drawing.Size(50, 21);
            this.brushDisabledRadio.TabIndex = 0;
            this.brushDisabledRadio.TabStop = true;
            this.brushDisabledRadio.Text = "&禁用";
            this.brushDisabledRadio.UseVisualStyleBackColor = true;
            // 
            // brushSettingsGroupBox
            // 
            this.brushSettingsGroupBox.Controls.Add(this.RadiusNumericUpDown);
            this.brushSettingsGroupBox.Controls.Add(this.radiusLabel);
            this.brushSettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushSettingsGroupBox.Location = new System.Drawing.Point(258, 17);
            this.brushSettingsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.brushSettingsGroupBox.Name = "brushSettingsGroupBox";
            this.brushSettingsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.brushSettingsGroupBox.Size = new System.Drawing.Size(163, 76);
            this.brushSettingsGroupBox.TabIndex = 71;
            this.brushSettingsGroupBox.TabStop = false;
            this.brushSettingsGroupBox.Text = "删除笔刷设置";
            // 
            // RadiusNumericUpDown
            // 
            this.RadiusNumericUpDown.DecimalPlaces = 1;
            this.RadiusNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.RadiusNumericUpDown.Location = new System.Drawing.Point(61, 37);
            this.RadiusNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.RadiusNumericUpDown.Name = "RadiusNumericUpDown";
            this.RadiusNumericUpDown.Size = new System.Drawing.Size(76, 23);
            this.RadiusNumericUpDown.TabIndex = 11;
            this.RadiusNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(7, 40);
            this.radiusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(32, 17);
            this.radiusLabel.TabIndex = 10;
            this.radiusLabel.Text = "范围";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 51);
            this.label1.TabIndex = 72;
            this.label1.Text = "按住 CTRL 来使用删除笔刷。在 “所有 Ymap” 模式下，被删除的实例草所在的 Ymap 文件会自动添加到当前项目中。";
            // 
            // currentYmapTextBox
            // 
            this.currentYmapTextBox.Enabled = false;
            this.currentYmapTextBox.Location = new System.Drawing.Point(258, 154);
            this.currentYmapTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.currentYmapTextBox.Name = "currentYmapTextBox";
            this.currentYmapTextBox.ReadOnly = true;
            this.currentYmapTextBox.Size = new System.Drawing.Size(219, 23);
            this.currentYmapTextBox.TabIndex = 73;
            this.currentYmapTextBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "当前 YMAP";
            this.label2.Visible = false;
            // 
            // DeleteGrassPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 265);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentYmapTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brushSettingsGroupBox);
            this.Controls.Add(this.brushModeGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteGrassPanel";
            this.Text = "删除实例草";
            this.brushModeGroupBox.ResumeLayout(false);
            this.brushModeGroupBox.PerformLayout();
            this.brushSettingsGroupBox.ResumeLayout(false);
            this.brushSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox brushModeGroupBox;
        private System.Windows.Forms.RadioButton brushDeleteAnyRadio;
        private System.Windows.Forms.RadioButton brushDeleteYmapRadio;
        private System.Windows.Forms.RadioButton brushDisabledRadio;
        private System.Windows.Forms.GroupBox brushSettingsGroupBox;
        private System.Windows.Forms.NumericUpDown RadiusNumericUpDown;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton brushDeleteBatchRadio;
        private System.Windows.Forms.TextBox currentYmapTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton brushDeleteProjectRadio;
    }
}