using Library.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private bool OkClick = false;//定义个关闭的

        //单击了修改密码按钮
        private void btn_PwdEdit_Click(object sender, EventArgs e)
        {
            user_PwdEdit user_pwdEdit = new user_PwdEdit();
            user_pwdEdit.ShowDialog();//显示的修改密码窗体设置为活动窗体
        }

        //单击了退出登录按钮
        private void btn_Signout_Click(object sender, EventArgs e)
        {
            //重复确认
            if (DialogResult.OK == MessageBox.Show("确认退出登录？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                Login login = new Login();//实例化登录窗体对象
                login.Show();//显示登录窗体
                OkClick = true;
                this.Close();//关闭该窗体
            }
            else { }
        }

        //关于帮助按钮事件
        private void btn_About_Click(object sender, EventArgs e)
        {
            user_About user_about = new user_About();//实例化关于帮助窗体对象
            user_about.ShowDialog();//显示的关于帮助窗体设置为活动窗体
        }

        //查询图书按钮事件
        private void btn_Book_Click(object sender, EventArgs e)
        {
            user_SeeBookPage user_book = new user_SeeBookPage();//实例化查询图书窗体对象
            user_book.ShowDialog();//显示的查询图书窗体设置为活动窗体
        }

        //借书记录按钮事件
        private void btn_borrow_Click(object sender, EventArgs e)
        {
            user_BorrowPage user_Borrow = new user_BorrowPage();//实例化借书记录窗体对象
            user_Borrow.ShowDialog();//显示的借书记录窗体设置为活动窗体
        }

        //还书记录按钮事件
        private void btn_return_Click(object sender, EventArgs e)
        {
            user_Return user_book = new user_Return();//实例化还书记录窗体对象
            user_book.ShowDialog();//显示的还书记录窗体设置为活动窗体
        }

        //逾期记录按钮事件
        private void btn_overdue_Click(object sender, EventArgs e)
        {
            user_OverduePage user_Overdue = new user_OverduePage();//实例化逾期记录窗体对象
            user_Overdue.ShowDialog();//显示的逾期记录窗体设置为活动窗体
        }

        //基本信息按钮事件
        private void btn_Basic_Click(object sender, EventArgs e)
        {
            user_Basic user_Basic = new user_Basic();//实例化用户基本信息窗体对象
            user_Basic.ShowDialog();//显示用户基本信息窗体设置为活动窗体
        }

        //反馈记录按钮事件
        private void btn_fbr_Click(object sender, EventArgs e)
        {
            user_FeedbackRecord user_FeedbackRecord = new user_FeedbackRecord();//实例化用户反馈记录体对象
            user_FeedbackRecord.ShowDialog();//显示反馈记录窗体设置为活动窗体
        }

        //关闭事件
        private void user_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            //单击了退出登录按钮
            if (OkClick == true) { }
            //单击了确认按钮
            else if (DialogResult.OK == MessageBox.Show("确认退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                Application.ExitThread();//强制中止调用线程上的所有消息
                // System.Environment.Exit(0);  //结束全进程,会产生创建窗口句柄时出错
            }
            else
            {
                e.Cancel = true;//当前窗体不关闭
            }
        }

        private void user_Home_Load(object sender, EventArgs e)
        {
            string sql = "select u_number from [user] where u_id='" + Log.log.u_id + "'";//sql查询可借数量语句
            DButil dButil = new DButil();//实例化DButil工具类
            SqlConnection con = dButil.SqlOpen();//打开数据库
            SqlCommand cmd = new SqlCommand(sql, con);//执行sql查询
            Log.log.user_number = Convert.ToInt16(cmd.ExecuteScalar());//获得可借图书数量，并储存在log类中调用

            //插入登陆信息
            sql = "insert login values (null," + Log.log.u_id + ",null,getdate())";
            cmd = new SqlCommand(sql, con);//执行
            con.Close();//关闭数据库

        }
    }
}
