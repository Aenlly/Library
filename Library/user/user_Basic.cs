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

namespace Library.user
{
    public partial class user_Basic : Form
    {
        public user_Basic()
        {
            InitializeComponent();
        }

        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        DButil dButil = new DButil();//实例化DButil工具类
        public string sex;//性别
        public int college;//学院
        public string tel;//手机号
        public string u_id;//学号

        private void user_Basic_Load(object sender, EventArgs e)
        {
            u_id = Log.log.u_id;//获得登录账号
            string sql = "select * from [user],[college] where [user].c_id=[college].c_id and u_id='"+u_id+"'";//利用学号查询学生详细信息
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);//执行sql语句
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            text_id.Text = u_id;
            text_name.Text = reader["u_name"].ToString();//获取用户姓名
            
            sex = reader["u_sex"].ToString();//获取用户性别，储存在字符串中
            if (sex == "男")
            {
                rbtn_male.Checked = true;//选中男
            }
            else
            {
                rbtn_female.Checked = true;//选中女
            }

            College();//下拉框加载学院
            college = cmb_college.SelectedIndex;//获得初始选中的学院索引值

            tel= reader["u_tel"].ToString();//获取用户手机号，储存在字符串中
            text_tel.Text = tel;//显示在文本框中

            text_position.Text = reader["u_position"].ToString();//获取用户所在用户组
            text_number.Text = reader["u_number"].ToString();//获取用户可借数量
            text_book.Text = reader["u_book"].ToString();//获取用户总借书数量
            con.Close();

        }

        /// <summary>
        /// 绑定下拉列表，添加数据库中的学院
        /// </summary>
        /// <param name="sql_col">数据库语句命名</param>
        /// <param name="college">表名</param>
        /// <param name="c_college">学院</param>
        public void College()
        {
            con = dButil.SqlOpen();
            //初始化，comboBox1绑定客户表
            string sql_col = "select c_college from [college]";//查询有多少学院
            SqlDataAdapter sda = new SqlDataAdapter(sql_col, con);//创建sql适配器
            DataSet ds = new DataSet();//创建ds缓存
            sda.Fill(ds);//添加到ds缓存中
            cmb_college.DataSource = ds.Tables[0].DefaultView;//取出数据源填充到列表中
            cmb_college.DisplayMember = "c_college";//列表中显示的值对应的字段名
            string sql = "select c_id from [user] where u_id='" + Log.log.u_id + "'";
            cmd = new SqlCommand(sql, con);////储存需要执行的c_id语句
            int t_id = Convert.ToInt16(cmd.ExecuteScalar());//返回c_id值，用于这边选中，执行c_id语句
            cmb_college.SelectedIndex = t_id;//设置索引为t_id
            con.Close();//关闭数据库
        }


        //点击了修改信息按钮
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (btn_edit.Text == "修改信息")
            {
                rbtn_male.Enabled = true;//启用男单选按钮
                rbtn_female.Enabled = true;//启用女单选按钮
                cmb_college.Enabled = true;//设置学院可编辑
                text_tel.Enabled = true;//设置手机号可编辑
                btn_edit.Text = "确认修改";
            }
            else
            {
                //满足学院为空、手机号为空、手机号小于11位，进行提示
                if (text_tel.Text.Trim() != "" && text_tel.Text.Length < 11)
                {
                    MessageBox.Show("手机号错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rbtn_male.Checked == true)
                    {
                        //执行选中男的sql语句
                        string sql = "update [user] set u_sex='男',c_id='" + cmb_college.SelectedIndex + "',u_tel='" + text_tel.Text.Trim() + "' where u_id='" + u_id + "'";
                        con = dButil.SqlOpen();//打开数据库
                        cmd = new SqlCommand(sql, con);//储存sql语句
                        int n = cmd.ExecuteNonQuery();//执行sql语句，获得受影响的行数
                        con.Close();//关闭数据库
                        if (n > 0)//判断是否执行成功
                        {
                            //成功提示
                            MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            rbtn_male.Enabled = false;//启用男单选按钮
                            rbtn_female.Enabled = false;//启用女单选按钮
                            cmb_college.Enabled = false;//设置学院可编辑
                            text_tel.Enabled = false;//设置手机号可编辑
                            btn_edit.Text = "修改信息";
                        }
                        else
                        {
                            //失败提示
                            MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //执行选中女的sql语句
                        string sql = "update [user] set u_sex='女',c_id='" + cmb_college.SelectedIndex + "',u_tel='" + text_tel.Text.Trim() + "' where u_id='" + u_id + "'";
                        con = dButil.SqlOpen();//打开数据库
                        cmd = new SqlCommand(sql, con);//执行sql语句
                        int n = cmd.ExecuteNonQuery();//获得受影响的行数
                        con.Close();//关闭数据库
                        if (n > 0)//判断是否执行成功
                        {
                            //成功提示
                            MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            rbtn_male.Enabled = false;//启用男单选按钮
                            rbtn_female.Enabled = false;//启用女单选按钮
                            cmb_college.Enabled = false;//设置学院可编辑
                            text_tel.Enabled = false;//设置手机号可编辑
                            btn_edit.Text = "修改信息";
                        }
                        else
                        {
                            //失败提示
                            MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        //返回按钮的单击事件，一个按钮，2种操作判断
        private void btn_no_Click(object sender, EventArgs e)
        {
            if (btn_edit.Text == "修改信息")//执行关闭窗体
            {
                this.Close();//关闭窗体
            }
            else//如果按钮的字变成了确认修改，则执行以下操作
            {
                if (sex == "男")
                {
                    rbtn_male.Checked = true;//选中男
                }
                else
                {
                    rbtn_female.Checked = true;//选中女
                }

                cmb_college.SelectedIndex = college;//获得未修改的索引值

                text_tel.Text = tel;//取出储存在字符串中的值显示在文本框中

                rbtn_male.Enabled = false;//不启用男单选按钮
                rbtn_female.Enabled = false;//不启用女单选按钮
                cmb_college.Enabled = false;//设置学不可编辑
                text_tel.Enabled = false;//设置手机号不可编辑
                btn_edit.Text = "修改信息";//使修改按钮的文本设置成修改信息
            }
        }

        //手机号的输入事件
        private void text_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }
    }
}
