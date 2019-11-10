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
    public partial class user_ChangePwd : Form
    {
        public user_ChangePwd()
        {
            InitializeComponent();
        }

        private bool OkClick = false;//定义给bool值，进行判断是否当即了返回按钮

        //重置密码的按钮事件
        private void btn_NetStep_Click(object sender, EventArgs e)
        {
            SqlDbHelper sqlDbHelper = new SqlDbHelper();
            String name_id = text_name.Text.Trim();
            String name_card = text_card.Text.Trim();

            if (name_id == "" || name_card == "")
            {
                MessageBox.Show("请输入账号、身份证", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql = "select u_card from [user] where u_id=" + name_id;
                int n = sqlDbHelper.Checkcard(sql, name_card);
                if (n==2)
                {
                    String card = name_card.Substring(name_card.Length-6);//取得身份证后六位
                    DialogResult dialog= MessageBox.Show("密码重置成功，为身份证后六位", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (dialog == DialogResult.OK)//判断是否点击了确认按钮
                    {
                        Login login = new Login();
                        login.Show();
                        this.Close();//当前窗体关闭
                    }
                    
                }
                else if(n==1)
                {
                    MessageBox.Show("身份证错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_card.Text = "";//清空身份证
                    text_card.Focus();//获得身份证输入焦点
                }
                else
                {
                    MessageBox.Show("账号不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_name.Text = "";//清空账号
                    text_card.Text = "";//清空身份证
                    text_name.Focus();//获得账号输入焦点
                }
            }
        }

        //返回登录按钮的事件
        private void btn_Login_Click(object sender, EventArgs e)
        {
            OkClick = true;//判断是否单击了该按钮
            this.Close();
            Login login = new Login();//实例化Login登录窗体对象
            login.Show();//显示登录窗体
            login.Activate();//给予焦点
        }

        //按×之后的关闭事件
        private void user_ChangePwd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //单击了返回登录按钮
            if (OkClick == true){  }
            //单击了确认按钮
            else if (DialogResult.OK == MessageBox.Show("确认退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
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
