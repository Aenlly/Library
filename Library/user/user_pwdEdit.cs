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
    public partial class user_PwdEdit : Form
    {
        public user_PwdEdit()
        {
            InitializeComponent();
        }

        private void btn_pwd_Click(object sender, EventArgs e)
        {
            SqlDbHelper sqlDbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            String user_id = Log.log.name;//获取登录的账户id
            Console.WriteLine(user_id);
            String user_pwd = text_pwd.Text.Trim();//获取登录的密码
            String user_pwds = text_pwds.Text.Trim();//获取重复输入密码

            if (user_pwd == "")
            {
                MessageBox.Show(this, "请输入新密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//弹窗警告提示
                text_pwd.Focus();
            }
            else if (user_pwds == "")
            {
                MessageBox.Show(this, "请再次输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//弹窗警告提示
                text_pwds.Focus();
            }
            else
            {
                if (user_pwd == user_pwds)
                {
                    if (!user_pwd.Equals(Log.log.pwd.ToString().Trim()))//返回为假，代表密码不一样，可以修改
                    {
                        bool f_ed;
                        string sqlpwd_ed = "update [user] set u_password ='" + text_pwd.Text.Trim() + "' where u_id='" + user_id + "'";//修改密码的sql语句
                        f_ed = sqlDbHelper.EditPwd(sqlpwd_ed);//传递sql语句进行判断是否修改了
                        if (f_ed == false)
                        {
                            Log.log.pwd = user_pwd;
                            MessageBox.Show(this, "密码修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);//弹窗提示
                            this.Close();//修改成功关闭该窗体
                        }
                        else
                        {
                            MessageBox.Show(this, "密码修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);//错误弹窗提示
                            text_pwds.Focus();//取得再次输入密码框焦点
                        }
                    }
                    else//否则不可以修改
                    {
                        MessageBox.Show(this, "密码与原密码相同", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//警告弹窗提示
                        text_pwds.Text = "";//清空确认密码框
                        text_pwd.Focus();//取得密码框的输入焦点
                        text_pwd.SelectAll();//选中密码框的全部内容
                    }
                }
                else
                {
                    MessageBox.Show(this, "两次的密码不一致，请重新修改", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);//错误弹窗提示
                    text_pwds.Focus();//取得确认密码框的输入焦点
                    text_pwds.SelectAll();//选中确认密码框的全部内容
                }
            }
        }

        private void user_PwdEdit_Load(object sender, EventArgs e)
        {
        }
    }
}
