using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class test1 : Form
    {
        int z = 60;
        public test1()
        {
            InitializeComponent();
        }

        /// <summary>自定义方法 -- 
        ///  获取文本中(行和列)--光标--坐标位置的调用方法
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        private void Ranks()
        {
            /*  得到光标行第一个字符的索引，
             *  即从第1个字符开始到光标行的第1个字符索引*/
            int index = richTextBox1.GetFirstCharIndexOfCurrentLine();
            /*得到光标行的行号,第1行从0开始计算，习惯上我们是从1开始计算，所以+1。 */
            int line = richTextBox1.GetLineFromCharIndex(index) + 1;
            /*  SelectionStart得到光标所在位置的索引
             *  再减去
             *  当前行第一个字符的索引
             *  = 光标所在的列数(从0开始)  */
            int column = richTextBox1.SelectionStart - index + 1;
            this.label1.Text = string.Format("第：{0}行 {1}列", line.ToString(), column.ToString());
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Ranks();  //按上、下、左、右时显示
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Ranks();  //点击鼠标时显示
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            z = z - 1;
            if (z == 0)
            {
                z = 60;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = z.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = fontDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string font = fontDialog1.Font.ToString();
                MessageBox.Show(font);
                string fontname = fontDialog1.Font.Name;
                float fontsize = fontDialog1.Font.Size;
                string fontstyle = fontDialog1.Font.Style.ToString();
                FontStyle fontS = (FontStyle)Enum.Parse(typeof(FontStyle), fontstyle, false);
                richTextBox1.Font = new Font(fontname, fontsize, fontS);//定义新的字体格式,对应数据1，字体格式（string）
                //public Font (string familyName, float emSize, System.Drawing.FontStyle style);
                //string myString = FontStyle.Bold.ToString();
                //FontStyle myFontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), myString, false);
            }

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            open.ShowDialog();
        }

        private void open_FileOk(object sender, CancelEventArgs e)
        {
            player.URL = open.FileName;
            MessageBox.Show(open.FileName);
        }
    }
}
