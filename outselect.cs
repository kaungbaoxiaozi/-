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
    public partial class outselect : Form
    {
        public outselect()
        {
            InitializeComponent();
        }

        private void outselect_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet1.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.wMSDataSet1.product);
            // TODO: 这行代码将数据加载到表“wMSDataSet._out”中。您可以根据需要移动或删除它。
            this.outTableAdapter.Fill(this.wMSDataSet._out);
            // TODO: 这行代码将数据加载到表“wMSDataSet.store”中。您可以根据需要移动或删除它。
            this.storeTableAdapter.Fill(this.wMSDataSet.store);
            // TODO: 这行代码将数据加载到表“wMSDataSet._out”中。您可以根据需要移动或删除它。
            this.outTableAdapter.Fill(this.wMSDataSet._out);

        }

        private void bynameToolStripButton_Click(object sender, EventArgs e)
        {
      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.outTableAdapter.byname(this.wMSDataSet._out, nameToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
            try
            {
                this.outTableAdapter.byname(this.wMSDataSet._out, snamecom.Text);
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string time = "'" + dateTimePicker1.Text + "'";
                this.outTableAdapter.bytime(this.wMSDataSet._out,time);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bytimeToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void bynumberToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.outTableAdapter.bynumber(this.wMSDataSet._out, ((int)(System.Convert.ChangeType(mintext.Text, typeof(int)))), ((int)(System.Convert.ChangeType(maxtext.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 还原ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.outTableAdapter.还原(this.wMSDataSet._out);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bysname_pnameToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.outTableAdapter.bysname_pname(this.wMSDataSet._out,dsname.Text, dpname.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
