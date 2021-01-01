namespace Library.admin
{
    partial class admin_Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_FeedBack = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_UserPage = new System.Windows.Forms.Button();
            this.btn_Recovery = new System.Windows.Forms.Button();
            this.btn_Operation = new System.Windows.Forms.Button();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.btn_Overdue = new System.Windows.Forms.Button();
            this.btn_SingOut = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Library.Properties.Resources.Home_title;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 111);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "欢迎您：管理员";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_FeedBack);
            this.panel2.Controls.Add(this.btn_Return);
            this.panel2.Controls.Add(this.btn_UserPage);
            this.panel2.Controls.Add(this.btn_Recovery);
            this.panel2.Controls.Add(this.btn_Operation);
            this.panel2.Controls.Add(this.btn_Backup);
            this.panel2.Controls.Add(this.btn_Login);
            this.panel2.Controls.Add(this.btn_Borrow);
            this.panel2.Controls.Add(this.btn_Overdue);
            this.panel2.Controls.Add(this.btn_SingOut);
            this.panel2.Controls.Add(this.btn_Book);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 475);
            this.panel2.TabIndex = 1;
            // 
            // btn_FeedBack
            // 
            this.btn_FeedBack.Location = new System.Drawing.Point(44, 248);
            this.btn_FeedBack.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_FeedBack.Name = "btn_FeedBack";
            this.btn_FeedBack.Size = new System.Drawing.Size(75, 27);
            this.btn_FeedBack.TabIndex = 5;
            this.btn_FeedBack.Text = "反馈管理";
            this.btn_FeedBack.UseVisualStyleBackColor = true;
            this.btn_FeedBack.Click += new System.EventHandler(this.btn_FeedBack_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(44, 138);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 27);
            this.btn_Return.TabIndex = 2;
            this.btn_Return.Text = "还书管理";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_UserPage
            // 
            this.btn_UserPage.Location = new System.Drawing.Point(44, 214);
            this.btn_UserPage.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_UserPage.Name = "btn_UserPage";
            this.btn_UserPage.Size = new System.Drawing.Size(75, 27);
            this.btn_UserPage.TabIndex = 4;
            this.btn_UserPage.Text = "用户管理";
            this.btn_UserPage.UseVisualStyleBackColor = true;
            this.btn_UserPage.Click += new System.EventHandler(this.btn_UserPage_Click);
            // 
            // btn_Recovery
            // 
            this.btn_Recovery.Location = new System.Drawing.Point(44, 328);
            this.btn_Recovery.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_Recovery.Name = "btn_Recovery";
            this.btn_Recovery.Size = new System.Drawing.Size(75, 27);
            this.btn_Recovery.TabIndex = 7;
            this.btn_Recovery.Text = "数据恢复";
            this.btn_Recovery.UseVisualStyleBackColor = true;
            this.btn_Recovery.Click += new System.EventHandler(this.btn_Recovery_Click);
            // 
            // btn_Operation
            // 
            this.btn_Operation.Location = new System.Drawing.Point(44, 358);
            this.btn_Operation.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_Operation.Name = "btn_Operation";
            this.btn_Operation.Size = new System.Drawing.Size(75, 27);
            this.btn_Operation.TabIndex = 8;
            this.btn_Operation.Text = "操作记录";
            this.btn_Operation.UseVisualStyleBackColor = true;
            this.btn_Operation.Click += new System.EventHandler(this.btn_Operation_Click);
            // 
            // btn_Backup
            // 
            this.btn_Backup.Location = new System.Drawing.Point(44, 298);
            this.btn_Backup.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(75, 27);
            this.btn_Backup.TabIndex = 6;
            this.btn_Backup.Text = "数据备份";
            this.btn_Backup.UseVisualStyleBackColor = true;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(44, 388);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 27);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "登录记录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.Location = new System.Drawing.Point(44, 108);
            this.btn_Borrow.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Size = new System.Drawing.Size(75, 27);
            this.btn_Borrow.TabIndex = 1;
            this.btn_Borrow.Text = "借书管理";
            this.btn_Borrow.UseVisualStyleBackColor = true;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // btn_Overdue
            // 
            this.btn_Overdue.Location = new System.Drawing.Point(44, 168);
            this.btn_Overdue.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_Overdue.Name = "btn_Overdue";
            this.btn_Overdue.Size = new System.Drawing.Size(75, 27);
            this.btn_Overdue.TabIndex = 3;
            this.btn_Overdue.Text = "逾期管理";
            this.btn_Overdue.UseVisualStyleBackColor = true;
            this.btn_Overdue.Click += new System.EventHandler(this.btn_Overdue_Click);
            // 
            // btn_SingOut
            // 
            this.btn_SingOut.Location = new System.Drawing.Point(44, 436);
            this.btn_SingOut.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_SingOut.Name = "btn_SingOut";
            this.btn_SingOut.Size = new System.Drawing.Size(75, 27);
            this.btn_SingOut.TabIndex = 10;
            this.btn_SingOut.Text = "退出登录";
            this.btn_SingOut.UseVisualStyleBackColor = true;
            this.btn_SingOut.Click += new System.EventHandler(this.btn_SingOut_Click);
            // 
            // btn_Book
            // 
            this.btn_Book.Location = new System.Drawing.Point(44, 58);
            this.btn_Book.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(75, 27);
            this.btn_Book.TabIndex = 0;
            this.btn_Book.Text = "图书管理";
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // admin_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1072, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "admin_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书后台管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admin_Home_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Borrow;
        private System.Windows.Forms.Button btn_Overdue;
        private System.Windows.Forms.Button btn_SingOut;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Button btn_Operation;
        private System.Windows.Forms.Button btn_Recovery;
        private System.Windows.Forms.Button btn_UserPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_FeedBack;
    }
}