namespace CodeWalker.Tools
{
    partial class ExtractKeysForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractKeysForm));
            this.BeginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderBrowseButton = new System.Windows.Forms.Button();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExeBrowseButton = new System.Windows.Forms.Button();
            this.ExeTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BeginButton
            // 
            this.BeginButton.Location = new System.Drawing.Point(114, 98);
            this.BeginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(88, 30);
            this.BeginButton.TabIndex = 60;
            this.BeginButton.Text = "开始";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "GTAV 目录：";
            // 
            // FolderBrowseButton
            // 
            this.FolderBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderBrowseButton.Location = new System.Drawing.Point(521, 30);
            this.FolderBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderBrowseButton.Name = "FolderBrowseButton";
            this.FolderBrowseButton.Size = new System.Drawing.Size(31, 30);
            this.FolderBrowseButton.TabIndex = 58;
            this.FolderBrowseButton.Text = "...";
            this.FolderBrowseButton.UseVisualStyleBackColor = true;
            this.FolderBrowseButton.Click += new System.EventHandler(this.FolderBrowseButton_Click);
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderTextBox.Location = new System.Drawing.Point(114, 33);
            this.FolderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.ReadOnly = true;
            this.FolderTextBox.Size = new System.Drawing.Size(399, 23);
            this.FolderTextBox.TabIndex = 57;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoEllipsis = true;
            this.StatusLabel.Location = new System.Drawing.Point(23, 141);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(554, 85);
            this.StatusLabel.TabIndex = 61;
            this.StatusLabel.Text = "秘钥未加载 - 选择 GTAV 安装目录然后点击开始按钮";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "GTAV exe:";
            // 
            // ExeBrowseButton
            // 
            this.ExeBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExeBrowseButton.Location = new System.Drawing.Point(521, 64);
            this.ExeBrowseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExeBrowseButton.Name = "ExeBrowseButton";
            this.ExeBrowseButton.Size = new System.Drawing.Size(31, 30);
            this.ExeBrowseButton.TabIndex = 63;
            this.ExeBrowseButton.Text = "...";
            this.ExeBrowseButton.UseVisualStyleBackColor = true;
            this.ExeBrowseButton.Click += new System.EventHandler(this.ExeBrowseButton_Click);
            // 
            // ExeTextBox
            // 
            this.ExeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExeTextBox.Location = new System.Drawing.Point(114, 67);
            this.ExeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExeTextBox.Name = "ExeTextBox";
            this.ExeTextBox.Size = new System.Drawing.Size(399, 23);
            this.ExeTextBox.TabIndex = 62;
            // 
            // ExtractKeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExeBrowseButton);
            this.Controls.Add(this.ExeTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.BeginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderBrowseButton);
            this.Controls.Add(this.FolderTextBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExtractKeysForm";
            this.Text = "ExtractKeysForm";
            this.Load += new System.EventHandler(this.ExtractKeysForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FolderBrowseButton;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExeBrowseButton;
        private System.Windows.Forms.TextBox ExeTextBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}