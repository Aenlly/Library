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
            string f_btn = Log.log.f_btn;
            string sql = "select * from feedback where f_id='" + Log.log.f_id + "'";
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            text_id.Text = reader["f_id"].ToString();
            text_stm.Text = reader["f_smntime"].ToString();
            text_atm.Text = reader["f_asrtime"].ToString();
            text_title.Text = reader["f_title"].ToString();
            rtb_cnt.Text = reader["f_content"].ToString();
            rtb_rcd.Text = reader["f_asrcontent"].ToString();
            text_solve.Text = reader["f_solve"].ToString();

            if (f_btn == "回复")
            {
                rtb_rcd.TabStop = true;//设置成tab键能获得焦点
                rtb_rcd.ReadOnly = false;
                rtb_rcd.Multiline = false;
                rtb_rcd.Multiline = true;
                btn_no.Visible = true;
                btn_ok.Text = "确认回复";
            }
            else
            {
                rtb_rcd.TabStop = false;//设置成无法为tab键获得焦点
                rtb_rcd.ReadOnly = true;//设置为不可输入
            }
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
                if (rtb_rcd.Text.Trim() == "")
                {
                    MessageBox.Show("请填写回复内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialog= MessageBox.Show("确认回复该内容？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult.OK == dialog)
                    {
                        string sql = "update feedback set f_asrcontent='" + rtb_rcd.Text.Trim() + "',f_asrtime='" + DateTime.Now.ToString() + "' where f_id='" + Log.log.f_id + "'";
                        con = dButil.SqlOpen();
                        cmd = new SqlCommand(sql, con);
                        int n = cmd.ExecuteNonQuery();
                        if (n > 0)
                        {
                            dialog = MessageBox.Show("回复成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (DialogResult.OK == dialog)
                            {
                                this.Close();
                            }
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
