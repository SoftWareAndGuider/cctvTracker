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
        //크로미움 브라우저 가져오기
        ChromiumWebBrowser cctvbrowser;
        ChromiumWebBrowser wifibrowser;
        ChromiumWebBrowser restbrowser;
        ChromiumWebBrowser allbrowser;
        public void browserset()
        {
            Cef.Initialize(new CefSettings());
            cctvbrowser = new ChromiumWebBrowser($"{url}/cctv/{Screen.PrimaryScreen.Bounds.Width}/{Screen.PrimaryScreen.Bounds.Height}");
            wifibrowser = new ChromiumWebBrowser($"{url}/wifi/{Screen.PrimaryScreen.Bounds.Width}/{Screen.PrimaryScreen.Bounds.Height}");
            restbrowser = new ChromiumWebBrowser($"{url}/toilet/{Screen.PrimaryScreen.Bounds.Width}/{Screen.PrimaryScreen.Bounds.Height}");
            allbrowser = new ChromiumWebBrowser($"{url}/all/{Screen.PrimaryScreen.Bounds.Width}/{Screen.PrimaryScreen.Bounds.Height}");
            CCTV.Controls.Add(cctvbrowser);
            Freewifi.Controls.Add(wifibrowser);
            restroom.Controls.Add(restbrowser);
            All.Controls.Add(allbrowser);
            cctvbrowser.Dock = DockStyle.Fill;
        }

        private void cctvTracker_Load(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = Freewifi;
            TabControl1.SelectedTab = restroom;
            TabControl1.SelectedTab = All;
        }

        private void cctvTracker_ResizeEnd(object sender, EventArgs e)
        {
        }
    }
}
