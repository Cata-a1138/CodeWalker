namespace CodeWalker.World
{
    partial class CutsceneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CutsceneForm));
            this.label3 = new System.Windows.Forms.Label();
            this.CutsceneComboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CutsceneTreeView = new System.Windows.Forms.TreeView();
            this.InfoPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.AnimateCameraCheckBox = new System.Windows.Forms.CheckBox();
            this.TimeTrackBar = new System.Windows.Forms.TrackBar();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PlayStopButton = new System.Windows.Forms.Button();
            this.PlaybackTimer = new System.Windows.Forms.Timer(this.components);
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.SubtitlesCheckBox = new System.Windows.Forms.CheckBox();
            this.AudioCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "动画：";
            // 
            // CutsceneComboBox
            // 
            this.CutsceneComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CutsceneComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CutsceneComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CutsceneComboBox.FormattingEnabled = true;
            this.CutsceneComboBox.Location = new System.Drawing.Point(71, 6);
            this.CutsceneComboBox.Name = "CutsceneComboBox";
            this.CutsceneComboBox.Size = new System.Drawing.Size(639, 20);
            this.CutsceneComboBox.TabIndex = 1;
            this.CutsceneComboBox.SelectedIndexChanged += new System.EventHandler(this.CutsceneComboBox_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 91);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CutsceneTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.InfoPropertyGrid);
            this.splitContainer1.Size = new System.Drawing.Size(722, 333);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 13;
            // 
            // CutsceneTreeView
            // 
            this.CutsceneTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CutsceneTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CutsceneTreeView.FullRowSelect = true;
            this.CutsceneTreeView.HideSelection = false;
            this.CutsceneTreeView.Location = new System.Drawing.Point(0, 0);
            this.CutsceneTreeView.Name = "CutsceneTreeView";
            this.CutsceneTreeView.ShowLines = false;
            this.CutsceneTreeView.ShowRootLines = false;
            this.CutsceneTreeView.Size = new System.Drawing.Size(259, 333);
            this.CutsceneTreeView.TabIndex = 14;
            this.CutsceneTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CutsceneTreeView_AfterSelect);
            // 
            // InfoPropertyGrid
            // 
            this.InfoPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPropertyGrid.HelpVisible = false;
            this.InfoPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.InfoPropertyGrid.Name = "InfoPropertyGrid";
            this.InfoPropertyGrid.Size = new System.Drawing.Size(459, 333);
            this.InfoPropertyGrid.TabIndex = 15;
            // 
            // AnimateCameraCheckBox
            // 
            this.AnimateCameraCheckBox.AutoSize = true;
            this.AnimateCameraCheckBox.Checked = true;
            this.AnimateCameraCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnimateCameraCheckBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AnimateCameraCheckBox.Location = new System.Drawing.Point(250, 66);
            this.AnimateCameraCheckBox.Name = "AnimateCameraCheckBox";
            this.AnimateCameraCheckBox.Size = new System.Drawing.Size(75, 21);
            this.AnimateCameraCheckBox.TabIndex = 8;
            this.AnimateCameraCheckBox.Text = "相机动画";
            this.AnimateCameraCheckBox.UseVisualStyleBackColor = true;
            this.AnimateCameraCheckBox.CheckedChanged += new System.EventHandler(this.AnimateCameraCheckBox_CheckedChanged);
            // 
            // TimeTrackBar
            // 
            this.TimeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTrackBar.AutoSize = false;
            this.TimeTrackBar.LargeChange = 0;
            this.TimeTrackBar.Location = new System.Drawing.Point(12, 31);
            this.TimeTrackBar.Maximum = 100;
            this.TimeTrackBar.Name = "TimeTrackBar";
            this.TimeTrackBar.Size = new System.Drawing.Size(700, 28);
            this.TimeTrackBar.TabIndex = 2;
            this.TimeTrackBar.Scroll += new System.EventHandler(this.TimeTrackBar_Scroll);
            this.TimeTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TimeTrackBar_MouseUp);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLabel.Location = new System.Drawing.Point(103, 62);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(129, 22);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "0.00 / 0.00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayStopButton
            // 
            this.PlayStopButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayStopButton.Location = new System.Drawing.Point(13, 59);
            this.PlayStopButton.Name = "PlayStopButton";
            this.PlayStopButton.Size = new System.Drawing.Size(75, 31);
            this.PlayStopButton.TabIndex = 3;
            this.PlayStopButton.Text = "播放";
            this.PlayStopButton.UseVisualStyleBackColor = true;
            this.PlayStopButton.Click += new System.EventHandler(this.PlayStopButton_Click);
            // 
            // PlaybackTimer
            // 
            this.PlaybackTimer.Tick += new System.EventHandler(this.PlaybackTimer_Tick);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VolumeLabel.Location = new System.Drawing.Point(549, 69);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(48, 17);
            this.VolumeLabel.TabIndex = 11;
            this.VolumeLabel.Text = "🕩 音量";
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeTrackBar.AutoSize = false;
            this.VolumeTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.VolumeTrackBar.LargeChange = 10;
            this.VolumeTrackBar.Location = new System.Drawing.Point(605, 66);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(105, 26);
            this.VolumeTrackBar.TabIndex = 12;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeTrackBar.Value = 50;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // SubtitlesCheckBox
            // 
            this.SubtitlesCheckBox.AutoSize = true;
            this.SubtitlesCheckBox.Checked = true;
            this.SubtitlesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SubtitlesCheckBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubtitlesCheckBox.Location = new System.Drawing.Point(368, 66);
            this.SubtitlesCheckBox.Name = "SubtitlesCheckBox";
            this.SubtitlesCheckBox.Size = new System.Drawing.Size(51, 21);
            this.SubtitlesCheckBox.TabIndex = 9;
            this.SubtitlesCheckBox.Text = "字幕";
            this.SubtitlesCheckBox.UseVisualStyleBackColor = true;
            this.SubtitlesCheckBox.CheckedChanged += new System.EventHandler(this.SubtitlesCheckBox_CheckedChanged);
            // 
            // AudioCheckBox
            // 
            this.AudioCheckBox.AutoSize = true;
            this.AudioCheckBox.Checked = true;
            this.AudioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AudioCheckBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AudioCheckBox.Location = new System.Drawing.Point(450, 66);
            this.AudioCheckBox.Name = "AudioCheckBox";
            this.AudioCheckBox.Size = new System.Drawing.Size(51, 21);
            this.AudioCheckBox.TabIndex = 10;
            this.AudioCheckBox.Text = "音频";
            this.AudioCheckBox.UseVisualStyleBackColor = true;
            this.AudioCheckBox.CheckedChanged += new System.EventHandler(this.AudioCheckBox_CheckedChanged);
            // 
            // CutsceneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 426);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.AudioCheckBox);
            this.Controls.Add(this.SubtitlesCheckBox);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.PlayStopButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeTrackBar);
            this.Controls.Add(this.AnimateCameraCheckBox);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CutsceneComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CutsceneForm";
            this.Text = "动画查看器 - CodeWalker by dexyfex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CutsceneForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CutsceneForm_FormClosed);
            this.Load += new System.EventHandler(this.CutsceneForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CutsceneComboBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView CutsceneTreeView;
        private System.Windows.Forms.PropertyGrid InfoPropertyGrid;
        private System.Windows.Forms.CheckBox AnimateCameraCheckBox;
        private System.Windows.Forms.TrackBar TimeTrackBar;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button PlayStopButton;
        private System.Windows.Forms.Timer PlaybackTimer;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.CheckBox SubtitlesCheckBox;
        private System.Windows.Forms.CheckBox AudioCheckBox;
    }
}