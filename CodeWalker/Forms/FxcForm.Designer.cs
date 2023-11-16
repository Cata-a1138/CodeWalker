namespace CodeWalker.Forms
{
    partial class FxcForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FxcForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ShadersTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ShadersListView = new System.Windows.Forms.ListView();
            this.ShadersNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShaderPanel = new System.Windows.Forms.Panel();
            this.ShaderTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.TechniquesTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TechniquesListView = new System.Windows.Forms.ListView();
            this.TechniquesNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TechniquePanel = new System.Windows.Forms.Panel();
            this.TechniqueTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.DetailsTabPage = new System.Windows.Forms.TabPage();
            this.DetailsPropertyGrid = new CodeWalker.WinForms.PropertyGridFix();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTabControl.SuspendLayout();
            this.ShadersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ShaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShaderTextBox)).BeginInit();
            this.TechniquesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.TechniquePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TechniqueTextBox)).BeginInit();
            this.DetailsTabPage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.ShadersTabPage);
            this.MainTabControl.Controls.Add(this.TechniquesTabPage);
            this.MainTabControl.Controls.Add(this.DetailsTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(2, 4);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(915, 505);
            this.MainTabControl.TabIndex = 0;
            // 
            // ShadersTabPage
            // 
            this.ShadersTabPage.Controls.Add(this.splitContainer1);
            this.ShadersTabPage.Location = new System.Drawing.Point(4, 26);
            this.ShadersTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShadersTabPage.Name = "ShadersTabPage";
            this.ShadersTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShadersTabPage.Size = new System.Drawing.Size(907, 475);
            this.ShadersTabPage.TabIndex = 0;
            this.ShadersTabPage.Text = "着色器";
            this.ShadersTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ShadersListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ShaderPanel);
            this.splitContainer1.Size = new System.Drawing.Size(899, 467);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // ShadersListView
            // 
            this.ShadersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ShadersNameColumn});
            this.ShadersListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShadersListView.FullRowSelect = true;
            this.ShadersListView.HideSelection = false;
            this.ShadersListView.Location = new System.Drawing.Point(0, 0);
            this.ShadersListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShadersListView.MultiSelect = false;
            this.ShadersListView.Name = "ShadersListView";
            this.ShadersListView.Size = new System.Drawing.Size(235, 467);
            this.ShadersListView.TabIndex = 0;
            this.ShadersListView.UseCompatibleStateImageBehavior = false;
            this.ShadersListView.View = System.Windows.Forms.View.Details;
            this.ShadersListView.SelectedIndexChanged += new System.EventHandler(this.ShadersListView_SelectedIndexChanged);
            // 
            // ShadersNameColumn
            // 
            this.ShadersNameColumn.Text = "名称";
            this.ShadersNameColumn.Width = 208;
            // 
            // ShaderPanel
            // 
            this.ShaderPanel.Controls.Add(this.ShaderTextBox);
            this.ShaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShaderPanel.Enabled = false;
            this.ShaderPanel.Location = new System.Drawing.Point(0, 0);
            this.ShaderPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShaderPanel.Name = "ShaderPanel";
            this.ShaderPanel.Size = new System.Drawing.Size(659, 467);
            this.ShaderPanel.TabIndex = 0;
            // 
            // ShaderTextBox
            // 
            this.ShaderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShaderTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ShaderTextBox.AutoIndentChars = false;
            this.ShaderTextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.ShaderTextBox.AutoIndentExistingLines = false;
            this.ShaderTextBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.ShaderTextBox.BackBrush = null;
            this.ShaderTextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.ShaderTextBox.CharHeight = 14;
            this.ShaderTextBox.CharWidth = 8;
            this.ShaderTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShaderTextBox.DelayedEventsInterval = 10;
            this.ShaderTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ShaderTextBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ShaderTextBox.IsReplaceMode = false;
            this.ShaderTextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            this.ShaderTextBox.LeftBracket = '(';
            this.ShaderTextBox.LeftBracket2 = '{';
            this.ShaderTextBox.Location = new System.Drawing.Point(4, 0);
            this.ShaderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShaderTextBox.Name = "ShaderTextBox";
            this.ShaderTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ShaderTextBox.RightBracket = ')';
            this.ShaderTextBox.RightBracket2 = '}';
            this.ShaderTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ShaderTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ShaderTextBox.ServiceColors")));
            this.ShaderTextBox.Size = new System.Drawing.Size(649, 467);
            this.ShaderTextBox.TabIndex = 1;
            this.ShaderTextBox.Zoom = 100;
            // 
            // TechniquesTabPage
            // 
            this.TechniquesTabPage.Controls.Add(this.splitContainer2);
            this.TechniquesTabPage.Location = new System.Drawing.Point(4, 26);
            this.TechniquesTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TechniquesTabPage.Name = "TechniquesTabPage";
            this.TechniquesTabPage.Size = new System.Drawing.Size(907, 475);
            this.TechniquesTabPage.TabIndex = 2;
            this.TechniquesTabPage.Text = "技术";
            this.TechniquesTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(4, 4);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.TechniquesListView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TechniquePanel);
            this.splitContainer2.Size = new System.Drawing.Size(898, 459);
            this.splitContainer2.SplitterDistance = 235;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // TechniquesListView
            // 
            this.TechniquesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TechniquesNameColumn});
            this.TechniquesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TechniquesListView.FullRowSelect = true;
            this.TechniquesListView.HideSelection = false;
            this.TechniquesListView.Location = new System.Drawing.Point(0, 0);
            this.TechniquesListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TechniquesListView.MultiSelect = false;
            this.TechniquesListView.Name = "TechniquesListView";
            this.TechniquesListView.Size = new System.Drawing.Size(235, 459);
            this.TechniquesListView.TabIndex = 0;
            this.TechniquesListView.UseCompatibleStateImageBehavior = false;
            this.TechniquesListView.View = System.Windows.Forms.View.Details;
            this.TechniquesListView.SelectedIndexChanged += new System.EventHandler(this.TechniquesListView_SelectedIndexChanged);
            // 
            // TechniquesNameColumn
            // 
            this.TechniquesNameColumn.Text = "名称";
            this.TechniquesNameColumn.Width = 208;
            // 
            // TechniquePanel
            // 
            this.TechniquePanel.Controls.Add(this.TechniqueTextBox);
            this.TechniquePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TechniquePanel.Enabled = false;
            this.TechniquePanel.Location = new System.Drawing.Point(0, 0);
            this.TechniquePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TechniquePanel.Name = "TechniquePanel";
            this.TechniquePanel.Size = new System.Drawing.Size(658, 459);
            this.TechniquePanel.TabIndex = 0;
            // 
            // TechniqueTextBox
            // 
            this.TechniqueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TechniqueTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.TechniqueTextBox.AutoIndentChars = false;
            this.TechniqueTextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.TechniqueTextBox.AutoIndentExistingLines = false;
            this.TechniqueTextBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.TechniqueTextBox.BackBrush = null;
            this.TechniqueTextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.TechniqueTextBox.CharHeight = 14;
            this.TechniqueTextBox.CharWidth = 8;
            this.TechniqueTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TechniqueTextBox.DelayedEventsInterval = 10;
            this.TechniqueTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TechniqueTextBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.TechniqueTextBox.IsReplaceMode = false;
            this.TechniqueTextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            this.TechniqueTextBox.LeftBracket = '(';
            this.TechniqueTextBox.LeftBracket2 = '{';
            this.TechniqueTextBox.Location = new System.Drawing.Point(4, 0);
            this.TechniqueTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TechniqueTextBox.Name = "TechniqueTextBox";
            this.TechniqueTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.TechniqueTextBox.RightBracket = ')';
            this.TechniqueTextBox.RightBracket2 = '}';
            this.TechniqueTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TechniqueTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("TechniqueTextBox.ServiceColors")));
            this.TechniqueTextBox.Size = new System.Drawing.Size(648, 459);
            this.TechniqueTextBox.TabIndex = 1;
            this.TechniqueTextBox.Zoom = 100;
            // 
            // DetailsTabPage
            // 
            this.DetailsTabPage.Controls.Add(this.DetailsPropertyGrid);
            this.DetailsTabPage.Location = new System.Drawing.Point(4, 26);
            this.DetailsTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DetailsTabPage.Name = "DetailsTabPage";
            this.DetailsTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DetailsTabPage.Size = new System.Drawing.Size(907, 475);
            this.DetailsTabPage.TabIndex = 1;
            this.DetailsTabPage.Text = "详情";
            this.DetailsTabPage.UseVisualStyleBackColor = true;
            // 
            // DetailsPropertyGrid
            // 
            this.DetailsPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsPropertyGrid.HelpVisible = false;
            this.DetailsPropertyGrid.Location = new System.Drawing.Point(4, 4);
            this.DetailsPropertyGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DetailsPropertyGrid.Name = "DetailsPropertyGrid";
            this.DetailsPropertyGrid.Size = new System.Drawing.Size(899, 467);
            this.DetailsPropertyGrid.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(902, 17);
            this.StatusLabel.Spring = true;
            this.StatusLabel.Text = "Ready";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FxcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 541);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FxcForm";
            this.Text = "着色器查看器 - CodeWalker by dexyfex";
            this.MainTabControl.ResumeLayout(false);
            this.ShadersTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ShaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShaderTextBox)).EndInit();
            this.TechniquesTabPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.TechniquePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TechniqueTextBox)).EndInit();
            this.DetailsTabPage.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ShadersTabPage;
        private System.Windows.Forms.TabPage DetailsTabPage;
        private WinForms.PropertyGridFix DetailsPropertyGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel ShaderPanel;
        private System.Windows.Forms.ListView ShadersListView;
        private System.Windows.Forms.ColumnHeader ShadersNameColumn;
        private FastColoredTextBoxNS.FastColoredTextBox ShaderTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TabPage TechniquesTabPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView TechniquesListView;
        private System.Windows.Forms.ColumnHeader TechniquesNameColumn;
        private System.Windows.Forms.Panel TechniquePanel;
        private FastColoredTextBoxNS.FastColoredTextBox TechniqueTextBox;
    }
}