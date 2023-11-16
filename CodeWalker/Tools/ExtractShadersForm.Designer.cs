namespace CodeWalker.Tools
{
    partial class ExtractShadersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractShadersForm));
            this.AbortButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputFolderBrowseButton = new System.Windows.Forms.Button();
            this.OutputFolderTextBox = new System.Windows.Forms.TextBox();
            this.ExtractStatusLabel = new System.Windows.Forms.Label();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderBrowseButton = new System.Windows.Forms.Button();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.AsmCheckBox = new System.Windows.Forms.CheckBox();
            this.CsoCheckBox = new System.Windows.Forms.CheckBox();
            this.MetaCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AbortButton
            // 
            this.AbortButton.Location = new System.Drawing.Point(351, 121);
            this.AbortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(88, 30);
            this.AbortButton.TabIndex = 72;
            this.AbortButton.Text = "取消";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "输出目录：";
            // 
            // OutputFolderBrowseButton
            // 
            this.OutputFolderBrowseButton.Location = new System.Drawing.Point(408, 47);
            this.OutputFolderBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputFolderBrowseButton.Name = "OutputFolderBrowseButton";
            this.OutputFolderBrowseButton.Size = new System.Drawing.Size(31, 30);
            this.OutputFolderBrowseButton.TabIndex = 70;
            this.OutputFolderBrowseButton.Text = "...";
            this.OutputFolderBrowseButton.UseVisualStyleBackColor = true;
            this.OutputFolderBrowseButton.Click += new System.EventHandler(this.OutputFolderBrowseButton_Click);
            // 
            // OutputFolderTextBox
            // 
            this.OutputFolderTextBox.Location = new System.Drawing.Point(108, 50);
            this.OutputFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputFolderTextBox.Name = "OutputFolderTextBox";
            this.OutputFolderTextBox.Size = new System.Drawing.Size(292, 23);
            this.OutputFolderTextBox.TabIndex = 69;
            this.OutputFolderTextBox.TextChanged += new System.EventHandler(this.OutputFolderTextBox_TextChanged);
            // 
            // ExtractStatusLabel
            // 
            this.ExtractStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtractStatusLabel.AutoEllipsis = true;
            this.ExtractStatusLabel.Location = new System.Drawing.Point(18, 155);
            this.ExtractStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExtractStatusLabel.Name = "ExtractStatusLabel";
            this.ExtractStatusLabel.Size = new System.Drawing.Size(421, 63);
            this.ExtractStatusLabel.TabIndex = 68;
            this.ExtractStatusLabel.Text = "初始化中...";
            // 
            // ExtractButton
            // 
            this.ExtractButton.Location = new System.Drawing.Point(240, 121);
            this.ExtractButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(88, 30);
            this.ExtractButton.TabIndex = 67;
            this.ExtractButton.Text = "导出";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "GTAV 目录：";
            // 
            // FolderBrowseButton
            // 
            this.FolderBrowseButton.Location = new System.Drawing.Point(408, 13);
            this.FolderBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderBrowseButton.Name = "FolderBrowseButton";
            this.FolderBrowseButton.Size = new System.Drawing.Size(31, 30);
            this.FolderBrowseButton.TabIndex = 65;
            this.FolderBrowseButton.Text = "...";
            this.FolderBrowseButton.UseVisualStyleBackColor = true;
            this.FolderBrowseButton.Click += new System.EventHandler(this.FolderBrowseButton_Click);
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(108, 16);
            this.FolderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.ReadOnly = true;
            this.FolderTextBox.Size = new System.Drawing.Size(292, 23);
            this.FolderTextBox.TabIndex = 64;
            this.FolderTextBox.TextChanged += new System.EventHandler(this.FolderTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "输出：";
            // 
            // AsmCheckBox
            // 
            this.AsmCheckBox.AutoSize = true;
            this.AsmCheckBox.Checked = true;
            this.AsmCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AsmCheckBox.Location = new System.Drawing.Point(166, 92);
            this.AsmCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AsmCheckBox.Name = "AsmCheckBox";
            this.AsmCheckBox.Size = new System.Drawing.Size(74, 21);
            this.AsmCheckBox.TabIndex = 74;
            this.AsmCheckBox.Text = "hlsl asm";
            this.AsmCheckBox.UseVisualStyleBackColor = true;
            // 
            // CsoCheckBox
            // 
            this.CsoCheckBox.AutoSize = true;
            this.CsoCheckBox.Location = new System.Drawing.Point(108, 92);
            this.CsoCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CsoCheckBox.Name = "CsoCheckBox";
            this.CsoCheckBox.Size = new System.Drawing.Size(47, 21);
            this.CsoCheckBox.TabIndex = 73;
            this.CsoCheckBox.Text = "cso";
            this.CsoCheckBox.UseVisualStyleBackColor = true;
            // 
            // MetaCheckBox
            // 
            this.MetaCheckBox.AutoSize = true;
            this.MetaCheckBox.Checked = true;
            this.MetaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MetaCheckBox.Location = new System.Drawing.Point(246, 92);
            this.MetaCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MetaCheckBox.Name = "MetaCheckBox";
            this.MetaCheckBox.Size = new System.Drawing.Size(56, 21);
            this.MetaCheckBox.TabIndex = 76;
            this.MetaCheckBox.Text = "meta";
            this.MetaCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExtractShadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 227);
            this.Controls.Add(this.MetaCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AsmCheckBox);
            this.Controls.Add(this.CsoCheckBox);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OutputFolderBrowseButton);
            this.Controls.Add(this.OutputFolderTextBox);
            this.Controls.Add(this.ExtractStatusLabel);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderBrowseButton);
            this.Controls.Add(this.FolderTextBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExtractShadersForm";
            this.Text = "导出着色器 - CodeWalker by dexyfex";
            this.Load += new System.EventHandler(this.ExtractShadersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OutputFolderBrowseButton;
        private System.Windows.Forms.TextBox OutputFolderTextBox;
        private System.Windows.Forms.Label ExtractStatusLabel;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FolderBrowseButton;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AsmCheckBox;
        private System.Windows.Forms.CheckBox CsoCheckBox;
        private System.Windows.Forms.CheckBox MetaCheckBox;
    }
}