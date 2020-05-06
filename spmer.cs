using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class spmer : Form
    {
        public spmer()
        {
            InitializeComponent();
        }

        private void spmer_FormClosed(object sender, FormClosedEventArgs e)
        {
            main mai = (main)this.Owner;
            mai.spre();
        }

        private void spmer_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet.sup”中。您可以根据需要移动或删除它。
            this.supTableAdapter.Fill(this.wMSDataSet.sup);

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = spdata.CurrentRow.Index;
                id.Text = spdata.Rows[index].Cells[0].Value.ToString();
                ids.Text = spdata.Rows[index].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string[] info = Getinfo(ids.Text);
            name.Text = info[0];
            phone.Text = info[1];
            address.Text = info[2];
            note.Text = info[3];
            names.Text = info[0];
            phones.Text = info[1];
            addresss.Text = info[2];
            notes.Text = info[3];
        }

        private void ids_TextChanged(object sender, EventArgs e)
        {
            string[] info = Getinfo(ids.Text);

            names.Text = info[0];
            phones.Text = info[1];
            addresss.Text = info[2];
            notes.Text = info[3];
        }
        /// <summary>
        /// 返还一个字符串组（name，phone，address,note）
        /// </summary>
        /// <returns></returns>
        private string[] Getinfo(string id)
        {
            string sql = string.Format("select [name],[phone],[address],[note] from [sup] where id = '{0}'", id);
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sql);
            string[] info = new string[4];
            while (reader.Read())
            {
                info[0] = reader["name"].ToString();
                info[1] = reader["phone"].ToString();
                info[2] = reader["address"].ToString();
                info[3] = reader["note"].ToString();
            }
            return info;
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            string[] info = Getinfo(ids.Text);
            name.Text = info[0];
            phone.Text = info[1];
            address.Text = info[2];
            note.Text = info[3];
        }

        private void debut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ids.Text) == false)
            {
                string sql = string.Format("delete from [sup] where [id] = '{0}'", ids.Text);
                int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                if (row == 1)
                {
                    spmerre();
                    MessageBox.Show("删除成功");
                }
            }
            else
            {
                MessageBox.Show("你没有选中任何行");
            }
        }

        private void editbut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text) == false)
            {
                string sql = string.Format("update [sup] set [name] = '{0}',[phone] = '{1}',[address] = '{2}',[note] = '{3}' where [id] = '{4}'", name.Text, phone.Text, address.Text, note.Text, id.Text);
                int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                if (row == 1)
                {
                    spmerre();
                    MessageBox.Show("修改成功");

                }
            }
            else
            {
                MessageBox.Show("你没有选中任何行");
            }
        }

        public void spmerre()
        {
            this.supTableAdapter.Fill(this.wMSDataSet.sup);
        }
    }
}
