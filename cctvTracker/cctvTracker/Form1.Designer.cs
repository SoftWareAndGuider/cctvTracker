namespace cctvTracker
{
    partial class cctvTracker
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.CCTV = new System.Windows.Forms.TabPage();
            this.Freewifi = new System.Windows.Forms.TabPage();
            this.restroom = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TabControl1.SuspendLayout();
            this.CCTV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.CCTV);
            this.TabControl1.Controls.Add(this.Freewifi);
            this.TabControl1.Controls.Add(this.restroom);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(800, 450);
            this.TabControl1.TabIndex = 0;
            this.TabControl1.UseSelectable = true;
            // 
            // CCTV
            // 
            this.CCTV.Controls.Add(this.pictureBox3);
            this.CCTV.Controls.Add(this.pictureBox2);
            this.CCTV.Controls.Add(this.pictureBox1);
            this.CCTV.Location = new System.Drawing.Point(4, 38);
            this.CCTV.Name = "CCTV";
            this.CCTV.Size = new System.Drawing.Size(792, 408);
            this.CCTV.TabIndex = 0;
            this.CCTV.Text = "CCTV";
            // 
            // Freewifi
            // 
            this.Freewifi.Location = new System.Drawing.Point(4, 38);
            this.Freewifi.Name = "Freewifi";
            this.Freewifi.Size = new System.Drawing.Size(792, 408);
            this.Freewifi.TabIndex = 1;
            this.Freewifi.Text = "무료 WIFI";
            // 
            // restroom
            // 
            this.restroom.Location = new System.Drawing.Point(4, 38);
            this.restroom.Name = "restroom";
            this.restroom.Size = new System.Drawing.Size(792, 408);
            this.restroom.TabIndex = 2;
            this.restroom.Text = "공중 화장실";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(767, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 408);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(0, 387);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(792, 25);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(2, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 408);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // cctvTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl1);
            this.Name = "cctvTracker";
            this.Load += new System.EventHandler(this.cctvTracker_Load);
            this.ResizeEnd += new System.EventHandler(this.cctvTracker_ResizeEnd);
            this.TabControl1.ResumeLayout(false);
            this.CCTV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl1;
        private System.Windows.Forms.TabPage CCTV;
        private System.Windows.Forms.TabPage Freewifi;
        private System.Windows.Forms.TabPage restroom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

