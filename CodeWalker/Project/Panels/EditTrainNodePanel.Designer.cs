namespace CodeWalker.Project.Panels
{
    partial class EditTrainNodePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTrainNodePanel));
            this.TrainNodeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label82 = new System.Windows.Forms.Label();
            this.TrainNodeDeleteButton = new System.Windows.Forms.Button();
            this.TrainNodeAddToProjectButton = new System.Windows.Forms.Button();
            this.TrainNodeGoToButton = new System.Windows.Forms.Button();
            this.TrainNodePositionTextBox = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TrainNodeTypeComboBox
            // 
            this.TrainNodeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrainNodeTypeComboBox.FormattingEnabled = true;
            this.TrainNodeTypeComboBox.Items.AddRange(new object[] {
            "0 - Default",
            "1 - Default Station",
            "2 - Freight Station",
            "3 - (Not used)",
            "4 - Underground",
            "5 - Underground Station"});
            this.TrainNodeTypeComboBox.Location = new System.Drawing.Point(79, 59);
            this.TrainNodeTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrainNodeTypeComboBox.Name = "TrainNodeTypeComboBox";
            this.TrainNodeTypeComboBox.Size = new System.Drawing.Size(261, 25);
            this.TrainNodeTypeComboBox.TabIndex = 47;
            this.TrainNodeTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TrainNodeTypeComboBox_SelectedIndexChanged);
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(27, 62);
            this.label82.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(44, 17);
            this.label82.TabIndex = 46;
            this.label82.Text = "类型：";
            // 
            // TrainNodeDeleteButton
            // 
            this.TrainNodeDeleteButton.Enabled = false;
            this.TrainNodeDeleteButton.Location = new System.Drawing.Point(192, 101);
            this.TrainNodeDeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrainNodeDeleteButton.Name = "TrainNodeDeleteButton";
            this.TrainNodeDeleteButton.Size = new System.Drawing.Size(105, 30);
            this.TrainNodeDeleteButton.TabIndex = 49;
            this.TrainNodeDeleteButton.Text = "删除节点";
            this.TrainNodeDeleteButton.UseVisualStyleBackColor = true;
            this.TrainNodeDeleteButton.Click += new System.EventHandler(this.TrainNodeDeleteButton_Click);
            // 
            // TrainNodeAddToProjectButton
            // 
            this.TrainNodeAddToProjectButton.Enabled = false;
            this.TrainNodeAddToProjectButton.Location = new System.Drawing.Point(79, 101);
            this.TrainNodeAddToProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrainNodeAddToProjectButton.Name = "TrainNodeAddToProjectButton";
            this.TrainNodeAddToProjectButton.Size = new System.Drawing.Size(105, 30);
            this.TrainNodeAddToProjectButton.TabIndex = 48;
            this.TrainNodeAddToProjectButton.Text = "添加到项目";
            this.TrainNodeAddToProjectButton.UseVisualStyleBackColor = true;
            this.TrainNodeAddToProjectButton.Click += new System.EventHandler(this.TrainNodeAddToProjectButton_Click);
            // 
            // TrainNodeGoToButton
            // 
            this.TrainNodeGoToButton.Location = new System.Drawing.Point(348, 13);
            this.TrainNodeGoToButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrainNodeGoToButton.Name = "TrainNodeGoToButton";
            this.TrainNodeGoToButton.Size = new System.Drawing.Size(79, 30);
            this.TrainNodeGoToButton.TabIndex = 44;
            this.TrainNodeGoToButton.Text = "传送";
            this.TrainNodeGoToButton.UseVisualStyleBackColor = true;
            this.TrainNodeGoToButton.Click += new System.EventHandler(this.TrainNodeGoToButton_Click);
            // 
            // TrainNodePositionTextBox
            // 
            this.TrainNodePositionTextBox.Location = new System.Drawing.Point(79, 17);
            this.TrainNodePositionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrainNodePositionTextBox.Name = "TrainNodePositionTextBox";
            this.TrainNodePositionTextBox.Size = new System.Drawing.Size(261, 23);
            this.TrainNodePositionTextBox.TabIndex = 43;
            this.TrainNodePositionTextBox.TextChanged += new System.EventHandler(this.TrainNodePositionTextBox_TextChanged);
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(27, 20);
            this.label81.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(44, 17);
            this.label81.TabIndex = 45;
            this.label81.Text = "位置：";
            // 
            // EditTrainNodePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 175);
            this.Controls.Add(this.TrainNodeTypeComboBox);
            this.Controls.Add(this.label82);
            this.Controls.Add(this.TrainNodeDeleteButton);
            this.Controls.Add(this.TrainNodeAddToProjectButton);
            this.Controls.Add(this.TrainNodeGoToButton);
            this.Controls.Add(this.TrainNodePositionTextBox);
            this.Controls.Add(this.label81);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditTrainNodePanel";
            this.Text = "Edit Train Node";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TrainNodeTypeComboBox;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Button TrainNodeDeleteButton;
        private System.Windows.Forms.Button TrainNodeAddToProjectButton;
        private System.Windows.Forms.Button TrainNodeGoToButton;
        private System.Windows.Forms.TextBox TrainNodePositionTextBox;
        private System.Windows.Forms.Label label81;
    }
}