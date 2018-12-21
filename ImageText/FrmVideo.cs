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
using System.Threading;
using Emgu.CV.CvEnum;

namespace ImageText
{
    public partial class FrmVideo : FrmBaseDocument
    {
        private VideoCapture videoCapture;
        private int fps;
        private double FrameCount;
        private double index;
        public FrmVideo()
        {
            InitializeComponent();
            Application.Idle += this.Application_Idle;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            if(this.videoCapture != null)
            {
                //Mat mat = this.videoCapture.QueryFrame();
                Mat mat = new Mat();
                this.videoCapture.Read(mat);
                Image<Bgr, byte> img = mat.ToImage<Bgr, byte>();
                img.Draw("www.baidu.com", new Point(0, 100), FontFace.HersheyDuplex, 2, new Bgr(0, 255, 255), 2);
                this.picVideo.BackgroundImage = img.ToBitmap();
                //Thread.Sleep((int)(1000.0 / this.fps) - 5);
                this.index++;
                this.pgb.Value = (int)this.index;
                double value = this.index / this.FrameCount * 100;
                this.lblMemo.Text = value.ToString("F2") + "%";
                mat.Dispose();
            }
        }

        private void btnSelectVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "视频|*.mp4;*.avi;";
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                this.index = 0;
                this.videoCapture = new VideoCapture(ofd.FileName);
                this.fps = (int)this.videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                this.FrameCount = this.videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                this.pgb.Maximum = (int)this.FrameCount;
                this.numFrm.Maximum = (decimal)this.FrameCount;
            }
        }

        private void FrmVideo_Load(object sender, EventArgs e)
        {
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if(this.videoCapture != null)
            {
                bool b = this.videoCapture.SetCaptureProperty(CapProp.PosFrames, (int)this.numFrm.Value);
            }
        }
    }
}
