namespace CodeWalker.Project.Panels
{
    partial class GenerateNavMeshPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateNavMeshPanel));
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(90, 163);
            this.MinTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(206, 23);
            this.MinTextBox.TabIndex = 46;
            this.MinTextBox.Text = "0, 0";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(14, 166);
            this.label81.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(74, 17);
            this.label81.TabIndex = 47;
            this.label81.Text = "最小：(X, Y)";
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(90, 197);
            this.MaxTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(206, 23);
            this.MaxTextBox.TabIndex = 48;
            this.MaxTextBox.Text = "50, 50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "最大：(X, Y)";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(630, 148);
            this.label2.TabIndex = 50;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(307, 193);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(115, 30);
            this.GenerateButton.TabIndex = 51;
            this.GenerateButton.Text = "生成";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "(寻路网格只会在该区域内生成)";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(14, 235);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(104, 17);
            this.StatusLabel.TabIndex = 53;
            this.StatusLabel.Text = "已准备好开始生成";
            // 
            // GenerateNavMeshPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 336);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.label81);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GenerateNavMeshPanel";
            this.Text = "生成寻路网格";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StatusLabel;
    }
}