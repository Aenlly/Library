namespace Library
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_pwd = new System.Windows.Forms.TextBox();
            this.btn_dl = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmb_1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码:";
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_name.Location = new System.Drawing.Point(85, 126);
            this.text_name.MaxLength = 13;
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(166, 23);
            this.text_name.TabIndex = 2;
            // 
            // text_pwd
            // 
            this.text_pwd.BackColor = System.Drawing.SystemColors.Window;
            this.text_pwd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_pwd.Location = new System.Drawing.Point(85, 170);
            this.text_pwd.MaxLength = 16;
            this.text_pwd.Name = "text_pwd";
            this.text_pwd.PasswordChar = '*';
            this.text_pwd.Size = new System.Drawing.Size(166, 23);
            this.text_pwd.TabIndex = 3;
            this.text_pwd.WordWrap = false;
            // 
            // btn_dl
            // 
            this.btn_dl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_dl.Location = new System.Drawing.Point(85, 217);
            this.btn_dl.Name = "btn_dl";
            this.btn_dl.Size = new System.Drawing.Size(166, 38);
            this.btn_dl.TabIndex = 4;
            this.btn_dl.Text = "登录";
            this.btn_dl.UseVisualStyleBackColor = true;
            this.btn_dl.Click += new System.EventHandler(this.btn_dl_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(265, 177);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 14);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "找回密码";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmb_1
            // 
            this.cmb_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_1.FormattingEnabled = true;
            this.cmb_1.Location = new System.Drawing.Point(106, 81);
            this.cmb_1.MaxDropDownItems = 1;
            this.cmb_1.Name = "cmb_1";
            this.cmb_1.Size = new System.Drawing.Size(121, 24);
            this.cmb_1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "登录身份：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(117, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "账号登录";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(340, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_dl);
            this.Controls.Add(this.text_pwd);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_pwd;
        private System.Windows.Forms.Button btn_dl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmb_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

