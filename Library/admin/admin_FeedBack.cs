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
    public partial class admin_FeedBack : Form
    {
        public admin_FeedBack()
        {
            InitializeComponent();
        }

        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        DButil dButil = new DButil();//实例化DButil工具类

        private void admin_FeedBack_Load(object sender, EventArgs e)
        {
            string f_btn = Log.log.f_btn;//获得储存在log类中的反馈编号
            string sql = "select * from feedback where f_id='" + Log.log.f_id + "'";//利用编号查询内容
            con = dButil.SqlOpen();//打开数据库
            cmd = new SqlCommand(sql, con);//执行数据库语句
            SqlDataReader reader = cmd.ExecuteReader();//返回内容
            reader.Read();
            text_id.Text = reader["f_id"].ToString();//获得用户id显示在用户id文本框中
            text_stm.Text = reader["f_smntime"].ToString();//获得提交时间显示在提交时间文本框中
            text_atm.Text = reader["f_asrtime"].ToString();//获得回复时间显示在回复时间文本框中
            text_title.Text = reader["f_title"].ToString();//获得反馈标题显示在反馈标题文本框中
            rtb_cnt.Text = reader["f_content"].ToString();//获得反馈内容显示在反馈内容文本框中
            rtb_rcd.Text = reader["f_asrcontent"].ToString();//获得回复内容显示在回复内容文本框中
            text_solve.Text = reader["f_solve"].ToString();//获得获得是否已回复的值显示在是否已回复文本框中

            if (f_btn == "回复")
            {
                rtb_rcd.TabStop = true;//设置成tab键能获得焦点
                rtb_rcd.ReadOnly = false;//设置成可输入
                rtb_rcd.Multiline = false;//这个与下个配合刷新该控件的样式
                rtb_rcd.Multiline = true;//这个与上个配合刷新该控件的样式
                btn_no.Visible = true;//返回按钮设置为显示
                btn_ok.Text = "确认回复";//设置确认按钮的文本为确认回复
            }
            else
            {
                rtb_rcd.TabStop = false;//设置成无法为tab键获得焦点
                rtb_rcd.ReadOnly = true;//设置为不可输入
            }
            con.Close();//关闭数据库
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //判断回复文本框是否能编辑
            if (btn_ok.Text == "确定")
            {
                Close();//关闭该窗体
            }
            else
            {
                if (rtb_rcd.Text.Trim() == "")//回复内容为空判断
                {
                    //回复内容为空提示
                    MessageBox.Show("请填写回复内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //获得回复对话框的返回值
                    DialogResult dialog= MessageBox.Show("确认回复该内容？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult.OK == dialog)//的判断是否点击了确认
                    {
                        //sql更新语句
                        string sql = "update feedback set f_asrcontent='" + rtb_rcd.Text.Trim() + "',f_asrtime='" + DateTime.Now.ToString() + "',f_solve='已回复' where f_id='" + Log.log.f_id + "'";
                        con = dButil.SqlOpen();//打开数据库
                        cmd = new SqlCommand(sql, con);//执行sql语句
                        int n = cmd.ExecuteNonQuery();//返回受影响行数并赋值到int中用于判断
                        if (n > 0)//判断是否成功
                        {
                            //成功提示
                            dialog = MessageBox.Show("回复成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (DialogResult.OK == dialog)
                            {
                                this.Close();//关闭窗体
                            }
                        }
                        else
                        {
                            MessageBox.Show("回复失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
