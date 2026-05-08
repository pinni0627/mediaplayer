namespace mediaplayer
{
    partial class frmMediaPlayer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediaPlayer));
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.palButton = new System.Windows.Forms.Panel();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.palButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowser.Location = new System.Drawing.Point(3, 3);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(73, 33);
            this.btnBrowser.TabIndex = 1;
            this.btnBrowser.Text = "瀏覽";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlay.Location = new System.Drawing.Point(82, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(73, 33);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPause.Location = new System.Drawing.Point(161, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(73, 33);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.Location = new System.Drawing.Point(240, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(73, 33);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // palButton
            // 
            this.palButton.Controls.Add(this.btnBrowser);
            this.palButton.Controls.Add(this.btnStop);
            this.palButton.Controls.Add(this.btnPlay);
            this.palButton.Controls.Add(this.btnPause);
            this.palButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.palButton.Location = new System.Drawing.Point(0, 257);
            this.palButton.Name = "palButton";
            this.palButton.Size = new System.Drawing.Size(533, 40);
            this.palButton.TabIndex = 5;
            // 
            // wmpVideo
            // 
            this.wmpVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(0, 0);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(533, 254);
            this.wmpVideo.TabIndex = 0;
            // 
            // frmMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 297);
            this.Controls.Add(this.palButton);
            this.Controls.Add(this.wmpVideo);
            this.Name = "frmMediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "多媒體撥放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMediaPlayer_FormClosing);
            this.palButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel palButton;
    }
}

