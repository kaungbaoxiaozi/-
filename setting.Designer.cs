﻿namespace Warehouse_Manager
{
    partial class setting
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.choosebgm = new System.Windows.Forms.Button();
            this.bgmfalse = new System.Windows.Forms.RadioButton();
            this.bgmtrue = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.wartime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.infolabel = new System.Windows.Forms.Label();
            this.runbut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.volumetrackBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.backwarning = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumetrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 65);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 277);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.volume);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.volumetrackBar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.choosebgm);
            this.tabPage1.Controls.Add(this.bgmfalse);
            this.tabPage1.Controls.Add(this.bgmtrue);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.wartime);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(69, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(397, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常规设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "*部分外文歌曲无法播放（已知：韩语）";
            // 
            // choosebgm
            // 
            this.choosebgm.Location = new System.Drawing.Point(185, 111);
            this.choosebgm.Name = "choosebgm";
            this.choosebgm.Size = new System.Drawing.Size(75, 23);
            this.choosebgm.TabIndex = 9;
            this.choosebgm.Text = "选择BGM";
            this.choosebgm.UseVisualStyleBackColor = true;
            this.choosebgm.Visible = false;
            this.choosebgm.Click += new System.EventHandler(this.choosebgm_Click);
            // 
            // bgmfalse
            // 
            this.bgmfalse.AutoSize = true;
            this.bgmfalse.Location = new System.Drawing.Point(103, 112);
            this.bgmfalse.Name = "bgmfalse";
            this.bgmfalse.Size = new System.Drawing.Size(74, 21);
            this.bgmfalse.TabIndex = 8;
            this.bgmfalse.TabStop = true;
            this.bgmfalse.Text = "专注工作";
            this.bgmfalse.UseVisualStyleBackColor = true;
            // 
            // bgmtrue
            // 
            this.bgmtrue.AutoSize = true;
            this.bgmtrue.Location = new System.Drawing.Point(11, 112);
            this.bgmtrue.Name = "bgmtrue";
            this.bgmtrue.Size = new System.Drawing.Size(86, 21);
            this.bgmtrue.TabIndex = 5;
            this.bgmtrue.TabStop = true;
            this.bgmtrue.Text = "听点小曲儿";
            this.bgmtrue.UseVisualStyleBackColor = true;
            this.bgmtrue.CheckedChanged += new System.EventHandler(this.bgmtrue_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "工作状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "*当库存低于设定值时，状态栏会出现警告信息";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(304, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wartime
            // 
            this.wartime.Location = new System.Drawing.Point(10, 35);
            this.wartime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wartime.Name = "wartime";
            this.wartime.Size = new System.Drawing.Size(116, 23);
            this.wartime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "库存警告阈值：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.infolabel);
            this.tabPage2.Controls.Add(this.runbut);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(69, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(397, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(106, 99);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(246, 17);
            this.infolabel.TabIndex = 2;
            this.infolabel.Text = "*删除出库，入库，终端，产品表的所有记录*";
            this.infolabel.Visible = false;
            // 
            // runbut
            // 
            this.runbut.Location = new System.Drawing.Point(109, 73);
            this.runbut.Name = "runbut";
            this.runbut.Size = new System.Drawing.Size(75, 23);
            this.runbut.TabIndex = 1;
            this.runbut.Text = "删库跑路";
            this.runbut.UseVisualStyleBackColor = true;
            this.runbut.Visible = false;
            this.runbut.Click += new System.EventHandler(this.runbut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "*这里什么都没有";
            this.label5.DoubleClick += new System.EventHandler(this.label5_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // volumetrackBar
            // 
            this.volumetrackBar.BackColor = System.Drawing.SystemColors.Window;
            this.volumetrackBar.Location = new System.Drawing.Point(14, 186);
            this.volumetrackBar.Maximum = 100;
            this.volumetrackBar.Name = "volumetrackBar";
            this.volumetrackBar.Size = new System.Drawing.Size(163, 45);
            this.volumetrackBar.TabIndex = 11;
            this.volumetrackBar.TickFrequency = 15;
            this.volumetrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.volumetrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "TTS声音大小：";
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Location = new System.Drawing.Point(184, 199);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(15, 17);
            this.volume.TabIndex = 13;
            this.volume.Text = "0";
            // 
            // backwarning
            // 
            this.backwarning.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backwarning_DoWork);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 277);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "setting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.setting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumetrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox wartime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton bgmtrue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton bgmfalse;
        private System.Windows.Forms.Button choosebgm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button runbut;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar volumetrackBar;
        private System.ComponentModel.BackgroundWorker backwarning;
    }
}