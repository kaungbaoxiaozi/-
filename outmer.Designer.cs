namespace Warehouse_Manager
{
    partial class outmer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(outmer));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.snamet = new System.Windows.Forms.ComboBox();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new Warehouse_Manager.WMSDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnamet = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.snamett = new System.Windows.Forms.TextBox();
            this.outtimett = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deletebut = new System.Windows.Forms.Button();
            this.pnamett = new System.Windows.Forms.TextBox();
            this.numbertt = new System.Windows.Forms.TextBox();
            this.ids = new System.Windows.Forms.Label();
            this.outBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.outTableAdapter();
            this.outmerdata = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.productTableAdapter();
            this.storeTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.storeTableAdapter();
            this.还原ToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.numbert = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outmerdata)).BeginInit();
            this.还原ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbert)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(238, 361);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numbert);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.snamet);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pnamet);
            this.tabPage1.Controls.Add(this.id);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(230, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "修改出库记录";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "*暂不提供更改出库产品功能，开发中...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "当前选中记录编号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // snamet
            // 
            this.snamet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.snamet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.snamet.DataSource = this.storeBindingSource;
            this.snamet.DisplayMember = "name";
            this.snamet.FormattingEnabled = true;
            this.snamet.Location = new System.Drawing.Point(65, 115);
            this.snamet.Name = "snamet";
            this.snamet.Size = new System.Drawing.Size(151, 20);
            this.snamet.TabIndex = 6;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "store";
            this.storeBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "商店：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "产品：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "数量：";
            // 
            // pnamet
            // 
            this.pnamet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pnamet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pnamet.DataSource = this.productBindingSource;
            this.pnamet.DisplayMember = "name";
            this.pnamet.Enabled = false;
            this.pnamet.FormattingEnabled = true;
            this.pnamet.Location = new System.Drawing.Point(65, 78);
            this.pnamet.Name = "pnamet";
            this.pnamet.Size = new System.Drawing.Size(151, 20);
            this.pnamet.TabIndex = 1;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.wMSDataSet;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(137, 16);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 12);
            this.id.TabIndex = 0;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.snamett);
            this.tabPage2.Controls.Add(this.outtimett);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.deletebut);
            this.tabPage2.Controls.Add(this.pnamett);
            this.tabPage2.Controls.Add(this.numbertt);
            this.tabPage2.Controls.Add(this.ids);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(230, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "删除出库记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "当前选中记录编号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "出库时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "商店名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "产品名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "数量：";
            // 
            // snamett
            // 
            this.snamett.Location = new System.Drawing.Point(81, 98);
            this.snamett.Name = "snamett";
            this.snamett.ReadOnly = true;
            this.snamett.Size = new System.Drawing.Size(131, 21);
            this.snamett.TabIndex = 6;
            // 
            // outtimett
            // 
            this.outtimett.Location = new System.Drawing.Point(81, 132);
            this.outtimett.Name = "outtimett";
            this.outtimett.ReadOnly = true;
            this.outtimett.Size = new System.Drawing.Size(131, 21);
            this.outtimett.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "*删除行为不可逆，谨慎使用";
            // 
            // deletebut
            // 
            this.deletebut.Location = new System.Drawing.Point(81, 159);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(75, 23);
            this.deletebut.TabIndex = 3;
            this.deletebut.Text = "删除";
            this.deletebut.UseVisualStyleBackColor = true;
            this.deletebut.Click += new System.EventHandler(this.deletebut_Click);
            // 
            // pnamett
            // 
            this.pnamett.Location = new System.Drawing.Point(81, 66);
            this.pnamett.Name = "pnamett";
            this.pnamett.ReadOnly = true;
            this.pnamett.Size = new System.Drawing.Size(131, 21);
            this.pnamett.TabIndex = 2;
            // 
            // numbertt
            // 
            this.numbertt.Location = new System.Drawing.Point(81, 34);
            this.numbertt.Name = "numbertt";
            this.numbertt.ReadOnly = true;
            this.numbertt.Size = new System.Drawing.Size(131, 21);
            this.numbertt.TabIndex = 1;
            // 
            // ids
            // 
            this.ids.AutoSize = true;
            this.ids.Location = new System.Drawing.Point(135, 15);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(0, 12);
            this.ids.TabIndex = 0;
            this.ids.TextChanged += new System.EventHandler(this.IDD_TextChanged);
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
            // outmerdata
            // 
            this.outmerdata.AllowUserToAddRows = false;
            this.outmerdata.AllowUserToDeleteRows = false;
            this.outmerdata.AutoGenerateColumns = false;
            this.outmerdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outmerdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.sidDataGridViewTextBoxColumn,
            this.outtimeDataGridViewTextBoxColumn,
            this.uidDataGridViewTextBoxColumn});
            this.outmerdata.DataSource = this.outBindingSource;
            this.outmerdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outmerdata.Location = new System.Drawing.Point(238, 22);
            this.outmerdata.Name = "outmerdata";
            this.outmerdata.ReadOnly = true;
            this.outmerdata.RowTemplate.Height = 23;
            this.outmerdata.Size = new System.Drawing.Size(743, 339);
            this.outmerdata.TabIndex = 7;
            this.outmerdata.Click += new System.EventHandler(this.dataGridView1_Click_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "编号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "数量";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "产品名";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "商店名";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "sid";
            this.sidDataGridViewTextBoxColumn.HeaderText = "商店编号";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outtimeDataGridViewTextBoxColumn
            // 
            this.outtimeDataGridViewTextBoxColumn.DataPropertyName = "outtime";
            this.outtimeDataGridViewTextBoxColumn.HeaderText = "出库时间";
            this.outtimeDataGridViewTextBoxColumn.Name = "outtimeDataGridViewTextBoxColumn";
            this.outtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uidDataGridViewTextBoxColumn
            // 
            this.uidDataGridViewTextBoxColumn.DataPropertyName = "uid";
            this.uidDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            this.uidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // 还原ToolStrip
            // 
            this.还原ToolStrip.AutoSize = false;
            this.还原ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.还原ToolStrip.Location = new System.Drawing.Point(238, 0);
            this.还原ToolStrip.Name = "还原ToolStrip";
            this.还原ToolStrip.Size = new System.Drawing.Size(743, 22);
            this.还原ToolStrip.TabIndex = 6;
            this.还原ToolStrip.Text = "还原ToolStrip";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 19);
            this.toolStripButton1.Text = "刷新";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // numbert
            // 
            this.numbert.Location = new System.Drawing.Point(65, 42);
            this.numbert.Name = "numbert";
            this.numbert.Size = new System.Drawing.Size(151, 21);
            this.numbert.TabIndex = 10;
            // 
            // outmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 361);
            this.Controls.Add(this.outmerdata);
            this.Controls.Add(this.还原ToolStrip);
            this.Controls.Add(this.tabControl1);
            this.Name = "outmer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理出库记录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.outmer_FormClosed);
            this.Load += new System.EventHandler(this.outmer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outmerdata)).EndInit();
            this.还原ToolStrip.ResumeLayout(false);
            this.还原ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource outBindingSource;
        private WMSDataSetTableAdapters.outTableAdapter outTableAdapter;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.DataGridView outmerdata;
        private System.Windows.Forms.ComboBox snamet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pnamet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private WMSDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private WMSDataSetTableAdapters.storeTableAdapter storeTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ids;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.TextBox pnamett;
        private System.Windows.Forms.TextBox numbertt;
        private System.Windows.Forms.TextBox snamett;
        private System.Windows.Forms.TextBox outtimett;
        private System.Windows.Forms.ToolStrip 还原ToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numbert;
    }
}