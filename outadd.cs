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
    public partial class outadd : Form
    {

        public outadd()
        {
            InitializeComponent();
        }

        private void addout_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet.store”中。您可以根据需要移动或删除它。
            this.storeTableAdapter.Fill(this.wMSDataSet.store);
            // TODO: 这行代码将数据加载到表“wMSDataSet.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.wMSDataSet.product);
            // TODO: 这行代码将数据加载到表“wMSDataSet._out”中。您可以根据需要移动或删除它。
            this.outTableAdapter.Fill(this.wMSDataSet._out);
        }

        int p = 0;

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)//滚动条滚动时，获取滚动条位置，用于查询后保持滚动条位置不变
        {
            p = e.NewValue;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.storeTableAdapter.FillBy(this.wMSDataSet.store);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numbert = Convert.ToInt32(number.Text);
            string pnamet = pnamecom.Text;
            string snamet = snamecom.Text;
            string time = DateTime.Now.ToLongDateString().ToString();
            string uid = user.uid;
            string pid;
            int sid;
            //通过产品名称，查询产品id用于后面的库存是否充足判断
            string sqlca = string.Format("select [id] from [product] where [name] = '{0}' ",pnamet);
            pid = SqlHelper.ExecuteScalar(SqlHelper.constr,CommandType.Text,sqlca).ToString();
            //查询店家id
            string sqlcas = string.Format("select [id] from [store] where [name] = '{0}'",snamet);
            sid = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlcas)); 
            //获取出库产品的剩余库存
            string sqlstock = string.Format("select [stock] from [product] where [id] = '{0}'",pid);
            int systock = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlstock));
            //判断出库数量是否大于剩余库存
            if (numbert <= systock)
            {
                string sqlin = string.Format("insert into [out] (number,pname,sname,outtime,uid,sid) values('{0}','{1}','{2}','{3}','{4}','{5}')", numbert, pnamet, snamet, time, uid, sid);
                int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqlin);
                if (row == 1)
                {
                    //刷新datagridview
                    try
                    {
                        this.outTableAdapter.FillBy1(this.wMSDataSet._out);
                        dataGridView1.FirstDisplayedScrollingRowIndex = p;

                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    //更新剩余库存
                    systock = systock - numbert;//剩余库存减去出库数量
                    string sqlup = string.Format("update [product] set [stock] = '{0}' where [id] = '{1}'",systock,pid);
                    string rows =SqlHelper.ExecuteNonQuery(SqlHelper.constr,CommandType.Text,sqlup).ToString();
                    if (rows == "1")
                    {
                        MessageBox.Show("出库成功");
                        //sid = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("库存不足！");
            }
        }

        private void addout_FormClosed(object sender, FormClosedEventArgs e)
        {
            main mai = (main)this.Owner;
            mai.outre();
            mai.prore();
        }

    }
}
