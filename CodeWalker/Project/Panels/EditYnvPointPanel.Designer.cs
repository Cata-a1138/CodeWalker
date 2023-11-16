namespace CodeWalker.Project.Panels
{
    partial class EditYnvPointPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYnvPointPanel));
            this.DeletePointButton = new System.Windows.Forms.Button();
            this.AddToProjectButton = new System.Windows.Forms.Button();
            this.YnvPointGoToButton = new System.Windows.Forms.Button();
            this.YnvPointPositionTextBox = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.YnvPointTypeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.YnvPointAngleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.YnvPointTypeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YnvPointAngleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DeletePointButton
            // 
            this.DeletePointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePointButton.Enabled = false;
            this.DeletePointButton.Location = new System.Drawing.Point(393, 77);
            this.DeletePointButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeletePointButton.Name = "DeletePointButton";
            this.DeletePointButton.Size = new System.Drawing.Size(105, 30);
            this.DeletePointButton.TabIndex = 8;
            this.DeletePointButton.Text = "删除该点";
            this.DeletePointButton.UseVisualStyleBackColor = true;
            this.DeletePointButton.Click += new System.EventHandler(this.DeletePointButton_Click);
            // 
            // AddToProjectButton
            // 
            this.AddToProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToProjectButton.Enabled = false;
            this.AddToProjectButton.Location = new System.Drawing.Point(393, 45);
            this.AddToProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddToProjectButton.Name = "AddToProjectButton";
            this.AddToProjectButton.Size = new System.Drawing.Size(105, 30);
            this.AddToProjectButton.TabIndex = 7;
            this.AddToProjectButton.Text = "添加到项目";
            this.AddToProjectButton.UseVisualStyleBackColor = true;
            this.AddToProjectButton.Click += new System.EventHandler(this.AddToProjectButton_Click);
            // 
            // YnvPointGoToButton
            // 
            this.YnvPointGoToButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YnvPointGoToButton.Location = new System.Drawing.Point(393, 13);
            this.YnvPointGoToButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvPointGoToButton.Name = "YnvPointGoToButton";
            this.YnvPointGoToButton.Size = new System.Drawing.Size(105, 30);
            this.YnvPointGoToButton.TabIndex = 2;
            this.YnvPointGoToButton.Text = "传送";
            this.YnvPointGoToButton.UseVisualStyleBackColor = true;
            this.YnvPointGoToButton.Click += new System.EventHandler(this.YnvPointGoToButton_Click);
            // 
            // YnvPointPositionTextBox
            // 
            this.YnvPointPositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YnvPointPositionTextBox.Location = new System.Drawing.Point(86, 16);
            this.YnvPointPositionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvPointPositionTextBox.Name = "YnvPointPositionTextBox";
            this.YnvPointPositionTextBox.Size = new System.Drawing.Size(296, 23);
            this.YnvPointPositionTextBox.TabIndex = 1;
            this.YnvPointPositionTextBox.TextChanged += new System.EventHandler(this.YnvPointPositionTextBox_TextChanged);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(34, 19);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(44, 17);
            this.label55.TabIndex = 0;
            this.label55.Text = "位置：";
            // 
            // YnvPointTypeUpDown
            // 
            this.YnvPointTypeUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YnvPointTypeUpDown.Location = new System.Drawing.Point(86, 84);
            this.YnvPointTypeUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvPointTypeUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.YnvPointTypeUpDown.Name = "YnvPointTypeUpDown";
            this.YnvPointTypeUpDown.Size = new System.Drawing.Size(296, 23);
            this.YnvPointTypeUpDown.TabIndex = 6;
            this.YnvPointTypeUpDown.ValueChanged += new System.EventHandler(this.YnvPointTypeUpDown_ValueChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(34, 86);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(44, 17);
            this.label49.TabIndex = 5;
            this.label49.Text = "类型：";
            this.label49.Click += new System.EventHandler(this.label49_Click);
            // 
            // YnvPointAngleUpDown
            // 
            this.YnvPointAngleUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YnvPointAngleUpDown.Location = new System.Drawing.Point(86, 50);
            this.YnvPointAngleUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YnvPointAngleUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.YnvPointAngleUpDown.Name = "YnvPointAngleUpDown";
            this.YnvPointAngleUpDown.Size = new System.Drawing.Size(296, 23);
            this.YnvPointAngleUpDown.TabIndex = 4;
            this.YnvPointAngleUpDown.ValueChanged += new System.EventHandler(this.YnvPointAngleUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "旋转：";
            // 
            // EditYnvPointPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 317);
            this.Controls.Add(this.YnvPointAngleUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YnvPointTypeUpDown);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.DeletePointButton);
            this.Controls.Add(this.AddToProjectButton);
            this.Controls.Add(this.YnvPointGoToButton);
            this.Controls.Add(this.YnvPointPositionTextBox);
            this.Controls.Add(this.label55);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditYnvPointPanel";
            this.Text = "编辑 Ynv 点";
            ((System.ComponentModel.ISupportInitialize)(this.YnvPointTypeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YnvPointAngleUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeletePointButton;
        private System.Windows.Forms.Button AddToProjectButton;
        private System.Windows.Forms.Button YnvPointGoToButton;
        private System.Windows.Forms.TextBox YnvPointPositionTextBox;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown YnvPointTypeUpDown;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.NumericUpDown YnvPointAngleUpDown;
        private System.Windows.Forms.Label label1;
    }
}