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
    public partial class JenkIndForm : Form
    {
        Dictionary<uint, string> extraStrings = new Dictionary<uint, string>();



        public JenkIndForm(GameFileCache gameFileCache = null)
        {
            InitializeComponent();

            if (GlobalText.FullIndexBuilt)
            {
                IndexBuildComplete();
            }
            else
            {
                MainPanel.Enabled = false;
                Cursor = Cursors.WaitCursor;

                if ((gameFileCache == null) || (gameFileCache.IsInited == false))
                {
                    Task.Run(() =>
                    {
                        GTA5Keys.LoadFromPath(GTAFolder.CurrentGTAFolder, Settings.Default.Key);
                        GameFileCache gfc = GameFileCacheFactory.Create();
                        gfc.DoFullStringIndex = true;
                        gfc.Init(UpdateStatus, UpdateStatus);
                        IndexBuildComplete();
                    });
                }
                else
                {
                    Task.Run(() =>
                    {
                        UpdateStatus("正在加载字符串...");
                        gameFileCache.DoFullStringIndex = true;
                        gameFileCache.InitStringDicts();
                        IndexBuildComplete();
                    });
                }
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
        private void IndexBuildComplete()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => { IndexBuildComplete(); }));
                }
                else
                {
                    StatusLabel.Text = "索引建立";
                    MainPanel.Enabled = true;
                    Cursor = Cursors.Default;
                }
            }
            catch { }
        }


        private void FindHash()
        {
            uint hash = 0;
            string hashtxt = HashTextBox.Text;
            MatchTextBox.Text = "";
            if (HexRadioButton.Checked)
            {
                try
                {
                    hash = Convert.ToUInt32(hashtxt, 16);
                }
                catch
                {
                    StatusLabel.Text = "无效的十六进制数值！";
                    return;
                }
            }
            else if (UnsignedRadioButton.Checked)
            {
                try
                {
                    hash = uint.Parse(hashtxt);
                }
                catch
                {
                    StatusLabel.Text = "无效的无符号整数值！";
                    return;
                }
            }
            else if (SignedRadioButton.Checked)
            {
                try
                {
                    hash = (uint)int.Parse(hashtxt);
                }
                catch
                {
                    StatusLabel.Text = "无效的整数值！";
                    return;
                }
            }
            StatusLabel.Text = Convert.ToString(hash, 16).ToUpper().PadLeft(8, '0');


            var str = JenkIndex.TryGetString(hash);
            var txt = GlobalText.TryGetString(hash);
            var sta = StatsNames.TryGetString(hash);
            var ext = TryGetExtraString(hash);
            bool hasstr = !string.IsNullOrEmpty(str);
            bool hastxt = !string.IsNullOrEmpty(txt);
            bool hasext = !string.IsNullOrEmpty(ext);
            bool hassta = !string.IsNullOrEmpty(sta);

            if (hasstr && hastxt)
            {
                MatchTextBox.Text = string.Format("索引匹配：\r\n{0}\r\n全局文本匹配：\r\n{1}", str, txt);
            }
            else if (hasstr)
            {
                MatchTextBox.Text = str;
            }
            else if (hastxt)
            {
                MatchTextBox.Text = "全局文本匹配：\r\n" + txt;
            }
            else if (hasext)
            {
                MatchTextBox.Text = "扩展字符串匹配：\r\n" + ext;
            }
            else if (hassta)
            {
                MatchTextBox.Text = "总计匹配：\r\n" + sta;
            }
            else
            {
                MatchTextBox.Text = "[未找到匹配项]";
            }


        }


        private string TryGetExtraString(uint hash)
        {
            string str;
            extraStrings.TryGetValue(hash, out str);
            return str;
        }


        private void HashTextBox_TextChanged(object sender, EventArgs e)
        {
            FindHash();
        }

        private void HexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FindHash();
        }

        private void UnsignedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FindHash();
        }

        private void SignedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FindHash();
        }

        private void LoadStringsButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            string file = OpenFileDialog.FileName;
            if (!File.Exists(file))
            {
                return;
            }

            try
            {
                string txt = File.ReadAllText(file);
                string[] lines = txt.Split('\n');
                foreach (string line in lines)
                {
                    string str = line.Trim();
                    if (str.Length > 2) //remove double quotes from start and end, if both present...
                    {
                        if ((str[0] == '\"') && (str[str.Length - 1] == '\"'))
                        {
                            str = str.Substring(1, str.Length - 2);
                        }
                    }
                    var hash = JenkHash.GenHash(str);
                    extraStrings[hash] = str;
                }
                MessageBox.Show(lines.Length.ToString() + " 字符串已成功导入");
            }
            catch
            {
                MessageBox.Show("读取文件时发生错误");
            }

        }

        private void SaveStringsButton_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            string file = SaveFileDialog.FileName;

            try
            {
                string[] lines = JenkIndex.GetAllStrings();

                File.WriteAllLines(file, lines);

                MessageBox.Show(lines.Length.ToString() + " 字符串已成功导出");
            }
            catch
            {
                MessageBox.Show("写入文件时发生错误");
            }
        }
    }
}
