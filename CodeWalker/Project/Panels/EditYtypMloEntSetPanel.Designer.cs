namespace CodeWalker.Project.Panels
{
    partial class EditYtypMloEntSetPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYtypMloEntSetPanel));
            this.EntitySetNameTextBox = new CodeWalker.WinForms.TextBoxFix();
            this.label3 = new System.Windows.Forms.Label();
            this.ForceVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LocationsListBox = new System.Windows.Forms.ListBox();
            this.SelectedLocationGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedLocationRoomCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectedLocationEntityLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEntityButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SelectedLocationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntitySetNameTextBox
            // 
            this.EntitySetNameTextBox.Location = new System.Drawing.Point(84, 20);
            this.EntitySetNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntitySetNameTextBox.Name = "EntitySetNameTextBox";
            this.EntitySetNameTextBox.Size = new System.Drawing.Size(233, 23);
            this.EntitySetNameTextBox.TabIndex = 7;
            this.EntitySetNameTextBox.TextChanged += new System.EventHandler(this.EntitySetNameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "名称：";
            // 
            // ForceVisibleCheckBox
            // 
            this.ForceVisibleCheckBox.AutoSize = true;
            this.ForceVisibleCheckBox.Location = new System.Drawing.Point(325, 22);
            this.ForceVisibleCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ForceVisibleCheckBox.Name = "ForceVisibleCheckBox";
            this.ForceVisibleCheckBox.Size = new System.Drawing.Size(135, 21);
            this.ForceVisibleCheckBox.TabIndex = 8;
            this.ForceVisibleCheckBox.Text = "强制在编辑器内可见";
            this.ForceVisibleCheckBox.UseVisualStyleBackColor = true;
            this.ForceVisibleCheckBox.CheckedChanged += new System.EventHandler(this.ForceVisibleCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "位置：";
            // 
            // LocationsListBox
            // 
            this.LocationsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LocationsListBox.FormattingEnabled = true;
            this.LocationsListBox.ItemHeight = 17;
            this.LocationsListBox.Location = new System.Drawing.Point(84, 51);
            this.LocationsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LocationsListBox.Name = "LocationsListBox";
            this.LocationsListBox.Size = new System.Drawing.Size(233, 429);
            this.LocationsListBox.TabIndex = 10;
            this.LocationsListBox.SelectedIndexChanged += new System.EventHandler(this.LocationsListBox_SelectedIndexChanged);
            // 
            // SelectedLocationGroupBox
            // 
            this.SelectedLocationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedLocationGroupBox.Controls.Add(this.SelectedLocationRoomCombo);
            this.SelectedLocationGroupBox.Controls.Add(this.label4);
            this.SelectedLocationGroupBox.Controls.Add(this.SelectedLocationEntityLabel);
            this.SelectedLocationGroupBox.Controls.Add(this.label2);
            this.SelectedLocationGroupBox.Location = new System.Drawing.Point(325, 51);
            this.SelectedLocationGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectedLocationGroupBox.Name = "SelectedLocationGroupBox";
            this.SelectedLocationGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectedLocationGroupBox.Size = new System.Drawing.Size(270, 109);
            this.SelectedLocationGroupBox.TabIndex = 11;
            this.SelectedLocationGroupBox.TabStop = false;
            this.SelectedLocationGroupBox.Text = "选择的位置";
            this.SelectedLocationGroupBox.Visible = false;
            // 
            // SelectedLocationRoomCombo
            // 
            this.SelectedLocationRoomCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedLocationRoomCombo.FormattingEnabled = true;
            this.SelectedLocationRoomCombo.Location = new System.Drawing.Point(59, 60);
            this.SelectedLocationRoomCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectedLocationRoomCombo.Name = "SelectedLocationRoomCombo";
            this.SelectedLocationRoomCombo.Size = new System.Drawing.Size(180, 25);
            this.SelectedLocationRoomCombo.TabIndex = 13;
            this.SelectedLocationRoomCombo.SelectedIndexChanged += new System.EventHandler(this.SelectedLocationRoomCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "房间：";
            // 
            // SelectedLocationEntityLabel
            // 
            this.SelectedLocationEntityLabel.AutoSize = true;
            this.SelectedLocationEntityLabel.Location = new System.Drawing.Point(56, 33);
            this.SelectedLocationEntityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedLocationEntityLabel.Name = "SelectedLocationEntityLabel";
            this.SelectedLocationEntityLabel.Size = new System.Drawing.Size(13, 17);
            this.SelectedLocationEntityLabel.TabIndex = 11;
            this.SelectedLocationEntityLabel.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "实体：";
            // 
            // AddEntityButton
            // 
            this.AddEntityButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEntityButton.Location = new System.Drawing.Point(325, 168);
            this.AddEntityButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddEntityButton.Name = "AddEntityButton";
            this.AddEntityButton.Size = new System.Drawing.Size(270, 30);
            this.AddEntityButton.TabIndex = 39;
            this.AddEntityButton.Text = "添加实体";
            this.AddEntityButton.UseVisualStyleBackColor = true;
            this.AddEntityButton.Click += new System.EventHandler(this.AddEntityButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(325, 206);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(270, 30);
            this.DeleteButton.TabIndex = 40;
            this.DeleteButton.Text = "删除实体预设";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditYtypMloEntSetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 504);
            this.Controls.Add(this.AddEntityButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SelectedLocationGroupBox);
            this.Controls.Add(this.LocationsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ForceVisibleCheckBox);
            this.Controls.Add(this.EntitySetNameTextBox);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditYtypMloEntSetPanel";
            this.Text = "实体预设";
            this.SelectedLocationGroupBox.ResumeLayout(false);
            this.SelectedLocationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinForms.TextBoxFix EntitySetNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ForceVisibleCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LocationsListBox;
        private System.Windows.Forms.GroupBox SelectedLocationGroupBox;
        private System.Windows.Forms.Label SelectedLocationEntityLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectedLocationRoomCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddEntityButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}