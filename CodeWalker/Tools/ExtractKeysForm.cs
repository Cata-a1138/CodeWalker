using CodeWalker.GameFiles;
using CodeWalker.Properties;
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

namespace CodeWalker.Tools
{
    public partial class ExtractKeysForm : Form
    {
        private volatile bool KeysLoaded = false;
        private volatile bool InProgress = false;
        private volatile bool AbortOperation = false;

        public ExtractKeysForm()
        {
            InitializeComponent();
        }

        private void ExtractKeysForm_Load(object sender, EventArgs e)
        {
            FolderTextBox.Text = GTAFolder.CurrentGTAFolder;

            try
            {
                GTA5Keys.LoadFromPath(GTAFolder.CurrentGTAFolder, Settings.Default.Key);
                KeysLoaded = true;
                UpdateStatus("秘钥已加载！");
            }
            catch
            {
                //default label text has this case
                //UpdateStatus("Keys not found! Please scan a GTA 5 exe...");
            }
        }

        private void FolderBrowseButton_Click(object sender, EventArgs e)
        {
            GTAFolder.UpdateGTAFolder(false);
            FolderTextBox.Text = GTAFolder.CurrentGTAFolder;
            ExeTextBox.Text = GTAFolder.CurrentGTAFolder + @"\GTA5.exe";
        }

        private void ExeBrowseButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FolderTextBox.Text) && !string.IsNullOrEmpty(ExeTextBox.Text))
            {
                OpenFileDialog.InitialDirectory = FolderTextBox.Text;
                OpenFileDialog.FileName = ExeTextBox.Text;
            }
            DialogResult res = OpenFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                ExeTextBox.Text = OpenFileDialog.FileName;
            }
        }


        private void UpdateStatus(string text)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => { UpdateStatus(text); }));
                }
                else
                {
                    StatusLabel.Text = text;
                }
            }
            catch { }
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            if (InProgress) return;
            if (KeysLoaded)
            {
                if (MessageBox.Show("秘钥已经加载过了，您确定要再次进行导出？", "秘钥已加载", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }
            }


            InProgress = true;
            AbortOperation = false;

            string exepath = ExeTextBox.Text;

            Task.Run(() =>
            {
                try
                {

                    if (AbortOperation)
                    {
                        UpdateStatus("秘钥导出已取消");
                        return;
                    }

                    FileInfo dmpfi = new FileInfo(exepath);

                    UpdateStatus(string.Format("正在扫描 {0} 获取秘钥...", dmpfi.Name));


                    byte[] exedat = File.ReadAllBytes(exepath);
                    GTA5Keys.GenerateV2(exedat, UpdateStatus);


                    UpdateStatus("正在保存已找到的秘钥...");

                    Settings.Default.Key = Convert.ToBase64String(GTA5Keys.PC_AES_KEY);
                    Settings.Default.Save();
                    //GTA5Keys.SaveToPath();

                    UpdateStatus("密钥已经成功导出！");
                    KeysLoaded = true;
                    InProgress = false;
                }
                catch (Exception ex)
                {
                    UpdateStatus("错误 - " + ex.ToString());

                    InProgress = false;
                }
            });
        }
    }
}
