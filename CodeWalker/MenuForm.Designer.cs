namespace CodeWalker
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.ExtractScriptsButton = new System.Windows.Forms.Button();
            this.BinarySearchButton = new System.Windows.Forms.Button();
            this.RPFBrowserButton = new System.Windows.Forms.Button();
            this.WorldButton = new System.Windows.Forms.Button();
            this.ExtractTexturesButton = new System.Windows.Forms.Button();
            this.GCCollectButton = new System.Windows.Forms.Button();
            this.ExtractRawFilesButton = new System.Windows.Forms.Button();
            this.ExtractShadersButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.JenkGenButton = new System.Windows.Forms.Button();
            this.ExtractKeysButton = new System.Windows.Forms.Button();
            this.ProjectButton = new System.Windows.Forms.Button();
            this.JenkIndButton = new System.Windows.Forms.Button();
            this.RPFExplorerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExtractScriptsButton
            // 
            this.ExtractScriptsButton.Location = new System.Drawing.Point(14, 54);
            this.ExtractScriptsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExtractScriptsButton.Name = "ExtractScriptsButton";
            this.ExtractScriptsButton.Size = new System.Drawing.Size(126, 30);
            this.ExtractScriptsButton.TabIndex = 2;
            this.ExtractScriptsButton.Text = "导出脚本...";
            this.ExtractScriptsButton.UseVisualStyleBackColor = true;
            this.ExtractScriptsButton.Click += new System.EventHandler(this.ExtractScriptsButton_Click);
            // 
            // BinarySearchButton
            // 
            this.BinarySearchButton.Location = new System.Drawing.Point(14, 205);
            this.BinarySearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BinarySearchButton.Name = "BinarySearchButton";
            this.BinarySearchButton.Size = new System.Drawing.Size(126, 30);
            this.BinarySearchButton.TabIndex = 6;
            this.BinarySearchButton.Text = "二进制搜索...";
            this.BinarySearchButton.UseVisualStyleBackColor = true;
            this.BinarySearchButton.Click += new System.EventHandler(this.BinarySearchButton_Click);
            // 
            // RPFBrowserButton
            // 
            this.RPFBrowserButton.Location = new System.Drawing.Point(219, 54);
            this.RPFBrowserButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RPFBrowserButton.Name = "RPFBrowserButton";
            this.RPFBrowserButton.Size = new System.Drawing.Size(126, 30);
            this.RPFBrowserButton.TabIndex = 13;
            this.RPFBrowserButton.Text = "RPF 浏览器...";
            this.RPFBrowserButton.UseVisualStyleBackColor = true;
            this.RPFBrowserButton.Click += new System.EventHandler(this.RPFBrowserButton_Click);
            // 
            // WorldButton
            // 
            this.WorldButton.Location = new System.Drawing.Point(14, 244);
            this.WorldButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WorldButton.Name = "WorldButton";
            this.WorldButton.Size = new System.Drawing.Size(126, 30);
            this.WorldButton.TabIndex = 7;
            this.WorldButton.Text = "世界...";
            this.WorldButton.UseVisualStyleBackColor = true;
            this.WorldButton.Click += new System.EventHandler(this.WorldButton_Click);
            // 
            // ExtractTexturesButton
            // 
            this.ExtractTexturesButton.Location = new System.Drawing.Point(14, 92);
            this.ExtractTexturesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExtractTexturesButton.Name = "ExtractTexturesButton";
            this.ExtractTexturesButton.Size = new System.Drawing.Size(126, 30);
            this.ExtractTexturesButton.TabIndex = 3;
            this.ExtractTexturesButton.Text = "导出纹理...";
            this.ExtractTexturesButton.UseVisualStyleBackColor = true;
            this.ExtractTexturesButton.Click += new System.EventHandler(this.ExtractTexturesButton_Click);
            // 
            // GCCollectButton
            // 
            this.GCCollectButton.Location = new System.Drawing.Point(219, 244);
            this.GCCollectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GCCollectButton.Name = "GCCollectButton";
            this.GCCollectButton.Size = new System.Drawing.Size(126, 30);
            this.GCCollectButton.TabIndex = 10;
            this.GCCollectButton.Text = "回收内存";
            this.GCCollectButton.UseVisualStyleBackColor = true;
            this.GCCollectButton.Click += new System.EventHandler(this.GCCollectButton_Click);
            // 
            // ExtractRawFilesButton
            // 
            this.ExtractRawFilesButton.Location = new System.Drawing.Point(14, 129);
            this.ExtractRawFilesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExtractRawFilesButton.Name = "ExtractRawFilesButton";
            this.ExtractRawFilesButton.Size = new System.Drawing.Size(126, 30);
            this.ExtractRawFilesButton.TabIndex = 4;
            this.ExtractRawFilesButton.Text = "导出原始文件...";
            this.ExtractRawFilesButton.UseVisualStyleBackColor = true;
            this.ExtractRawFilesButton.Click += new System.EventHandler(this.ExtractRawFilesButton_Click);
            // 
            // ExtractShadersButton
            // 
            this.ExtractShadersButton.Location = new System.Drawing.Point(14, 167);
            this.ExtractShadersButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExtractShadersButton.Name = "ExtractShadersButton";
            this.ExtractShadersButton.Size = new System.Drawing.Size(126, 30);
            this.ExtractShadersButton.TabIndex = 5;
            this.ExtractShadersButton.Text = "导出着色器...";
            this.ExtractShadersButton.UseVisualStyleBackColor = true;
            this.ExtractShadersButton.Click += new System.EventHandler(this.ExtractShadersButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(219, 280);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(126, 30);
            this.AboutButton.TabIndex = 9;
            this.AboutButton.Text = "关于...";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // JenkGenButton
            // 
            this.JenkGenButton.Location = new System.Drawing.Point(219, 129);
            this.JenkGenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JenkGenButton.Name = "JenkGenButton";
            this.JenkGenButton.Size = new System.Drawing.Size(126, 30);
            this.JenkGenButton.TabIndex = 12;
            this.JenkGenButton.Text = "哈希生成器...";
            this.JenkGenButton.UseVisualStyleBackColor = true;
            this.JenkGenButton.Click += new System.EventHandler(this.JenkGenButton_Click);
            // 
            // ExtractKeysButton
            // 
            this.ExtractKeysButton.Location = new System.Drawing.Point(14, 16);
            this.ExtractKeysButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExtractKeysButton.Name = "ExtractKeysButton";
            this.ExtractKeysButton.Size = new System.Drawing.Size(126, 30);
            this.ExtractKeysButton.TabIndex = 1;
            this.ExtractKeysButton.Text = "导出秘钥...";
            this.ExtractKeysButton.UseVisualStyleBackColor = true;
            this.ExtractKeysButton.Click += new System.EventHandler(this.ExtractKeysButton_Click);
            // 
            // ProjectButton
            // 
            this.ProjectButton.Location = new System.Drawing.Point(14, 280);
            this.ProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectButton.Name = "ProjectButton";
            this.ProjectButton.Size = new System.Drawing.Size(126, 30);
            this.ProjectButton.TabIndex = 8;
            this.ProjectButton.Text = "项目...";
            this.ProjectButton.UseVisualStyleBackColor = true;
            this.ProjectButton.Click += new System.EventHandler(this.ProjectButton_Click);
            // 
            // JenkIndButton
            // 
            this.JenkIndButton.Location = new System.Drawing.Point(219, 167);
            this.JenkIndButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JenkIndButton.Name = "JenkIndButton";
            this.JenkIndButton.Size = new System.Drawing.Size(126, 30);
            this.JenkIndButton.TabIndex = 11;
            this.JenkIndButton.Text = "哈希搜索器...";
            this.JenkIndButton.UseVisualStyleBackColor = true;
            this.JenkIndButton.Click += new System.EventHandler(this.JenkIndButton_Click);
            // 
            // RPFExplorerButton
            // 
            this.RPFExplorerButton.Location = new System.Drawing.Point(219, 16);
            this.RPFExplorerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RPFExplorerButton.Name = "RPFExplorerButton";
            this.RPFExplorerButton.Size = new System.Drawing.Size(126, 30);
            this.RPFExplorerButton.TabIndex = 0;
            this.RPFExplorerButton.Text = "RPF 浏览器...";
            this.RPFExplorerButton.UseVisualStyleBackColor = true;
            this.RPFExplorerButton.Click += new System.EventHandler(this.RPFExplorerButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 327);
            this.Controls.Add(this.RPFExplorerButton);
            this.Controls.Add(this.JenkIndButton);
            this.Controls.Add(this.ProjectButton);
            this.Controls.Add(this.ExtractKeysButton);
            this.Controls.Add(this.JenkGenButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.ExtractShadersButton);
            this.Controls.Add(this.ExtractRawFilesButton);
            this.Controls.Add(this.GCCollectButton);
            this.Controls.Add(this.ExtractTexturesButton);
            this.Controls.Add(this.WorldButton);
            this.Controls.Add(this.RPFBrowserButton);
            this.Controls.Add(this.BinarySearchButton);
            this.Controls.Add(this.ExtractScriptsButton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuForm";
            this.Text = "CodeWalker Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ExtractScriptsButton;
        private System.Windows.Forms.Button BinarySearchButton;
        private System.Windows.Forms.Button RPFBrowserButton;
        private System.Windows.Forms.Button WorldButton;
        private System.Windows.Forms.Button ExtractTexturesButton;
        private System.Windows.Forms.Button GCCollectButton;
        private System.Windows.Forms.Button ExtractRawFilesButton;
        private System.Windows.Forms.Button ExtractShadersButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button JenkGenButton;
        private System.Windows.Forms.Button ExtractKeysButton;
        private System.Windows.Forms.Button ProjectButton;
        private System.Windows.Forms.Button JenkIndButton;
        private System.Windows.Forms.Button RPFExplorerButton;
    }
}

