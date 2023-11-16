namespace CodeWalker.Tools
{
    partial class JenkIndForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JenkIndForm));
            this.label1 = new System.Windows.Forms.Label();
            this.HashTextBox = new System.Windows.Forms.TextBox();
            this.HexRadioButton = new System.Windows.Forms.RadioButton();
            this.UnsignedRadioButton = new System.Windows.Forms.RadioButton();
            this.SignedRadioButton = new System.Windows.Forms.RadioButton();
            this.MatchTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SaveStringsButton = new System.Windows.Forms.Button();
            this.LoadStringsButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "哈希：";
            // 
            // HashTextBox
            // 
            this.HashTextBox.Location = new System.Drawing.Point(51, 11);
            this.HashTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HashTextBox.Name = "HashTextBox";
            this.HashTextBox.Size = new System.Drawing.Size(156, 23);
            this.HashTextBox.TabIndex = 1;
            this.HashTextBox.TextChanged += new System.EventHandler(this.HashTextBox_TextChanged);
            // 
            // HexRadioButton
            // 
            this.HexRadioButton.AutoSize = true;
            this.HexRadioButton.Checked = true;
            this.HexRadioButton.Location = new System.Drawing.Point(215, 13);
            this.HexRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HexRadioButton.Name = "HexRadioButton";
            this.HexRadioButton.Size = new System.Drawing.Size(48, 21);
            this.HexRadioButton.TabIndex = 2;
            this.HexRadioButton.TabStop = true;
            this.HexRadioButton.Text = "Hex";
            this.HexRadioButton.UseVisualStyleBackColor = true;
            this.HexRadioButton.CheckedChanged += new System.EventHandler(this.HexRadioButton_CheckedChanged);
            // 
            // UnsignedRadioButton
            // 
            this.UnsignedRadioButton.AutoSize = true;
            this.UnsignedRadioButton.Location = new System.Drawing.Point(273, 13);
            this.UnsignedRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UnsignedRadioButton.Name = "UnsignedRadioButton";
            this.UnsignedRadioButton.Size = new System.Drawing.Size(81, 21);
            this.UnsignedRadioButton.TabIndex = 3;
            this.UnsignedRadioButton.Text = "Unsigned";
            this.UnsignedRadioButton.UseVisualStyleBackColor = true;
            this.UnsignedRadioButton.CheckedChanged += new System.EventHandler(this.UnsignedRadioButton_CheckedChanged);
            // 
            // SignedRadioButton
            // 
            this.SignedRadioButton.AutoSize = true;
            this.SignedRadioButton.Location = new System.Drawing.Point(362, 13);
            this.SignedRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignedRadioButton.Name = "SignedRadioButton";
            this.SignedRadioButton.Size = new System.Drawing.Size(66, 21);
            this.SignedRadioButton.TabIndex = 4;
            this.SignedRadioButton.Text = "Signed";
            this.SignedRadioButton.UseVisualStyleBackColor = true;
            this.SignedRadioButton.CheckedChanged += new System.EventHandler(this.SignedRadioButton_CheckedChanged);
            // 
            // MatchTextBox
            // 
            this.MatchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchTextBox.Location = new System.Drawing.Point(51, 75);
            this.MatchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MatchTextBox.Multiline = true;
            this.MatchTextBox.Name = "MatchTextBox";
            this.MatchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MatchTextBox.Size = new System.Drawing.Size(608, 174);
            this.MatchTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "文本：";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(48, 42);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(13, 17);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "-";
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.SaveStringsButton);
            this.MainPanel.Controls.Add(this.LoadStringsButton);
            this.MainPanel.Controls.Add(this.HashTextBox);
            this.MainPanel.Controls.Add(this.StatusLabel);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.HexRadioButton);
            this.MainPanel.Controls.Add(this.MatchTextBox);
            this.MainPanel.Controls.Add(this.UnsignedRadioButton);
            this.MainPanel.Controls.Add(this.SignedRadioButton);
            this.MainPanel.Location = new System.Drawing.Point(14, 16);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(666, 262);
            this.MainPanel.TabIndex = 8;
            // 
            // SaveStringsButton
            // 
            this.SaveStringsButton.Location = new System.Drawing.Point(561, 8);
            this.SaveStringsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveStringsButton.Name = "SaveStringsButton";
            this.SaveStringsButton.Size = new System.Drawing.Size(98, 30);
            this.SaveStringsButton.TabIndex = 9;
            this.SaveStringsButton.Text = "保存字符串";
            this.SaveStringsButton.UseVisualStyleBackColor = true;
            this.SaveStringsButton.Click += new System.EventHandler(this.SaveStringsButton_Click);
            // 
            // LoadStringsButton
            // 
            this.LoadStringsButton.Location = new System.Drawing.Point(456, 8);
            this.LoadStringsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadStringsButton.Name = "LoadStringsButton";
            this.LoadStringsButton.Size = new System.Drawing.Size(98, 30);
            this.LoadStringsButton.TabIndex = 8;
            this.LoadStringsButton.Text = "加载字符串";
            this.LoadStringsButton.UseVisualStyleBackColor = true;
            this.LoadStringsButton.Click += new System.EventHandler(this.LoadStringsButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "Text files|*.txt|All files|*.*";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Text files|*.txt|All files|*.*";
            // 
            // JenkIndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 293);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JenkIndForm";
            this.Text = "哈希搜索器 - CodeWalker by dexyfex";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HashTextBox;
        private System.Windows.Forms.RadioButton HexRadioButton;
        private System.Windows.Forms.RadioButton UnsignedRadioButton;
        private System.Windows.Forms.RadioButton SignedRadioButton;
        private WinForms.TextBoxFix MatchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button LoadStringsButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button SaveStringsButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}