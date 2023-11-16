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
    public partial class ExtractScriptsForm : Form
    {
        private volatile bool KeysLoaded = false;
        private volatile bool InProgress = false;
        private volatile bool AbortOperation = false;


        public ExtractScriptsForm()
        {
            InitializeComponent();
        }

        private void ExtractForm_Load(object sender, EventArgs e)
        {
            DumpTextBox.Text = Settings.Default.GTAExeDumpFile;
            FolderTextBox.Text = GTAFolder.CurrentGTAFolder;
            OutputFolderTextBox.Text = Settings.Default.CompiledScriptFolder;

            try
            {
                GTA5Keys.LoadFromPath(GTAFolder.CurrentGTAFolder, Settings.Default.Key);
                KeysLoaded = true;
                UpdateDumpStatus("就绪。");
                UpdateExtractStatus("已准备好导出。");
            }
            catch
            {
                UpdateDumpStatus("秘钥未找到！这不应该发生！");
            }
        }

        private void DumpTextBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.GTAExeDumpFile = DumpTextBox.Text;
        }

        private void OutputFolderTextBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.CompiledScriptFolder = OutputFolderTextBox.Text;
        }

        private void FolderBrowseButton_Click(object sender, EventArgs e)
        {
            GTAFolder.UpdateGTAFolder(false);
            FolderTextBox.Text = GTAFolder.CurrentGTAFolder;
        }

        private void OutputFolderBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog.SelectedPath = OutputFolderTextBox.Text;
            DialogResult res = FolderBrowserDialog.ShowDialogNew();
            if (res == DialogResult.OK)
            {
                OutputFolderTextBox.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void DumpBrowseButton_Click(object sender, EventArgs e)
        {

            DialogResult res = OpenFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                DumpTextBox.Text = OpenFileDialog.FileName;
            }

        }

        private void FindKeysButton_Click(object sender, EventArgs e)
        {
            if (InProgress) return;
            if (KeysLoaded)
            {
                if (MessageBox.Show("秘钥已经加载了，您确定要重新进行秘钥转储吗？", "秘钥已加载", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }
            }


            InProgress = true;
            AbortOperation = false;

            string dmppath = DumpTextBox.Text;

            Task.Run(() =>
            {
                try
                {

                    if (AbortOperation)
                    {
                        UpdateDumpStatus("转储扫描取消。");
                        return;
                    }

                    FileInfo dmpfi = new FileInfo(dmppath);

                    UpdateDumpStatus(string.Format("正在扫描 {0} 以获取秘钥...", dmpfi.Name));


                    byte[] exedat = File.ReadAllBytes(dmppath);
                    GTA5Keys.Generate(exedat, UpdateDumpStatus);


                    UpdateDumpStatus("正在保存秘钥...");

                    GTA5Keys.SaveToPath();

                    UpdateDumpStatus("秘钥已加载。");
                    UpdateExtractStatus("秘钥已加载，准备开始扫描。");
                    KeysLoaded = true;
                    InProgress = false;
                }
                catch (Exception ex)
                {
                    UpdateDumpStatus("错误 - " + ex.ToString());

                    InProgress = false;
                }
            });
        }

        private void ExtractScriptsButton_Click(object sender, EventArgs e)
        {
            if (InProgress) return;

            if (!KeysLoaded)
            {
                MessageBox.Show("请选择 GTA5 EXE 来进行扫描，或者将秘钥放在程序目录下！");
                return;
            }
            if (!Directory.Exists(FolderTextBox.Text))
            {
                MessageBox.Show("文件夹不存在：" + FolderTextBox.Text);
                return;
            }
            if (!Directory.Exists(OutputFolderTextBox.Text))
            {
                MessageBox.Show("文件夹不存在：" + OutputFolderTextBox.Text);
                return;
            }
            if (Directory.GetFiles(OutputFolderTextBox.Text, "*.ysc", SearchOption.AllDirectories).Length > 0)
            {
                if (MessageBox.Show("输出目录下已经存在 ysc 文件，您确定要继续吗？", "文件已存在", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }
            }

            InProgress = true;
            AbortOperation = false;

            string searchpath = FolderTextBox.Text;
            string outputpath = OutputFolderTextBox.Text;
            string replpath = searchpath + "\\";

            Task.Run(() =>
            {

                UpdateExtractStatus("秘钥已加载。");

                string[] allfiles = Directory.GetFiles(searchpath, "*.rpf", SearchOption.AllDirectories);
                foreach (string rpfpath in allfiles)
                {
                    RpfFile rf = new RpfFile(rpfpath, rpfpath.Replace(replpath, ""));
                    UpdateExtractStatus("正在搜索 " + rf.Name + "...");
                    rf.ExtractScripts(outputpath, UpdateExtractStatus);
                }

                UpdateExtractStatus("完成。");
                InProgress = false;
            });
        }



        private void UpdateDumpStatus(string text)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => { UpdateDumpStatus(text); }));
                }
                else
                {
                    DumpStatusLabel.Text = text;
                }
            }
            catch { }
        }

        private void UpdateExtractStatus(string text)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => { UpdateExtractStatus(text); }));
                }
                else
                {
                    ExtractStatusLabel.Text = text;
                }
            }
            catch { }
        }

    }
}
