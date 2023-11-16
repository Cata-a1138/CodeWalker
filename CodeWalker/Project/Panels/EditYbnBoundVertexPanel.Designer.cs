namespace CodeWalker.Project.Panels
{
    partial class EditYbnBoundVertexPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYbnBoundVertexPanel));
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddToProjectButton = new System.Windows.Forms.Button();
            this.ColourTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionTextBox.Location = new System.Drawing.Point(90, 46);
            this.PositionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(499, 23);
            this.PositionTextBox.TabIndex = 1;
            this.PositionTextBox.TextChanged += new System.EventHandler(this.PositionTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "位置：";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(478, 8);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 30);
            this.DeleteButton.TabIndex = 40;
            this.DeleteButton.Text = "删除顶点";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddToProjectButton
            // 
            this.AddToProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToProjectButton.Location = new System.Drawing.Point(360, 8);
            this.AddToProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddToProjectButton.Name = "AddToProjectButton";
            this.AddToProjectButton.Size = new System.Drawing.Size(111, 30);
            this.AddToProjectButton.TabIndex = 39;
            this.AddToProjectButton.Text = "添加到项目";
            this.AddToProjectButton.UseVisualStyleBackColor = true;
            this.AddToProjectButton.Click += new System.EventHandler(this.AddToProjectButton_Click);
            // 
            // ColourTextBox
            // 
            this.ColourTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColourTextBox.Location = new System.Drawing.Point(90, 77);
            this.ColourTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColourTextBox.Name = "ColourTextBox";
            this.ColourTextBox.Size = new System.Drawing.Size(499, 23);
            this.ColourTextBox.TabIndex = 3;
            this.ColourTextBox.TextChanged += new System.EventHandler(this.ColourTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "颜色：";
            // 
            // EditYbnBoundVertexPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 372);
            this.Controls.Add(this.ColourTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddToProjectButton);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditYbnBoundVertexPanel";
            this.Text = "EditYbnBoundVertexPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddToProjectButton;
        private System.Windows.Forms.TextBox ColourTextBox;
        private System.Windows.Forms.Label label1;
    }
}