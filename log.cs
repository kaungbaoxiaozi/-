using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {
            this.getfont();
            time.Text = DateTime.Now.ToLongDateString().ToString();
            string nowtime = DateTime.Now.ToLongDateString().ToString();
            string sqlca = string.Format("select logt from [log] where time = '{0}'", nowtime);
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sqlca);
            if (reader.HasRows)
            {
                log1.Text = "今日日志已提交,请勿重复提交日志！\n如需修改请移步➡";
                //log.Enabled = false;
                log1.Enabled = false;
                send.Enabled = false;
                clears.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nowtime = DateTime.Now.ToLongDateString().ToString();
            if (string.IsNullOrWhiteSpace(log1.Text))
            {
                MessageBox.Show("你没写日志你提交个der的日志！");
            }
            else
            {
                string sqlca = string.Format("select logt from [log] where time = '{0}'",nowtime);
                SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr,CommandType.Text,sqlca);
                if (reader.HasRows)
                {
                    MessageBox.Show("你已经写过日志了,若需要修改改请移步➡");
                }
                else
                {
                    string logt = log1.Text;
                    string sqlin = string.Format("insert into [log] (time,logt) values ('{0}','{1}')", nowtime, logt);
                    int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqlin);
                    if (row == 1)
                    {
                        MessageBox.Show("提交成功");
                        inlog.Enabled = false;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string times = dateTimePicker1.Text;
            string sql = string.Format("select count(*) from [log] where time = '{0}'", times);
            string row = SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sql).ToString();
            if (row == "1")
            {
                string sqlca = string.Format("select [logt] from [log] where time = '{0}'", times);
                log2.Text = SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlca).ToString();
            }
            else
            {
                MessageBox.Show("所选日期无日志！","无日志", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clear(object sender, EventArgs e)
        {
            log1.Clear();
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定提交吗？","",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                string logt = log2.Text;
                string times = dateTimePicker1.Text;
                string sqlup = string.Format("update [log] set [logt] = '{0}' where [time] = '{1}'", logt, times);
                string row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqlup).ToString();
                if (row == "1")
                {
                    MessageBox.Show("日志修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                } 
            }
        }

        private void infont_Click(object sender, EventArgs e)
        {
            
            DialogResult result = inlogfont.ShowDialog();
            if (result == DialogResult.OK)
            {
                log1.Font = inlogfont.Font;
            }
        }

        private void getfont()
        {
            string sql = string.Format("select [fname],[fsize],[fstyle] from [setting] where [id] = '{0}'",user.uid);
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sql);
            while (reader.Read())
            {
                string fname = reader["fname"].ToString();
                string fsize = reader["fsize"].ToString();
                float fsizef = float.Parse(fsize);
                string fontstyle = reader["fstyle"].ToString(); 
                FontStyle fstyle = (FontStyle)Enum.Parse(typeof(FontStyle), fontstyle, false);
                Font myfont = new Font(fname,fsizef,fstyle);
                log1.Font = myfont;
                log2.Font = myfont;
            }
        }

        private void font_Click(object sender, EventArgs e)
        {
            DialogResult result = inlogfont.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.getfont();
                string fname = inlogfont.Font.Name;
                float fsize = inlogfont.Font.Size;
                string fstyle = inlogfont.Font.Style.ToString();
                string sqlca = "select count(*) from [setting] where [id] = "+ user.uid;
                int rowca = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlca));
                if (rowca == 1)
                {
                    string sqlup = string.Format("update [setting] set [fname] = '{0}',[fsize]='{1}',[fstyle]='{2}'",fname,fsize,fstyle);
                    int rowup = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqlup) ;
                    if (rowup == 1)
                    {
                        MessageBox.Show("设置已更新");
                    }
                }
                else
                {
                    string sql = string.Format("INSERT INTO [setting] ([fname],[fsize],[fstyle],[id]) values('{0}','{1}','{2}','{3}')", fname, fsize, fstyle, user.uid);
                    int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                    if (row == 1)
                    {
                        MessageBox.Show("设置成功");
                    }
                }
            }
            MessageBox.Show(log1.Font.ToString());
        }
    }
}
