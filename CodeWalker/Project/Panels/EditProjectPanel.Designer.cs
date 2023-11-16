namespace CodeWalker.Project.Panels
{
    partial class EditProjectPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProjectPanel));
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectVersionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectNameTextBox.Location = new System.Drawing.Point(111, 28);
            this.ProjectNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectNameTextBox.MinimumSize = new System.Drawing.Size(116, 4);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(382, 23);
            this.ProjectNameTextBox.TabIndex = 4;
            this.ProjectNameTextBox.TextChanged += new System.EventHandler(this.ProjectNameTextBox_TextChanged);
            // 
            // ProjectVersionLabel
            // 
            this.ProjectVersionLabel.AutoSize = true;
            this.ProjectVersionLabel.Location = new System.Drawing.Point(37, 79);
            this.ProjectVersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProjectVersionLabel.Name = "ProjectVersionLabel";
            this.ProjectVersionLabel.Size = new System.Drawing.Size(68, 17);
            this.ProjectVersionLabel.TabIndex = 5;
            this.ProjectVersionLabel.Text = "项目版本：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "项目名称：";
            // 
            // EditProjectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 313);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.ProjectVersionLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditProjectPanel";
            this.Text = "项目属性";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Label ProjectVersionLabel;
        private System.Windows.Forms.Label label1;
    }
}