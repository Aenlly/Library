using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library.utils;

namespace Library.admin
{
    public partial class admin_userEdit : Form
    {
        public admin_userEdit()
        {
            InitializeComponent();
        }

        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        SqlDataReader sdr;//创建一个只读的结果集
        DButil dButil = new DButil();//实例化DButil工具类

        private void admin_userEdit_Load(object sender, EventArgs e)
        {
            string user_id = Log.log.user_id;
            string sql = "select * from [user] where u_id='" + user_id.ToString() + "'";
            con = dButil.SqlOpen();//打开数据库
            cmd = new SqlCommand(sql, con);
            sdr = cmd.ExecuteReader();//储存结果
            sdr.Read();//检测是否有数据
            text_id.Text = user_id;//学号/工号
            text_name.Text= sdr["u_name"].ToString();//在姓名文本框中显示查询到的姓名
            mtext_tel.Text = sdr["u_tel"].ToString();//在手机号文本框中显示查询到的手机号
            mtext_card.Text = sdr["u_card"].ToString();//在身份证文本框中显示查询到的身份证
            text_college.Text = sdr["u_college"].ToString();//在学院文本框中显示查询到的学院

            cmb_sex.Items.Add(sdr["u_sex"].ToString());//获得性别
            cmb_sex.SelectedIndex = 0;//并选中性别
            if (cmb_sex.Text == "男")//如果是男，下拉框就添加女，否则添加男
            {
                cmb_sex.Items.Add("女");
            }
            else
            {
                cmb_sex.Items.Add("女");
            }

            cmb_position.Items.Add(sdr["u_position"].ToString());
            cmb_position.SelectedIndex = 0;
            if (cmb_position.Text == "学生")//如果是学生组，下拉框就添加老师组，否则添加学生组
            {
                cmb_position.Items.Add("老师");
            }
            else
            {
                cmb_position.Items.Add("学生");
            }
            con.Close();//关闭数据库
        }


        //确认修改按钮事件
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (mtext_tel.Text.Trim().Length < 11){ MessageBox.Show("手机号错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (mtext_card.Text.Trim().Length < 18) { MessageBox.Show("身份证错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                if (text_name.Text != "" || mtext_tel.Text != "" || text_college.Text != "" || mtext_card.Text != "")
                {
                    string[] tel_temp = mtext_tel.Text.Split('-');//去掉-，分成3个值储存在数组中
                    string str_tel = tel_temp[0].Trim() + tel_temp[1].Trim() + tel_temp[2].Trim();//进行组合成手机号
                    string[] card_temp = mtext_card.Text.Split('-');//去掉-，分成3个值储存在数组中
                    string str_card = card_temp[0].Trim() + card_temp[1].Trim() + card_temp[2].Trim();//进行组合成身份证

                    //sql更新语句
                    string sql = "update [user] set u_name='" + text_name.Text.Trim() + "',u_sex='" + cmb_sex.Text + "',u_tel='" + str_tel + "',u_card='" + str_card + "',u_position='" + cmb_position.Text + "',u_college='" + text_college.Text.Trim() + "' where u_id='" + text_id.Text + "'";
                    con = dButil.SqlOpen();
                    cmd = new SqlCommand(sql, con);//储存sql语句
                    int n = cmd.ExecuteNonQuery();//执行sql语句，返回影响行数判断是否修改成功
                    con.Close();//关闭数据库
                    if (n > 0)
                    {
                        SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                        dbHelper.Operation("成功修改学号/工号为：" + text_id.Text.Trim()+"的用户");//插入操作记录

                        //修改成功进行提示
                        DialogResult dialog = MessageBox.Show("修改成功！点击确认返回用户管理界面", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (DialogResult.OK == dialog)
                        {
                            this.Close();
                            admin_userPage admin_User = new admin_userPage();
                            admin_User.Activate();
                        }
                    }
                    else
                    {
                        //修改失败弹出提示
                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //文本框内容为空弹出提示
                    MessageBox.Show("修改内容不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
