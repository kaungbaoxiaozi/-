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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet.store”中。您可以根据需要移动或删除它。
            this.storeTableAdapter.Fill(this.wMSDataSet.store);
            // TODO: 这行代码将数据加载到表“wMSDataSet._out”中。您可以根据需要移动或删除它。
            this.outTableAdapter.Fill(this.wMSDataSet._out);
            // TODO: 这行代码将数据加载到表“wMSDataSet._in”中。您可以根据需要移动或删除它。
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("选中行"+(e.RowIndex+1));
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.outTableAdapter.FillBy(this.wMSDataSet._out);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void refresh()
        {
            try
            {
                this.outTableAdapter.FillBy(this.wMSDataSet._out);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.outTableAdapter.FillBy2(this.wMSDataSet._out,sname.Text);
        }

        private void 出库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outadd add = new outadd();
            add.Show();
        }

        private void 测试ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.outTableAdapter.测试(this.wMSDataSet._out);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.outTableAdapter.FillBy2(this.wMSDataSet._out, snameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void storeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.storeTableAdapter.store(this.wMSDataSet.store);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
