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
        SqlConnection con;

        private void btn_dl_Click(object sender, EventArgs e)
        {
            String name = txt_name.Text.Trim();
            String password = txt_pass.Text.Trim();
            Log log = new Log();
            log.Name = name;

            if (txt_name.Text.Equals(""))
            {
                MessageBox.Show("用户名不能为空", "提示错误");
                txt_name.Focus();//输入光标移至用户框
            }
            if (txt_pass.Text == "")
            {
                MessageBox.Show("密码不能为空");//输入光标移至密码框
                txt_pass.Focus();
            }
            else
            {
                //判断登录方式是否为用户
                if (cmb_1.SelectedIndex == 0)
                {
                    String sql = "SELECT u_password FROM readers where u_id='" + txt_name.Text.Trim() + "'";
                    if (!log.Checkuser(sql,txt_pass.Text.Trim()))
                    {
                        MessageBox.Show(this, "该账号或密码错误\n\r或登录方式错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txt_name.Focus();
                    }
                    else if (log.Checkuser(txt_name.Text.Trim(), txt_pass.Text.Trim()))
                    {
                        user.user_Home user_Home = new user.user_Home();//用户窗体实例化
                        user_Home.Show();// 显示窗体
                        user_Home.Activate();//给予焦点
                        this.Visible = false;  // 当前窗体不可见
                    }
                    else
                    {
                        MessageBox.Show("密码错误", "提示");
                        txt_pass.Focus();//清空密码文本框控件
                        txt_pass.SelectAll();//取得密码文本框焦点
                    }

                }

                //判断登录方式是否为管理员
                else if (cmb_1.SelectedIndex == 1)
                {
                    string sql = "SELECT a_password FROM admin where a_name='" + txt_name.Text.Trim() + "'";//执行管理员查询语句
                    if (!log.Checkadmin(sql, txt_pass.Text.Trim()))//账号判断是否为空
                    {
                        MessageBox.Show(this, "该账号或密码错误\n\r或登录方式错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else if (log.Checkadmin(sql, txt_pass.Text.Trim()))//传递参数至方法中进行真假判断
                    {
                        admin.admin_home admin_Home = new admin.admin_home();//管理员窗体实例化
                        admin_Home.Show();//转到管理员的界面
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(this, "密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txt_pass.Focus();//清空密码文本框控件
                        txt_pass.SelectAll();//取得密码文本框焦点
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
    }
}