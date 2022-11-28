using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using YoutubeExtractor;
using System.IO;
using System.Threading;

namespace YoutubeDownloader
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void lblQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmAccueil_Load(object sender, EventArgs e)
        {
            cboResolution.SelectedIndex = 0;
        }

        private void btnTelecharger_Click(object sender, EventArgs e)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(txtUrl.Text);
            VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(cboResolution.Text));
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);
            VideoDownloader downloader = new VideoDownloader(video, Path.Combine(Application.StartupPath + "\\", video.Title + video.VideoExtension));
            downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;
            Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
            thread.Start();
        }

        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar.Value = (int)e.ProgressPercentage;
                lblPourc.Text = $"{string.Format("0:0.##",e.ProgressPercentage)}%";
                progressBar.Update();
            }));
        }
    }
}
