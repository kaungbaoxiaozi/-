using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Warehouse_Manager
{
    public partial class test3 : Form
    {
        public test3()
        {
            InitializeComponent();
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendString", CharSet = CharSet.Auto)]
        public static extern int mciSendString(
         string lpstrCommand,
         string lpstrReturnString,
         int uReturnLength,
         int hwndCallback
        );
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //mciSendString("set wave bitpersample 8", "", 0, 0);

            //mciSendString("set wave samplespersec 20000", "", 0, 0);
            //mciSendString("set wave channels 2", "", 0, 0);
            //mciSendString("set wave format tag pcm", "", 0, 0);
            //mciSendString("open new type WAVEAudio alias movie", "", 0, 0);

            //mciSendString("record movie", "", 0, 0);
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mciSendString("stop movie", "", 0, 0);
            mciSendString("save movie 1.wav", "", 0, 0);
            mciSendString("close movie", "", 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ai = Convert.ToInt32(a.Text);
            int bi = Convert.ToInt32(b.Text);
            c.Text = (ai - bi).ToString();
        }
    }
}
/*using System.Runtime.InteropServices;
 
        [DllImport("winmm.dll", EntryPoint = "mciSendString", CharSet = CharSet.Auto)]
        public static extern int mciSendString(
         string lpstrCommand,
         string lpstrReturnString,
         int uReturnLength,
         int hwndCallback
        );
        private void button1_Click(object sender, EventArgs e)
        {
            mciSendString("set wave bitpersample 8", "", 0, 0);
 
            mciSendString("set wave samplespersec 20000", "", 0, 0);
            mciSendString("set wave channels 2", "", 0, 0);
            mciSendString("set wave format tag pcm", "", 0, 0);
            mciSendString("open new type WAVEAudio alias movie", "", 0, 0);
 
            mciSendString("record movie", "", 0, 0);
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            mciSendString("stop movie", "", 0, 0);
            mciSendString("save movie 1.wav", "", 0, 0);
            mciSendString("close movie", "", 0, 0);
        }
*/