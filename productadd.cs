using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class productadd : Form
    {
        public productadd()
        {
            InitializeComponent();
        }

        private void productadd_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.wMSDataSet.product);

        }

        private void add_Click(object sender, EventArgs e)
        {
            string nameformat = string.Format("{0}({1})", name.Text, format.Text);
            string sql = string.Format("insert into [product] ([name],[format],[onlyname]) values('{0}','{1}','{2}')", nameformat, format.Text, name.Text);
            int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
            if (row == 1)
            {
                MessageBox.Show("添加成功");
                this.productTableAdapter.Fill(this.wMSDataSet.product);
            }
        }

        private void productadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            main mai = (main)this.Owner;
            mai.prore();
        }

        private void productadd_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("添加产品后，库存默认为零（0），如需添加库存，需要在入库管理模块另行添加", "指南", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
