namespace CodeWalker.Forms
{
    partial class ModelMatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelMatForm));
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.ModelsTreeView = new CodeWalker.WinForms.TreeViewFix();
            this.MaterialPropertiesPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.label1);
            this.MainSplitContainer.Panel1.Controls.Add(this.ModelsTreeView);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.MaterialPropertiesPanel);
            this.MainSplitContainer.Size = new System.Drawing.Size(723, 484);
            this.MainSplitContainer.SplitterDistance = 232;
            this.MainSplitContainer.SplitterWidth = 5;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择几何体：";
            // 
            // ModelsTreeView
            // 
            this.ModelsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelsTreeView.FullRowSelect = true;
            this.ModelsTreeView.HideSelection = false;
            this.ModelsTreeView.Location = new System.Drawing.Point(4, 31);
            this.ModelsTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelsTreeView.Name = "ModelsTreeView";
            this.ModelsTreeView.ShowRootLines = false;
            this.ModelsTreeView.Size = new System.Drawing.Size(224, 447);
            this.ModelsTreeView.TabIndex = 2;
            this.ModelsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ModelsTreeView_AfterSelect);
            // 
            // MaterialPropertiesPanel
            // 
            this.MaterialPropertiesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialPropertiesPanel.AutoScroll = true;
            this.MaterialPropertiesPanel.Location = new System.Drawing.Point(4, 31);
            this.MaterialPropertiesPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaterialPropertiesPanel.Name = "MaterialPropertiesPanel";
            this.MaterialPropertiesPanel.Size = new System.Drawing.Size(479, 449);
            this.MaterialPropertiesPanel.TabIndex = 0;
            // 
            // ModelMatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 484);
            this.Controls.Add(this.MainSplitContainer);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModelMatForm";
            this.Text = "模型材质编辑器 - CodeWalker by dexyfex";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModelMatForm_FormClosed);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel1.PerformLayout();
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Label label1;
        private WinForms.TreeViewFix ModelsTreeView;
        private System.Windows.Forms.Panel MaterialPropertiesPanel;
    }
}