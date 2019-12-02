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
    public partial class user_Feedback : Form
    {
        public user_Feedback()
        {
            InitializeComponent();
        }

        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        DButil dButil = new DButil();//实例化DButil工具类

        private void user_Feedback_Load(object sender, EventArgs e)
        {
            text_id.Text = Log.log.u_id;//获得反馈人的编号，显示在用户id文本框中
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //判断反馈标题是否为空
            if (text_title.Text.Trim() == "")
            {
                //反馈标题为空弹窗提示，警告
                MessageBox.Show("反馈标题不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (text_conent.Text.Trim() == "")
            {
                //反馈内容为空弹窗提示，警告
                MessageBox.Show("反馈内容不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //弹窗进行用户二次确认
                DialogResult dialog=MessageBox.Show("确认进行该反馈提交？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == dialog)//判断是否点击了确认按钮
                {
                    //sql插入语句
                    string sql = "insert into feedback(u_id,f_title,f_content,f_smntime) values ('" + text_id.Text + "','" + text_title.Text.Trim() + "','" + text_conent.Text.Trim() + "',getdate())";
                    con = dButil.SqlOpen();//打开数据库
                    cmd = new SqlCommand(sql, con);//储存sql语句
                    int n = cmd.ExecuteNonQuery();//执行sql语句,返回受影响的行数赋值到n中
                    if (n > 0)//判断n是否大于0，大于0则成功
                    {
                        //成功提交提示
                        dialog=MessageBox.Show("提交反馈成功！点击确认按钮返回反馈记录窗口", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dialog == DialogResult.OK)
                        {
                            Close();//关闭当前窗体
                        }
                    }
                    else
                    {
                        //提交失败提示
                        MessageBox.Show("提交反馈失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
