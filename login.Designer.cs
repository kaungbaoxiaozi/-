namespace Warehouse_Manager
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.loginbut = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.exitbut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbut
            // 
            resources.ApplyResources(this.loginbut, "loginbut");
            this.loginbut.Name = "loginbut";
            this.loginbut.UseVisualStyleBackColor = true;
            this.loginbut.Click += new System.EventHandler(this.sqltest_Click);
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            // 
            // pwd
            // 
            resources.ApplyResources(this.pwd, "pwd");
            this.pwd.Name = "pwd";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // exitbut
            // 
            resources.ApplyResources(this.exitbut, "exitbut");
            this.exitbut.Name = "exitbut";
            this.exitbut.UseVisualStyleBackColor = true;
            this.exitbut.Click += new System.EventHandler(this.exitbut_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // login
            // 
            this.AcceptButton = this.loginbut;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitbut);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.id);
            this.Controls.Add(this.loginbut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbut;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button exitbut;
        private System.Windows.Forms.Label label4;
    }
}

