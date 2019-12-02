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
    public partial class user_FeedbackPage : Form
    {
        public user_FeedbackPage()
        {
            InitializeComponent();
        }

        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        DButil dButil = new DButil();//实例化DButil工具类
        SqlDataAdapter sda;//创建数据库适配器对象
        DataSet ds;//创建ds缓存
        int count = 0;//用来判断开始时间的按钮控件是单击的第几次，为0打开日历，为1关闭日历

        //填充表内容的databind方法
        public void databind(string sql)
        {
            Dgv_fbk.AutoGenerateColumns = false;//不自动生成列，从数据库可能取得很多列，使其不显示在DataGridView中
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();//ds初始化
            sda.Fill(ds);//把查询内容添加到ds中
            bindingSource1.DataSource = ds.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;//连接数据源
            Dgv_fbk.DataSource = bindingSource1;//导出到dataGridView1中显示并用下列代码对于列名
            for (int i = 0; i < 6; i++)
            {
                Dgv_fbk.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            }
            con.Close();//关闭数据库
        }

        //加载窗体
        private void user_FeedbackRecord_Load(object sender, EventArgs e)
        {
            mcd_time.Hide();//隐藏日历控件
            string sql = "select f_id,u_id,f_title,f_smntime,f_asrtime,f_solve from feedback where u_id='"+Log.log.u_id+"'";
            databind(sql);//传递sql语句
        }

        //文本框获取事件
        private void tstext_time_Click(object sender, EventArgs e)
        {
            //判断是第几次单击选择日期按钮，为0则显示日历控件，为1则隐藏日历控件
            if (count == 0) { mcd_time.Show(); count = 1; }
            else { mcd_time.Hide(); count = 0; }
        }

        //鼠标移动到日期窗体外时，隐藏日期窗体
        private void mcd_time_MouseLeave(object sender, EventArgs e)
        {
            mcd_time.Hide();//隐藏日历控件
            count = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //获得日历中的值传递到文本框中
        private void mcd_time_DateChanged(object sender, DateRangeEventArgs e)
        {
            tstext_time.Text = mcd_time.SelectionStart.ToShortDateString();//获取日历控件中的值传递到按钮上显示
            mcd_time.Hide();//选择后隐藏该控件
            count = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //显示未回复按钮事件
        private void tsbtn_no_Click(object sender, EventArgs e)
        {
            //查询未解决的反馈sql语句
            string sql = "select f_id,u_id,f_title,f_smntime,f_asrtime,f_solve from feedback where f_solve='未回复' and u_id='"+Log.log.u_id+"'";
            databind(sql);//传递sql语句
            mcd_time.Hide();//隐藏日历控件
            count = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //显示已回复按钮事件
        private void tsbtn_yes_Click(object sender, EventArgs e)
        {
            //查询未解决的反馈sql语句
            string sql = "select f_id,u_id,f_title,f_smntime,f_asrtime,f_solve from feedback where f_solve='已回复' and u_id='" + Log.log.u_id + "'";
            databind(sql);//传递sql语句
            mcd_time.Hide();//隐藏日历控件
            count = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //显示全部按钮单击事件
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            //查询全部的反馈sql语句
            string sql = "select f_id,u_id,f_title,f_smntime,f_asrtime,f_solve from feedback where u_id='" + Log.log.u_id + "'";
            databind(sql);//传递sql语句
            mcd_time.Hide();//隐藏日历控件
            count = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //单击表格内容时的事件
        private void Dgv_fbk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //判断是否点在了内容行上，而不是表头
            if (e.RowIndex >= 0)
            {
                //获得反馈编号
                string f_id = Dgv_fbk.Rows[e.RowIndex].Cells["Cl_id"].Value.ToString();
                Log.log.user_fid = f_id;//储存在log类中
                //单击了查看按钮
                if (Dgv_fbk.Columns[e.ColumnIndex].Name == "Cl_see")
                {
                    user_FeedbackSee user_FeedbackSee = new user_FeedbackSee();//实例化user_FeedBack窗体对象
                    user_FeedbackSee.ShowDialog();//admin_FeedBack窗体以对话框显示
                }
                //点击了删除按钮
                if (Dgv_fbk.Columns[e.ColumnIndex].Name == "Cl_del")
                {
                    //弹出询问对话框，获得用户的按的按钮
                    DialogResult dialog=MessageBox.Show("确认删除反馈编号：" + f_id + "的记录？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)//点击了确认按钮
                    {
                        string sql = "delete feedback where f_id='" + f_id + "'";//创建sql删除语句
                        con = dButil.SqlOpen();//打开数据库
                        cmd = new SqlCommand(sql, con);//储存sql语句
                        int n = cmd.ExecuteNonQuery();//执行sql语句，获得执行sql语句受影响的行数赋值到n中
                        if (n > 0)//判断是否成功
                        {
                            //成功提示
                            MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //重新加载，刷新
                            sql = "select f_id,u_id,f_title,f_smntime,f_asrtime,f_solve from feedback where u_id='" + Log.log.u_id + "'";
                            databind(sql);//传递sql语句
                        }
                        else
                        {
                            //失败提示
                            MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        //查询按钮单击事件
        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            //查询时间的反馈记录sql语句
            string sql = "select f_id,u_id,f_title,f_smntime,f_asrtime,f_solve from feedback where u_id='" + Log.log.u_id + "' and f_smntime='" + tstext_time.Text + "'";
            databind(sql);//传递sql
            mcd_time.Hide();//隐藏日历控件
            count = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //单击进行反馈按钮事件
        private void ts_fbr_Click(object sender, EventArgs e)
        {
            user_Feedback user_feedback = new user_Feedback();//实例化user_FeedBack窗体对象
            user_feedback.ShowDialog();//admin_FeedBack窗体以对话框显示
            string sql = "select f_id,u_id,f_title,f_smntime,f_asrtime,f_solve from feedback where u_id='" + Log.log.u_id + "'";
            databind(sql);//传递sql语句，相当于刷新表的内容
        }
    }
}
