using CodeWalker.GameFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeWalker.Tools
{
    public partial class JenkGenForm : Form
    {
        public JenkGenForm()
        {
            InitializeComponent();
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            GenerateHash();
        }

        private void GenerateHash()
        {
            JenkHashInputEncoding encoding = JenkHashInputEncoding.UTF8;
            if (ASCIIRadioButton.Checked) encoding = JenkHashInputEncoding.ASCII;

            /* JenkHash h = new JenkHash(InputTextBox.Text, encoding);

            HashHexTextBox.Text = h.HashHex;
            HashSignedTextBox.Text = h.HashInt.ToString();
            HashUnsignedTextBox.Text = h.HashUint.ToString(); */

            HashHexTextBox.Text = "";
            HashSignedTextBox.Text = "";
            HashUnsignedTextBox.Text = "";

            // explode the input into lines
            string[] lines = InputTextBox.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            foreach (string line in lines) {
                JenkHash h = new JenkHash(line, encoding);
                HashHexTextBox.Text += h.HashHex + "\r\n";
                HashSignedTextBox.Text += h.HashInt.ToString() + "\r\n";
                HashUnsignedTextBox.Text += h.HashUint.ToString() + "\r\n";
            }
        }

    }
}
