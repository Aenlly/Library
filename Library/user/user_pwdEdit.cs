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
            Log log = new Log();//实例化Log类
            String user_id = log.Name;//获取登录的账户id
            String user_pwd = txt_pwd.Text.Trim();//获取登录的密码

            if (user_pwd == txt_pwds.Text.Trim())
            {
                String sql = "select u_password from [user] where u_id=" + user_id;//设置查询用户密码sql语句
                bool f_t = log.Checkuser(sql, user_pwd);//传递参数获取返回只，修改密码是否与原来的密码相同
                if (f_t == false)//返回为假，代表密码不一样，可以修改
                {
                    bool f_ed;
                    string sqlpwd_ed = "update set u_password ='" + txt_pwd.Text.Trim() + "' from [user] where u_id='" + user_id + "'";//修改密码的sql语句
                    f_ed = log.EditPwd(sqlpwd_ed);//传递sql语句进行判断是否修改了
                    if (f_ed == false)
                    {
                        MessageBox.Show(this, "密码修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);//弹窗提示
                        this.Close();//修改成功关闭该窗体
                    }
                    else
                    {
                        MessageBox.Show(this, "密码修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);//错误弹窗提示
                        txt_pwds.Focus();//取得再次输入密码框焦点
                    }
                }
                else//否则不可以修改
                {
                    MessageBox.Show(this, "密码与原密码相同", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//警告弹窗提示
                    txt_pwds.Text = "";//清空确认密码框
                    txt_pwd.Focus();//取得密码框的输入焦点
                    txt_pwd.SelectAll();//选中密码框的全部内容
                }
            }
            else
            {
                MessageBox.Show(this, "两次的密码不一致，请重新修改", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);//错误弹窗提示
                txt_pwds.Focus();//取得确认密码框的输入焦点
                txt_pwds.SelectAll();//选中确认密码框的全部内容
            }
        }

    }
}
