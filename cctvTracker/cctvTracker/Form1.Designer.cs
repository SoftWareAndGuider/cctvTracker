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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.restroom = new System.Windows.Forms.TabPage();
            this.bell = new System.Windows.Forms.TabPage();
            this.CCTV = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CCTV);
            this.tabControl1.Controls.Add(this.restroom);
            this.tabControl1.Controls.Add(this.bell);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // restroom
            // 
            this.restroom.Location = new System.Drawing.Point(4, 22);
            this.restroom.Name = "restroom";
            this.restroom.Padding = new System.Windows.Forms.Padding(3);
            this.restroom.Size = new System.Drawing.Size(792, 424);
            this.restroom.TabIndex = 1;
            this.restroom.Text = "공중화장실";
            this.restroom.UseVisualStyleBackColor = true;
            // 
            // bell
            // 
            this.bell.Location = new System.Drawing.Point(4, 22);
            this.bell.Name = "bell";
            this.bell.Size = new System.Drawing.Size(792, 424);
            this.bell.TabIndex = 2;
            this.bell.Text = "비상벨";
            this.bell.UseVisualStyleBackColor = true;
            // 
            // CCTV
            // 
            this.CCTV.Location = new System.Drawing.Point(4, 22);
            this.CCTV.Name = "CCTV";
            this.CCTV.Size = new System.Drawing.Size(792, 424);
            this.CCTV.TabIndex = 3;
            this.CCTV.Text = "CCTV";
            this.CCTV.UseVisualStyleBackColor = true;
            // 
            // cctvTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "cctvTracker";
            this.Load += new System.EventHandler(this.cctvTracker_Load);
            this.ResizeEnd += new System.EventHandler(this.cctvTracker_ResizeEnd);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage restroom;
        private System.Windows.Forms.TabPage bell;
        private System.Windows.Forms.TabPage CCTV;
    }
}

