namespace Warehouse_Manager
{
    partial class test
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.账号管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.管理权限仅管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.终端管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我要入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供应商管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加供应商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限分级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s1完全控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s2只读ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s2可读写ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new Warehouse_Manager.WMSDataSet();
            this.outTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.outTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storeTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.storeTableAdapter();
            this.测试ToolStrip = new System.Windows.Forms.ToolStrip();
            this.测试ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.snameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.snameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sname = new System.Windows.Forms.ComboBox();
            this.storeToolStrip = new System.Windows.Forms.ToolStrip();
            this.storeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outBindingSource1)).BeginInit();
            this.测试ToolStrip.SuspendLayout();
            this.fillBy2ToolStrip.SuspendLayout();
            this.storeToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账号管理ToolStripMenuItem,
            this.库存查询ToolStripMenuItem,
            this.出库管理ToolStripMenuItem,
            this.终端管理ToolStripMenuItem,
            this.入库管理ToolStripMenuItem,
            this.供应商管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 账号管理ToolStripMenuItem
            // 
            this.账号管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销ToolStripMenuItem,
            this.更改密码ToolStripMenuItem,
            this.toolStripSeparator1,
            this.管理权限仅管理员ToolStripMenuItem});
            this.账号管理ToolStripMenuItem.Name = "账号管理ToolStripMenuItem";
            this.账号管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.账号管理ToolStripMenuItem.Text = "账号管理(&Z)";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // 管理权限仅管理员ToolStripMenuItem
            // 
            this.管理权限仅管理员ToolStripMenuItem.Name = "管理权限仅管理员ToolStripMenuItem";
            this.管理权限仅管理员ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.管理权限仅管理员ToolStripMenuItem.Text = "管理权限（仅管理员）";
            // 
            // 库存查询ToolStripMenuItem
            // 
            this.库存查询ToolStripMenuItem.Name = "库存查询ToolStripMenuItem";
            this.库存查询ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.库存查询ToolStripMenuItem.Text = "库存查询(&K)";
            // 
            // 出库管理ToolStripMenuItem
            // 
            this.出库管理ToolStripMenuItem.Name = "出库管理ToolStripMenuItem";
            this.出库管理ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.出库管理ToolStripMenuItem.Text = "出库管理(&C)";
            this.出库管理ToolStripMenuItem.Click += new System.EventHandler(this.出库管理ToolStripMenuItem_Click);
            // 
            // 终端管理ToolStripMenuItem
            // 
            this.终端管理ToolStripMenuItem.Name = "终端管理ToolStripMenuItem";
            this.终端管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.终端管理ToolStripMenuItem.Text = "终端管理(D)";
            // 
            // 入库管理ToolStripMenuItem
            // 
            this.入库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我要入库ToolStripMenuItem});
            this.入库管理ToolStripMenuItem.Name = "入库管理ToolStripMenuItem";
            this.入库管理ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.入库管理ToolStripMenuItem.Text = "入库管理(R)";
            // 
            // 我要入库ToolStripMenuItem
            // 
            this.我要入库ToolStripMenuItem.Name = "我要入库ToolStripMenuItem";
            this.我要入库ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.我要入库ToolStripMenuItem.Text = "我要入库！";
            // 
            // 供应商管理ToolStripMenuItem
            // 
            this.供应商管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加供应商ToolStripMenuItem});
            this.供应商管理ToolStripMenuItem.Name = "供应商管理ToolStripMenuItem";
            this.供应商管理ToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.供应商管理ToolStripMenuItem.Text = "供应商管理(&Y)";
            // 
            // 添加供应商ToolStripMenuItem
            // 
            this.添加供应商ToolStripMenuItem.Name = "添加供应商ToolStripMenuItem";
            this.添加供应商ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加供应商ToolStripMenuItem.Text = "添加供应商";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.权限分级ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&B)";
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
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.关于ToolStripMenuItem.Text = "关于(&G)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.sidDataGridViewTextBoxColumn,
            this.outtimeDataGridViewTextBoxColumn,
            this.uidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.outBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(271, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(738, 483);
            this.dataGridView1.TabIndex = 5;
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
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "pname";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "sid";
            this.sidDataGridViewTextBoxColumn.HeaderText = "sid";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outtimeDataGridViewTextBoxColumn
            // 
            this.outtimeDataGridViewTextBoxColumn.DataPropertyName = "outtime";
            this.outtimeDataGridViewTextBoxColumn.HeaderText = "outtime";
            this.outtimeDataGridViewTextBoxColumn.Name = "outtimeDataGridViewTextBoxColumn";
            this.outtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uidDataGridViewTextBoxColumn
            // 
            this.uidDataGridViewTextBoxColumn.DataPropertyName = "uid";
            this.uidDataGridViewTextBoxColumn.HeaderText = "uid";
            this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            this.uidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outBindingSource
            // 
            this.outBindingSource.DataMember = "out";
            this.outBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outTableAdapter
            // 
            this.outTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.storeBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 8;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "store";
            this.storeBindingSource.DataSource = this.wMSDataSet;
            // 
            // outBindingSource1
            // 
            this.outBindingSource1.DataMember = "out";
            this.outBindingSource1.DataSource = this.wMSDataSet;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // 测试ToolStrip
            // 
            this.测试ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试ToolStripButton});
            this.测试ToolStrip.Location = new System.Drawing.Point(0, 25);
            this.测试ToolStrip.Name = "测试ToolStrip";
            this.测试ToolStrip.Size = new System.Drawing.Size(271, 25);
            this.测试ToolStrip.TabIndex = 9;
            this.测试ToolStrip.Text = "测试ToolStrip";
            // 
            // 测试ToolStripButton
            // 
            this.测试ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.测试ToolStripButton.Name = "测试ToolStripButton";
            this.测试ToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.测试ToolStripButton.Text = "测试";
            this.测试ToolStripButton.Click += new System.EventHandler(this.测试ToolStripButton_Click);
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snameToolStripLabel,
            this.snameToolStripTextBox,
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 50);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(271, 25);
            this.fillBy2ToolStrip.TabIndex = 10;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            // 
            // snameToolStripLabel
            // 
            this.snameToolStripLabel.Name = "snameToolStripLabel";
            this.snameToolStripLabel.Size = new System.Drawing.Size(49, 22);
            this.snameToolStripLabel.Text = "sname:";
            // 
            // snameToolStripTextBox
            // 
            this.snameToolStripTextBox.Name = "snameToolStripTextBox";
            this.snameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.fillBy2ToolStripButton.Text = "FillBy2";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // sname
            // 
            this.sname.FormattingEnabled = true;
            this.sname.Location = new System.Drawing.Point(12, 79);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(121, 20);
            this.sname.TabIndex = 11;
            // 
            // storeToolStrip
            // 
            this.storeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeToolStripButton});
            this.storeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.storeToolStrip.Name = "storeToolStrip";
            this.storeToolStrip.Size = new System.Drawing.Size(111, 25);
            this.storeToolStrip.TabIndex = 12;
            this.storeToolStrip.Text = "storeToolStrip";
            // 
            // storeToolStripButton
            // 
            this.storeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.storeToolStripButton.Name = "storeToolStripButton";
            this.storeToolStripButton.Size = new System.Drawing.Size(42, 22);
            this.storeToolStripButton.Text = "store";
            this.storeToolStripButton.Click += new System.EventHandler(this.storeToolStripButton_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 508);
            this.Controls.Add(this.storeToolStrip);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.测试ToolStrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outBindingSource1)).EndInit();
            this.测试ToolStrip.ResumeLayout(false);
            this.测试ToolStrip.PerformLayout();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            this.storeToolStrip.ResumeLayout(false);
            this.storeToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 账号管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 管理权限仅管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 终端管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我要入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供应商管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加供应商ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限分级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem s1完全控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem s2只读ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem s2可读写ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource outBindingSource;
        private WMSDataSetTableAdapters.outTableAdapter outTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource outBindingSource1;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private WMSDataSetTableAdapters.storeTableAdapter storeTableAdapter;
        private System.Windows.Forms.ToolStrip 测试ToolStrip;
        private System.Windows.Forms.ToolStripButton 测试ToolStripButton;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripLabel snameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox snameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.ComboBox sname;
        private System.Windows.Forms.ToolStrip storeToolStrip;
        private System.Windows.Forms.ToolStripButton storeToolStripButton;
    }
}