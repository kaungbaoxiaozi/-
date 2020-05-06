using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class test4 : Form
    {
        public test4()
        {
            InitializeComponent();
        }

        private void test4_Load(object sender, EventArgs e)
        {
            string sql = string.Format("select [time] from [log]");
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sql);
            int row = Convert.ToInt32(SqlHelper.ExecuteNonQuery(SqlHelper.constr, CommandType.Text, sql));
            while (reader.Read())
            {
                date.AppendText("\n" + reader["time"].ToString());
            }
        }
    }
}
