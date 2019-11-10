using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library.admin
{
    public partial class admin_Home : Form
    {
        public admin_Home()
        {
            InitializeComponent();
        }
        //图书管理按钮事件
        private void btn_Book_Click(object sender, EventArgs e)
        {
            admin_BookPage admin_Book = new admin_BookPage();//实例化图书管理窗体对象
            admin_Book.ShowDialog();//显示图书管理窗体
        }

        //结束记录按钮事件
        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            admin_BorrowPage admin_Borrow = new admin_BorrowPage();//实例化借书记录窗体对象
            admin_Borrow.ShowDialog();//显示借书记录窗体
        }

        //还书记录按钮事件
        private void btn_Return_Click(object sender, EventArgs e)
        {
            admin_ReturnPage admin_Return = new admin_ReturnPage();//实例化还书记录窗体对象
            admin_Return.ShowDialog();//显示还书记录窗体
        }

        //逾期按钮事件
        private void btn_Overdue_Click(object sender, EventArgs e)
        {
            admin_OverduePage admin_Overdue = new admin_OverduePage();//实例化逾期记录窗体对象
            admin_Overdue.ShowDialog();//显示逾期记录窗体
        }

        //用户管理按钮事件
        private void btn_UserPage_Click(object sender, EventArgs e)
        {
            admin_userPage admin_UserPage = new admin_userPage();//实例化用户管理窗体对象
            admin_UserPage.ShowDialog();//显示用户管理界面
        }

        //反馈记录按钮事件
        private void btn_FeedBack_Click(object sender, EventArgs e)
        {
            admin_FeedBackPage admin_FeedBack = new admin_FeedBackPage();//实例化反馈记录窗体对象
            admin_FeedBack.ShowDialog();//显示反馈记录窗体
        }

        //数据备份按钮事件
        private void btn_Backup_Click(object sender, EventArgs e)
        {
            admin_Backups admin_Backups = new admin_Backups();//实例化数据备份窗体对象
            admin_Backups.ShowDialog();//显示数据备份窗体
        }

        //数据恢复按钮事件
        private void btn_Recovery_Click(object sender, EventArgs e)
        {
            admin_Recovery admin_Recovery = new admin_Recovery();//实例化数据恢复窗体对象
            admin_Recovery.ShowDialog();//显示数据恢复窗体
        }

        //操作记录按钮事件
        private void btn_Operation_Click(object sender, EventArgs e)
        {
            admin_OperationPage admin_Operation = new admin_OperationPage();//实例化操作记录窗体对象
            admin_Operation.ShowDialog();//显示操作记录界面
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            admin_loginPage admin_Login = new admin_loginPage();//实例化登录记录窗体对象
            admin_Login.ShowDialog();//显示登录记录界面
        }

        //退出登录按钮事件
        private void btn_SingOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();//实例化登录窗体对象
            login.Show();//显示登录窗体
            this.Close();//关闭当前窗体
        }
    }
}
