namespace Warehouse_Manager
{
    partial class test0
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
            this.wMSDataSet = new Warehouse_Manager.WMSDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.userTableAdapter();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.账号管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理权限仅管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.终端管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限分级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s1完全控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s2只读ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s2可读写ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.outTableAdapter();
            this.outpa = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inpa = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.storepa = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.inBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.inTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.storeTableAdapter();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outBindingSource)).BeginInit();
            this.outpa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.inpa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.storepa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账号管理ToolStripMenuItem,
            this.出库管理ToolStripMenuItem,
            this.入库管理ToolStripMenuItem,
            this.终端管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 25);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 账号管理ToolStripMenuItem
            // 
            this.账号管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销ToolStripMenuItem,
            this.更改密码ToolStripMenuItem,
            this.管理权限仅管理员ToolStripMenuItem});
            this.账号管理ToolStripMenuItem.Name = "账号管理ToolStripMenuItem";
            this.账号管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.账号管理ToolStripMenuItem.Text = "账号管理";
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.注销ToolStripMenuItem.Text = "注销";
            // 
            // 更改密码ToolStripMenuItem
            // 
            this.更改密码ToolStripMenuItem.Name = "更改密码ToolStripMenuItem";
            this.更改密码ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.更改密码ToolStripMenuItem.Text = "更改密码";
            // 
            // 管理权限仅管理员ToolStripMenuItem
            // 
            this.管理权限仅管理员ToolStripMenuItem.Name = "管理权限仅管理员ToolStripMenuItem";
            this.管理权限仅管理员ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.管理权限仅管理员ToolStripMenuItem.Text = "管理权限（仅管理员）";
            // 
            // 出库管理ToolStripMenuItem
            // 
            this.出库管理ToolStripMenuItem.Name = "出库管理ToolStripMenuItem";
            this.出库管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.出库管理ToolStripMenuItem.Text = "出库管理";
            this.出库管理ToolStripMenuItem.Click += new System.EventHandler(this.出库管理ToolStripMenuItem_Click);
            // 
            // 入库管理ToolStripMenuItem
            // 
            this.入库管理ToolStripMenuItem.Name = "入库管理ToolStripMenuItem";
            this.入库管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.入库管理ToolStripMenuItem.Text = "入库管理";
            this.入库管理ToolStripMenuItem.Click += new System.EventHandler(this.入库管理ToolStripMenuItem_Click);
            // 
            // 终端管理ToolStripMenuItem
            // 
            this.终端管理ToolStripMenuItem.Name = "终端管理ToolStripMenuItem";
            this.终端管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.终端管理ToolStripMenuItem.Text = "终端管理";
            this.终端管理ToolStripMenuItem.Click += new System.EventHandler(this.终端管理ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.权限分级ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 权限分级ToolStripMenuItem
            // 
            this.权限分级ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.s1完全控制ToolStripMenuItem,
            this.s2只读ToolStripMenuItem,
            this.s2可读写ToolStripMenuItem});
            this.权限分级ToolStripMenuItem.Name = "权限分级ToolStripMenuItem";
            this.权限分级ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.权限分级ToolStripMenuItem.Text = "权限分级";
            // 
            // s1完全控制ToolStripMenuItem
            // 
            this.s1完全控制ToolStripMenuItem.Name = "s1完全控制ToolStripMenuItem";
            this.s1完全控制ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.s1完全控制ToolStripMenuItem.Text = "S0:只读";
            // 
            // s2只读ToolStripMenuItem
            // 
            this.s2只读ToolStripMenuItem.Name = "s2只读ToolStripMenuItem";
            this.s2只读ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.s2只读ToolStripMenuItem.Text = "S1:完全控制";
            // 
            // s2可读写ToolStripMenuItem
            // 
            this.s2可读写ToolStripMenuItem.Name = "s2可读写ToolStripMenuItem";
            this.s2可读写ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.s2可读写ToolStripMenuItem.Text = "S2:可读写";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // outBindingSource
            // 
            this.outBindingSource.DataMember = "out";
            this.outBindingSource.DataSource = this.wMSDataSet;
            // 
            // outTableAdapter
            // 
            this.outTableAdapter.ClearBeforeFill = true;
            // 
            // outpa
            // 
            this.outpa.Controls.Add(this.dataGridView1);
            this.outpa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outpa.Location = new System.Drawing.Point(0, 25);
            this.outpa.Name = "outpa";
            this.outpa.Size = new System.Drawing.Size(800, 425);
            this.outpa.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.numberDataGridViewTextBoxColumn1,
            this.pnameDataGridViewTextBoxColumn1,
            this.snameDataGridViewTextBoxColumn,
            this.sidDataGridViewTextBoxColumn,
            this.outtimeDataGridViewTextBoxColumn,
            this.uidDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.outBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // inpa
            // 
            this.inpa.Controls.Add(this.dataGridView2);
            this.inpa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inpa.Location = new System.Drawing.Point(0, 25);
            this.inpa.Name = "inpa";
            this.inpa.Size = new System.Drawing.Size(800, 425);
            this.inpa.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.spnameDataGridViewTextBoxColumn,
            this.spidDataGridViewTextBoxColumn,
            this.intimeDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.uidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.inBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(800, 425);
            this.dataGridView2.TabIndex = 0;
            // 
            // storepa
            // 
            this.storepa.Controls.Add(this.dataGridView3);
            this.storepa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storepa.Location = new System.Drawing.Point(0, 25);
            this.storepa.Name = "storepa";
            this.storepa.Size = new System.Drawing.Size(800, 425);
            this.storepa.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.storeBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(800, 425);
            this.dataGridView3.TabIndex = 0;
            // 
            // inBindingSource
            // 
            this.inBindingSource.DataMember = "in";
            this.inBindingSource.DataSource = this.wMSDataSet;
            // 
            // inTableAdapter
            // 
            this.inTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "pname";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            // 
            // spnameDataGridViewTextBoxColumn
            // 
            this.spnameDataGridViewTextBoxColumn.DataPropertyName = "spname";
            this.spnameDataGridViewTextBoxColumn.HeaderText = "spname";
            this.spnameDataGridViewTextBoxColumn.Name = "spnameDataGridViewTextBoxColumn";
            // 
            // spidDataGridViewTextBoxColumn
            // 
            this.spidDataGridViewTextBoxColumn.DataPropertyName = "spid";
            this.spidDataGridViewTextBoxColumn.HeaderText = "spid";
            this.spidDataGridViewTextBoxColumn.Name = "spidDataGridViewTextBoxColumn";
            // 
            // intimeDataGridViewTextBoxColumn
            // 
            this.intimeDataGridViewTextBoxColumn.DataPropertyName = "intime";
            this.intimeDataGridViewTextBoxColumn.HeaderText = "intime";
            this.intimeDataGridViewTextBoxColumn.Name = "intimeDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // uidDataGridViewTextBoxColumn
            // 
            this.uidDataGridViewTextBoxColumn.DataPropertyName = "uid";
            this.uidDataGridViewTextBoxColumn.HeaderText = "uid";
            this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn1
            // 
            this.numberDataGridViewTextBoxColumn1.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn1.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn1.Name = "numberDataGridViewTextBoxColumn1";
            // 
            // pnameDataGridViewTextBoxColumn1
            // 
            this.pnameDataGridViewTextBoxColumn1.DataPropertyName = "pname";
            this.pnameDataGridViewTextBoxColumn1.HeaderText = "pname";
            this.pnameDataGridViewTextBoxColumn1.Name = "pnameDataGridViewTextBoxColumn1";
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "sid";
            this.sidDataGridViewTextBoxColumn.HeaderText = "sid";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            // 
            // outtimeDataGridViewTextBoxColumn
            // 
            this.outtimeDataGridViewTextBoxColumn.DataPropertyName = "outtime";
            this.outtimeDataGridViewTextBoxColumn.HeaderText = "outtime";
            this.outtimeDataGridViewTextBoxColumn.Name = "outtimeDataGridViewTextBoxColumn";
            // 
            // uidDataGridViewTextBoxColumn1
            // 
            this.uidDataGridViewTextBoxColumn1.DataPropertyName = "uid";
            this.uidDataGridViewTextBoxColumn1.HeaderText = "uid";
            this.uidDataGridViewTextBoxColumn1.Name = "uidDataGridViewTextBoxColumn1";
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "store";
            this.storeBindingSource.DataSource = this.wMSDataSet;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            this.noteDataGridViewTextBoxColumn1.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn1.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            // 
            // patest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.storepa);
            this.Controls.Add(this.inpa);
            this.Controls.Add(this.outpa);
            this.Controls.Add(this.menuStrip2);
            this.Name = "patest";
            this.Text = "patest";
            this.Load += new System.EventHandler(this.patest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outBindingSource)).EndInit();
            this.outpa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.inpa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.storepa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private WMSDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 账号管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理权限仅管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 终端管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限分级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem s1完全控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem s2只读ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem s2可读写ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.BindingSource outBindingSource;
        private WMSDataSetTableAdapters.outTableAdapter outTableAdapter;
        private System.Windows.Forms.Panel outpa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel inpa;
        private System.Windows.Forms.Panel storepa;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource inBindingSource;
        private WMSDataSetTableAdapters.inTableAdapter inTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private WMSDataSetTableAdapters.storeTableAdapter storeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
    }
}