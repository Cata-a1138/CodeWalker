
namespace CodeWalker.Project.Panels
{
    partial class EditYmapOccludeModelPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditYmapOccludeModelPanel));
            this.OccludeModelTabControl = new System.Windows.Forms.TabControl();
            this.ModelTabPage = new System.Windows.Forms.TabPage();
            this.ModelFlagsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelDeleteButton = new System.Windows.Forms.Button();
            this.ModelAddToProjectButton = new System.Windows.Forms.Button();
            this.TriangleTabPage = new System.Windows.Forms.TabPage();
            this.TriangleCorner3TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TriangleCorner2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TriangleCorner1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TriangleDeleteButton = new System.Windows.Forms.Button();
            this.TriangleAddToProjectButton = new System.Windows.Forms.Button();
            this.TriangleGoToButton = new System.Windows.Forms.Button();
            this.TriangleCenterTextBox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.OccludeModelTabControl.SuspendLayout();
            this.ModelTabPage.SuspendLayout();
            this.TriangleTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // OccludeModelTabControl
            // 
            this.OccludeModelTabControl.Controls.Add(this.ModelTabPage);
            this.OccludeModelTabControl.Controls.Add(this.TriangleTabPage);
            this.OccludeModelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OccludeModelTabControl.Location = new System.Drawing.Point(0, 0);
            this.OccludeModelTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OccludeModelTabControl.Name = "OccludeModelTabControl";
            this.OccludeModelTabControl.SelectedIndex = 0;
            this.OccludeModelTabControl.Size = new System.Drawing.Size(551, 210);
            this.OccludeModelTabControl.TabIndex = 0;
            // 
            // ModelTabPage
            // 
            this.ModelTabPage.Controls.Add(this.ModelFlagsTextBox);
            this.ModelTabPage.Controls.Add(this.label4);
            this.ModelTabPage.Controls.Add(this.ModelDeleteButton);
            this.ModelTabPage.Controls.Add(this.ModelAddToProjectButton);
            this.ModelTabPage.Location = new System.Drawing.Point(4, 26);
            this.ModelTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelTabPage.Name = "ModelTabPage";
            this.ModelTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelTabPage.Size = new System.Drawing.Size(543, 180);
            this.ModelTabPage.TabIndex = 0;
            this.ModelTabPage.Text = "模型";
            this.ModelTabPage.UseVisualStyleBackColor = true;
            // 
            // ModelFlagsTextBox
            // 
            this.ModelFlagsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelFlagsTextBox.Location = new System.Drawing.Point(88, 8);
            this.ModelFlagsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelFlagsTextBox.Name = "ModelFlagsTextBox";
            this.ModelFlagsTextBox.Size = new System.Drawing.Size(414, 23);
            this.ModelFlagsTextBox.TabIndex = 119;
            this.ModelFlagsTextBox.TextChanged += new System.EventHandler(this.ModelFlagsTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 118;
            this.label4.Text = "Flags：";
            // 
            // ModelDeleteButton
            // 
            this.ModelDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelDeleteButton.Location = new System.Drawing.Point(391, 39);
            this.ModelDeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelDeleteButton.Name = "ModelDeleteButton";
            this.ModelDeleteButton.Size = new System.Drawing.Size(111, 30);
            this.ModelDeleteButton.TabIndex = 111;
            this.ModelDeleteButton.Text = "删除模型";
            this.ModelDeleteButton.UseVisualStyleBackColor = true;
            this.ModelDeleteButton.Click += new System.EventHandler(this.ModelDeleteButton_Click);
            // 
            // ModelAddToProjectButton
            // 
            this.ModelAddToProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelAddToProjectButton.Location = new System.Drawing.Point(272, 39);
            this.ModelAddToProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelAddToProjectButton.Name = "ModelAddToProjectButton";
            this.ModelAddToProjectButton.Size = new System.Drawing.Size(111, 30);
            this.ModelAddToProjectButton.TabIndex = 110;
            this.ModelAddToProjectButton.Text = "添加到项目";
            this.ModelAddToProjectButton.UseVisualStyleBackColor = true;
            this.ModelAddToProjectButton.Click += new System.EventHandler(this.ModelAddToProjectButton_Click);
            // 
            // TriangleTabPage
            // 
            this.TriangleTabPage.Controls.Add(this.TriangleCorner3TextBox);
            this.TriangleTabPage.Controls.Add(this.label3);
            this.TriangleTabPage.Controls.Add(this.TriangleCorner2TextBox);
            this.TriangleTabPage.Controls.Add(this.label2);
            this.TriangleTabPage.Controls.Add(this.TriangleCorner1TextBox);
            this.TriangleTabPage.Controls.Add(this.label1);
            this.TriangleTabPage.Controls.Add(this.TriangleDeleteButton);
            this.TriangleTabPage.Controls.Add(this.TriangleAddToProjectButton);
            this.TriangleTabPage.Controls.Add(this.TriangleGoToButton);
            this.TriangleTabPage.Controls.Add(this.TriangleCenterTextBox);
            this.TriangleTabPage.Controls.Add(this.label31);
            this.TriangleTabPage.Location = new System.Drawing.Point(4, 26);
            this.TriangleTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TriangleTabPage.Name = "TriangleTabPage";
            this.TriangleTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TriangleTabPage.Size = new System.Drawing.Size(543, 180);
            this.TriangleTabPage.TabIndex = 1;
            this.TriangleTabPage.Text = "三角形";
            this.TriangleTabPage.UseVisualStyleBackColor = true;
            // 
            // TriangleCorner3TextBox
            // 
            this.TriangleCorner3TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TriangleCorner3TextBox.Location = new System.Drawing.Point(88, 101);
            this.TriangleCorner3TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TriangleCorner3TextBox.Name = "TriangleCorner3TextBox";
            this.TriangleCorner3TextBox.Size = new System.Drawing.Size(360, 23);
            this.TriangleCorner3TextBox.TabIndex = 115;
            this.TriangleCorner3TextBox.TextChanged += new System.EventHandler(this.TriangleCorner3TextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 114;
            this.label3.Text = "边角 3：";
            // 
            // TriangleCorner2TextBox
            // 
            this.TriangleCorner2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TriangleCorner2TextBox.Location = new System.Drawing.Point(88, 70);
            this.TriangleCorner2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TriangleCorner2TextBox.Name = "TriangleCorner2TextBox";
            this.TriangleCorner2TextBox.Size = new System.Drawing.Size(360, 23);
            this.TriangleCorner2TextBox.TabIndex = 113;
            this.TriangleCorner2TextBox.TextChanged += new System.EventHandler(this.TriangleCorner2TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 112;
            this.label2.Text = "边角 2：";
            // 
            // TriangleCorner1TextBox
            // 
            this.TriangleCorner1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TriangleCorner1TextBox.Location = new System.Drawing.Point(88, 39);
            this.TriangleCorner1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TriangleCorner1TextBox.Name = "TriangleCorner1TextBox";
            this.TriangleCorner1TextBox.Size = new System.Drawing.Size(360, 23);
            this.TriangleCorner1TextBox.TabIndex = 111;
            this.TriangleCorner1TextBox.TextChanged += new System.EventHandler(this.TriangleCorner1TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 110;
            this.label1.Text = "边角 1：";
            // 
            // TriangleDeleteButton
            // 
            this.TriangleDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TriangleDeleteButton.Location = new System.Drawing.Point(337, 132);
            this.TriangleDeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TriangleDeleteButton.Name = "TriangleDeleteButton";
            this.TriangleDeleteButton.Size = new System.Drawing.Size(111, 30);
            this.TriangleDeleteButton.TabIndex = 109;
            this.TriangleDeleteButton.Text = "删除三角形";
            this.TriangleDeleteButton.UseVisualStyleBackColor = true;
            this.TriangleDeleteButton.Click += new System.EventHandler(this.TriangleDeleteButton_Click);
            // 
            // TriangleAddToProjectButton
            // 
            this.TriangleAddToProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TriangleAddToProjectButton.Location = new System.Drawing.Point(220, 132);
            this.TriangleAddToProjectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TriangleAddToProjectButton.Name = "TriangleAddToProjectButton";
            this.TriangleAddToProjectButton.Size = new System.Drawing.Size(111, 30);
            this.TriangleAddToProjectButton.TabIndex = 108;
            this.TriangleAddToProjectButton.Text = "添加到项目";
            this.TriangleAddToProjectButton.UseVisualStyleBackColor = true;
            this.TriangleAddToProjectButton.Click += new System.EventHandler(this.TriangleAddToProjectButton_Click);
            // 
            // TriangleGoToButton
            // 
            this.TriangleGoToButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TriangleGoToButton.Location = new System.Drawing.Point(455, 4);
            this.TriangleGoToButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TriangleGoToButton.Name = "TriangleGoToButton";
            this.TriangleGoToButton.Size = new System.Drawing.Size(79, 30);
            this.TriangleGoToButton.TabIndex = 87;
            this.TriangleGoToButton.Text = "传送";
            this.TriangleGoToButton.UseVisualStyleBackColor = true;
            this.TriangleGoToButton.Click += new System.EventHandler(this.TriangleGoToButton_Click);
            // 
            // TriangleCenterTextBox
            // 
            this.TriangleCenterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TriangleCenterTextBox.Location = new System.Drawing.Point(88, 8);
            this.TriangleCenterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TriangleCenterTextBox.Name = "TriangleCenterTextBox";
            this.TriangleCenterTextBox.Size = new System.Drawing.Size(360, 23);
            this.TriangleCenterTextBox.TabIndex = 86;
            this.TriangleCenterTextBox.TextChanged += new System.EventHandler(this.TriangleCenterTextBox_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(24, 11);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 17);
            this.label31.TabIndex = 85;
            this.label31.Text = "中心点：";
            // 
            // EditYmapOccludeModelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 210);
            this.Controls.Add(this.OccludeModelTabControl);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditYmapOccludeModelPanel";
            this.Text = "遮挡模型";
            this.OccludeModelTabControl.ResumeLayout(false);
            this.ModelTabPage.ResumeLayout(false);
            this.ModelTabPage.PerformLayout();
            this.TriangleTabPage.ResumeLayout(false);
            this.TriangleTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl OccludeModelTabControl;
        private System.Windows.Forms.TabPage ModelTabPage;
        private System.Windows.Forms.TabPage TriangleTabPage;
        private System.Windows.Forms.Button TriangleGoToButton;
        private System.Windows.Forms.TextBox TriangleCenterTextBox;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button TriangleDeleteButton;
        private System.Windows.Forms.Button TriangleAddToProjectButton;
        private System.Windows.Forms.Button ModelDeleteButton;
        private System.Windows.Forms.Button ModelAddToProjectButton;
        private System.Windows.Forms.TextBox TriangleCorner3TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TriangleCorner2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TriangleCorner1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ModelFlagsTextBox;
        private System.Windows.Forms.Label label4;
    }
}