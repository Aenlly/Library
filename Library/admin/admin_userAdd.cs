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
        DButil dButil = new DButil();//实例化DButil数据库打开类

        private void admin_userAdd_Load(object sender, EventArgs e)
        {
            BookType();
            cmb_sex.Items.Add("男");//添加下拉信息男
            cmb_sex.Items.Add("女");//添加下拉信息女
            cmb_sex.SelectedIndex = 0;//默认选定为男

            cmb_user.Items.Add("学生");//添加下拉信息学生
            cmb_user.Items.Add("老师");//添加下拉信息老师
            cmb_user.SelectedIndex = 0;//默认选定为学生
        }

        /// <summary>
        /// 绑定下拉列表，添加数据库中的学院
        /// </summary>
        /// <param name="sqltype">数据库语句</param>
        /// <param name="college">表名</param>
        /// <param name="c_college">字段名</param>
        public void BookType()
        {
            con = dButil.SqlOpen();//打开i数据库
            //初始化，comboBox1绑定学院表
            string sqltype = "select c_college from [college]";//查询有多少类别
            SqlDataAdapter sda = new SqlDataAdapter(sqltype, con);
            DataSet ds = new DataSet();//创建ds缓存
            sda.Fill(ds);//添加到ds缓存中
            cmb_college.DataSource = ds.Tables[0].DefaultView;//取出数据源填充到列表中
            cmb_college.DisplayMember = "c_college";//列表中显示的值对应的字段名
            string sql = "select c_id from [college] where c_college='" + cmb_college.Text + "'";//查学院第一个的列的id
            cmd = new SqlCommand(sql, con);////储存需要执行的c_id语句
            int c_id = Convert.ToInt16(cmd.ExecuteScalar());//返回c_id值，用于这边选中，执行c_id语句
            cmb_college.SelectedIndex = c_id;//设置索引为c_id
            con.Close();//关闭数据库
        }

        //添加按钮
        private void btn_add_Click(object sender, EventArgs e)
        {
            //判断输入文本是否为空
            if (text_name.Text == "" || mtext_card.Text.Trim().Length<18) { MessageBox.Show("请填写添加正确信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                string[] card_temp = mtext_card.Text.Split('-');//去掉-符号
                string card = card_temp[0].Trim() + card_temp[1].Trim() + card_temp[2].Trim();//组合身份证
                string pwd = card.Substring(card.Length - 6, 6);//取身份证后6位数做密码

                if (cmb_user.Text == "学生")
                {
                    //添加用户的sql语句
                    string sql = "insert into [user] (u_password,u_name,u_sex,u_card,c_id,u_position,u_number) values ('" + pwd + "','" + text_name.Text.Trim() + "','" + cmb_sex.Text + "','" + card + "','"+cmb_college.SelectedIndex+"','" + cmb_user.Text + "','5')";
                    con = dButil.SqlOpen();//打开数据库
                    cmd = new SqlCommand(sql, con);//储存sql语句
                    int n = cmd.ExecuteNonQuery();//执行语句，返回成功记录进行判断
                    sql = "select u_id from [user] where u_card='" + card + "'";//查询账号
                    cmd = new SqlCommand(sql, con);//储存sql语句
                    int m = Convert.ToInt32(cmd.ExecuteScalar());//执行sql语句，获得账号
                    con.Close();//关闭数据量
                    if (n > 0)
                    {
                        SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                        dbHelper.Operation("成功添加用户：" + text_name.Text.Trim());//插入操作记录

                        DialogResult dialog=MessageBox.Show("添加用户："+text_name.Text.Trim()+ "成功！\n账号为" + m + "\n密码为身份证后六位\n点击确认返回用户管理界面", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //失败提示
                        MessageBox.Show("添加失败，请检查资料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();//关闭数据库
                }
                else
                {
                    //添加用户的sql语句
                    string sql = "insert into [user] (u_password,u_name,u_sex,u_card,c_id,u_position,u_number) values ('" + pwd + "','" + text_name.Text.Trim() + "','" + cmb_sex.Text + "','"+cmb_college.SelectedIndex+"','" + card + "','" + cmb_user.Text + "','8')";
                    con = dButil.SqlOpen();//打开数据库
                    cmd = new SqlCommand(sql, con);//储存sql语句
                    int n = cmd.ExecuteNonQuery();//执行sql语句,返回成功记录进行判断
                    sql = "select u_id from [user] where u_card='" + card+"'";//查询账号
                    cmd = new SqlCommand(sql, con);//储存sql语句
                    int m=Convert.ToInt16(cmd.ExecuteScalar());//执行sql语句，获得账号
                    con.Close();//关闭数据库
                    if (n > 0)
                    {
                        SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                        dbHelper.Operation("成功添加用户：" + text_name.Text.Trim());//插入操作记录

                        //成功提示
                        DialogResult dialog=MessageBox.Show("添加用户：" + text_name.Text.Trim() + "成功！\n账号为"+m+ "\n密码为身份证后六位\n点击确认返回用户管理界面", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (DialogResult.OK == dialog)//确认判断
                        {
                            this.Close();//关闭窗体
                            admin_userPage admin_User = new admin_userPage();
                            admin_User.Activate();
                        }
                    }
                    else
                    {
                        //失败提示
                        MessageBox.Show("添加失败，请检查资料！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();//关闭数据库
                }
            }
        }

        //跳转到添加学院窗体
        private void link_college_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Log.log.user_college = true;//判断是用户窗体处单击的
            admin_Type admin_Type = new admin_Type();//实例化admin_Type
            admin_Type.ShowDialog();//显示
            BookType();//刷新学院下拉框
        }

        //关闭窗体
        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
