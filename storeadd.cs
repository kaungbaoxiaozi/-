using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class storeadd : Form
    {
        public storeadd()
        {
            InitializeComponent();
        }

        private void storeadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            //main mai = (main)this.Owner;
            //mai.prore();
            main mai = (main)this.Owner;
            mai.storere();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (Control control in this.Controls)
            //{
            //    if (control is TextBox)
            //    {
            //        TextBox txt = control as TextBox;
            //        if (txt != null && txt.Text == "")
            //        {
            //            MessageBox.Show("请输入...");
            //        }
            //    }
            //}
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(address.Text) || string.IsNullOrWhiteSpace(phone.Text))
            {
                MessageBox.Show("请补全必填项");
            }
            else
            {
                string sql = string.Format("insert into [store](name,phone,address,note) values ('{0}','{1}','{2}','{3}')", name.Text, phone.Text, address.Text, note.Text);
                int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                if (row == 1)
                {
                    MessageBox.Show("录入成功");
                }
            }
        }

        private void storeadd_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("商店名称，电话，地址为必填项\n");
        }
    }
}

