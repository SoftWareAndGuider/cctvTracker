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
            this.toIframe = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toIframe
            // 
            this.toIframe.Location = new System.Drawing.Point(12, 12);
            this.toIframe.MinimumSize = new System.Drawing.Size(20, 20);
            this.toIframe.Name = "toIframe";
            this.toIframe.ScrollBarsEnabled = false;
            this.toIframe.Size = new System.Drawing.Size(250, 250);
            this.toIframe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // cctvTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toIframe);
            this.Name = "cctvTracker";
            this.Text = "cctvTracker";
            this.Load += new System.EventHandler(this.cctvTracker_Load);
            this.ResizeEnd += new System.EventHandler(this.cctvTracker_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser toIframe;
        private System.Windows.Forms.Label label1;
    }
}

