using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cctvTracker
{
    public partial class URL : Form
    {
        public bool finish = false;
        public URL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText("url.txt", textBox1.Text);
                finish = true;
                MessageBox.Show("입력이 완료되었습니다", "완료");
                this.Close();
            }
            catch
            {
                MessageBox.Show("관리자 권한으로 프로그램을 실행해 주세요");
                Application.Exit();
            }
        }
    }
}
