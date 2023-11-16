
namespace CodeWalker.Project.Panels
{
    partial class EditYmapBoxOccluderPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYmapBoxOccluderPanel));
            this.GoToButton = new System.Windows.Forms.Button();
            this.CenterTextBox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddToProjectButton = new System.Windows.Forms.Button();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SinCosZTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoToButton
            // 
            this.GoToButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToButton.Location = new System.Drawing.Point(533, 6);
            this.GoToButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoToButton.Name = "GoToButton";
            this.GoToButton.Size = new System.Drawing.Size(79, 30);
            this.GoToButton.TabIndex = 87;
            this.GoToButton.Text = "传送";
            this.GoToButton.UseVisualStyleBackColor = true;
            this.GoToButton.Click += new System.EventHandler(this.GoToButton_Click);
            // 
            // CenterTextBox
            // 
            this.CenterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterTextBox.Location = new System.Drawing.Point(96, 10);
            this.CenterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CenterTextBox.Name = "CenterTextBox";
            this.CenterTextBox.Size = new System.Drawing.Size(434, 23);
            this.CenterTextBox.TabIndex = 86;
            this.CenterTextBox.TextChanged += new System.EventHandler(this.CenterTextBox_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(32, 13);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 17);
            this.label31.TabIndex = 85;
            this.label31.Text = "中心点：";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(419, 119);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 30);
            this.DeleteButton.TabIndex = 107;
            this.DeleteButton.Text = "删除立方体";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddToProjectButton
            // 
            this.AddToProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToProjectButton.Location = new System.Drawing.Point(300, 119);
            this.AddToProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddToProjectButton.Name = "AddToProjectButton";
            this.AddToProjectButton.Size = new System.Drawing.Size(111, 30);
            this.AddToProjectButton.TabIndex = 106;
            this.AddToProjectButton.Text = "添加到项目";
            this.AddToProjectButton.UseVisualStyleBackColor = true;
            this.AddToProjectButton.Click += new System.EventHandler(this.AddToProjectButton_Click);
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeTextBox.Location = new System.Drawing.Point(96, 44);
            this.SizeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(434, 23);
            this.SizeTextBox.TabIndex = 109;
            this.SizeTextBox.TextChanged += new System.EventHandler(this.SizeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 108;
            this.label1.Text = "大小：";
            // 
            // SinCosZTextBox
            // 
            this.SinCosZTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SinCosZTextBox.Location = new System.Drawing.Point(96, 78);
            this.SinCosZTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SinCosZTextBox.Name = "SinCosZTextBox";
            this.SinCosZTextBox.Size = new System.Drawing.Size(434, 23);
            this.SinCosZTextBox.TabIndex = 111;
            this.SinCosZTextBox.TextChanged += new System.EventHandler(this.SinCosZTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Sin,Cos Z：";
            // 
            // EditYmapBoxOccluderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 414);
            this.Controls.Add(this.SinCosZTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddToProjectButton);
            this.Controls.Add(this.GoToButton);
            this.Controls.Add(this.CenterTextBox);
            this.Controls.Add(this.label31);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditYmapBoxOccluderPanel";
            this.Text = "遮挡盒";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoToButton;
        private System.Windows.Forms.TextBox CenterTextBox;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddToProjectButton;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SinCosZTextBox;
        private System.Windows.Forms.Label label2;
    }
}