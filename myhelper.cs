using SpeechLib;
using System;

namespace Warehouse_Manager
{
    public static class Myhelper//本类都是静态方法，可直接引用，无需实例化
    {
        /// <summary>
        /// 通过产品名，查询产品ID
        /// </summary>
        /// <param name="name">产品名</param>
        /// <returns>返还与输入产品名对应的产品ID</returns>
        public static int Getpidbyname(string name)//通过产品名，查询产品id
        {
            string sql = string.Format("select [id] from [product] where [name] = '{0}'", name);
            int pid = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, System.Data.CommandType.Text, sql));
            return pid;
        }

        /// <summary>
        /// 通过供应商名，查询供应商id
        /// </summary>
        /// <param name="name">供应商名称</param>
        /// <returns>返还供应商ID</returns>
        public static int Getspidbyname(string name)//通过供应商名，查询供应商id
        {
            string sql = string.Format("select [id] from [sup] where [name] = '{0}'", name);
            int spid = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, System.Data.CommandType.Text, sql));
            return spid;
        }

        /// <summary>
        /// 通过产品ID，查询剩余库存
        /// </summary>
        /// <param name="id">产品ID</param>
        /// <returns>返还剩余库存（int）</returns>
        public static int Getstockbyid(int id)//通过id，查询剩余库存
        {
            string sql = string.Format("select [stock] from [product] where [id] = '{0}'", id);
            int systock = Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.constr, System.Data.CommandType.Text, sql));
            return systock;
        }

        /// <summary>
        /// 更新产品库存信息，需输入两个参数：处理后的库存与需要修改的产品ID
        /// </summary>
        /// <param name="newstock">处理后的库存</param>
        /// <param name="id">产品ID</param>
        /// <returns>返还“1”说明更新成功</returns>
        public static int Upstock_delete(int newstock, int id)//更新对应产品信息，需要提供新库存和产品id两个参数，返还执行结果1
        {
            string sql = string.Format("update [product] set [stock] = '{0}' where [id] = '{1}' ", newstock, id);
            int row = Convert.ToInt32(SqlHelper.ExecuteNonQuery(SqlHelper.constr, System.Data.CommandType.Text, sql));
            return row;
        }

        /// <summary>
        /// 利用sql直接进行库存的加减
        /// </summary>
        /// <param name="id">产品id</param>
        /// <param name="addstock">需要出口的库存数（正加负减）</param>
        /// <returns>返还执行结果</returns>
        public static int Upstock_sql(int id, int addstock)
        {
            string sql = string.Format("update [product] set [stock] = [stock] + '{0}' where [id] = '{1}'", addstock, id);
            int row = SqlHelper.ExecuteNonQuery(SqlHelper.constr, System.Data.CommandType.Text, sql);
            return row;
        }

        public static string Gettime()
        {
            string time = DateTime.Now.ToLongDateString();
            return time;
        }
        /// <summary>
        /// TTS文字转语音，传入需要转换的文本
        /// </summary>
        /// <param name="text">需要转语音的文本</param>
        public static void Speak(string text)
        {
            SpVoiceClass voice = new SpVoiceClass();
            voice.Volume = user.volume;
            voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
            voice.Speak(text, SpeechVoiceSpeakFlags.SVSFDefault);
        }
    }

}
