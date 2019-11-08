using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library.user
{
    public partial class user_Home : Form
    {
        public user_Home()
        {
            InitializeComponent();
        }

        private void btn_PwdEdit_Click(object sender, EventArgs e)
        {
            user_PwdEdit user_pwdEdit = new user_PwdEdit();
            user_pwdEdit.ShowDialog();//显示的修改密码窗体设置为活动窗体
        }

        private void btn_Signout_Click(object sender, EventArgs e)
        {
            Login login = new Login();//实例化登录窗体对象
            login.Show();//显示登录窗体
            this.Close();//关闭该窗体
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            user_About user_about = new user_About();//实例化关于帮助窗体对象
            user_about.ShowDialog();//显示的关于帮助窗体设置为活动窗体
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            user_SeeBookPage user_book = new user_SeeBookPage();//实例化查询图书窗体对象
            user_book.ShowDialog();//显示的查询图书窗体设置为活动窗体
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            user_BorrowPage user_Borrow = new user_BorrowPage();//实例化借书记录窗体对象
            user_Borrow.ShowDialog();//显示的借书记录窗体设置为活动窗体
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            user_SeeBookPage user_book = new user_SeeBookPage();//实例化还书记录窗体对象
            user_book.ShowDialog();//显示的还书记录窗体设置为活动窗体
        }

        private void btn_Basic_Click(object sender, EventArgs e)
        {
            user_Basic user_Basic = new user_Basic();//实例化用户基本信息窗体对象
            user_Basic.ShowDialog();//显示用户基本信息窗体设置为活动窗体
        }
    }
}
