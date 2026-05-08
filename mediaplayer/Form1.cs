using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaplayer
{
    public partial class frmMediaPlayer : Form
    {
        public frmMediaPlayer()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WMV files (*.wmv)|*.wmv|MP4files(*.mp4) | *.mp4 | AVI files(*.avi) | *.avi | All files(*.*) | *.* ";
if (ofd.ShowDialog() == DialogResult.OK)
            {
                wmpVideo.URL = ofd.FileName;
                wmpVideo.Ctlcontrols.stop(); // 停止
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play(); // 播放
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause(); // 暫停
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop(); // 停止
        }

        private void frmMediaPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("確定要關閉應用程式嗎？", "關閉確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // 取消關閉
            }
        }
    }
}
