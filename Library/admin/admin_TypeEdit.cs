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
    public partial class admin_TypeEdit : Form
    {
        public admin_TypeEdit()
        {
            InitializeComponent();
        }


        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        DButil dButil = new DButil();//实例化DButil工具类

        private void admin_TypeEdit_Load(object sender, EventArgs e)
        {
            if (Log.log.user_college == true)
            {
                Text = "更改学院";
            }
            type();//添加下拉列表
        }

        /// <summary>
        /// 判断传递管理的user_college是真还是假
        /// 绑定下拉列表，添加数据库中的学院或类别
        /// 为真添加学院
        /// 为假添加类别
        /// </summary>
        /// <param name="sql_col">数据库语句命名</param>
        /// <param name="college">表名</param>
        /// <param name="c_college">学院</param>
        public void type()
        {
            if (Log.log.user_college == true)
            {
                con = dButil.SqlOpen();
                //初始化，comboBox1绑定客户表
                string sql = "select c_college from [college]";//查询有多少学院
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);//创建sql适配器
                DataSet ds = new DataSet();//创建ds缓存
                sda.Fill(ds);//添加到ds缓存中
                cmb_type.DataSource = ds.Tables[0].DefaultView;//取出数据源填充到列表中'
                cmb_type.DisplayMember = "c_college";//列表中显示的值对应的字段名
                cmb_type.SelectedIndex = 0;
                con.Close();//关闭数据库
            }
            else
            {
                con = dButil.SqlOpen();
                //初始化，comboBox1绑定客户表
                string sqltype = "select t_name from [type]";//查询有多少类别
                SqlDataAdapter sda = new SqlDataAdapter(sqltype, con);//创建sql适配器
                DataSet ds = new DataSet();//创建ds缓存
                sda.Fill(ds);//添加到ds缓存中
                cmb_type.DataSource = ds.Tables[0].DefaultView;//取出数据源填充到列表中
                cmb_type.DisplayMember = "t_name";//列表中显示的值对应的字段名
                cmb_type.SelectedIndex = 0;
                con.Close();//关闭数据库            
            }
        }

        //确认按钮
        private void btn_ok_Click(object sender, EventArgs e)
        {
            con.Close();
            DialogResult dialog = MessageBox.Show("确定将" + cmb_type.Text + "更改为" + text_type.Text.Trim() + "？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                if (Log.log.user_college == true)
                {
                    con = dButil.SqlOpen();
                    string sql = "select c_id from college where c_college='" + cmb_type.Text + "'";
                    cmd = new SqlCommand(sql, con);
                    string c_id = Convert.ToString(cmd.ExecuteScalar());
                    con.Close();
                    sql = "select c_id from college where c_college='" + text_type.Text.Trim() + "'";
                    con = dButil.SqlOpen();
                    cmd = new SqlCommand(sql, con);
                    string c_ids = Convert.ToString(cmd.ExecuteScalar());
                    con.Close();
                    if (c_id == c_ids||!c_ids.Equals (""))
                    {
                        MessageBox.Show("修改的内容已存在，请修改成其他内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sql = "update college set c_college='" + text_type.Text.Trim() + "' where c_college='" + cmb_type.Text + "'";
                        con = dButil.SqlOpen();//打开连接
                        cmd = new SqlCommand(sql, con);//储存语句
                        int n = cmd.ExecuteNonQuery();//执行
                        if (n > 0)
                        {
                            MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            type();
                            text_type.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    con = dButil.SqlOpen();
                    string sql = "select t_id from type where t_name='" + cmb_type.Text + "'";
                    cmd = new SqlCommand(sql, con);
                    string t_id = Convert.ToString(cmd.ExecuteScalar());
                    con.Close();
                    sql = "select t_id from type where t_name='" + text_type.Text.Trim() + "'";
                    con = dButil.SqlOpen();
                    cmd = new SqlCommand(sql, con);
                    string t_ids = Convert.ToString(cmd.ExecuteScalar());
                    con.Close();
                    if (t_id == t_ids||!t_ids.Equals(""))
                    {
                        MessageBox.Show("修改的内容已存在，请修改成其他内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con = dButil.SqlOpen();
                        sql = "update type set t_name='" + text_type.Text.Trim() + "' where t_name='" + cmb_type.Text + "'";
                        cmd = new SqlCommand(sql, con);
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            type();
                            text_type.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        //取消按钮
        private void btn_no_Click(object sender, EventArgs e)
        {
            Close();//关闭当前窗体
        }
    }
}
