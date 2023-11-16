namespace CodeWalker.Tools
{
    partial class JenkGenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JenkGenForm));
            this.HashHexTextBox = new System.Windows.Forms.TextBox();
            this.HashUnsignedTextBox = new System.Windows.Forms.TextBox();
            this.UTF8RadioButton = new System.Windows.Forms.RadioButton();
            this.ASCIIRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.HashSignedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HashHexTextBox
            // 
            this.HashHexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HashHexTextBox.Location = new System.Drawing.Point(589, 30);
            this.HashHexTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HashHexTextBox.Multiline = true;
            this.HashHexTextBox.Name = "HashHexTextBox";
            this.HashHexTextBox.ReadOnly = true;
            this.HashHexTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HashHexTextBox.Size = new System.Drawing.Size(145, 368);
            this.HashHexTextBox.TabIndex = 15;
            // 
            // HashUnsignedTextBox
            // 
            this.HashUnsignedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HashUnsignedTextBox.Location = new System.Drawing.Point(436, 29);
            this.HashUnsignedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HashUnsignedTextBox.Multiline = true;
            this.HashUnsignedTextBox.Name = "HashUnsignedTextBox";
            this.HashUnsignedTextBox.ReadOnly = true;
            this.HashUnsignedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HashUnsignedTextBox.Size = new System.Drawing.Size(145, 368);
            this.HashUnsignedTextBox.TabIndex = 14;
            // 
            // UTF8RadioButton
            // 
            this.UTF8RadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UTF8RadioButton.AutoSize = true;
            this.UTF8RadioButton.Checked = true;
            this.UTF8RadioButton.Location = new System.Drawing.Point(147, 7);
            this.UTF8RadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UTF8RadioButton.Name = "UTF8RadioButton";
            this.UTF8RadioButton.Size = new System.Drawing.Size(60, 21);
            this.UTF8RadioButton.TabIndex = 13;
            this.UTF8RadioButton.TabStop = true;
            this.UTF8RadioButton.Text = "UTF-8";
            this.UTF8RadioButton.UseVisualStyleBackColor = true;
            // 
            // ASCIIRadioButton
            // 
            this.ASCIIRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ASCIIRadioButton.AutoSize = true;
            this.ASCIIRadioButton.Location = new System.Drawing.Point(217, 7);
            this.ASCIIRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ASCIIRadioButton.Name = "ASCIIRadioButton";
            this.ASCIIRadioButton.Size = new System.Drawing.Size(57, 21);
            this.ASCIIRadioButton.TabIndex = 12;
            this.ASCIIRadioButton.Text = "ASCII";
            this.ASCIIRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "哈希（整数）：";
            // 
            // HashSignedTextBox
            // 
            this.HashSignedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HashSignedTextBox.Location = new System.Drawing.Point(283, 29);
            this.HashSignedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HashSignedTextBox.Multiline = true;
            this.HashSignedTextBox.Name = "HashSignedTextBox";
            this.HashSignedTextBox.ReadOnly = true;
            this.HashSignedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HashSignedTextBox.Size = new System.Drawing.Size(145, 368);
            this.HashSignedTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "输入文本内容：";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InputTextBox.Location = new System.Drawing.Point(13, 29);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputTextBox.Size = new System.Drawing.Size(261, 368);
            this.InputTextBox.TabIndex = 8;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "哈希（无符号整数）：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "哈希（十六进制）：";
            // 
            // JenkGenForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(744, 406);
            this.Controls.Add(this.HashHexTextBox);
            this.Controls.Add(this.HashUnsignedTextBox);
            this.Controls.Add(this.UTF8RadioButton);
            this.Controls.Add(this.ASCIIRadioButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HashSignedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTextBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 800);
            this.MinimumSize = new System.Drawing.Size(760, 440);
            this.Name = "JenkGenForm";
            this.Text = "哈希生成器 - CodeWalker by dexyfex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HashHexTextBox;
        private System.Windows.Forms.TextBox HashUnsignedTextBox;
        private System.Windows.Forms.RadioButton UTF8RadioButton;
        private System.Windows.Forms.RadioButton ASCIIRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HashSignedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}