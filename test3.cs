using System;
using System.ComponentModel;
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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.supTableAdapter.Fill(this.wMSDataSet.sup);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (myplayer.Visible == false)
            {
                myplayer.Visible = true;
            }
            else
            {
                myplayer.Visible = false;
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
