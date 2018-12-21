namespace ImageText
{
    partial class FrmVideo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picVideo = new System.Windows.Forms.PictureBox();
            this.btnSelectVideo = new System.Windows.Forms.Button();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.lblMemo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numFrm = new System.Windows.Forms.NumericUpDown();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrm)).BeginInit();
            this.SuspendLayout();
            // 
            // picVideo
            // 
            this.picVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picVideo.Location = new System.Drawing.Point(0, 0);
            this.picVideo.Name = "picVideo";
            this.picVideo.Size = new System.Drawing.Size(731, 562);
            this.picVideo.TabIndex = 0;
            this.picVideo.TabStop = false;
            // 
            // btnSelectVideo
            // 
            this.btnSelectVideo.Location = new System.Drawing.Point(338, 17);
            this.btnSelectVideo.Name = "btnSelectVideo";
            this.btnSelectVideo.Size = new System.Drawing.Size(95, 23);
            this.btnSelectVideo.TabIndex = 1;
            this.btnSelectVideo.Text = "选择视频...";
            this.btnSelectVideo.UseVisualStyleBackColor = true;
            this.btnSelectVideo.Click += new System.EventHandler(this.btnSelectVideo_Click);
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(22, 17);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(189, 23);
            this.pgb.TabIndex = 2;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(217, 22);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(29, 12);
            this.lblMemo.TabIndex = 3;
            this.lblMemo.Text = "进度";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblF);
            this.panel1.Controls.Add(this.numFrm);
            this.panel1.Controls.Add(this.btnSet);
            this.panel1.Controls.Add(this.btnSelectVideo);
            this.panel1.Controls.Add(this.lblMemo);
            this.panel1.Controls.Add(this.pgb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 562);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 64);
            this.panel1.TabIndex = 4;
            // 
            // numFrm
            // 
            this.numFrm.Location = new System.Drawing.Point(484, 18);
            this.numFrm.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numFrm.Name = "numFrm";
            this.numFrm.Size = new System.Drawing.Size(90, 21);
            this.numFrm.TabIndex = 5;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(592, 17);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "快进";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(271, 22);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(29, 12);
            this.lblF.TabIndex = 7;
            this.lblF.Text = "播放";
            // 
            // FrmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 626);
            this.Controls.Add(this.picVideo);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = true;
            this.Name = "FrmVideo";
            this.Text = "播放视频";
            this.Load += new System.EventHandler(this.FrmVideo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmVideo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picVideo;
        private System.Windows.Forms.Button btnSelectVideo;
        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numFrm;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblF;
    }
}