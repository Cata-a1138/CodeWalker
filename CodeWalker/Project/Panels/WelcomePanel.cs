using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace CodeWalker.Project.Panels
{
    public partial class WelcomePanel : ProjectPanel
    {
        public WelcomePanel()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // https://www.youtube.com/watch?v=FKQIxunb26k
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=FKQIxunb26k");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // https://www.youtube.com/watch?v=2WbLb3NCrrg
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=2WbLb3NCrrg");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // https://www.youtube.com/watch?v=vDYllxY7ReY
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=vDYllxY7ReY");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // https://www.bilibili.com/video/BV1HN4y197VN/
            System.Diagnostics.Process.Start("https://www.bilibili.com/video/BV1HN4y197VN/");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // https://www.bilibili.com/video/BV1u94y1x7M2/
            System.Diagnostics.Process.Start("https://www.bilibili.com/video/BV1u94y1x7M2/");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // https://www.bilibili.com/video/BV1Mp4y177Wg/
            System.Diagnostics.Process.Start("https://www.bilibili.com/video/BV1Mp4y177Wg/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // https://www.bilibili.com/video/BV1Lj41127HQ/
            System.Diagnostics.Process.Start("https://www.bilibili.com/video/BV1Lj41127HQ/");
        }
    }
}
