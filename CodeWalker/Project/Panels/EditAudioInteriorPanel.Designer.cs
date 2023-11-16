namespace CodeWalker.Project.Panels
{
    partial class EditAudioInteriorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAudioInteriorPanel));
            this.label12 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.HashesTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.TunnelTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.WallaTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.FlagsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "名称哈希：";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(126, 16);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(454, 23);
            this.NameTextBox.TabIndex = 8;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(50, 145);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 17);
            this.label19.TabIndex = 15;
            this.label19.Text = "房间哈希：";
            // 
            // HashesTextBox
            // 
            this.HashesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HashesTextBox.Location = new System.Drawing.Point(126, 142);
            this.HashesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HashesTextBox.Multiline = true;
            this.HashesTextBox.Name = "HashesTextBox";
            this.HashesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HashesTextBox.Size = new System.Drawing.Size(454, 288);
            this.HashesTextBox.TabIndex = 16;
            this.HashesTextBox.WordWrap = false;
            this.HashesTextBox.TextChanged += new System.EventHandler(this.HashesTextBox_TextChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(472, 72);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(108, 30);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "删除室内";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(74, 113);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 17);
            this.label21.TabIndex = 13;
            this.label21.Text = "隧道：";
            // 
            // TunnelTextBox
            // 
            this.TunnelTextBox.Location = new System.Drawing.Point(126, 110);
            this.TunnelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TunnelTextBox.Name = "TunnelTextBox";
            this.TunnelTextBox.Size = new System.Drawing.Size(180, 23);
            this.TunnelTextBox.TabIndex = 14;
            this.TunnelTextBox.TextChanged += new System.EventHandler(this.TunnelTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 81);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "背景音：";
            // 
            // WallaTextBox
            // 
            this.WallaTextBox.Location = new System.Drawing.Point(126, 78);
            this.WallaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WallaTextBox.Name = "WallaTextBox";
            this.WallaTextBox.Size = new System.Drawing.Size(180, 23);
            this.WallaTextBox.TabIndex = 12;
            this.WallaTextBox.TextChanged += new System.EventHandler(this.WallaTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Flags：";
            // 
            // FlagsTextBox
            // 
            this.FlagsTextBox.Location = new System.Drawing.Point(126, 47);
            this.FlagsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlagsTextBox.Name = "FlagsTextBox";
            this.FlagsTextBox.Size = new System.Drawing.Size(180, 23);
            this.FlagsTextBox.TabIndex = 10;
            this.FlagsTextBox.TextChanged += new System.EventHandler(this.FlagsTextBox_TextChanged);
            // 
            // EditAudioInteriorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 446);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.TunnelTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.WallaTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.FlagsTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.HashesTextBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditAudioInteriorPanel";
            this.Text = "EditAudioInteriorPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label19;
        private WinForms.TextBoxFix HashesTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TunnelTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox WallaTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox FlagsTextBox;
    }
}