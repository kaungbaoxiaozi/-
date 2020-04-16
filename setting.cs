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
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
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
            if (string.IsNullOrWhiteSpace(wartime.Text))
            {
                MessageBox.Show("不要什么都不写就点确定！");
            }
            else
            {
                string sqlca = string.Format("select count(*) from [setting] where [id] = '{0}'",user.uid);
                SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sqlca);
                if (reader.HasRows)
                {
                    string sqls = string.Format("update [setting] set [warning] = '{0}' where [id] = '{1}'", wartime.Text, user.uid);
                    string rows = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqls).ToString();
                    if(rows == "1")
                    {
                        MessageBox.Show("更新成功");
                    }
                }
                else
                {
                    string sql = string.Format("insert into [setting] values ('{0}','{1}')", user.uid, wartime.Text);
                    string row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql).ToString();
                    if (row == "1")
                    {
                        MessageBox.Show("保存成功！");
                    }
                }
            }
        }
    }
}
