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
    public partial class admin_loginPage : Form
    {
        public admin_loginPage()
        {
            InitializeComponent();
        }

        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        SqlDataAdapter sda;//创建数据库适配器对象
        DataSet ds;//创建ds缓存
        DButil dButil = new DButil();//实例化DButil工具类
        int end = 0;//用来判断结束时间的按钮控件是单击的第几次，为0打开日历，为1关闭日历
        int start = 0;//用来判断开始时间的按钮控件是单击的第几次，为0打开日历，为1关闭日历

        //填充表内容的databind方法
        public void databind(string sql)
        {
            Dgv_login.AutoGenerateColumns = false;//不自动生成列，从数据库可能取得很多列，使其不显示在DataGridView中
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();//ds初始化
            sda.Fill(ds);//把查询内容添加到ds中
            Dgv_login.DataSource = ds.Tables[0];//导出到dataGridView1中显示并用下列代码对于列名
            for (int i = 0; i < 3; i++)
            {
                Dgv_login.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            }
            con.Close();//关闭数据库
        }

        private void admin_loginPage_Load(object sender, EventArgs e)
        {
            //隐藏2个日历控件
            mcd_end.Visible = false;
            mcd_start.Visible = false;
            string sql = "select * from [login]";//查询全部内容的sql语句
            databind(sql);//传递sql语句
        }

        //开始时间的按钮
        private void btn_start_Click(object sender, EventArgs e)
        {
            //判断是第几次单击选择日期按钮，为0则显示日历控件，为1则隐藏日历控件
            if (start == 0){ mcd_start.Show(); start = 1; }
            else { mcd_start.Hide(); start = 0; }
        }

        //开始时间的日历控件单击事件
        private void mcd_start_DateChanged(object sender, DateRangeEventArgs e)
        {
            btn_start.Text = mcd_start.SelectionStart.ToShortDateString();//获取日历控件中的值传递到按钮上显示
            mcd_start.Hide();//选择后隐藏该控件
            start = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //结束时间的日历控件单击事件
        private void mcd_end_DateChanged(object sender, DateRangeEventArgs e)
        {
            btn_end.Text = mcd_end.SelectionStart.ToShortDateString();//获取日历控件中的值传递到按钮上显示
            mcd_start.Hide();//选择后隐藏该控件
            end = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //结束时间的按钮时间
        private void btn_end_Click(object sender, EventArgs e)
        {
            //判断是第几次单击选择日期按钮，为0则显示日期控件，为1则隐藏日期控件
            if (end == 0) { mcd_end.Show(); end = 1; }
            else { mcd_end.Hide(); end = 0; }
        }

        //点击查询按钮
        private void btn_select_Click(object sender, EventArgs e)
        {
            //判断是否选择了日期
            if (!"点击选择".Equals(btn_end.Text) && !"点击选择".Equals(btn_start.Text))
            {
                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                dbHelper.Operation("查询开始时间为:"+ btn_start.Text + "结束时间为:"+ btn_end.Text+"的登录记录");//插入操作记录

                //选择了日期就传递日期的值，然后整合sql语句
                string sql = "select * from [login] where l_time>'" + btn_start.Text + "' and l_time<'" + btn_end.Text + "'";
                databind(sql);//传递sql语句过去然后填充到表格中
            }
            else
            {
                //没选择日期进行提示
                MessageBox.Show("请选择查询时间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        //查询全部按钮，显示全部的登录记录
        private void btn_whole_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询全部的登录记录");//插入操作记录
            string sql = "select * from [login]";
            databind(sql);
        }

        //鼠标移动到日期窗体外时，隐藏日期窗体
        private void mcd_start_MouseLeave(object sender, EventArgs e)
        {
            mcd_start.Hide();//隐藏控件
            start = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //鼠标移动到日期窗体外时，隐藏日期窗体
        private void mcd_end_MouseLeave(object sender, EventArgs e)
        {
            mcd_end.Hide();//隐藏控件
            end = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }
    }
}
