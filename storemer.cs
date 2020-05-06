using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Warehouse_Manager
{
    public partial class storemer : Form
    {
        public storemer()
        {
            InitializeComponent();
        }

        private void storemer_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet.store”中。您可以根据需要移动或删除它。
            this.storeTableAdapter.Fill(this.wMSDataSet.store);
            name.Text = null;

        }

        public void storemerre()
        {
            try
            {
                this.storeTableAdapter.FillBy(this.wMSDataSet.store);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(id.Text))
            {
                MessageBox.Show("你没有选中任何行");
            }
            else
            {
                if (MessageBox.Show("确定修改吗？", "在？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sql = string.Format("update [store] set [name] = '{0}',[phone] = '{1}',[address] = '{2}',[note] = '{3}' where [id] = '{4}'", name.Text, phone.Text, address.Text, note.Text, id.Text);
                    int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                    if (row == 1)
                    {
                        MessageBox.Show("修改成功");
                        this.storemerre();
                    }
                }
            }
        }

        private void storemer_FormClosed(object sender, FormClosedEventArgs e)
        {
            main mai = (main)this.Owner;
            mai.storere();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            id.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            ids.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text))
            {

            }
            else
            {
                string[] info = this.Getinfo(Convert.ToInt32(id.Text));
                name.Text = info[0];
                phone.Text = info[1];
                address.Text = info[2];
                note.Text = info[3];
            }
        }


        private void ids_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text))
            {

            }
            else
            {
                string[] info = this.Getinfo(Convert.ToInt32(id.Text));
                dename.Text = info[0];
                dephone.Text = info[1];
                deaddress.Text = info[2];
                denote.Text = info[3];
            }
        }

        private void debut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ids.Text) == false)
            {
                if (MessageBox.Show("确定删除该商家吗？", "在？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sql = string.Format("delete  from [store] where [id] = '{0}'", ids.Text);
                    int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                    if (row == 1)
                    {
                        MessageBox.Show("删除成功");
                        this.storemerre();
                        this.clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("你没有选中任何行");
            }
        }

        /// <summary>
        /// 查询对应id的信息，并保存在数组中,长度为[3]，包含"name,phone,address,note"四条数据。
        /// </summary>
        /// <param name="id">查询ID</param>
        /// <returns>长度为[3]的数组，包括name，phone，address，note</returns>
        public string[] Getinfo(int id)
        {
            try
            {
                string[] info;
                info = new string[4];
                string sql = string.Format("select [name],[phone],[address],[note] from [store] where [id] = '{0}'", id);
                SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sql);
                if (reader.Read())
                {
                    info[0] = reader["name"].ToString();
                    info[1] = reader["phone"].ToString();
                    info[2] = reader["address"].ToString();
                    info[3] = reader["note"].ToString();
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// 清空各个控件的内容
        /// </summary>
        public void clear()
        {
            name.Text = null;
            phone.Text = null;
            address.Text = null;
            note.Text = null;
            dename.Text = null;
            dephone.Text = null;
            deaddress.Text = null;
            denote.Text = null;
            id.Text = null;
            ids.Text = null;
        }
    }
}
