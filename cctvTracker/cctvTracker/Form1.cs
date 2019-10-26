using System;
using System.Net;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;
using System.Diagnostics;

namespace cctvTracker
{
    public partial class cctvTracker : Form
    {
        //Insert your map url in "url.txt" ("url.txt파일 안에 당신의 지도 url을 넣으십시오")
        string url;
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
            try
            {
                url = System.IO.File.ReadAllText("url.txt");
                cctvbrowser = new ChromiumWebBrowser($"{url}/cctv/{Screen.PrimaryScreen.Bounds.Width}/{Screen.PrimaryScreen.Bounds.Height}");
                wifibrowser = new ChromiumWebBrowser($"{url}/wifi/{Screen.PrimaryScreen.Bounds.Width}/{Screen.PrimaryScreen.Bounds.Height}");
                restbrowser = new ChromiumWebBrowser($"{url}/toilet/{Screen.PrimaryScreen.Bounds.Width}/{Screen.PrimaryScreen.Bounds.Height}");
                allbrowser = new ChromiumWebBrowser($"{url}/all/{Screen.PrimaryScreen.Bounds.Width}/{Screen.PrimaryScreen.Bounds.Height}");
            }
            catch
            {
                MessageBox.Show("URL을 확인해 주세요");
                Process.Start("url.txt");
            }
            allbrowser.LoadError += Allbrowser_LoadError;
            CCTV.Controls.Add(cctvbrowser);
            Freewifi.Controls.Add(wifibrowser);
            restroom.Controls.Add(restbrowser);
            All.Controls.Add(allbrowser);
            cctvbrowser.Dock = DockStyle.Fill;
            wifibrowser.Dock = DockStyle.Fill;
            restbrowser.Dock = DockStyle.Fill;
            allbrowser.Dock = DockStyle.Fill;
        }

        private void Allbrowser_LoadError(object sender, LoadErrorEventArgs e)
        {
            MessageBox.Show("URL을 확인해 주세요");
            Process.Start("url.txt");
            MessageBox.Show("수정이 완료되었으면 저장 후 확인을 눌러주세요");
            url = System.IO.File.ReadAllText("url.txt");
            cctvbrowser.Load($"{url}/cctv/{Screen.PrimaryScreen.Bounds.Width}/{Screen.PrimaryScreen.Bounds.Height}");
            wifibrowser.Load($"{url}/wifi/{Screen.PrimaryScreen.Bounds.Width}/{Screen.PrimaryScreen.Bounds.Height}");
            restbrowser.Load($"{url}/toilet/{Screen.PrimaryScreen.Bounds.Width}/{Screen.PrimaryScreen.Bounds.Height}");
            allbrowser.Load($"{url}/all/{Screen.PrimaryScreen.Bounds.Width}/{Screen.PrimaryScreen.Bounds.Height}");
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
