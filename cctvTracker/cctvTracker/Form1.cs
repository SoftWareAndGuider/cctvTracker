using System;
using System.Net;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;

namespace cctvTracker
{
    public partial class cctvTracker : Form
    {
        //Insert your map url in "url.txt" ("url.txt파일 안에 당신의 지도 url을 넣으십시오")
        string url = System.IO.File.ReadAllText("url.txt");
        public cctvTracker()
        {
            InitializeComponent();
            browserset();
        }
        ChromiumWebBrowser browser;
        public void browserset()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser($"{url}/776/344");
            CCTV.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void cctvTracker_Load(object sender, EventArgs e)
        {
        }

        private void cctvTracker_ResizeEnd(object sender, EventArgs e)
        {
            browser.Load($"{url}/{browser.Size.Width}/{browser.Size.Height}");
        }
    }
}
