namespace CodeWalker.Project.Panels
{
    partial class EditMultiPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMultiPanel));
            this.ScaleTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RotationQuatBox = new CodeWalker.WinForms.QuaternionBox();
            this.SuspendLayout();
            // 
            // ScaleTextBox
            // 
            this.ScaleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleTextBox.Location = new System.Drawing.Point(88, 84);
            this.ScaleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ScaleTextBox.Name = "ScaleTextBox";
            this.ScaleTextBox.Size = new System.Drawing.Size(464, 23);
            this.ScaleTextBox.TabIndex = 18;
            this.ScaleTextBox.TextChanged += new System.EventHandler(this.ScaleTextBox_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(40, 87);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 17);
            this.label23.TabIndex = 17;
            this.label23.Text = "缩放：";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionTextBox.Location = new System.Drawing.Point(88, 16);
            this.PositionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(464, 23);
            this.PositionTextBox.TabIndex = 14;
            this.PositionTextBox.TextChanged += new System.EventHandler(this.PositionTextBox_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(40, 53);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 17);
            this.label24.TabIndex = 15;
            this.label24.Text = "旋转：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(40, 19);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 17);
            this.label25.TabIndex = 13;
            this.label25.Text = "位置：";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 17;
            this.ItemsListBox.Location = new System.Drawing.Point(88, 142);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(464, 378);
            this.ItemsListBox.TabIndex = 21;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "对象：";
            // 
            // RotationQuatBox
            // 
            this.RotationQuatBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RotationQuatBox.Location = new System.Drawing.Point(88, 47);
            this.RotationQuatBox.Margin = new System.Windows.Forms.Padding(0);
            this.RotationQuatBox.Name = "RotationQuatBox";
            this.RotationQuatBox.Padding = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.RotationQuatBox.Size = new System.Drawing.Size(464, 31);
            this.RotationQuatBox.TabIndex = 16;
            this.RotationQuatBox.ValueChanged += new System.EventHandler(this.RotationQuatBox_ValueChanged);
            this.RotationQuatBox.Load += new System.EventHandler(this.RotationQuatBox_Load);
            // 
            // EditMultiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 532);
            this.Controls.Add(this.RotationQuatBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ScaleTextBox);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditMultiPanel";
            this.Text = "EditMultiPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScaleTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label label1;
        private WinForms.QuaternionBox RotationQuatBox;
    }
}