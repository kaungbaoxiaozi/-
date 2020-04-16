namespace Warehouse_Manager
{
    partial class storemer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wMSDataSet = new Warehouse_Manager.WMSDataSet();
            this.storeTableAdapter = new Warehouse_Manager.WMSDataSetTableAdapters.storeTableAdapter();
            this.upbut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.uptab = new System.Windows.Forms.TabPage();
            this.name = new System.Windows.Forms.ComboBox();
            this.note = new System.Windows.Forms.RichTextBox();
            this.address = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.detab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ids = new System.Windows.Forms.Label();
            this.dename = new System.Windows.Forms.ComboBox();
            this.denote = new System.Windows.Forms.RichTextBox();
            this.deaddress = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dephone = new System.Windows.Forms.TextBox();
            this.debut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uptab.SuspendLayout();
            this.detab.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.storeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(249, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(663, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "编号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 80;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 180;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "备注";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 180;
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
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // upbut
            // 
            this.upbut.Location = new System.Drawing.Point(17, 225);
            this.upbut.Name = "upbut";
            this.upbut.Size = new System.Drawing.Size(72, 23);
            this.upbut.TabIndex = 1;
            this.upbut.Text = "修改";
            this.upbut.UseVisualStyleBackColor = true;
            this.upbut.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.uptab);
            this.tabControl1.Controls.Add(this.detab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(249, 365);
            this.tabControl1.TabIndex = 2;
            // 
            // uptab
            // 
            this.uptab.Controls.Add(this.name);
            this.uptab.Controls.Add(this.note);
            this.uptab.Controls.Add(this.address);
            this.uptab.Controls.Add(this.label6);
            this.uptab.Controls.Add(this.label4);
            this.uptab.Controls.Add(this.label3);
            this.uptab.Controls.Add(this.label2);
            this.uptab.Controls.Add(this.phone);
            this.uptab.Controls.Add(this.label5);
            this.uptab.Controls.Add(this.id);
            this.uptab.Controls.Add(this.upbut);
            this.uptab.Location = new System.Drawing.Point(4, 22);
            this.uptab.Name = "uptab";
            this.uptab.Padding = new System.Windows.Forms.Padding(3);
            this.uptab.Size = new System.Drawing.Size(241, 339);
            this.uptab.TabIndex = 0;
            this.uptab.Text = "修改终端信息";
            this.uptab.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.name.DataSource = this.storeBindingSource;
            this.name.DisplayMember = "name";
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(62, 47);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(160, 20);
            this.name.TabIndex = 20;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(62, 172);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(160, 37);
            this.note.TabIndex = 19;
            this.note.Text = "";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(62, 120);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(160, 37);
            this.address.TabIndex = 18;
            this.address.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "备注：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "地址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "名称：";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(62, 84);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(161, 21);
            this.phone.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "当前选中记录编号：";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(127, 13);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 12);
            this.id.TabIndex = 9;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // detab
            // 
            this.detab.Controls.Add(this.debut);
            this.detab.Controls.Add(this.dename);
            this.detab.Controls.Add(this.denote);
            this.detab.Controls.Add(this.deaddress);
            this.detab.Controls.Add(this.label7);
            this.detab.Controls.Add(this.label8);
            this.detab.Controls.Add(this.label9);
            this.detab.Controls.Add(this.label10);
            this.detab.Controls.Add(this.dephone);
            this.detab.Controls.Add(this.label1);
            this.detab.Controls.Add(this.ids);
            this.detab.Location = new System.Drawing.Point(4, 22);
            this.detab.Name = "detab";
            this.detab.Padding = new System.Windows.Forms.Padding(3);
            this.detab.Size = new System.Drawing.Size(241, 339);
            this.detab.TabIndex = 1;
            this.detab.Text = "删除终端信息";
            this.detab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "当前选中记录编号：";
            // 
            // ids
            // 
            this.ids.AutoSize = true;
            this.ids.Location = new System.Drawing.Point(129, 12);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(0, 12);
            this.ids.TabIndex = 11;
            this.ids.TextChanged += new System.EventHandler(this.ids_TextChanged);
            // 
            // dename
            // 
            this.dename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dename.DataSource = this.storeBindingSource;
            this.dename.DisplayMember = "name";
            this.dename.Enabled = false;
            this.dename.FormattingEnabled = true;
            this.dename.Location = new System.Drawing.Point(63, 36);
            this.dename.Name = "dename";
            this.dename.Size = new System.Drawing.Size(160, 20);
            this.dename.TabIndex = 28;
            // 
            // denote
            // 
            this.denote.Location = new System.Drawing.Point(63, 161);
            this.denote.Name = "denote";
            this.denote.ReadOnly = true;
            this.denote.Size = new System.Drawing.Size(160, 37);
            this.denote.TabIndex = 27;
            this.denote.Text = "";
            // 
            // deaddress
            // 
            this.deaddress.Location = new System.Drawing.Point(63, 109);
            this.deaddress.Name = "deaddress";
            this.deaddress.ReadOnly = true;
            this.deaddress.Size = new System.Drawing.Size(160, 37);
            this.deaddress.TabIndex = 26;
            this.deaddress.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "备注：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "地址：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "电话：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "名称：";
            // 
            // dephone
            // 
            this.dephone.Location = new System.Drawing.Point(63, 73);
            this.dephone.Name = "dephone";
            this.dephone.ReadOnly = true;
            this.dephone.Size = new System.Drawing.Size(161, 21);
            this.dephone.TabIndex = 21;
            // 
            // debut
            // 
            this.debut.Location = new System.Drawing.Point(18, 214);
            this.debut.Name = "debut";
            this.debut.Size = new System.Drawing.Size(75, 23);
            this.debut.TabIndex = 29;
            this.debut.Text = "删除";
            this.debut.UseVisualStyleBackColor = true;
            this.debut.Click += new System.EventHandler(this.debut_Click);
            // 
            // storemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "storemer";
            this.ShowIcon = false;
            this.Text = "维护终端信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.storemer_FormClosed);
            this.Load += new System.EventHandler(this.storemer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uptab.ResumeLayout(false);
            this.uptab.PerformLayout();
            this.detab.ResumeLayout(false);
            this.detab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WMSDataSet wMSDataSet;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private WMSDataSetTableAdapters.storeTableAdapter storeTableAdapter;
        private System.Windows.Forms.Button upbut;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage uptab;
        private System.Windows.Forms.TabPage detab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ids;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Button debut;
        private System.Windows.Forms.ComboBox dename;
        private System.Windows.Forms.RichTextBox denote;
        private System.Windows.Forms.RichTextBox deaddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dephone;
    }
}