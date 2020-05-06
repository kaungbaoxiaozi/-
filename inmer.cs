using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class inmer : Form
    {
        int number;
        public inmer()
        {
            InitializeComponent();
        }

        private void inmer_FormClosed(object sender, FormClosedEventArgs e)
        {
            main mai = (main)this.Owner;
            mai.inre();
            mai.prore();
        }

        private void inmer_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet.sup”中。您可以根据需要移动或删除它。
            this.supTableAdapter.Fill(this.wMSDataSet.sup);
            // TODO: 这行代码将数据加载到表“wMSDataSet._in”中。您可以根据需要移动或删除它。
            this.inTableAdapter.Fill(this.wMSDataSet._in);

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = indata.CurrentRow.Index;
                id.Text = indata.Rows[index].Cells[0].Value.ToString();
                ids.Text = indata.Rows[index].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text))
            {
                MessageBox.Show("你还没有选择任何记录");
            }
            else
            {
                //通过产品名称，查询产品id

                int pid = Myhelper.Getpidbyname(pnamet.Text);
                //获取入库产品的剩余库存
                string sqlstock = string.Format("select [stock] from [product] where [id] = '{0}'", pid);
                int systock = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlstock));
                //if (Convert.ToInt32(numbert.Text) > systock)
                //{
                //    MessageBox.Show("库存不足！");
                //}
                //else
                //{
                string spnamett = spnamet.Text;
                string sqlsid = string.Format("select [id] from [sup] where [name] = '{0}'", spnamett);//获取供应商id
                int spid = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlsid));
                string time = DateTime.Now.ToLongDateString().ToString();//获取当前时间
                string sql = string.Format("update [in] set [number] = '{0}',[pname] = '{1}',[spname] = '{2}',[intime] = '{3}',[spid] = '{4}',[note] = '{5}' where [id] = '{6}'", numbert.Text, pnamet.Text, spnamet.Text, time, spid, notet.Text, id.Text);
                int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                if (row == 1)
                {
                    int newnumber = Convert.ToInt32(numbert.Text);
                    int kucun = newnumber - number;
                    systock = systock + kucun;
                    string sqlup = string.Format("update [product] set [stock] = '{0}' where [id] = '{1}'", systock, pid);
                    int rows = Convert.ToInt32(SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqlup));
                    if (rows == 1)
                    {
                        MessageBox.Show("修改成功");
                        inmerre();
                    }
                    else
                    {
                        MessageBox.Show("这条记录真的存在吗？");
                    }
                    //}
                }
            }
        }
        public void inmerre()
        {
            this.inTableAdapter.Fill(this.wMSDataSet._in);
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select [number],[spname],[pname],[note] from [in] where id = '{0}'", id.Text);
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sql);
            while (reader.Read())
            {
                numbert.Text = reader["number"].ToString();
                pnamet.Text = reader["pname"].ToString();
                spnamet.Text = reader["spname"].ToString();
                notet.Text = reader["note"].ToString();
            }
            number = Convert.ToInt32(numbert.Text);
        }

        private void deletebut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ids.Text) == false)
            {
                int pids = Myhelper.Getpidbyname(pnamett.Text);
                string sqls = string.Format("update [product] set [stock] = [stock] - '{0}' where [id]='{1}'", numbertt.Text, pids);
                int rows = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sqls);
                if (rows == 1)
                {
                    string sql = string.Format("delete from [in] where [id] = '{0}'", ids.Text);
                    int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
                    if (row == 1)
                    {
                        MessageBox.Show("删除成功");
                        this.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("你没有选中任何行");
            }

        }

        private void ids_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select [number],[spname],[pname],[note],[intime] from [in] where id = '{0}'", id.Text);
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sql);
            while (reader.Read())
            {
                numbertt.Text = reader["number"].ToString();
                pnamett.Text = reader["pname"].ToString();
                spnamett.Text = reader["spname"].ToString();
                intimett.Text = reader["intime"].ToString();
            }
            number = Convert.ToInt32(numbert.Text);
        }

        public void Clear()
        {
            ids.Text = null;
            id.Text = null;
            numbert.Text = null;
            pnamet.Text = null;
            spnamet.Text = null;
            notet.Text = null;
            numbertt.Text = null;
            pnamett.Text = null;
            spnamett.Text = null;
            intimett.Text = null;
        }
    }
}
