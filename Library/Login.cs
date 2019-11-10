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

        private void btn_dl_Click(object sender, EventArgs e)
        {
            String name = text_name.Text.Trim();
            String pwd = text_pwd.Text.Trim();


            SqlDbHelper sqlDbHelper = new SqlDbHelper();

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
                if (cmb_1.SelectedIndex == 0)
                {
                    String sql = "select u_password from [user] where u_id=" + name;
                    int n = sqlDbHelper.Checkuser(sql, pwd);
                    if (n == 2)//账号密码正确
                    {
                        Log.log.name = text_name.Text.Trim();
                        Log.log.pwd = text_pwd.Text.Trim();
                        user.user_Home user_Home = new user.user_Home();//用户窗体实例化
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
                else if (cmb_1.SelectedIndex == 1)
                {
                    string sql = "select a_password from [admin] where a_name='" + name + "'";//执行管理员查询语句
                    int n = sqlDbHelper.Checkadmin(sql, pwd);
                    if (n == 2)//账号密码正确
                    {
                        Log.log.name = text_name.Text.Trim();
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

        private void Login_Load(object sender, EventArgs e)
        {
            cmb_1.Items.Add("用户");//添加用户选项
            cmb_1.Items.Add("管理员");//添加管理员选项
            cmb_1.SelectedIndex = 0;//使用户为默认选项
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK==MessageBox.Show("确认退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) )
            {
                System.Environment.Exit(0);  //结束全进程
            }
            else
            {
                e.Cancel = true;//当前窗体不关闭
            }
        }
    }
}