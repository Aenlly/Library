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

        private bool OkClick = false;//定义给bool值，进行判断是否点击了返回按钮

        //重置密码的按钮事件
        private void btn_NetStep_Click(object sender, EventArgs e)
        {
            SqlDbHelper sqlDbHelper = new SqlDbHelper();//类的实例创建
            string name_id = text_name.Text.Trim();//获得学号
            string name_card = text_card.Text.Trim();//获得身份证

            //判断
            if (name_id == "" || name_card == "")
            {
                //错误提示
                MessageBox.Show("请输入账号、身份证", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name_card.Length < 18)//判断身份证是否有18位
            {
                //错误提示
                MessageBox.Show("身份证号码未达到18位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //sql查询语句
                String sql = "select u_card from [user] where u_id=" + name_id;
                int n = sqlDbHelper.Checkcard(sql, name_card);//传递参数进行判断
                if (n==2)
                {
                    string card = name_card.Substring(name_card.Length - 6);//取得身份证后六位
                    sql = "update [user] set u_password='" + card + "' where u_id='" + name_id + "'";
                    bool b_card = sqlDbHelper.EditPwd(sql);
                    if (b_card == true)
                    {
                        //弹窗提示
                        MessageBox.Show("密码重置成功，为身份证后六位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //弹窗提示
                        MessageBox.Show("密码重置失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                   
                else if(n==1)
                {
                    //身份证错误提示
                    MessageBox.Show("身份证错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_card.Text = "";//清空身份证
                    text_card.Focus();//获得身份证输入焦点
                }
                else
                {
                    //账号不存在提示
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
            OkClick = true;//点击单击了该按钮
            Login login = new Login();//实例化Login登录窗体对象
            login.Show();//显示登录窗体
            login.Activate();//给予焦点
            this.Close();//当前窗体关闭
        }

        //按×之后的关闭事件
        private void user_ChangePwd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //单击了返回登录按钮
            if (OkClick == true){  }
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

        private void text_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是不允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }

        private void text_card_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是不允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }
    }
}
