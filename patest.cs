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
    public partial class patest : Form
    {
        public patest()
        {
            InitializeComponent();
        }

        private void patest_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet.store”中。您可以根据需要移动或删除它。
            this.storeTableAdapter.Fill(this.wMSDataSet.store);
            // TODO: 这行代码将数据加载到表“wMSDataSet._in”中。您可以根据需要移动或删除它。
            this.inTableAdapter.Fill(this.wMSDataSet._in);
            // TODO: 这行代码将数据加载到表“wMSDataSet._out”中。您可以根据需要移动或删除它。
            this.outTableAdapter.Fill(this.wMSDataSet._out);
            // TODO: 这行代码将数据加载到表“wMSDataSet.user”中。您可以根据需要移动或删除它。
            this.userTableAdapter.Fill(this.wMSDataSet.user);

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //userpanl.Visible = true;
            //outpa.Visible = false;
        }

        private void butToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //userpanl.Visible = false;
            //outpa.Visible = true;
        }

        private void 出库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outpa.Visible = true;
            inpa.Visible = false;
            storepa.Visible = false;
        }

        private void 入库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inpa.Visible = true;
            storepa.Visible = false;
            outpa.Visible = false;
        }

        private void 终端管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inpa.Visible = false;
            storepa.Visible = true;
            outpa.Visible = false;
        }
    }
}
