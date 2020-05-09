using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class speechtest : Form
    {
        public speechtest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Myhelper.Speak("测试，后台播放测试 测试1");
        }
    }
}
