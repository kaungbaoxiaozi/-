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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            if (7 <= hour&&hour <11)
            {
                hi.Text = "上午好";
            }
            else
            {
                if (11 <= hour && hour < 14)
                {
                    hi.Text = "中午好";
                }
                else
                {
                    if (14 <= hour && hour < 18)
                    {
                        hi.Text = "下午好";
                    }
                    else
                    {
                        if (18 <= hour && hour < 23)
                        {
                            hi.Text = "晚上好";
                        }
                    }
                }
            }
        }

        private void sqltest_Click(object sender, EventArgs e)
        {
            string idt = id.Text;
            string pwdt = pwd.Text;
            string time = DateTime.Now.ToString();
            String sql = "select count(*) from [user] where id = '" + idt + "'and password = '" + pwdt + "'";           
            int a = (int)SqlHelper.ExecuteScalar(SqlHelper.constr,CommandType.Text,sql);
            if ( idt == "" || pwdt == "" )
            {
                MessageBox.Show("请告诉我你是谁？");
            }
            else
            {
                if (a == 1)
                {
                    user.uid = idt;
                    user.upwd = pwdt;
                    //获取用户姓名
                    string sqlname = string.Format("select rtrim([name]) from [user] where id = '{0}' ", idt);
                    user.uname = SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlname).ToString();
                    //录入登录时间
                    string sqlin = string.Format("update [user] set [lasttime] = '{0}' where id = '{1}'", time, user.uid);
                    SqlHelper.ExecuteNonQuery(SqlHelper.constr,CommandType.Text,sqlin);
                    //获取权限等级
                    string sqlc = string.Format("SELECT [power] FROM [user] where id = '{0}'",idt);
                    SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sqlc);
                    if (reader.Read())
                    {
                        user.power = reader.GetString(0);
                    }
                    //获取用户设置信息
                    string sqlset = string.Format("select [warning] from [setting] where [id] = '{0}'",user.uid);
                    user.uwarning = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlset));
                    this.Hide();
                    main main = new main();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("你没有登录权限");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regist regist = new regist();
            regist.ShowDialog();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitbut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
