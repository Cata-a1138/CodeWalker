using CodeWalker.GameFiles;
using CodeWalker.Properties;
using CodeWalker.Utils;
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
    public partial class ExtractTexForm : Form
    {
        private volatile bool KeysLoaded = false;
        private volatile bool InProgress = false;
        private volatile bool AbortOperation = false;

        public ExtractTexForm()
        {
            InitializeComponent();
        }

        private void ExtractTexForm_Load(object sender, EventArgs e)
        {
            FolderTextBox.Text = GTAFolder.CurrentGTAFolder;
            OutputFolderTextBox.Text = Settings.Default.ExtractedTexturesFolder;

            try
            {
                GTA5Keys.LoadFromPath(GTAFolder.CurrentGTAFolder, Settings.Default.Key);
                KeysLoaded = true;
                UpdateExtractStatus("已准备好导出。");
            }
            catch
            {
                UpdateExtractStatus("未找到秘钥！这不应该发生！");
            }
        }

        private void OutputFolderTextBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.ExtractedTexturesFolder = OutputFolderTextBox.Text;
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

        private void ExtractButton_Click(object sender, EventArgs e)
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
            //if (Directory.GetFiles(OutputFolderTextBox.Text, "*.ysc", SearchOption.AllDirectories).Length > 0)
            //{
            //    if (MessageBox.Show("Output folder already contains .ysc files. Are you sure you want to continue?", "Output folder already contains .ysc files", MessageBoxButtons.OKCancel) != DialogResult.OK)
            //    {
            //        return;
            //    }
            //}

            InProgress = true;
            AbortOperation = false;

            string searchpath = FolderTextBox.Text;
            string outputpath = OutputFolderTextBox.Text;
            string replpath = searchpath + "\\";
            bool bytd = YtdChecBox.Checked;
            bool bydr = YdrCheckBox.Checked;
            bool bydd = YddCheckBox.Checked;
            bool byft = YftCheckBox.Checked;

            Task.Run(() =>
            {

                UpdateExtractStatus("秘钥已加载。");



                RpfManager rpfman = new RpfManager();
                rpfman.Init(searchpath, UpdateExtractStatus, UpdateExtractStatus);


                UpdateExtractStatus("开始导出纹理...");
                StringBuilder errsb = new StringBuilder();
                foreach (RpfFile rpf in rpfman.AllRpfs)
                {
                    foreach (RpfEntry entry in rpf.AllEntries)
                    {
                        if (AbortOperation)
                        {
                            UpdateExtractStatus("操作已取消");
                            InProgress = false;
                            return;
                        }
                        try
                        {
                            if (bytd && entry.NameLower.EndsWith(".ytd"))
                            {
                                UpdateExtractStatus(entry.Path);
                                YtdFile ytd = rpfman.GetFile<YtdFile>(entry);
                                if (ytd == null) throw new Exception("无法加载文件。");
                                if (ytd.TextureDict == null) throw new Exception("无法加载纹理字典。");
                                if (ytd.TextureDict.Textures == null) throw new Exception("无法加载纹理字典纹理数组");
                                if (ytd.TextureDict.Textures.data_items == null) throw new Exception("纹理字典内容为空...");
                                foreach (var tex in ytd.TextureDict.Textures.data_items)
                                {
                                    SaveTexture(tex, entry, outputpath);
                                }
                            }
                            else if (bydr && entry.NameLower.EndsWith(".ydr"))
                            {
                                UpdateExtractStatus(entry.Path);
                                YdrFile ydr = rpfman.GetFile<YdrFile>(entry);
                                if (ydr == null) throw new Exception("无法加载文件。");
                                if (ydr.Drawable == null) throw new Exception("无法加载可绘制模型。");
                                if (ydr.Drawable.ShaderGroup != null)
                                {
                                    var ydrtd = ydr.Drawable.ShaderGroup.TextureDictionary;
                                    if ((ydrtd != null) && (ydrtd.Textures != null) && (ydrtd.Textures.data_items != null))
                                    {
                                        foreach (var tex in ydrtd.Textures.data_items)
                                        {
                                            SaveTexture(tex, entry, outputpath);
                                        }
                                    }
                                }
                            }
                            else if (bydd && entry.NameLower.EndsWith(".ydd"))
                            {
                                UpdateExtractStatus(entry.Path);
                                YddFile ydd = rpfman.GetFile<YddFile>(entry);
                                if (ydd == null) throw new Exception("无法加载文件。");
                                //if (ydd.DrawableDict == null) throw new Exception("Couldn't load drawable dictionary.");
                                //if (ydd.DrawableDict.Drawables == null) throw new Exception("Drawable dictionary had no items...");
                                //if (ydd.DrawableDict.Drawables.data_items == null) throw new Exception("Drawable dictionary had no items...");
                                if ((ydd.Dict==null)||(ydd.Dict.Count==0)) throw new Exception("可绘制字典的内容为空...");
                                foreach (var drawable in ydd.Dict.Values)
                                {
                                    if (drawable.ShaderGroup != null)
                                    {
                                        var ydrtd = drawable.ShaderGroup.TextureDictionary;
                                        if ((ydrtd != null) && (ydrtd.Textures != null) && (ydrtd.Textures.data_items != null))
                                        {
                                            foreach (var tex in ydrtd.Textures.data_items)
                                            {
                                                SaveTexture(tex, entry, outputpath);
                                            }
                                        }
                                    }
                                }
                            }
                            else if (byft && entry.NameLower.EndsWith(".yft"))
                            {
                                UpdateExtractStatus(entry.Path);
                                YftFile yft = rpfman.GetFile<YftFile>(entry);
                                if (yft == null) throw new Exception("无法加载文件。");
                                if (yft.Fragment == null) throw new Exception("无法加载模型分段。");
                                if (yft.Fragment.Drawable != null)
                                {
                                    if (yft.Fragment.Drawable.ShaderGroup != null)
                                    {
                                        var ydrtd = yft.Fragment.Drawable.ShaderGroup.TextureDictionary;
                                        if ((ydrtd != null) && (ydrtd.Textures != null) && (ydrtd.Textures.data_items != null))
                                        {
                                            foreach (var tex in ydrtd.Textures.data_items)
                                            {
                                                SaveTexture(tex, entry, outputpath);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            string err = entry.Name + ": " + ex.Message;
                            UpdateExtractStatus(err);
                            errsb.AppendLine(err);
                        }

                    }
                }

                File.WriteAllText(outputpath + "\\_errors.txt", errsb.ToString());

                UpdateExtractStatus("完成。");
                InProgress = false;
            });
        }

        private void SaveTexture(Texture tex, RpfEntry entry, string folder)
        {

            //DirectXTex

            byte[] dds = DDSIO.GetDDSFile(tex);

            string bpath = folder + "\\" + entry.Name + "_" + tex.Name;
            string fpath = bpath + ".dds";
            int c = 1;
            while (File.Exists(fpath))
            {
                fpath = bpath + "_Copy" + c.ToString() + ".dds";
                c++;
            }

            File.WriteAllBytes(fpath, dds);

        }


        private void AbortButton_Click(object sender, EventArgs e)
        {
            AbortOperation = true;
        }

    }
}
