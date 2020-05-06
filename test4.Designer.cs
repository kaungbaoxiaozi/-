namespace Warehouse_Manager
{
    partial class test4
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
            this.date = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date.Location = new System.Drawing.Point(0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(287, 140);
            this.date.TabIndex = 0;
            this.date.Text = "";
            // 
            // test4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 140);
            this.Controls.Add(this.date);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "test4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "已保存日志";
            this.Load += new System.EventHandler(this.test4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox date;
    }
}