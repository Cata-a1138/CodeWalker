﻿using CodeWalker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeWalker.Utils
{
    public partial class SelectFolderForm : Form
    {

        public string SelectedFolder { get; set; }
        public DialogResult Result { get; set; } = DialogResult.Cancel;

        public SelectFolderForm()
        {
            InitializeComponent();
            SelectedFolder = GTAFolder.CurrentGTAFolder;
        }

        private void SelectFolderForm_Load(object sender, EventArgs e)
        {
            FolderTextBox.Text = SelectedFolder;
            RememberFolderCheckbox.Checked = Settings.Default.RememberGTAFolder;
        }

        private void FolderBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog.SelectedPath = FolderTextBox.Text;
            DialogResult res = FolderBrowserDialog.ShowDialogNew();
            if (res == DialogResult.OK)
            {
                FolderTextBox.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void FolderTextBox_TextChanged(object sender, EventArgs e)
        {
            SelectedFolder = FolderTextBox.Text;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(!GTAFolder.ValidateGTAFolder(SelectedFolder, out string failReason))
            {
                MessageBox.Show("所选择的目录无法使用：\n\n" + failReason, "无效的 GTA5 目录", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Result = DialogResult.OK;
            Close();
        }

        private void RememberFolderCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.RememberGTAFolder = RememberFolderCheckbox.Checked;
        }
    }
}
