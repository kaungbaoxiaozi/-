namespace Warehouse_Manager
{
    partial class usermer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.uppower = new System.Windows.Forms.ComboBox();
            this.upid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deid = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.inname = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbut = new System.Windows.Forms.Button();
            this.cx = new System.Windows.Forms.TextBox();
            this.tj = new System.Windows.Forms.ComboBox();
            this.inpwds = new System.Windows.Forms.TextBox();
            this.inpwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.wMSDataSet = new Warehouse_Manager.WMSDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.userTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userlist
            // 
            this.userlist.BackColor = System.Drawing.SystemColors.Info;
            this.userlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.userlist.Dock = System.Windows.Forms.DockStyle.Right;
            this.userlist.FullRowSelect = true;
            this.userlist.GridLines = true;
            this.userlist.HideSelection = false;
            this.userlist.Location = new System.Drawing.Point(225, 0);
            this.userlist.Name = "userlist";
            this.userlist.Size = new System.Drawing.Size(425, 431);
            this.userlist.TabIndex = 0;
            this.userlist.UseCompatibleStateImageBehavior = false;
            this.userlist.View = System.Windows.Forms.View.Details;
            this.userlist.Click += new System.EventHandler(this.userlist_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "账号";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "密码";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "权限";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "最后登录时间";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "姓名";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uppower
            // 
            this.uppower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uppower.FormattingEnabled = true;
            this.uppower.Items.AddRange(new object[] {
            "S0",
            "S1",
            "S2"});
            this.uppower.Location = new System.Drawing.Point(71, 68);
            this.uppower.Name = "uppower";
            this.uppower.Size = new System.Drawing.Size(121, 20);
            this.uppower.TabIndex = 3;
            // 
            // upid
            // 
            this.upid.Location = new System.Drawing.Point(71, 41);
            this.upid.Name = "upid";
            this.upid.Size = new System.Drawing.Size(121, 21);
            this.upid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "修改权限：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "删除用户";
            // 
            // deid
            // 
            this.deid.Location = new System.Drawing.Point(71, 135);
            this.deid.Name = "deid";
            this.deid.Size = new System.Drawing.Size(121, 21);
            this.deid.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(71, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inname
            // 
            this.inname.Location = new System.Drawing.Point(71, 206);
            this.inname.Name = "inname";
            this.inname.Size = new System.Drawing.Size(121, 21);
            this.inname.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(71, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "添加";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbut);
            this.panel1.Controls.Add(this.cx);
            this.panel1.Controls.Add(this.tj);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.inpwds);
            this.panel1.Controls.Add(this.inpwd);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.inname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.upid);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.uppower);
            this.panel1.Controls.Add(this.deid);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 431);
            this.panel1.TabIndex = 11;
            // 
            // cbut
            // 
            this.cbut.Location = new System.Drawing.Point(71, 392);
            this.cbut.Name = "cbut";
            this.cbut.Size = new System.Drawing.Size(75, 23);
            this.cbut.TabIndex = 14;
            this.cbut.Text = "查询";
            this.cbut.UseVisualStyleBackColor = true;
            this.cbut.Click += new System.EventHandler(this.cbut_Click);
            // 
            // cx
            // 
            this.cx.Location = new System.Drawing.Point(71, 364);
            this.cx.Name = "cx";
            this.cx.Size = new System.Drawing.Size(100, 21);
            this.cx.TabIndex = 13;
            // 
            // tj
            // 
            this.tj.FormattingEnabled = true;
            this.tj.Items.AddRange(new object[] {
            "账号",
            "权限",
            "姓名"});
            this.tj.Location = new System.Drawing.Point(71, 337);
            this.tj.Name = "tj";
            this.tj.Size = new System.Drawing.Size(121, 20);
            this.tj.TabIndex = 12;
            // 
            // inpwds
            // 
            this.inpwds.Location = new System.Drawing.Point(71, 262);
            this.inpwds.Name = "inpwds";
            this.inpwds.Size = new System.Drawing.Size(121, 21);
            this.inpwds.TabIndex = 11;
            // 
            // inpwd
            // 
            this.inpwd.Location = new System.Drawing.Point(71, 234);
            this.inpwd.Name = "inpwd";
            this.inpwd.Size = new System.Drawing.Size(121, 21);
            this.inpwd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "添加用户:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "账号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "账号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "姓名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "条件：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "权限：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "密码：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "确认密码：";
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.wMSDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "内容：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "查询用户:";
            // 
            // usermer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userlist);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "usermer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理用户";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.listviewtest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView userlist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox uppower;
        private System.Windows.Forms.TextBox upid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox inname;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inpwds;
        private System.Windows.Forms.TextBox inpwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cbut;
        private System.Windows.Forms.TextBox cx;
        private System.Windows.Forms.ComboBox tj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private WMSDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}