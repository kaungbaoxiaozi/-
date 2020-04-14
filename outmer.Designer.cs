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
            this.button1 = new System.Windows.Forms.Button();
            this.snamet = new System.Windows.Forms.ComboBox();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new Warehouse_Manager.WMSDataSet();
            this.numbert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnamet = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.IDD = new System.Windows.Forms.Label();
            this.numbertt = new System.Windows.Forms.TextBox();
            this.pnamett = new System.Windows.Forms.TextBox();
            this.deletebut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.outtimett = new System.Windows.Forms.TextBox();
            this.snamett = new System.Windows.Forms.TextBox();
            this.还原ToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outmerdata)).BeginInit();
            this.还原ToolStrip.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(257, 361);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.snamet);
            this.tabPage1.Controls.Add(this.numbert);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pnamet);
            this.tabPage1.Controls.Add(this.id);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(249, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "修改出库记录";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            this.snamet.Location = new System.Drawing.Point(56, 111);
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
            // numbert
            // 
            this.numbert.Location = new System.Drawing.Point(57, 31);
            this.numbert.Name = "numbert";
            this.numbert.Size = new System.Drawing.Size(150, 21);
            this.numbert.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "商店：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "产品：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
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
            this.pnamet.Location = new System.Drawing.Point(56, 68);
            this.pnamet.Name = "pnamet";
            this.pnamet.Size = new System.Drawing.Size(151, 20);
            this.pnamet.TabIndex = 1;
            this.pnamet.MouseHover += new System.EventHandler(this.pnamet_MouseHover);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.wMSDataSet;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(9, 16);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(17, 12);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.snamett);
            this.tabPage2.Controls.Add(this.outtimett);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.deletebut);
            this.tabPage2.Controls.Add(this.pnamett);
            this.tabPage2.Controls.Add(this.numbertt);
            this.tabPage2.Controls.Add(this.IDD);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(249, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "删除出库记录";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.outmerdata.Location = new System.Drawing.Point(257, 22);
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
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // IDD
            // 
            this.IDD.AutoSize = true;
            this.IDD.Location = new System.Drawing.Point(9, 7);
            this.IDD.Name = "IDD";
            this.IDD.Size = new System.Drawing.Size(41, 12);
            this.IDD.TabIndex = 0;
            this.IDD.Text = "label4";
            this.IDD.TextChanged += new System.EventHandler(this.IDD_TextChanged);
            // 
            // numbertt
            // 
            this.numbertt.Location = new System.Drawing.Point(39, 34);
            this.numbertt.Name = "numbertt";
            this.numbertt.Size = new System.Drawing.Size(100, 21);
            this.numbertt.TabIndex = 1;
            // 
            // pnamett
            // 
            this.pnamett.Location = new System.Drawing.Point(39, 61);
            this.pnamett.Name = "pnamett";
            this.pnamett.Size = new System.Drawing.Size(100, 21);
            this.pnamett.TabIndex = 2;
            // 
            // deletebut
            // 
            this.deletebut.Location = new System.Drawing.Point(39, 142);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(75, 23);
            this.deletebut.TabIndex = 3;
            this.deletebut.Text = "button2";
            this.deletebut.UseVisualStyleBackColor = true;
            this.deletebut.Click += new System.EventHandler(this.deletebut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "*删除行为不可逆，谨慎使用";
            // 
            // outtimett
            // 
            this.outtimett.Location = new System.Drawing.Point(39, 115);
            this.outtimett.Name = "outtimett";
            this.outtimett.Size = new System.Drawing.Size(100, 21);
            this.outtimett.TabIndex = 5;
            // 
            // snamett
            // 
            this.snamett.Location = new System.Drawing.Point(39, 88);
            this.snamett.Name = "snamett";
            this.snamett.Size = new System.Drawing.Size(100, 21);
            this.snamett.TabIndex = 6;
            // 
            // 还原ToolStrip
            // 
            this.还原ToolStrip.AutoSize = false;
            this.还原ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.还原ToolStrip.Location = new System.Drawing.Point(257, 0);
            this.还原ToolStrip.Name = "还原ToolStrip";
            this.还原ToolStrip.Size = new System.Drawing.Size(743, 22);
            this.还原ToolStrip.TabIndex = 6;
            this.还原ToolStrip.Text = "还原ToolStrip";
            this.还原ToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.还原ToolStrip_ItemClicked);
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
            // outmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 361);
            this.Controls.Add(this.outmerdata);
            this.Controls.Add(this.还原ToolStrip);
            this.Controls.Add(this.tabControl1);
            this.Name = "outmer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "outmer";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox snamet;
        private System.Windows.Forms.TextBox numbert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pnamet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private WMSDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private WMSDataSetTableAdapters.storeTableAdapter storeTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label IDD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.TextBox pnamett;
        private System.Windows.Forms.TextBox numbertt;
        private System.Windows.Forms.TextBox snamett;
        private System.Windows.Forms.TextBox outtimett;
        private System.Windows.Forms.ToolStrip 还原ToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}