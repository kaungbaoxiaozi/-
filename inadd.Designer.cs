namespace Warehouse_Manager
{
    partial class inadd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new Warehouse_Manager.WMSDataSet();
            this.number = new System.Windows.Forms.TextBox();
            this.inbut = new System.Windows.Forms.Button();
            this.spname = new System.Windows.Forms.ComboBox();
            this.supBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pname = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.inTableAdapter();
            this.supTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.supTableAdapter();
            this.productTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.productTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.spnameDataGridViewTextBoxColumn,
            this.spidDataGridViewTextBoxColumn,
            this.intimeDataGridViewTextBoxColumn,
            this.uidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(791, 254);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "入库编号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "入库数量";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "产品名称";
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
            // wMSDataSet
            // 
            this.wMSDataSet.DataSetName = "WMSDataSet";
            this.wMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // number
            // 
            this.number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.number.Location = new System.Drawing.Point(73, 284);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(121, 21);
            this.number.TabIndex = 12;
            // 
            // inbut
            // 
            this.inbut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inbut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inbut.Location = new System.Drawing.Point(663, 279);
            this.inbut.Name = "inbut";
            this.inbut.Size = new System.Drawing.Size(113, 29);
            this.inbut.TabIndex = 18;
            this.inbut.Text = "入库";
            this.inbut.UseVisualStyleBackColor = true;
            this.inbut.Click += new System.EventHandler(this.inbut_Click);
            // 
            // spname
            // 
            this.spname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.spname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.spname.DataSource = this.supBindingSource;
            this.spname.DisplayMember = "name";
            this.spname.FormattingEnabled = true;
            this.spname.Location = new System.Drawing.Point(299, 285);
            this.spname.Name = "spname";
            this.spname.Size = new System.Drawing.Size(121, 20);
            this.spname.TabIndex = 15;
            // 
            // supBindingSource
            // 
            this.supBindingSource.DataMember = "sup";
            this.supBindingSource.DataSource = this.wMSDataSet;
            // 
            // pname
            // 
            this.pname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pname.DataSource = this.productBindingSource;
            this.pname.DisplayMember = "name";
            this.pname.FormattingEnabled = true;
            this.pname.Location = new System.Drawing.Point(521, 285);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(121, 20);
            this.pname.TabIndex = 13;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.wMSDataSet;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(436, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "产品名称：";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(200, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "供应商名称：";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "数量：";
            // 
            // inTableAdapter
            // 
            this.inTableAdapter.ClearBeforeFill = true;
            // 
            // supTableAdapter
            // 
            this.supTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // inadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 328);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.inbut);
            this.Controls.Add(this.spname);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "inadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inadd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.inadd_FormClosed);
            this.Load += new System.EventHandler(this.inadd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button inbut;
        private System.Windows.Forms.ComboBox spname;
        private System.Windows.Forms.ComboBox pname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource inBindingSource;
        private WMSDataSetTableAdapters.inTableAdapter inTableAdapter;
        private System.Windows.Forms.BindingSource supBindingSource;
        private WMSDataSetTableAdapters.supTableAdapter supTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private WMSDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
    }
}