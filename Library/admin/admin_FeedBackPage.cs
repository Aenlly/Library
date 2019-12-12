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
    public partial class admin_FeedBackPage : Form
    {
        public admin_FeedBackPage()
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
        private void admin_FeedBackPage_Load(object sender, EventArgs e)
        {
            mcd_time.Hide();//隐藏日历控件
            string sql = "select f_id,[user].u_id,f_title,f_smntime,f_asrtime,f_solve from feedback,[user] where feedback.u_id=[user].u_id";
            databind(sql);//传递sql
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
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询未回复的反馈记录");//插入操作记录

            //查询未解决的反馈sql语句
            string sql = "select f_id,[user].u_id,f_title,f_smntime,f_asrtime,f_solve from feedback,[user] where feedback.u_id=[user].u_id and f_solve='未回复'";
            databind(sql);//传递sql
            mcd_time.Hide();//隐藏日历控件
            count = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //显示已回复按钮事件
        private void tsbtn_yes_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询已回复的反馈记录");//插入操作记录

            //查询未解决的反馈sql语句
            string sql = "select f_id,[user].u_id,f_title,f_smntime,f_asrtime,f_solve from feedback,[user] where feedback.u_id=[user].u_id and f_solve='已回复'";
            databind(sql);//传递sql
            mcd_time.Hide();//隐藏日历控件
            count = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //显示全部按钮单击事件
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询全部的反馈记录");//插入操作记录

            //查询全部的反馈sql语句
            string sql = "select f_id,[user].u_id,f_title,f_smntime,f_asrtime,f_solve from feedback,[user] where feedback.u_id=[user].u_id";
            databind(sql);//传递sql
            mcd_time.Hide();//隐藏日历控件
            count = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //单击表格内容时的事件
        private void Dgv_fbk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                //判断是否点在了内容行上，而不是表头
                if (e.RowIndex >= 0)
                {
                    Log.log.f_id = Dgv_fbk.Rows[e.RowIndex].Cells["Cl_id"].Value.ToString();
                    //单击了查看按钮
                    if (Dgv_fbk.Columns[e.ColumnIndex].Name == "Cl_see")
                    {
                        Log.log.f_btn = "查看";//使f_btn值修改为查看
                        admin_FeedBack admin_Feed = new admin_FeedBack();//实例化admin_FeedBack窗体对象
                        admin_Feed.ShowDialog();//admin_FeedBack窗体以对话框显示

                        SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                        dbHelper.Operation("查看反馈编号为" + Log.log.f_id + "的反馈记录");//插入操作记录
                    }
                    //单击了回复按钮
                    if (Dgv_fbk.Columns[e.ColumnIndex].Name == "Cl_Reply")
                    {
                        if (Dgv_fbk.Rows[e.RowIndex].Cells["Cl_asrtime"].Value.ToString() != "")
                        {
                            DialogResult dialog = MessageBox.Show("该用户已经回复过了！点击确定转到查看界面", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (DialogResult.OK == dialog)
                            {
                                Log.log.f_btn = "查看";//使f_btn值修改为查看
                                admin_FeedBack admin_Feed = new admin_FeedBack();//实例化admin_FeedBack窗体对象
                                admin_Feed.ShowDialog();//admin_FeedBack窗体以对话框显示

                                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                dbHelper.Operation("查看反馈编号为" + Log.log.f_id + "的反馈记录");//插入操作记录
                            }
                        }
                        else
                        {
                            Log.log.f_btn = "回复";//使f_btn值修改为回复
                            admin_FeedBack admin_Feed = new admin_FeedBack();//实例化admin_FeedBack窗体对象
                            admin_Feed.ShowDialog();//admin_FeedBack窗体以对话框显示
                                                    //查询全部的反馈sql语句
                            string sql = "select f_id,[user].u_id,f_title,f_smntime,f_asrtime,f_solve from feedback,[user] where feedback.u_id=[user].u_id";
                            databind(sql);//传递sql
                        }
                    }
                }
            }
        }

        //查询按钮单击事件
        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            if (tstext_time.Text == "")//判断是否选择了查询时间
            {
                //进行警告
                MessageBox.Show("请选择查询时间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                dbHelper.Operation("查询提交时间为："+ tstext_time .Text+ "的反馈记录");//插入操作记录

                //查询时间的反馈记录sql语句
                string sql = "select f_id,[user].u_id,f_title,f_smntime,f_asrtime,f_solve from feedback,[user] where feedback.u_id=[user].u_id and f_smntime='" + tstext_time.Text + "'";
                databind(sql);//传递sql
                mcd_time.Hide();//隐藏日历控件
                count = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
            }
        }
    }
}
