namespace CodeWalker.Utils
{
    partial class SelectFolderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFolderForm));
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderBrowseButton = new System.Windows.Forms.Button();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CancelButt = new System.Windows.Forms.Button();
            this.RememberFolderCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OkButton.Location = new System.Drawing.Point(479, 60);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 25);
            this.OkButton.TabIndex = 64;
            this.OkButton.Text = "完成";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "请选择您的 GTAV 安装目录：";
            // 
            // FolderBrowseButton
            // 
            this.FolderBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderBrowseButton.Location = new System.Drawing.Point(527, 32);
            this.FolderBrowseButton.Name = "FolderBrowseButton";
            this.FolderBrowseButton.Size = new System.Drawing.Size(27, 21);
            this.FolderBrowseButton.TabIndex = 62;
            this.FolderBrowseButton.Text = "...";
            this.FolderBrowseButton.UseVisualStyleBackColor = true;
            this.FolderBrowseButton.Click += new System.EventHandler(this.FolderBrowseButton_Click);
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderTextBox.Location = new System.Drawing.Point(12, 33);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(505, 21);
            this.FolderTextBox.TabIndex = 61;
            this.FolderTextBox.TextChanged += new System.EventHandler(this.FolderTextBox_TextChanged);
            // 
            // CancelButt
            // 
            this.CancelButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelButt.Location = new System.Drawing.Point(398, 60);
            this.CancelButt.Name = "CancelButt";
            this.CancelButt.Size = new System.Drawing.Size(75, 25);
            this.CancelButt.TabIndex = 65;
            this.CancelButt.Text = "取消";
            this.CancelButt.UseVisualStyleBackColor = true;
            this.CancelButt.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RememberFolderCheckbox
            // 
            this.RememberFolderCheckbox.AutoSize = true;
            this.RememberFolderCheckbox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RememberFolderCheckbox.Location = new System.Drawing.Point(12, 63);
            this.RememberFolderCheckbox.Name = "RememberFolderCheckbox";
            this.RememberFolderCheckbox.Size = new System.Drawing.Size(111, 21);
            this.RememberFolderCheckbox.TabIndex = 66;
            this.RememberFolderCheckbox.Text = "记住该目录位置";
            this.RememberFolderCheckbox.UseVisualStyleBackColor = true;
            this.RememberFolderCheckbox.CheckedChanged += new System.EventHandler(this.RememberFolderCheckbox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 190);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "如何找到安装目录";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(530, 162);
            this.label2.TabIndex = 68;
            this.label2.Text = "Steam 用户\r\n1. 打开 Steam 库，找到 Grand Theft Auto V\r\n2. 在左侧游戏名称上右键 > 管理 > 浏览本地文件\r\n\r\nEpi" +
    "c 用户\r\n1. 打开 Epic 库，找到 Grand Theft Auto V\r\n2. 点击游戏封面右下角的三个 ... 进入详情\r\n3. 点击 “安装” 右" +
    "边的文件夹图标打开";
            // 
            // SelectFolderForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButt;
            this.ClientSize = new System.Drawing.Size(566, 292);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RememberFolderCheckbox);
            this.Controls.Add(this.CancelButt);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderBrowseButton);
            this.Controls.Add(this.FolderTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 143);
            this.Name = "SelectFolderForm";
            this.Text = "选择 GTAV 安装目录 - CodeWalker by dexyfex";
            this.Load += new System.EventHandler(this.SelectFolderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FolderBrowseButton;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button CancelButt;
        private System.Windows.Forms.CheckBox RememberFolderCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}