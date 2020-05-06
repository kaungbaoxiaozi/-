using System;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("mailto:Tom123@163.com?Subject=[Feedback] Good Day");
            System.Diagnostics.Process.Start("mailto:kuangbaoxiaozi@outlook.com?Subject= [WM] Hello！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tests = comboBox1.Text;
            switch (tests)
            {
                case "test":
                    test test = new test();
                    test.Show();
                    break;
                case "test1":
                    test1 test1 = new test1();
                    test1.Show();
                    break;
                case "test2":
                    test2 test2 = new test2();
                    test2.Show();
                    break;
                case "test3":
                    test3 test3 = new test3();
                    test3.Show();
                    break;

            }
        }
    }
}
