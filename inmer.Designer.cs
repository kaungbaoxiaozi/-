namespace Warehouse_Manager
{
    partial class inmer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numbert = new System.Windows.Forms.NumericUpDown();
            this.notet = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.spnamet = new System.Windows.Forms.ComboBox();
            this.supBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new Warehouse_Manager.WMSDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnamet = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ids = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spnamett = new System.Windows.Forms.TextBox();
            this.intimett = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deletebut = new System.Windows.Forms.Button();
            this.pnamett = new System.Windows.Forms.TextBox();
            this.numbertt = new System.Windows.Forms.TextBox();
            this.indata = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.inTableAdapter();
            this.supTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.supTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(242, 473);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numbert);
            this.tabPage1.Controls.Add(this.notet);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.spnamet);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pnamet);
            this.tabPage1.Controls.Add(this.id);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(234, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "修改入库记录";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numbert
            // 
            this.numbert.Location = new System.Drawing.Point(65, 42);
            this.numbert.Name = "numbert";
            this.numbert.Size = new System.Drawing.Size(151, 21);
            this.numbert.TabIndex = 14;
            // 
            // notet
            // 
            this.notet.Location = new System.Drawing.Point(65, 137);
            this.notet.Name = "notet";
            this.notet.Size = new System.Drawing.Size(151, 71);
            this.notet.TabIndex = 13;
            this.notet.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "备注：";
            // 
            // spnamet
            // 
            this.spnamet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.spnamet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.spnamet.DataSource = this.supBindingSource;
            this.spnamet.DisplayMember = "name";
            this.spnamet.FormattingEnabled = true;
            this.spnamet.Location = new System.Drawing.Point(65, 104);
            this.spnamet.Name = "spnamet";
            this.spnamet.Size = new System.Drawing.Size(151, 20);
            this.spnamet.TabIndex = 11;
            // 
            // supBindingSource
            // 
            this.supBindingSource.DataMember = "sup";
            this.supBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "供应商：";
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
            this.button1.Location = new System.Drawing.Point(65, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
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
            this.pnamet.DisplayMember = "name";
            this.pnamet.Enabled = false;
            this.pnamet.FormattingEnabled = true;
            this.pnamet.Location = new System.Drawing.Point(65, 74);
            this.pnamet.Name = "pnamet";
            this.pnamet.Size = new System.Drawing.Size(151, 20);
            this.pnamet.TabIndex = 1;
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
            this.tabPage2.Controls.Add(this.ids);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.spnamett);
            this.tabPage2.Controls.Add(this.intimett);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.deletebut);
            this.tabPage2.Controls.Add(this.pnamett);
            this.tabPage2.Controls.Add(this.numbertt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(234, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "删除入库记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ids
            // 
            this.ids.AutoSize = true;
            this.ids.Location = new System.Drawing.Point(136, 16);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(0, 12);
            this.ids.TabIndex = 12;
            this.ids.TextChanged += new System.EventHandler(this.ids_TextChanged);
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
            this.label8.Text = "供应商：";
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
            // spnamett
            // 
            this.spnamett.Location = new System.Drawing.Point(81, 98);
            this.spnamett.Name = "spnamett";
            this.spnamett.ReadOnly = true;
            this.spnamett.Size = new System.Drawing.Size(131, 21);
            this.spnamett.TabIndex = 6;
            // 
            // intimett
            // 
            this.intimett.Location = new System.Drawing.Point(81, 132);
            this.intimett.Name = "intimett";
            this.intimett.ReadOnly = true;
            this.intimett.Size = new System.Drawing.Size(131, 21);
            this.intimett.TabIndex = 5;
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
            this.deletebut.Location = new System.Drawing.Point(81, 171);
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
            // indata
            // 
            this.indata.AllowUserToAddRows = false;
            this.indata.AllowUserToDeleteRows = false;
            this.indata.AutoGenerateColumns = false;
            this.indata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.spnameDataGridViewTextBoxColumn,
            this.spidDataGridViewTextBoxColumn,
            this.intimeDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.uidDataGridViewTextBoxColumn});
            this.indata.DataSource = this.inBindingSource;
            this.indata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indata.Location = new System.Drawing.Point(242, 0);
            this.indata.Name = "indata";
            this.indata.ReadOnly = true;
            this.indata.RowTemplate.Height = 23;
            this.indata.Size = new System.Drawing.Size(843, 473);
            this.indata.TabIndex = 8;
            this.indata.Click += new System.EventHandler(this.dataGridView1_Click);
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
            // spnameDataGridViewTextBoxColumn
            // 
            this.spnameDataGridViewTextBoxColumn.DataPropertyName = "spname";
            this.spnameDataGridViewTextBoxColumn.HeaderText = "供应商";
            this.spnameDataGridViewTextBoxColumn.Name = "spnameDataGridViewTextBoxColumn";
            this.spnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spidDataGridViewTextBoxColumn
            // 
            this.spidDataGridViewTextBoxColumn.DataPropertyName = "spid";
            this.spidDataGridViewTextBoxColumn.HeaderText = "供应商编号";
            this.spidDataGridViewTextBoxColumn.Name = "spidDataGridViewTextBoxColumn";
            this.spidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intimeDataGridViewTextBoxColumn
            // 
            this.intimeDataGridViewTextBoxColumn.DataPropertyName = "intime";
            this.intimeDataGridViewTextBoxColumn.HeaderText = "入库时间";
            this.intimeDataGridViewTextBoxColumn.Name = "intimeDataGridViewTextBoxColumn";
            this.intimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "备注";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uidDataGridViewTextBoxColumn
            // 
            this.uidDataGridViewTextBoxColumn.DataPropertyName = "uid";
            this.uidDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            this.uidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // supTableAdapter
            // 
            this.supTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "*暂不提供更改出库产品功能，开发中...";
            // 
            // inmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 473);
            this.Controls.Add(this.indata);
            this.Controls.Add(this.tabControl1);
            this.Name = "inmer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理入库记录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.inmer_FormClosed);
            this.Load += new System.EventHandler(this.inmer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pnamet;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox spnamett;
        private System.Windows.Forms.TextBox intimett;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.TextBox pnamett;
        private System.Windows.Forms.TextBox numbertt;
        private System.Windows.Forms.DataGridView indata;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource inBindingSource;
        private WMSDataSetTableAdapters.inTableAdapter inTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox spnamet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource supBindingSource;
        private WMSDataSetTableAdapters.supTableAdapter supTableAdapter;
        private System.Windows.Forms.RichTextBox notet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ids;
        private System.Windows.Forms.NumericUpDown numbert;
        private System.Windows.Forms.Label label11;
    }
}