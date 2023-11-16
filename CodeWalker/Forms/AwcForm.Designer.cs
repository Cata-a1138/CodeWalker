namespace CodeWalker.Forms
{
    partial class AwcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AwcForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.PlayerTabPage = new System.Windows.Forms.TabPage();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.chbAutoJump = new System.Windows.Forms.CheckBox();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PlayListView = new System.Windows.Forms.ListView();
            this.PlaylistNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaylistTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaylistLengthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaylistSizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExportAsWav = new System.Windows.Forms.ToolStripMenuItem();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.PositionTrackBar = new System.Windows.Forms.TrackBar();
            this.DetailsTabPage = new System.Windows.Forms.TabPage();
            this.DetailsPropertyGrid = new CodeWalker.WinForms.PropertyGridFix();
            this.XmlTabPage = new System.Windows.Forms.TabPage();
            this.XmlTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainTabControl.SuspendLayout();
            this.PlayerTabPage.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionTrackBar)).BeginInit();
            this.DetailsTabPage.SuspendLayout();
            this.XmlTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XmlTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.PlayerTabPage);
            this.MainTabControl.Controls.Add(this.DetailsTabPage);
            this.MainTabControl.Controls.Add(this.XmlTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(827, 545);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // PlayerTabPage
            // 
            this.PlayerTabPage.Controls.Add(this.LabelInfo);
            this.PlayerTabPage.Controls.Add(this.LabelTime);
            this.PlayerTabPage.Controls.Add(this.StopButton);
            this.PlayerTabPage.Controls.Add(this.VolumeLabel);
            this.PlayerTabPage.Controls.Add(this.chbAutoJump);
            this.PlayerTabPage.Controls.Add(this.PrevButton);
            this.PlayerTabPage.Controls.Add(this.NextButton);
            this.PlayerTabPage.Controls.Add(this.PlayButton);
            this.PlayerTabPage.Controls.Add(this.PlayListView);
            this.PlayerTabPage.Controls.Add(this.VolumeTrackBar);
            this.PlayerTabPage.Controls.Add(this.PositionTrackBar);
            this.PlayerTabPage.Location = new System.Drawing.Point(4, 26);
            this.PlayerTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerTabPage.Name = "PlayerTabPage";
            this.PlayerTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerTabPage.Size = new System.Drawing.Size(819, 515);
            this.PlayerTabPage.TabIndex = 0;
            this.PlayerTabPage.Text = "播放器";
            this.PlayerTabPage.UseVisualStyleBackColor = true;
            // 
            // LabelInfo
            // 
            this.LabelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.Location = new System.Drawing.Point(9, 391);
            this.LabelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(0, 17);
            this.LabelInfo.TabIndex = 12;
            // 
            // LabelTime
            // 
            this.LabelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTime.Location = new System.Drawing.Point(488, 472);
            this.LabelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(133, 23);
            this.LabelTime.TabIndex = 11;
            this.LabelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(246, 443);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(36, 30);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "◼";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(628, 449);
            this.VolumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(64, 17);
            this.VolumeLabel.TabIndex = 9;
            this.VolumeLabel.Text = "🕩 Volume";
            // 
            // chbAutoJump
            // 
            this.chbAutoJump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbAutoJump.AutoSize = true;
            this.chbAutoJump.Location = new System.Drawing.Point(20, 451);
            this.chbAutoJump.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbAutoJump.Name = "chbAutoJump";
            this.chbAutoJump.Size = new System.Drawing.Size(132, 21);
            this.chbAutoJump.TabIndex = 8;
            this.chbAutoJump.Text = "Auto-jump to next";
            this.chbAutoJump.UseVisualStyleBackColor = true;
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrevButton.Location = new System.Drawing.Point(160, 443);
            this.PrevButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(36, 30);
            this.PrevButton.TabIndex = 2;
            this.PrevButton.Text = "⏮";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NextButton.Location = new System.Drawing.Point(289, 443);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(36, 30);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "⏭";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayButton.Location = new System.Drawing.Point(203, 443);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(36, 30);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "▶";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PlayListView
            // 
            this.PlayListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlaylistNameHeader,
            this.PlaylistTypeHeader,
            this.PlaylistLengthHeader,
            this.PlaylistSizeHeader});
            this.PlayListView.ContextMenuStrip = this.contextMenuStrip;
            this.PlayListView.FullRowSelect = true;
            this.PlayListView.HideSelection = false;
            this.PlayListView.Location = new System.Drawing.Point(7, 8);
            this.PlayListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayListView.MultiSelect = false;
            this.PlayListView.Name = "PlayListView";
            this.PlayListView.Size = new System.Drawing.Size(803, 378);
            this.PlayListView.TabIndex = 0;
            this.PlayListView.UseCompatibleStateImageBehavior = false;
            this.PlayListView.View = System.Windows.Forms.View.Details;
            this.PlayListView.SelectedIndexChanged += new System.EventHandler(this.PlayListView_SelectedIndexChanged);
            this.PlayListView.DoubleClick += new System.EventHandler(this.PlayListView_DoubleClick);
            // 
            // PlaylistNameHeader
            // 
            this.PlaylistNameHeader.Text = "名称";
            this.PlaylistNameHeader.Width = 337;
            // 
            // PlaylistTypeHeader
            // 
            this.PlaylistTypeHeader.Text = "类型";
            this.PlaylistTypeHeader.Width = 110;
            // 
            // PlaylistLengthHeader
            // 
            this.PlaylistLengthHeader.Text = "长度";
            this.PlaylistLengthHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PlaylistLengthHeader.Width = 80;
            // 
            // PlaylistSizeHeader
            // 
            this.PlaylistSizeHeader.Text = "大小";
            this.PlaylistSizeHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PlaylistSizeHeader.Width = 80;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportAsWav});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(161, 26);
            // 
            // ExportAsWav
            // 
            this.ExportAsWav.Name = "ExportAsWav";
            this.ExportAsWav.Size = new System.Drawing.Size(160, 22);
            this.ExportAsWav.Text = "Export as .wav";
            this.ExportAsWav.Click += new System.EventHandler(this.ExportAsWav_Click);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeTrackBar.AutoSize = false;
            this.VolumeTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VolumeTrackBar.LargeChange = 10;
            this.VolumeTrackBar.Location = new System.Drawing.Point(686, 443);
            this.VolumeTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(122, 37);
            this.VolumeTrackBar.TabIndex = 6;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeTrackBar.Value = 50;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // PositionTrackBar
            // 
            this.PositionTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionTrackBar.AutoSize = false;
            this.PositionTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PositionTrackBar.LargeChange = 0;
            this.PositionTrackBar.Location = new System.Drawing.Point(7, 394);
            this.PositionTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PositionTrackBar.Maximum = 1000;
            this.PositionTrackBar.Name = "PositionTrackBar";
            this.PositionTrackBar.Size = new System.Drawing.Size(802, 42);
            this.PositionTrackBar.TabIndex = 1;
            this.PositionTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PositionTrackBar.Scroll += new System.EventHandler(this.PositionTrackBar_Scroll);
            this.PositionTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PositionTrackBar_MouseUp);
            // 
            // DetailsTabPage
            // 
            this.DetailsTabPage.Controls.Add(this.DetailsPropertyGrid);
            this.DetailsTabPage.Location = new System.Drawing.Point(4, 26);
            this.DetailsTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DetailsTabPage.Name = "DetailsTabPage";
            this.DetailsTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DetailsTabPage.Size = new System.Drawing.Size(819, 515);
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
            this.DetailsPropertyGrid.Size = new System.Drawing.Size(811, 507);
            this.DetailsPropertyGrid.TabIndex = 0;
            // 
            // XmlTabPage
            // 
            this.XmlTabPage.Controls.Add(this.XmlTextBox);
            this.XmlTabPage.Location = new System.Drawing.Point(4, 26);
            this.XmlTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XmlTabPage.Name = "XmlTabPage";
            this.XmlTabPage.Size = new System.Drawing.Size(819, 515);
            this.XmlTabPage.TabIndex = 2;
            this.XmlTabPage.Text = "XML";
            this.XmlTabPage.UseVisualStyleBackColor = true;
            // 
            // XmlTextBox
            // 
            this.XmlTextBox.AutoCompleteBracketsList = new char[] {
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
            this.XmlTextBox.AutoIndentChars = false;
            this.XmlTextBox.AutoIndentCharsPatterns = "";
            this.XmlTextBox.AutoIndentExistingLines = false;
            this.XmlTextBox.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.XmlTextBox.BackBrush = null;
            this.XmlTextBox.CharHeight = 14;
            this.XmlTextBox.CharWidth = 8;
            this.XmlTextBox.CommentPrefix = null;
            this.XmlTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.XmlTextBox.DelayedEventsInterval = 1;
            this.XmlTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.XmlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XmlTextBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.XmlTextBox.IsReplaceMode = false;
            this.XmlTextBox.Language = FastColoredTextBoxNS.Language.XML;
            this.XmlTextBox.LeftBracket = '<';
            this.XmlTextBox.LeftBracket2 = '(';
            this.XmlTextBox.Location = new System.Drawing.Point(0, 0);
            this.XmlTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.XmlTextBox.Name = "XmlTextBox";
            this.XmlTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.XmlTextBox.RightBracket = '>';
            this.XmlTextBox.RightBracket2 = ')';
            this.XmlTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.XmlTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("XmlTextBox.ServiceColors")));
            this.XmlTextBox.Size = new System.Drawing.Size(819, 515);
            this.XmlTextBox.TabIndex = 2;
            this.XmlTextBox.Zoom = 100;
            this.XmlTextBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.XmlTextBox_TextChanged);
            this.XmlTextBox.VisibleRangeChangedDelayed += new System.EventHandler(this.XmlTextBox_VisibleRangeChangedDelayed);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 25;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "wav";
            this.saveFileDialog.Filter = "Wave files (*.wav)|*.wav";
            // 
            // AwcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 545);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(688, 380);
            this.Name = "AwcForm";
            this.Text = "音频播放器 - CodeWalker by dexyfex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AwcForm_FormClosing);
            this.MainTabControl.ResumeLayout(false);
            this.PlayerTabPage.ResumeLayout(false);
            this.PlayerTabPage.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionTrackBar)).EndInit();
            this.DetailsTabPage.ResumeLayout(false);
            this.XmlTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XmlTextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage PlayerTabPage;
        private System.Windows.Forms.TabPage DetailsTabPage;
        private WinForms.PropertyGridFix DetailsPropertyGrid;
        private System.Windows.Forms.ListView PlayListView;
        private System.Windows.Forms.ColumnHeader PlaylistNameHeader;
        private System.Windows.Forms.ColumnHeader PlaylistTypeHeader;
        private System.Windows.Forms.ColumnHeader PlaylistLengthHeader;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.TrackBar PositionTrackBar;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox chbAutoJump;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExportAsWav;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ColumnHeader PlaylistSizeHeader;
        private System.Windows.Forms.TabPage XmlTabPage;
        private FastColoredTextBoxNS.FastColoredTextBox XmlTextBox;
    }
}