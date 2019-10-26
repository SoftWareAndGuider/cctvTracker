using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace cctvTracker
{
    public partial class cctvTracker : Form
    {
        //Insert your map url in "url.txt" ("url.txt파일 안에 당신의 지도 url을 넣으십시오")
        string url = System.IO.File.ReadAllText("url.txt");
        public cctvTracker()
        {
            InitializeComponent();
        }

        private void cctvTracker_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            //show map in display (화면에 지도 표시하기)
            toIframe.Navigate($"{url}/{toIframe.Size.Width}/{toIframe.Size.Height}");
            label1.Text = client.DownloadString($"{url}/{toIframe.Size.Width}/{toIframe.Size.Height}");
            Text = "finish";
        }

        private void cctvTracker_ResizeEnd(object sender, EventArgs e)
        {
            Text = "start";
            toIframe.Navigate($"{url}/{toIframe.Size.Width}/{toIframe.Size.Height}");
            Text = "end";
        }
    }
}
