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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wMSDataSet._in”中。您可以根据需要移动或删除它。
            this.inTableAdapter.Fill(this.wMSDataSet._in);
            // TODO: 这行代码将数据加载到表“wMSDataSet.sup”中。您可以根据需要移动或删除它。
            this.supTableAdapter.Fill(this.wMSDataSet.sup);
            // TODO: 这行代码将数据加载到表“wMSDataSet.product”中。您可以根据需要移动或删除它。
            this.productTableAdapter.Fill(this.wMSDataSet.product);
            // TODO: 这行代码将数据加载到表“wMSDataSet.store”中。您可以根据需要移动或删除它。
            this.storeTableAdapter.Fill(this.wMSDataSet.store);

            // TODO: 这行代码将数据加载到表“wMSDataSet._out”中。您可以根据需要移动或删除它。
            this.outTableAdapter.Fill(this.wMSDataSet._out);
            //power.Text ="当前权限等级:"+ user.power;
            //label1.Text = user.uid;
            //label2.Text = user.upwd;
            if (user.power != "S1")
            {
                管理权限仅管理员ToolStripMenuItem.Enabled = false;
            }
            //powerss.Text = "当前权限等级:" + user.power;
            namess.Text = "【当前登录用户:" + user.uname + " | 权限等级:" + user.power + "】 ";
            propa.Visible = true;
            outpa.Visible = false;
            storepa.Visible = false;
            inpa.Visible = false;
            sppa.Visible = false;
            panelname.Text = "库存查询";
            string[] setting = GetSetting();
            if (Convert.ToInt32(setting[0]) == 1)
            {
                myplayer.URL = setting[1];
            }
            else
            {
                myplayer.URL = null;
            }

        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)//注销登录
        {
            if (MessageBox.Show("确定注销账户吗？", "在？", MessageBoxButtons.OKCancel) == DialogResult.OK)//弹出对话框二次询问
            {
                this.Hide();
                this.myplayer.Ctlcontrols.pause();
                login login = new login();
                login.Show();
            }
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usercpwd cpwd = new usercpwd();
            cpwd.ShowDialog();
        }

        private void 管理权限仅管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (user.power == "S1")
            {
                //MessageBox.Show("你是谁？","二次确认",MessageBoxButtons.);
                usermer cuser = new usermer();
                cuser.ShowDialog();
            }
            else
            {
                MessageBox.Show("你没有权限访问", "无权限", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void power_Click(object sender, EventArgs e)
        {
            MessageBox.Show("S1:完全控制,S0:仅查询", "等级说明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timess.Text = DateTime.Now.ToString();
        }

        private void 库存查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propa.Visible = true;
            outpa.Visible = false;
            storepa.Visible = false;
            inpa.Visible = false;
            sppa.Visible = false;
            panelname.Text = "库存查询";

        }

        private void 出库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propa.Visible = false;
            outpa.Visible = true;
            storepa.Visible = false;
            inpa.Visible = false;
            sppa.Visible = false;
            panelname.Text = "出库管理";
        }

        private void 终端管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propa.Visible = false;
            outpa.Visible = false;
            storepa.Visible = true;
            inpa.Visible = false;
            sppa.Visible = false;
            panelname.Text = "终端管理";
        }

        private void 入库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propa.Visible = false;
            outpa.Visible = false;
            storepa.Visible = false;
            inpa.Visible = true;
            sppa.Visible = false;
            panelname.Text = "入库管理";
        }

        private void 供应商管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propa.Visible = false;
            outpa.Visible = false;
            storepa.Visible = false;
            inpa.Visible = false;
            sppa.Visible = true;
            panelname.Text = "供应商管理";
        }

        private void 刷新ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.supTableAdapter.刷新(this.wMSDataSet.sup);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show（< 字符串 > Text, < 字符串 > Title, < 整型 > nType，MessageBoxIcon）;
            if (MessageBox.Show("确定退出吗？", "在？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                System.Environment.Exit(System.Environment.ExitCode);

                this.Dispose();

                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void 添加出库记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outadd addout = new outadd();
            addout.ShowDialog(this);
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Refresh();
        }

        private void 刷新ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.outTableAdapter.刷新(this.wMSDataSet._out);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void 开发日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log ab = new log();
            ab.ShowDialog();
        }

        private void 作者说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.ShowDialog();
        }



        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting set = new setting(this);
            set.ShowDialog(this);
        }

        private void warning_Tick(object sender, EventArgs e)
        {
            string sqlwar = string.Format("select [warning] from [setting] where [id] = '{0}' ", user.uid);
            string warning = SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlwar).ToString();
            string sqlrow = string.Format("SELECT COUNT(name) FROM [product] where [stock] <= '{0}'", warning);
            int row = (int)SqlHelper.ExecuteScalar(SqlHelper.constr, CommandType.Text, sqlrow);//返还第一条第一列的数据 多用行数查询
            if (row == 0)
            {
                warinfo.Text = null;
            }
            else
            {
                warinfo.Text = "注意:目前有" + row.ToString() + "件商品缺货";
            }
        }

        private void 条件查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outselect outs = new outselect();
            outs.Show(this);
        }

        private void 更新出库记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outmer outmer = new outmer();
            outmer.ShowDialog(this);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.FillBy(this.wMSDataSet.product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void 录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storeadd storeadd = new storeadd();
            storeadd.ShowDialog(this);
        }

        private void 更新终端信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storemer storemer = new storemer();
            storemer.Show(this);
        }

        private void 添加入库记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inadd inadd = new inadd();
            inadd.Show(this);
        }

        private void 更新出库记录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inmer inmer = new inmer();
            inmer.Show(this);
        }

        private void 添加供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spadd spadd = new spadd();
            spadd.Show(this);
        }

        private void 维护供应商信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spmer spmer = new spmer();
            spmer.Show(this);
        }

        //*************************************************自定义方法*****************************************************//

        public void outre()//刷新出库
        {
            try
            {
                this.outTableAdapter.FillBy(this.wMSDataSet._out);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void prore()//刷新库存
        {
            try
            {
                this.productTableAdapter.FillBy(this.wMSDataSet.product);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void storere()//刷新商店
        {
            try
            {
                this.storeTableAdapter.store(this.wMSDataSet.store);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void inre()//刷新入库
        {
            try
            {
                this.inTableAdapter.Fill(this.wMSDataSet._in);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void spre()//刷新供应商
        {
            this.supTableAdapter.Fill(this.wMSDataSet.sup);
        }

        public void SetPlayerUrl(string url)
        {
            myplayer.URL = url;
        }
        /// <summary>
        /// 获取用户设置
        /// </summary>
        /// <returns>返还一个数组(bgmmode，bgmurl)</returns>
        public string[] GetSetting()
        {
            string sql = string.Format("select [bgmmode],[bgmurl] from [setting] where [id] = '{0}'", user.uid);
            string[] setting = new string[2];
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.constr, CommandType.Text, sql);
            while (reader.Read())
            {
                setting[0] = reader["bgmmode"].ToString();
                setting[1] = reader["bgmurl"].ToString();
            }
            return setting;
        }


        private void myplayer_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            switch (Convert.ToInt32(myplayer.playState))
            {
                case 3:
                    myplayer.Ctlcontrols.pause();
                    break;
                case 2:
                    myplayer.Ctlcontrols.play();
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void myplayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //if( Convert.ToInt32( myplayer.playState) == 1)
            //{
            //string[] setting = GetSetting();
            ////myplayer.settings.setMode("loop", true);
            //myplayer.URL = setting[1];
            //myplayer.Ctlcontrols.play();

            //}
            if ((int)myplayer.playState == 1)
            {
                myplayer.Ctlcontrols.play();
            }

        }

        private void 添加产品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productadd productadd = new productadd();
            productadd.Show(this);
        }

        private void 管理产品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productmer productmer = new productmer();
            productmer.Show(this);
        }

        private void 刷新ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.prore();
            this.inre();
            this.outre();
            this.spre();

        }
    }
}
