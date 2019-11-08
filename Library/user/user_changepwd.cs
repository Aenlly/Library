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
    }
}
