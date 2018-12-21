using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using System.IO;
using System.Diagnostics;

namespace ImageText
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Text += $"[{DevCommon.Version},{DevCommon.VersionTime}]";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "picture|*.png;*.bmp;*.jpg;";
            if(ofd.ShowDialog(this) == DialogResult.OK)
            {
                this.pic.BackgroundImage = new Bitmap(ofd.FileName);
                this.pic.Tag = ofd.FileName;
            }
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> draw = new Image<Bgr, byte>(this.pic.Tag as string);
            draw.Draw(this.txtContent.Text, new Point(100, 100), FontFace.HersheyDuplex, 5, new Bgr(0, 255, 255), 10);
            this.pic.BackgroundImage = draw.ToBitmap();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string fileName = @"tim55g.jpg";
            this.pic.BackgroundImage = new Bitmap(fileName);
            this.pic.Tag = fileName;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "picture|*.jpg;*.bmp;*.png";
            if(sfd.ShowDialog(this) == DialogResult.OK)
            {
                this.pic.BackgroundImage.Save(sfd.FileName);
            }
        }

        private void btnMany_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                string path = @"D:\BaiduNetdiskDownload\动漫";
                string savePath = Path.Combine(path, "many");
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);
                }
                foreach (string fileName in Directory.GetFiles(path))
                {
                    Image<Bgr, byte> img = new Image<Bgr, byte>(fileName);
                    img.Draw(this.txtContent.Text, new Point(100, 100), FontFace.HersheyDuplex, 5, new Bgr(0, 255, 255), 10);
                    string name = Path.GetFileName(fileName);
                    string saveAsFileName = Path.Combine(savePath, name);
                    img.Save(saveAsFileName);
                    img.Dispose();
                }
                stopwatch.Stop();
                Action action = () => {
                    this.Text = stopwatch.Elapsed.ToString();
                };
                this.Invoke(action);
            });
           
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            FrmVideo frmVideo = new FrmVideo();
            if(frmVideo.ShowDialog(this) == DialogResult.OK)
            {

            }
        }
    }
}
