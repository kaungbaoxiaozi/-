using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Manager
{
    public static class Myhelper
    {

        public static int Getpidbyname(string name)//通过产品名，查询产品id
        {
            string sql = string.Format("select [id] from [product] where [name] = '{0}'",name);
            int pid = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr,System.Data.CommandType.Text,sql));
            return  pid;
        }

        public static int Getstockbyid(int id)//通过id，查询剩余库存
        {
            string sql = string.Format("select [stock] from [product] where [id] = '{0}'",id);
            int systock = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, System.Data.CommandType.Text, sql));
            return systock;
        }

        public static int Upstock_delete(int newstock,int id)//更新对应铲平得信息，需要提供新库存和产品id两个参数，返还执行结果1
        {
            string sql = string.Format("update [product] set [stock] = '{0}' where [id] = '{1}' ",newstock,id);
            int row = Convert.ToInt32(SqlHelper.ExecuteNonQuery(SqlHelper.constr, System.Data.CommandType.Text, sql));
            return row;
        }
    }
    
}
