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
    public partial class inadd : Form
    {
        public inadd()
        {
            InitializeComponent();
        }

        private void inadd_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.wMSDataSet.product);
            // TODO: 这行代码将数据加载到表“wMSDataSet.sup”中。您可以根据需要移动或删除它。
            this.supTableAdapter.Fill(this.wMSDataSet.sup);
            // TODO: 这行代码将数据加载到表“wMSDataSet._in”中。您可以根据需要移动或删除它。
            this.inTableAdapter.Fill(this.wMSDataSet._in);

        }

        private void inadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            main mai = (main)this.Owner;
            mai.inre();
            mai.prore();
        }

        private void inbut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(number.Text) == false || string.IsNullOrWhiteSpace(spname.Text) == false || string.IsNullOrWhiteSpace(pname.Text) == false)
            {
                string time = Myhelper.Gettime();
                int spid = Myhelper.Getspidbyname(spname.Text);
                string sql = string.Format("insert into [in] (number,pname,spname,spid,intime,uid) values('{0}','{1}','{2}','{3}','{4}','{5}')", number.Text, pname.Text, spname.Text, spid, time, user.uid);
                int rows = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                if (rows == 1)
                {
                    int pid = Myhelper.Getpidbyname(pname.Text);
                    int row = Myhelper.Upstock_sql(pid, Convert.ToInt32(number.Text));
                    if (row == 1)
                    {
                        MessageBox.Show("入库成功");
                        this.inTableAdapter.Fill(this.wMSDataSet._in);
                    }
                }
            }
        }
    }
}
