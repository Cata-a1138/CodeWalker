namespace CodeWalker.Forms
{
    partial class YwrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YwrForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.MainListView = new System.Windows.Forms.ListView();
            this.XPosColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YPosColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ZPosColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unk0Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unk1Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unk2Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unk3Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExportButton = new System.Windows.Forms.Button();
            this.CopyClipboardButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(485, 474);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(88, 29);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "关闭";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MainListView
            // 
            this.MainListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.XPosColumn,
            this.YPosColumn,
            this.ZPosColumn,
            this.Unk0Column,
            this.Unk1Column,
            this.Unk2Column,
            this.Unk3Column});
            this.MainListView.HideSelection = false;
            this.MainListView.Location = new System.Drawing.Point(15, 17);
            this.MainListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainListView.Name = "MainListView";
            this.MainListView.Size = new System.Drawing.Size(557, 445);
            this.MainListView.TabIndex = 4;
            this.MainListView.UseCompatibleStateImageBehavior = false;
            this.MainListView.View = System.Windows.Forms.View.Details;
            // 
            // XPosColumn
            // 
            this.XPosColumn.Text = "坐标 X";
            this.XPosColumn.Width = 75;
            // 
            // YPosColumn
            // 
            this.YPosColumn.Text = "坐标 Y";
            this.YPosColumn.Width = 75;
            // 
            // ZPosColumn
            // 
            this.ZPosColumn.Text = "坐标 Z";
            this.ZPosColumn.Width = 75;
            // 
            // Unk0Column
            // 
            this.Unk0Column.Text = "Unk0";
            // 
            // Unk1Column
            // 
            this.Unk1Column.Text = "Unk1";
            // 
            // Unk2Column
            // 
            this.Unk2Column.Text = "Unk2";
            // 
            // Unk3Column
            // 
            this.Unk3Column.Text = "Unk3";
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Enabled = false;
            this.ExportButton.Location = new System.Drawing.Point(391, 474);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(88, 29);
            this.ExportButton.TabIndex = 5;
            this.ExportButton.Text = "导出";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // CopyClipboardButton
            // 
            this.CopyClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyClipboardButton.Enabled = false;
            this.CopyClipboardButton.Location = new System.Drawing.Point(264, 474);
            this.CopyClipboardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CopyClipboardButton.Name = "CopyClipboardButton";
            this.CopyClipboardButton.Size = new System.Drawing.Size(120, 29);
            this.CopyClipboardButton.TabIndex = 6;
            this.CopyClipboardButton.Text = "复制到剪切板";
            this.CopyClipboardButton.UseVisualStyleBackColor = true;
            this.CopyClipboardButton.Click += new System.EventHandler(this.CopyClipboardButton_Click);
            // 
            // YwrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(587, 513);
            this.Controls.Add(this.CopyClipboardButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.MainListView);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "YwrForm";
            this.Text = "导航记录查看器 - CodeWalker by dexyfex";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListView MainListView;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button CopyClipboardButton;
        private System.Windows.Forms.ColumnHeader XPosColumn;
        private System.Windows.Forms.ColumnHeader YPosColumn;
        private System.Windows.Forms.ColumnHeader ZPosColumn;
        private System.Windows.Forms.ColumnHeader Unk0Column;
        private System.Windows.Forms.ColumnHeader Unk1Column;
        private System.Windows.Forms.ColumnHeader Unk2Column;
        private System.Windows.Forms.ColumnHeader Unk3Column;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}