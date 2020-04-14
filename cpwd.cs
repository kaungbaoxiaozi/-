using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class cpwd : Form
    {
        public cpwd()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
            string opwdt = opwd.Text;
            string npwdt = npwd.Text;
            string npwdst = npwds.Text;
            if(opwdt == user.upwd)
            {
                if (npwdt != npwdst)
                {
                    MessageBox.Show("请确保两次输入密码的一致性");
                }
                else
                {
                    //使用dataset更新数据库
                    //string sqlup = string.Format("update qq_user set userpwd ='{0}' where userid ='{1}'", npwdt, Users.userid);
                    //SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqlup);
                    //MessageBox.Show("密码修改成功，请谨记新密码");
                    try
                    {
                        string sqlup = string.Format("update [user] set [password] = '{0}' where id = '{1}'", npwdt, user.uid);
                        SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqlup);
                        MessageBox.Show("修改成功");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("暂时无法更改密码请重试","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("我不知道你是谁？","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
