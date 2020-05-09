using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class setting : Form
    {
        private main mai = null;
        string bgmurl = null;

        public setting(main main)
        {
            InitializeComponent();
            this.mai = main;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)//重绘tab
        {
            string text = ((TabControl)sender).TabPages[e.Index].Text;
            SolidBrush brush = new SolidBrush(Color.Black);
            StringFormat sf = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(text, SystemInformation.MenuFont, brush, e.Bounds, sf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bgmmode;
            if (bgmtrue.Checked == true)
            {
                bgmmode = 1;
            }
            else
            {
                bgmmode = 0;
            }

            string sqlca = string.Format("select count(*) from [setting] where [id] = '{0}'", user.uid);
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sqlca);
            if (reader.HasRows)
            {
                string sqls = string.Format("update [setting] set [warning] = '{0}',[bgmmode] = '{1}',[bgmurl] = '{2}',[volume] = '{3}' where [id] = '{4}'", wartime.Text, bgmmode, bgmurl, volume.Text, user.uid);
                string rows = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqls).ToString();
                if (rows == "1")
                {
                    MessageBox.Show("保存成功");
                    user.volume = Convert.ToInt32(volume.Text);
                }
            }
            else
            {
                string sql = string.Format("insert into [setting] values ('{0}','{1}','{2}','{3}','{4}')", user.uid, wartime.Text, bgmmode, bgmurl, volume.Text);
                string row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql).ToString();
                if (row == "1")
                {
                    MessageBox.Show("设置成功");
                    user.volume = Convert.ToInt32(volume.Text);
                }
            }
            if (bgmmode == 0)
            {
                mai.SetPlayerUrl(null);
            }
        }

        private void setting_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select [bgmmode] from [setting] where [id] = '{0}'", user.uid);
            int bgmmode = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sql));
            if (bgmmode == 1)
            {
                bgmtrue.Checked = true;
            }
            else
            {
                bgmfalse.Checked = true;
            }

            if (bgmtrue.Checked == true)
            {
                choosebgm.Visible = true;
            }
            string sqls = string.Format("select [warning] from [setting] where [id] = '{0}'", user.uid);
            int warning = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqls));
            wartime.Text = warning.ToString();
            string sqlss = string.Format("select [bgmurl] from [setting] where [id] = '{0}'", user.uid);
            bgmurl = SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlss).ToString();

            string sqlvolme = string.Format("select [volume] from [setting] where [id] = '{0}'", user.uid);
            volumetrackBar.Value = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlvolme));
            volume.Text = volumetrackBar.Value.ToString();

            runbut.Visible = false;
            infolabel.Visible = false;
        }

        private void choosebgm_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //main mai = (main)this.Owner;
            mai.SetPlayerUrl(openFileDialog1.FileName);
            bgmurl = openFileDialog1.FileName;
        }

        private void bgmtrue_CheckedChanged(object sender, EventArgs e)
        {
            if (bgmtrue.Checked == true)
            {
                choosebgm.Visible = true;
            }
            else
            {
                choosebgm.Visible = false;
            }
        }

        private void label5_DoubleClick(object sender, EventArgs e)
        {
            runbut.Visible = true;
            infolabel.Visible = true;
        }

        private void runbut_Click(object sender, EventArgs e)
        {
            string[] vs = new string[5] { "in", "out", "sup", "product", "store" };
            foreach (string i in vs)
            {
                string sql = string.Format("delete from [{0}]", i);
                SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
            }
            MessageBox.Show("删除成功");
            main mai = (main)this.Owner;
            mai.prore();
            mai.inre();
            mai.outre();
            mai.spre();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            volume.Text = volumetrackBar.Value.ToString();
        }
    }
}
