using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class productmer : Form
    {
        public productmer()
        {
            InitializeComponent();
        }

        private void productmer_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.wMSDataSet.product);

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index = prodata.CurrentRow.Index;
            id.Text = prodata.Rows[index].Cells[0].Value.ToString();
            ids.Text = prodata.Rows[index].Cells[0].Value.ToString();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

            string sql = string.Format("select * from [product] where [id] = '{0}'", id.Text);
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sql);
            while (reader.Read())
            {
                name.Text = reader["onlyname"].ToString();
                stock.Text = reader["stock"].ToString();
                format.Text = reader["format"].ToString();
            }
        }

        private void debut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ids.Text) == false)
            {
                string sql = string.Format("delete [product] where [id] = '{0}'", ids.Text);
                int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                if (row == 1)
                {
                    MessageBox.Show("删除成功");
                    this.productTableAdapter.Fill(this.wMSDataSet.product);
                    this.clear();
                }
            }
        }

        public void clear()
        {
            name.Text = null;
            names.Text = null;
            id.Text = null;
            ids.Text = null;
            format.Text = null;
            formats.Text = null;
            stock.Text = null;
            stocks.Text = null;
        }

        private void edbut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text) == false)
            {
                string nameformat = string.Format("{0}({1})", name.Text, format.Text);
                string sql = string.Format("update [product] set [onlyname] = '{0}',[stock] = '{1}',[format] = '{2}',[name] = '{3}' where [id] = '{4}'", name.Text, stock.Text, format.Text, nameformat, id.Text);
                int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                if (row == 1)
                {
                    MessageBox.Show("修改成功");
                    this.productTableAdapter.Fill(this.wMSDataSet.product);
                }
            }
            else
            {
                MessageBox.Show("你没有选中任何行");
            }
        }

        private void productmer_FormClosed(object sender, FormClosedEventArgs e)
        {
            main mai = (main)this.Owner;
            mai.prore();
        }

        private void ids_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select * from [product] where [id] = '{0}'", id.Text);
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sql);
            while (reader.Read())
            {
                names.Text = reader["onlyname"].ToString();
                stocks.Text = reader["stock"].ToString();
                formats.Text = reader["format"].ToString();
            }
        }
    }
}
