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
    public partial class regist : Form
    {
        public regist()
        {
            InitializeComponent();
        }

        private void reloginbut_Click(object sender, EventArgs e)
        {
            if (pwd.Text == "" || pwds.Text == "")
            {
                MessageBox.Show("请输入密码");
            }
            else
            {
                if (pwd.Text == pwds.Text)
                {
                    string pwdt = pwd.Text;
                    string constr = "Data Source=APPARITIONS\\WM;Initial Catalog=WMS;Integrated Security=True";//连接字符串
                    SqlConnection sqlConnection = new SqlConnection(constr);//实例化数据库连接（新建数据库连接实例）
                    sqlConnection.Open();//打开数据库连接
                                         //往数据库插入值
                    String sql = String.Format("insert into [user](password,name) values ('{0}','{1}')", pwdt,textBox1.Text) + "select @@identity";//显示id//SQL语句实现表数据的读取
                                                                                                                                                                                                                                                                                                                                                 //String sql = String.Format("selete count(*) from qq_user where userid = ")
                    SqlCommand insert = new SqlCommand(sql, sqlConnection);//新建数据库操作实例
                                                                          //int a = (int)insert.ExecuteNonQuery();//执行操作，返回结果
                    string a = insert.ExecuteScalar().ToString();//执行操作，并将返还值赋值给a
                    sqlConnection.Close();//关闭连接
                    MessageBox.Show("注册成功，你的账号为：" + a);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致");
                }
            }
        }

        private void regist_Load(object sender, EventArgs e)
        {

        }
    }
}
