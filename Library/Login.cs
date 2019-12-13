using Library.user;
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

namespace Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DButil dButil = new DButil();

        //登录按钮的单击事件
        private void btn_dl_Click(object sender, EventArgs e)
        {
            string name = text_name.Text.Trim();
            string pwd = text_pwd.Text.Trim();


            SqlDbHelper sqlDbHelper = new SqlDbHelper();//实例化SqlDbHelper类

            if (text_name.Text.Equals(""))
            {
                MessageBox.Show("用户名不能为空", "提示错误");
                text_name.Focus();//输入光标移至用户框
            }
            else if (text_pwd.Text == "")
            {
                MessageBox.Show("密码不能为空");//输入光标移至密码框
                text_pwd.Focus();
            }
            else
            {
                //判断登录方式是否为用户
                if (cmb_type.SelectedIndex == 0)
                {
                    string sql = "select u_password from [user] where u_id='" + name+"'";
                    int n = sqlDbHelper.Checkuser(sql, pwd);
                    if (n == 2)//账号密码正确
                    {
                        //插入登陆信息
                        sql = "insert into login values (" + text_name.Text.Trim() + ",getdate())";
                        SqlConnection con= dButil.SqlOpen();//打开//储存需要执行的sql语句数据库
                        SqlCommand cmd = new SqlCommand(sql, con);//储存sql语句
                        cmd.ExecuteNonQuery();//执行sql语句
                        con.Close();//关闭数据库

                        Log.log.u_id = text_name.Text.Trim();//储存id
                        Log.log.pwd = text_pwd.Text.Trim();//储存密码              

                        user_Home user_Home = new user_Home();//用户窗体实例化
                        user_Home.Show();// 显示窗体
                        user_Home.Activate();//给予焦点
                        this.Visible = false;  // 当前窗体不可见
                    }
                    else if (n == 1)//密码正确
                    {
                        MessageBox.Show(this, "该账号密码错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        text_pwd.Focus();//光标移到密码框中
                    }
                    else//账号不存在
                    {
                        MessageBox.Show(this, "该账号不存在或登录方式错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        text_pwd.Text = "";
                        text_name.Focus();//光标移到账号框中
                    }
                }

                //判断登录方式是否为管理员
                else if (cmb_type.SelectedIndex == 1)
                {
                    string sql = "select a_password from [admin] where a_name='" + name + "'";//执行管理员查询语句
                    int n = sqlDbHelper.Checkadmin(sql, pwd);//传递sql语句与用户输入的密码
                    if (n == 2)//账号密码正确
                    {
                        //创建查询管理员id的sql语句
                        sql = "select a_id from admin where a_name='" + name + "' and a_password='" + pwd + "'";
                        DButil dButil = new DButil();//实例化连接数据库类
                        SqlConnection con = dButil.SqlOpen();//打开数据库
                        SqlCommand cmd = new SqlCommand(sql, con);//储存需要执行的sql语句
                        Log.log.a_id = Convert.ToInt16(cmd.ExecuteScalar());//赋值管理员编号，执行sql语句
                        con.Close();//关闭数据库

                        Log.log.u_id = text_name.Text.Trim();
                        Log.log.pwd = text_pwd.Text.Trim();
                        admin.admin_Home admin_Home = new admin.admin_Home();//管理员窗体实例化
                        admin_Home.Show();//转到管理员的界面
                        admin_Home.Activate();//给予焦点
                        this.Hide();
                    }
                    else if (n == 1)//判断账号密码是否错误
                    {
                        MessageBox.Show(this, "该账号密码错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        text_pwd.Text = "";
                        text_pwd.Focus();//光标移到密码框中
                    }
                    else//账号不存在
                    {
                        MessageBox.Show(this, "该账号不存在或登录方式错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        text_pwd.Text="";
                        text_name.Focus();//光标移到账号框中
                    }
                }
            }
        }

        /// <summary>
        /// 找回密码按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            user_ChangePwd user_ChangePwd = new user_ChangePwd();//实例化找回密码窗体
            user_ChangePwd.Show();//显示找回密码窗体
            user_ChangePwd.Activate();//给予找回密码窗体焦点
            this.Hide();//登录窗体隐藏
        }

        //窗体加载
        private void Login_Load(object sender, EventArgs e)
        {
            cmb_type.Items.Add("用户");//添加用户选项
            cmb_type.Items.Add("管理员");//添加管理员选项
            cmb_type.SelectedIndex = 0;//使用户为默认选项
        }

        //点击关闭时的执行代码判断
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //弹窗询问
            if (DialogResult.OK==MessageBox.Show("确认退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) )
            {
                Application.ExitThread();//强制中止调用线程上的所有消息
                // System.Environment.Exit(0);  //结束全进程,会产生创建窗口句柄时出错
            }
            else
            {
                e.Cancel = true;//当前窗体不关闭
            }
        }

        private void text_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmb_type.Text == "用户")
            {
                if (e.KeyChar != '\b')//这是允许输入退格键  
                {
                    if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是不允许输入0-9数字  
                    {
                        e.Handled = true;
                    }
                }
            }
            else { }
        }

        //下拉索引修改
        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_type.SelectedIndex == 0)//如果索引修改为0，则输入框内容全部清空
            {
                text_name.Text = "";
                text_pwd.Text = "";
                text_name.Focus();
            }
        }
    }
}