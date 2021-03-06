﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class outmer : Form
    {
        public outmer()
        {
            InitializeComponent();
        }
        int number;

        private void outmer_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet.store”中。您可以根据需要移动或删除它。
            this.storeTableAdapter.Fill(this.wMSDataSet.store);
            // TODO: 这行代码将数据加载到表“wMSDataSet.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.wMSDataSet.product);
            // TODO: 这行代码将数据加载到表“wMSDataSet._out”中。您可以根据需要移动或删除它。
            this.outTableAdapter.Fill(this.wMSDataSet._out);

        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int index = outmerdata.CurrentRow.Index;
                id.Text = outmerdata.Rows[index].Cells[0].Value.ToString();
                ids.Text = outmerdata.Rows[index].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

            string sql = string.Format("select [number],[pname],[sname] from [out] where id = '{0}'", id.Text);
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sql);
            while (reader.Read())
            {
                numbert.Text = reader["number"].ToString();
                pnamet.Text = reader["pname"].ToString();
                snamet.Text = reader["sname"].ToString();
            }
            number = Convert.ToInt32(numbert.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text))
            {
                MessageBox.Show("你还没有选择任何记录");
            }
            else
            {
                //通过产品名称，查询产品id用于后面的库存是否充足判断
                string sqlca = string.Format("select [id] from [product] where [name] = '{0}' ", pnamet.Text);
                int pid = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlca));
                //获取出库产品的剩余库存
                string sqlstock = string.Format("select [stock] from [product] where [id] = '{0}'", pid);
                int systock = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlstock));
                if (Convert.ToInt32(numbert.Text) > systock)
                {
                    MessageBox.Show("库存不足！");
                }
                else
                {
                    string snamett = snamet.Text;
                    string sqlsid = string.Format("select [id] from [store] where [name] = '{0}'", snamett);
                    int sid = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlsid));
                    string time = DateTime.Now.ToLongDateString().ToString();
                    string sql = string.Format("update [out] set [number] = '{0}',[pname] = '{1}',[sname] = '{2}',[outtime] = '{3}',[sid] = '{4}' where [id] = '{5}'", numbert.Text, pnamet.Text, snamet.Text, time, sid, id.Text);
                    int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                    if (row == 1)
                    {
                        int newnumber = Convert.ToInt32(numbert.Text);
                        int kucun = newnumber - number;
                        systock = systock - kucun;
                        string sqlup = string.Format("update [product] set [stock] = '{0}' where [id] = '{1}'", systock, pid);
                        int rows = Convert.ToInt32(SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqlup));
                        if (rows == 1)
                        {
                            MessageBox.Show("修改成功");
                            outremer();
                        }
                        else
                        {
                            MessageBox.Show("这条记录真的存在吗？");
                        }
                    }
                }
            }
        }

        private void outmer_FormClosed(object sender, FormClosedEventArgs e)
        {
            main mai = (main)this.Owner;
            mai.prore();
            mai.outre();
        }

        private void IDD_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select [number],[pname],[sname],[outtime] from [out] where id = '{0}'", id.Text);
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sql);
            while (reader.Read())
            {
                numbertt.Text = reader["number"].ToString();
                pnamett.Text = reader["pname"].ToString();
                snamett.Text = reader["sname"].ToString();
                outtimett.Text = reader["outtime"].ToString();
            }
        }
        private void outremer()
        {
            try
            {
                this.outTableAdapter.Fill(this.wMSDataSet._out);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ids.Text))
            {
                MessageBox.Show("你还没有选择任何记录");
            }
            else
            {
                if (MessageBox.Show("是否删除该记录？", "在？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int pid = Myhelper.Getpidbyname(pnamett.Text);
                    int systock = Myhelper.Getstockbyid(pid);
                    int denumber = Convert.ToInt32(numbertt.Text);
                    int newstock = systock + denumber;
                    int row = Myhelper.Upstock_delete(newstock, pid);
                    if (row == 1 || row != 1)//row=1：库存已经更新
                    {
                        string sql = string.Format("delete from [out] where [id] = '{0}'", ids.Text);
                        int rows = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                        if (rows == 1)
                        {
                            MessageBox.Show("删除成功");
                            outremer();
                            id.Text = null;
                            ids.Text = null;
                        }
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            outremer();
        }
    }
}
