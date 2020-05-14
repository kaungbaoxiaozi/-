using System;
using System.Data;
using System.Data.SqlClient;
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
            if (7 <= hour && hour < 11)
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
            backspeak.RunWorkerAsync();

            string sql = "SELECT TOP 1 * FROM [user] order by [lasttime] desc;";//查询已登录用户账号信息
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sql);
            if (reader.Read())
            {
                int isrem = (int)reader["rember"];
                if (isrem == 1)
                {
                    pwd.Text = reader["password"].ToString();
                    id.Text = reader["id"].ToString();
                    rember.Checked = true;
                } 
            }

        }

        private void sqltest_Click(object sender, EventArgs e)
        {
            string idt = id.Text;
            string pwdt = pwd.Text;
            string time = DateTime.Now.ToString();
            String sql = "select count(*) from [user] where id = '" + idt + "'and password = '" + pwdt + "'";
            int a = (int)SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sql);
            if (idt == "" || pwdt == "")
            {
                MessageBox.Show("请告诉我你是谁？");
            }
            else
            {
                if (a == 1)
                {
                    user.uid = idt;
                    user.upwd = pwdt;
                    string sqlvolme = string.Format("select [volume] from [setting] where [id] = '{0}'", idt);
                    user.volume = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlvolme));
                    //获取用户姓名
                    string sqlname = string.Format("select rtrim([name]) from [user] where id = '{0}' ", idt);
                    user.uname = SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlname).ToString();
                    //录入登录时间
                    string sqlin = string.Format("update [user] set [lasttime] = '{0}' where id = '{1}'", time, user.uid);
                    SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqlin);
                    //获取权限等级
                    string sqlc = string.Format("SELECT [power] FROM [user] where id = '{0}'", idt);
                    SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sqlc);
                    if (reader.Read())
                    {
                        user.power = reader.GetString(0);
                    }
                    //获取用户设置信息
                    string sqlset = string.Format("select [warning] from [setting] where [id] = '{0}'", user.uid);
                    user.uwarning = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlset));
                    this.Hide();
                    main main = new main();
                    main.Show();
                    //Myhelper.Speak("欢迎使用仓库管理系统");
                    backlogin.RunWorkerAsync();
                    if (rember.Checked == true)
                    {
                        string sqlre = string.Format("update [user] set [rember] = '{0}' where [id] = '{1}' ",1,idt);
                        SqlHelper.ExecuteNonQuery(SqlHelper.constr,CommandType.Text,sqlre);
                    }
                    else
                    {
                        string sqlre = string.Format("update [user] set [rember] = '{0}' where [id] = '{1}' ", 0, idt);
                        SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqlre);
                    }
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

        private void backspeak_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Myhelper.Speak(hi.Text + "，请问你是谁？");
        }

        private void backlogin_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Myhelper.Speak(user.uname + "！欢迎使用仓库管理系统！");
        }

        private void id_Enter(object sender, EventArgs e)
        {
            id.Text = null;
            pwd.Text = null;
            rember.Checked = false;
        }

        private void getLogin()
        {

        }
    }
}
