namespace Warehouse_Manager
{
    partial class test3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(526, 88);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 21);
            this.a.TabIndex = 2;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(526, 125);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 21);
            this.b.TabIndex = 3;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(526, 153);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 21);
            this.c.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // test3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "test3";
            this.Text = "test3";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Button button3;
        private System.Diagnostics.EventLog eventLog1;
    }
}