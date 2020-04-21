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
    public partial class test3 : Form
    {
        public test3()
        {
            InitializeComponent();
        }

        private void test3_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet.sup”中。您可以根据需要移动或删除它。
            this.supTableAdapter.Fill(this.wMSDataSet.sup);
            dataGridView1.Columns[0].ReadOnly = true;
            //dataGridView1.Rows[0].ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.supTableAdapter.Fill(this.wMSDataSet.sup);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string cell = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            //string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string strrow = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//获取焦点触发行的第一个值
            MessageBox.Show(cell, strrow);
        }
    }
}
