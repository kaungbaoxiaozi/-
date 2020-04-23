namespace Warehouse_Manager
{
    partial class productmer
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
            this.prodata = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new Warehouse_Manager.WMSDataSet();
            this.productTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.productTableAdapter();
            this.name = new System.Windows.Forms.TextBox();
            this.format = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edbut = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.stocks = new System.Windows.Forms.TextBox();
            this.ids = new System.Windows.Forms.Label();
            this.formats = new System.Windows.Forms.TextBox();
            this.debut = new System.Windows.Forms.Button();
            this.names = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // prodata
            // 
            this.prodata.AllowUserToAddRows = false;
            this.prodata.AllowUserToDeleteRows = false;
            this.prodata.AutoGenerateColumns = false;
            this.prodata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.prodata.DataSource = this.productBindingSource;
            this.prodata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodata.Location = new System.Drawing.Point(213, 0);
            this.prodata.Name = "prodata";
            this.prodata.ReadOnly = true;
            this.prodata.RowTemplate.Height = 23;
            this.prodata.Size = new System.Drawing.Size(348, 223);
            this.prodata.TabIndex = 0;
            this.prodata.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "编号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "产品名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "库存";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.wMSDataSet;
            // 
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(83, 42);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 21);
            this.name.TabIndex = 1;
            // 
            // format
            // 
            this.format.Location = new System.Drawing.Point(83, 78);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(100, 21);
            this.format.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "产品名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "规格：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "库存：";
            // 
            // edbut
            // 
            this.edbut.Location = new System.Drawing.Point(56, 153);
            this.edbut.Name = "edbut";
            this.edbut.Size = new System.Drawing.Size(75, 23);
            this.edbut.TabIndex = 8;
            this.edbut.Text = "修改";
            this.edbut.UseVisualStyleBackColor = true;
            this.edbut.Click += new System.EventHandler(this.edbut_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Dock = System.Windows.Forms.DockStyle.Left;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(213, 223);
            this.tab.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.stock);
            this.tabPage1.Controls.Add(this.id);
            this.tabPage1.Controls.Add(this.format);
            this.tabPage1.Controls.Add(this.edbut);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(205, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "修改产品信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "当前选中行：";
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(83, 115);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(100, 21);
            this.stock.TabIndex = 10;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(90, 16);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 12);
            this.id.TabIndex = 9;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.stocks);
            this.tabPage2.Controls.Add(this.ids);
            this.tabPage2.Controls.Add(this.formats);
            this.tabPage2.Controls.Add(this.debut);
            this.tabPage2.Controls.Add(this.names);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(205, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "删除产品信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "当前选中行：";
            // 
            // stocks
            // 
            this.stocks.Location = new System.Drawing.Point(83, 114);
            this.stocks.Name = "stocks";
            this.stocks.Size = new System.Drawing.Size(100, 21);
            this.stocks.TabIndex = 17;
            // 
            // ids
            // 
            this.ids.AutoSize = true;
            this.ids.Location = new System.Drawing.Point(81, 13);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(0, 12);
            this.ids.TabIndex = 16;
            this.ids.TextChanged += new System.EventHandler(this.ids_TextChanged);
            // 
            // formats
            // 
            this.formats.Location = new System.Drawing.Point(83, 75);
            this.formats.Name = "formats";
            this.formats.Size = new System.Drawing.Size(100, 21);
            this.formats.TabIndex = 10;
            // 
            // debut
            // 
            this.debut.Location = new System.Drawing.Point(64, 151);
            this.debut.Name = "debut";
            this.debut.Size = new System.Drawing.Size(75, 23);
            this.debut.TabIndex = 15;
            this.debut.Text = "删除";
            this.debut.UseVisualStyleBackColor = true;
            this.debut.Click += new System.EventHandler(this.debut_Click);
            // 
            // names
            // 
            this.names.Location = new System.Drawing.Point(83, 36);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(100, 21);
            this.names.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "产品名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "库存：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "规格：";
            // 
            // productmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 223);
            this.Controls.Add(this.prodata);
            this.Controls.Add(this.tab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "productmer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理产品信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.productmer_FormClosed);
            this.Load += new System.EventHandler(this.productmer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView prodata;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private WMSDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox format;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button edbut;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label ids;
        private System.Windows.Forms.TextBox formats;
        private System.Windows.Forms.Button debut;
        private System.Windows.Forms.TextBox names;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.TextBox stocks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}