using System;
using System.Data;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class spadd : Form
    {
        public spadd()
        {
            InitializeComponent();
        }

        private void spadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            main mai = (main)this.Owner;
            mai.spre();
        }

        private void spadd_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet.sup”中。您可以根据需要移动或删除它。
            this.supTableAdapter.Fill(this.wMSDataSet.sup);
            // TODO: 这行代码将数据加载到表“wMSDataSet.sup”中。您可以根据需要移动或删除它。
            this.supTableAdapter.Fill(this.wMSDataSet.sup);

        }

        private void addbut_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(name.Text) == false)
            {
                int row = Insert(name.Text, address.Text, phone.Text, note.Text);
                if (row == 1)
                {
                    MessageBox.Show("录入成功");
                    this.supTableAdapter.Fill(this.wMSDataSet.sup);
                }
            }
        }

        public static int Insert(string name, string address, string phone, string note)
        {
            string sql = string.Format("insert into [sup] ([name],[address],[phone],[note]) values('{0}','{1}','{2}','{3}') ", name, address, phone, note);
            int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql);
            return row;
        }
    }
}
