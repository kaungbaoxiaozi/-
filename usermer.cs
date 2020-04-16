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
    public partial class usermer : Form
    {
        public usermer()
        {
            InitializeComponent();
        }

        private void listviewtest_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlc = string.Format("SELECT * FROM [USER]");
                SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sqlc);//逐条读取
                string sqlrow = string.Format("SELECT COUNT(*) FROM [USER]");
                int row = (int)SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlrow);//返还第一条第一列的数据 多用行数查询
                for (int i = 0; i < row; i++)
                {
                    if (reader.Read())
                    {
                        ListViewItem lv = new ListViewItem(reader[0].ToString());//第一列数据
                        lv.SubItems.Add(reader[1].ToString());
                        lv.SubItems.Add(reader[2].ToString());
                        lv.SubItems.Add(reader[3].ToString());
                        lv.SubItems.Add(reader[4].ToString());
                        userlist.Items.Add(lv);//将合集加入到listview控件中
                    }
                }
            }
            catch
            {
                MessageBox.Show("出现错误，请重试", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//常用参数：（"弹窗内容","标题",按钮类型,图标类型,==DialogResul.ok(可用判断)）
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                userlist.Items.Clear();
                string sqlc = string.Format("SELECT * FROM [USER]");
                SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sqlc);//逐条读取
                string sqlrow = string.Format("SELECT COUNT(*) FROM [USER]");
                int row = (int)SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlrow);//返还第一条第一列的数据 多用行数查询
                for (int i = 0; i < row; i++)
                {
                    if (reader.Read())
                    {
                        ListViewItem lv = new ListViewItem(reader[0].ToString());//第一列数据
                        //lv.SubItems.Add(reader[0].ToString());
                        lv.SubItems.Add(reader[1].ToString());
                        lv.SubItems.Add(reader[2].ToString());
                        lv.SubItems.Add(reader[3].ToString());
                        lv.SubItems.Add(reader[4].ToString());
                        userlist.Items.Add(lv);//将合集加入到listview控件中
                    }
                }
            }
            catch
            {
                MessageBox.Show("出现错误，请重试", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//常用参数：（"弹窗内容","标题",按钮类型,图标类型,==DialogResul.ok(可用判断)）
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sqlup = string.Format("update [user] set [power] = '{0}' where id = '{1}'", uppower.Text,upid.Text);
            SqlHelper.ExecuteNonQuery(SqlHelper.constr,CommandType.Text,sqlup);
            MessageBox.Show("修改成功");
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlde = string.Format("delete from [user] where [id] = '{0}'", deid.Text);
            SqlHelper.ExecuteNonQuery(SqlHelper.constr,CommandType.Text,sqlde);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlin = string.Format("INSERT INTO [user] (password,name) VALUES ('{0}','{1}')",inpwd.Text,inname.Text);
            SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqlin);
            MessageBox.Show("添加成功");
        }

        private void cbut_Click(object sender, EventArgs e)
        {
            string tjt = tj.Text;
            string cxtj=null;
            switch (tjt)
            {
                case "账号":
                    cxtj = "id";
                    break;
                case "姓名":
                    cxtj = "name";
                    break;
            }
            //*********************************************************************************************
            try
            {
                userlist.Items.Clear();
                string sqlca = string.Format("select * from [user] where '{0}' = '{1}' ", cxtj, cx.Text);
                SqlDataReader sqlreader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sqlca);
                string sqlrow = string.Format("SELECT COUNT(*) FROM [USER]");
                int row = (int)SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlrow);//返还第一条第一列的数据 多用行数查询
                for (int i = 0; i <= 0; i++)
                {
                    if (sqlreader.Read())
                    {
                        ListViewItem lv = new ListViewItem(sqlreader[0].ToString());//第一列数据
                        lv.SubItems.Add(sqlreader[1].ToString());
                        lv.SubItems.Add(sqlreader[2].ToString());
                        lv.SubItems.Add(sqlreader[3].ToString());
                        lv.SubItems.Add(sqlreader[4].ToString());
                        userlist.Items.Add(lv);//将合集加入到listview控件中
                    }
                }
            }
            catch
            {
                MessageBox.Show("出现错误，请重试", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//常用参数：（"弹窗内容","标题",按钮类型,图标类型,==DialogResul.ok(可用判断)）
            }
        }
    }
}
