namespace Warehouse_Manager
{
    partial class spmer
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
            this.note = new System.Windows.Forms.RichTextBox();
            this.address = new System.Windows.Forms.RichTextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editbut = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.addresss = new System.Windows.Forms.RichTextBox();
            this.phones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.debut = new System.Windows.Forms.Button();
            this.names = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ids = new System.Windows.Forms.Label();
            this.spdata = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new Warehouse_Manager.WMSDataSet();
            this.supTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.supTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(242, 450);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.note);
            this.tabPage1.Controls.Add(this.address);
            this.tabPage1.Controls.Add(this.phone);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.editbut);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.id);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(234, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "修改供应商信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(66, 170);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(150, 56);
            this.note.TabIndex = 13;
            this.note.Text = "";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(66, 118);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(150, 41);
            this.address.TabIndex = 12;
            this.address.Text = "";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(66, 78);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(150, 21);
            this.phone.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "备注：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 322);
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
            // editbut
            // 
            this.editbut.Location = new System.Drawing.Point(66, 232);
            this.editbut.Name = "editbut";
            this.editbut.Size = new System.Drawing.Size(89, 23);
            this.editbut.TabIndex = 7;
            this.editbut.Text = "修改";
            this.editbut.UseVisualStyleBackColor = true;
            this.editbut.Click += new System.EventHandler(this.editbut_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(66, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(150, 21);
            this.name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "电话：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "名称：";
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
            this.tabPage2.Controls.Add(this.notes);
            this.tabPage2.Controls.Add(this.addresss);
            this.tabPage2.Controls.Add(this.phones);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.debut);
            this.tabPage2.Controls.Add(this.names);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ids);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(234, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "删除供应商信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(61, 170);
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Size = new System.Drawing.Size(150, 56);
            this.notes.TabIndex = 22;
            this.notes.Text = "";
            // 
            // addresss
            // 
            this.addresss.Location = new System.Drawing.Point(61, 118);
            this.addresss.Name = "addresss";
            this.addresss.ReadOnly = true;
            this.addresss.Size = new System.Drawing.Size(150, 41);
            this.addresss.TabIndex = 21;
            this.addresss.Text = "";
            // 
            // phones
            // 
            this.phones.Location = new System.Drawing.Point(61, 78);
            this.phones.Name = "phones";
            this.phones.ReadOnly = true;
            this.phones.Size = new System.Drawing.Size(150, 21);
            this.phones.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "备注：";
            // 
            // debut
            // 
            this.debut.Location = new System.Drawing.Point(61, 232);
            this.debut.Name = "debut";
            this.debut.Size = new System.Drawing.Size(89, 23);
            this.debut.TabIndex = 18;
            this.debut.Text = "删除";
            this.debut.UseVisualStyleBackColor = true;
            this.debut.Click += new System.EventHandler(this.debut_Click);
            // 
            // names
            // 
            this.names.Location = new System.Drawing.Point(61, 41);
            this.names.Name = "names";
            this.names.ReadOnly = true;
            this.names.Size = new System.Drawing.Size(150, 21);
            this.names.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "地址：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "电话：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "名称：";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "*删除行为不可逆，谨慎使用";
            // 
            // ids
            // 
            this.ids.AutoSize = true;
            this.ids.Location = new System.Drawing.Point(135, 15);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(0, 12);
            this.ids.TabIndex = 0;
            this.ids.TextChanged += new System.EventHandler(this.ids_TextChanged);
            // 
            // spdata
            // 
            this.spdata.AllowUserToAddRows = false;
            this.spdata.AllowUserToDeleteRows = false;
            this.spdata.AutoGenerateColumns = false;
            this.spdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.spdata.DataSource = this.supBindingSource;
            this.spdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spdata.Location = new System.Drawing.Point(242, 0);
            this.spdata.Name = "spdata";
            this.spdata.ReadOnly = true;
            this.spdata.RowTemplate.Height = 23;
            this.spdata.Size = new System.Drawing.Size(558, 450);
            this.spdata.TabIndex = 7;
            this.spdata.Click += new System.EventHandler(this.dataGridView1_Click);
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "备注";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
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
            // supTableAdapter
            // 
            this.supTableAdapter.ClearBeforeFill = true;
            // 
            // spmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spdata);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "spmer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "维护供应商信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.spmer_FormClosed);
            this.Load += new System.EventHandler(this.spmer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editbut;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ids;
        private System.Windows.Forms.DataGridView spdata;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource supBindingSource;
        private WMSDataSetTableAdapters.supTableAdapter supTableAdapter;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.RichTextBox addresss;
        private System.Windows.Forms.TextBox phones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button debut;
        private System.Windows.Forms.TextBox names;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}