namespace Warehouse_Manager
{
    partial class log
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.log1 = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.log2 = new System.Windows.Forms.RichTextBox();
            this.select = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.inlog = new System.Windows.Forms.TabPage();
            this.clears = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.log3 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.font = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.m5 = new System.Windows.Forms.RadioButton();
            this.m3 = new System.Windows.Forms.RadioButton();
            this.m1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.inlogfont = new System.Windows.Forms.FontDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.inlog.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "输入日志文本";
            // 
            // log1
            // 
            this.log1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.log1.Location = new System.Drawing.Point(9, 22);
            this.log1.Name = "log1";
            this.log1.Size = new System.Drawing.Size(571, 218);
            this.log1.TabIndex = 3;
            this.log1.Text = "";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(9, 248);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 22);
            this.send.TabIndex = 4;
            this.send.Text = "提交";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button1_Click);
            // 
            // log2
            // 
            this.log2.Location = new System.Drawing.Point(9, 33);
            this.log2.Name = "log2";
            this.log2.Size = new System.Drawing.Size(571, 238);
            this.log2.TabIndex = 5;
            this.log2.Text = "";
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(141, 6);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 22);
            this.select.TabIndex = 6;
            this.select.Text = "查看日志";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.inlog);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 302);
            this.tabControl1.TabIndex = 7;
            // 
            // inlog
            // 
            this.inlog.Controls.Add(this.clears);
            this.inlog.Controls.Add(this.log1);
            this.inlog.Controls.Add(this.label1);
            this.inlog.Controls.Add(this.send);
            this.inlog.Location = new System.Drawing.Point(4, 22);
            this.inlog.Name = "inlog";
            this.inlog.Padding = new System.Windows.Forms.Padding(3);
            this.inlog.Size = new System.Drawing.Size(594, 276);
            this.inlog.TabIndex = 0;
            this.inlog.Text = "提交日志";
            this.inlog.UseVisualStyleBackColor = true;
            // 
            // clears
            // 
            this.clears.Location = new System.Drawing.Point(108, 248);
            this.clears.Name = "clears";
            this.clears.Size = new System.Drawing.Size(75, 22);
            this.clears.TabIndex = 5;
            this.clears.Text = "清空";
            this.clears.UseVisualStyleBackColor = true;
            this.clears.Click += new System.EventHandler(this.clear);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.change);
            this.tabPage2.Controls.Add(this.log2);
            this.tabPage2.Controls.Add(this.select);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "查看/修改日志";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(221, 6);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 22);
            this.change.TabIndex = 7;
            this.change.Text = "提交修改";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.log3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 276);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "指定提交";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(8, 8);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // log3
            // 
            this.log3.Location = new System.Drawing.Point(8, 35);
            this.log3.Name = "log3";
            this.log3.Size = new System.Drawing.Size(570, 235);
            this.log3.TabIndex = 0;
            this.log3.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.font);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.m5);
            this.tabPage3.Controls.Add(this.m3);
            this.tabPage3.Controls.Add(this.m1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(594, 276);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "选择你的字体：";
            // 
            // font
            // 
            this.font.Location = new System.Drawing.Point(10, 94);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(75, 23);
            this.font.TabIndex = 12;
            this.font.Text = "字体";
            this.font.UseVisualStyleBackColor = true;
            this.font.Click += new System.EventHandler(this.font_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "默认一秒钟，不可选择！ *遇到致命错误，暂不可用";
            // 
            // m5
            // 
            this.m5.AutoSize = true;
            this.m5.Enabled = false;
            this.m5.Location = new System.Drawing.Point(185, 28);
            this.m5.Name = "m5";
            this.m5.Size = new System.Drawing.Size(53, 16);
            this.m5.TabIndex = 10;
            this.m5.Text = "5分钟";
            this.m5.UseVisualStyleBackColor = true;
            // 
            // m3
            // 
            this.m3.AutoSize = true;
            this.m3.Enabled = false;
            this.m3.Location = new System.Drawing.Point(127, 28);
            this.m3.Name = "m3";
            this.m3.Size = new System.Drawing.Size(53, 16);
            this.m3.TabIndex = 9;
            this.m3.Text = "3分钟";
            this.m3.UseVisualStyleBackColor = true;
            // 
            // m1
            // 
            this.m1.AutoSize = true;
            this.m1.Checked = true;
            this.m1.Location = new System.Drawing.Point(20, 28);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(101, 16);
            this.m1.TabIndex = 8;
            this.m1.TabStop = true;
            this.m1.Text = "1秒钟（默认）";
            this.m1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "自动保存时间间隔：";
            // 
            // inlogfont
            // 
            this.inlogfont.ShowApply = true;
            this.inlogfont.ShowColor = true;
            this.inlogfont.ShowEffects = false;
            this.inlogfont.ShowHelp = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.time,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 305);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(602, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(33, 17);
            this.time.Text = "time";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(553, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 327);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "log";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日志";
            this.Load += new System.EventHandler(this.about_Load);
            this.tabControl1.ResumeLayout(false);
            this.inlog.ResumeLayout(false);
            this.inlog.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox log1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.RichTextBox log2;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage inlog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button clears;
        private System.Windows.Forms.FontDialog inlogfont;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox log3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button font;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton m5;
        private System.Windows.Forms.RadioButton m3;
        private System.Windows.Forms.RadioButton m1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
    }
}