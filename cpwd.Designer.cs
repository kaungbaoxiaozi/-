namespace Warehouse_Manager
{
    partial class cpwd
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
            this.change = new System.Windows.Forms.Button();
            this.opwd = new System.Windows.Forms.TextBox();
            this.npwd = new System.Windows.Forms.TextBox();
            this.npwds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(125, 164);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 0;
            this.change.Text = "提交";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // opwd
            // 
            this.opwd.Location = new System.Drawing.Point(125, 27);
            this.opwd.Name = "opwd";
            this.opwd.Size = new System.Drawing.Size(100, 21);
            this.opwd.TabIndex = 1;
            // 
            // npwd
            // 
            this.npwd.Location = new System.Drawing.Point(125, 71);
            this.npwd.Name = "npwd";
            this.npwd.Size = new System.Drawing.Size(100, 21);
            this.npwd.TabIndex = 2;
            // 
            // npwds
            // 
            this.npwds.Location = new System.Drawing.Point(125, 117);
            this.npwds.Name = "npwds";
            this.npwds.Size = new System.Drawing.Size(100, 21);
            this.npwds.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "重新新密码：";
            // 
            // cpwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 219);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.npwds);
            this.Controls.Add(this.npwd);
            this.Controls.Add(this.opwd);
            this.Controls.Add(this.change);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cpwd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox opwd;
        private System.Windows.Forms.TextBox npwd;
        private System.Windows.Forms.TextBox npwds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}