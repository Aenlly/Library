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
    public partial class admin_BookType : Form
    {
        public admin_BookType()
        {
            InitializeComponent();
        }

        //添加按钮事件
        private void btn_type_Click(object sender, EventArgs e)
        {
            SqlConnection con;//创建数据库连接对象
            SqlCommand cmd;//创建sql执行对象
            DButil dButil = new DButil();
            con = dButil.SqlOpen();//打开数据库
            string sql = "select t_name from type where t_name='" + text_type.Text.Trim() + "'";
            cmd = new SqlCommand(sql, con);//执行sql语句
            string name = Convert.ToString(cmd.ExecuteScalar());//获得是否存在内容
            con.Close();//关闭数据库
            if (text_type.Text.Trim() == "")//判断是否输入了类别
            {
                MessageBox.Show("类别不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (name != "")//判断是否存在该类别
            {
                //存在提示
                MessageBox.Show("已存在该类别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con = dButil.SqlOpen();//打开数据库
                //sql插入语句
                sql = "insert into type(t_name) values ('" + text_type.Text.Trim() + "')";
                cmd = new SqlCommand(sql, con);//执行sql语句
                int n = cmd.ExecuteNonQuery();//返回影响行
                con.Close();//关闭数据库
                if (n > 0)
                {
                    SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                    dbHelper.Operation("添加新图书类别："+ text_type.Text.Trim());//插入操作记录
                    //成功提示
                    MessageBox.Show("添加类别:" + text_type.Text.Trim() + "成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //失败提示
                    MessageBox.Show("添加类别失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
