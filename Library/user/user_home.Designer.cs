﻿namespace Library.user
{
    partial class user_Home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_fbr = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_PwdEdit = new System.Windows.Forms.Button();
            this.btn_Signout = new System.Windows.Forms.Button();
            this.btn_Basic = new System.Windows.Forms.Button();
            this.btn_overdue = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.btn_book = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(968, 143);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 34);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_fbr);
            this.panel2.Controls.Add(this.btn_about);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_PwdEdit);
            this.panel2.Controls.Add(this.btn_Signout);
            this.panel2.Controls.Add(this.btn_Basic);
            this.panel2.Controls.Add(this.btn_overdue);
            this.panel2.Controls.Add(this.btn_return);
            this.panel2.Controls.Add(this.btn_borrow);
            this.panel2.Controls.Add(this.btn_book);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 428);
            this.panel2.TabIndex = 2;
            // 
            // btn_fbr
            // 
            this.btn_fbr.Location = new System.Drawing.Point(30, 244);
            this.btn_fbr.Name = "btn_fbr";
            this.btn_fbr.Size = new System.Drawing.Size(75, 23);
            this.btn_fbr.TabIndex = 8;
            this.btn_fbr.Text = "反馈记录";
            this.btn_fbr.UseVisualStyleBackColor = true;
            this.btn_fbr.Click += new System.EventHandler(this.btn_fbr_Click);
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(30, 282);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(75, 23);
            this.btn_about.TabIndex = 7;
            this.btn_about.Text = "关于系统";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // btn_PwdEdit
            // 
            this.btn_PwdEdit.Location = new System.Drawing.Point(30, 206);
            this.btn_PwdEdit.Name = "btn_PwdEdit";
            this.btn_PwdEdit.Size = new System.Drawing.Size(75, 23);
            this.btn_PwdEdit.TabIndex = 6;
            this.btn_PwdEdit.Text = "更改密码";
            this.btn_PwdEdit.UseVisualStyleBackColor = true;
            this.btn_PwdEdit.Click += new System.EventHandler(this.btn_PwdEdit_Click);
            // 
            // btn_Signout
            // 
            this.btn_Signout.Location = new System.Drawing.Point(30, 320);
            this.btn_Signout.Name = "btn_Signout";
            this.btn_Signout.Size = new System.Drawing.Size(75, 23);
            this.btn_Signout.TabIndex = 5;
            this.btn_Signout.Text = "退出登录";
            this.btn_Signout.UseVisualStyleBackColor = true;
            this.btn_Signout.Click += new System.EventHandler(this.btn_Signout_Click);
            // 
            // btn_Basic
            // 
            this.btn_Basic.Location = new System.Drawing.Point(30, 168);
            this.btn_Basic.Name = "btn_Basic";
            this.btn_Basic.Size = new System.Drawing.Size(75, 23);
            this.btn_Basic.TabIndex = 4;
            this.btn_Basic.Text = "基本信息";
            this.btn_Basic.UseVisualStyleBackColor = true;
            this.btn_Basic.Click += new System.EventHandler(this.btn_Basic_Click);
            // 
            // btn_overdue
            // 
            this.btn_overdue.Location = new System.Drawing.Point(30, 130);
            this.btn_overdue.Name = "btn_overdue";
            this.btn_overdue.Size = new System.Drawing.Size(75, 23);
            this.btn_overdue.TabIndex = 3;
            this.btn_overdue.Text = "逾期记录";
            this.btn_overdue.UseVisualStyleBackColor = true;
            this.btn_overdue.Click += new System.EventHandler(this.btn_overdue_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(30, 92);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 2;
            this.btn_return.Text = "还书记录";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_borrow
            // 
            this.btn_borrow.Location = new System.Drawing.Point(30, 54);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(75, 23);
            this.btn_borrow.TabIndex = 1;
            this.btn_borrow.Text = "借书记录";
            this.btn_borrow.UseVisualStyleBackColor = true;
            this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(30, 16);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(75, 23);
            this.btn_book.TabIndex = 0;
            this.btn_book.Text = "查询图书";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(134, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 428);
            this.panel3.TabIndex = 3;
            // 
            // user_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "user_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书馆";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.user_Home_FormClosing);
            this.Load += new System.EventHandler(this.user_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Signout;
        private System.Windows.Forms.Button btn_Basic;
        private System.Windows.Forms.Button btn_overdue;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_PwdEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fbr;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Label label2;
    }
}