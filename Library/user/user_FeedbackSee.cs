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
    public partial class user_FeedbackSee : Form
    {
        public user_FeedbackSee()
        {
            InitializeComponent();
        }

        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        DButil dButil = new DButil();//实例化DButil工具类

        //窗体加载事件
        private void user_SeeFeedback_Load(object sender, EventArgs e)
        {
            //利用编号查询内容
            string sql = "select * from feedback where f_id='" + Log.log.user_fid + "'";
            con = dButil.SqlOpen();//打开数据库
            cmd = new SqlCommand(sql, con);//执行数据库语句
            SqlDataReader reader = cmd.ExecuteReader();//返回内容
            reader.Read();
            text_id.Text = reader["u_id"].ToString();//获得用户id显示在用户id文本框中
            text_stm.Text = reader["f_smntime"].ToString();//获得提交时间显示在提交时间文本框中
            text_atm.Text = reader["f_asrtime"].ToString();//获得回复时间显示在回复时间文本框中
            text_title.Text = reader["f_title"].ToString();//获得反馈标题显示在反馈标题文本框中
            rtb_cnt.Text = reader["f_content"].ToString();//获得反馈内容显示在反馈内容文本框中
            rtb_rcd.Text = reader["f_asrcontent"].ToString();//获得回复内容显示在回复内容文本框中
            text_solve.Text = reader["f_solve"].ToString();//获得获得是否已回复的值显示在是否已回复文本框中
            con.Close();//关闭数据库
        }

        //确认按钮单击事件
        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }
    }
}
