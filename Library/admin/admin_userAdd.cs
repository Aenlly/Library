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

namespace Library.admin
{
    public partial class admin_userAdd : Form
    {
        public admin_userAdd()
        {
            InitializeComponent();
        }

        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        SqlDataAdapter sda;//创建数据库适配器对象
        DButil dButil = new DButil();

        private void admin_userAdd_Load(object sender, EventArgs e)
        {
            cmb_sex.Items.Add("男");//添加下拉信息男
            cmb_sex.Items.Add("女");//添加下拉信息女
            cmb_sex.SelectedIndex = 0;//默认选定为男

            cmb_user.Items.Add("学生");//添加下拉信息学生
            cmb_user.Items.Add("老师");//添加下拉信息老师
            cmb_user.SelectedIndex = 0;//默认选定为学生
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //判断输入文本是否为空
            if (text_name.Text == "" || mtext_card.Text.Trim().Length<18) { MessageBox.Show("请填写添加用户信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                string[] card_temp = mtext_card.Text.Split('-');//去掉-符号
                string card = card_temp[0].Trim() + card_temp[1].Trim() + card_temp[2].Trim();//组合身份证
                string pwd = card.Substring(card.Length - 6, 6);//取身份证后6位数做密码

                if (cmb_user.Text == "学生")
                {
                    //添加用户的sql语句
                    string sql = "insert into [user] (u_password,u_name,u_sex,u_card,u_position,u_number) values ('" + pwd + "','" + text_name.Text.Trim() + "','" + cmb_sex.Text + "','" + card + "','" + cmb_user.Text + "','5')";
                    con = dButil.SqlOpen();
                    cmd = new SqlCommand(sql, con);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        DialogResult dialog=MessageBox.Show("添加用户："+text_name.Text.Trim()+ "成功！密码为身份证后六位\n点击确认返回用户管理界面", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (DialogResult.OK == dialog)
                        {
                            this.Close();
                            admin_userPage admin_User = new admin_userPage();
                            admin_User.Activate();
                        }
                    }
                    else
                    {
                        MessageBox.Show("添加失败，请检查资料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();//关闭数据库
                }
                else
                {
                    //添加用户的sql语句
                    string sql = "insert into [user] (,u_password,u_name,u_sex,u_card,u_position,u_number) values ('" + pwd + "','" + text_name.Text.Trim() + "','" + cmb_sex.Text + "''" + card + "','" + cmb_user.Text + "','8')";
                    con = dButil.SqlOpen();
                    cmd = new SqlCommand(sql, con);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        MessageBox.Show("添加用户：" + text_name.Text.Trim() + "成功！密码为身份证后六位", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("添加失败，请检查资料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();//关闭数据库
                }
            }
        }
    }
}
