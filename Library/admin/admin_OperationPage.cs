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
    public partial class admin_OperationPage : Form
    {
        public admin_OperationPage()
        {
            InitializeComponent();
        }

        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        SqlDataAdapter sda;//创建数据库适配器对象
        DataSet ds;//创建ds缓存
        DButil dButil = new DButil();//实例化DButil工具类
        int btn = 0;////用来判断选时间按钮控件是单击的第几次，为0打开日历，为1关闭日历
        //填充表内容的databind方法
        public void databind(string sql)
        {
            Dgv_ort.AutoGenerateColumns = false;//不自动生成列，从数据库可能取得很多列，使其不显示在DataGridView中
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();//ds初始化
            sda.Fill(ds);//把查询内容添加到ds中
            Dgv_ort.DataSource = ds.Tables[0];//导出到dataGridView1中显示并用下列代码对于列名   
            for(int i = 0; i < 4; i++)
            {
                Dgv_ort.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            }          
            con.Close();//关闭数据库
        }

        //开始日期日历控件的单击事件
        private void mcd_time_DateChanged(object sender, DateRangeEventArgs e)
        {
            btn_time.Text = mcd_time.SelectionStart.ToShortDateString();//获得选中的时间传递到选择按钮上
            mcd_time.Hide();//隐藏日历
            btn = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //结束日期日历控件的单击事件
        private void mcd_end_DateChanged(object sender, DateRangeEventArgs e)
        {
            btn_end.Text = mcd_end.SelectionStart.ToShortDateString();//获得选中的时间传递到选择按钮上
            mcd_end.Hide();//隐藏日历
            btn = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //窗体加载
        private void admin_OperationPage_Load(object sender, EventArgs e)
        {
            String sql = "select * from V_Operation";//查询全部操作的sql语句
            mcd_time.Hide();//隐藏日历
            mcd_end.Hide();//隐藏日历
            databind(sql);//传递sql语句
        }

        //点击查询按钮事件
        private void btn_select_Click(object sender, EventArgs e)
        {
            if (btn_time.Text == "选择时间"|| btn_end.Text == "选择时间")
            {
                //提示警告
                MessageBox.Show("请选择查询时间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else
            {
                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                dbHelper.Operation("查询开始时间：" + btn_time.Text + "，结束时间："+btn_end.Text+"的操作记录");//插入操作记录

                //sql语句按时间查询
                string sql = "select * from V_Operation where o_time>'" + btn_time.Text + "' and o_time<'"+btn_end.Text+"'";
                databind(sql);//传递sql参数
            }
        }

        //点击开始时间事件
        private void btn_time_Click(object sender, EventArgs e)
        {
            //为0显示日历控件，否则隐藏日历控件
            if (btn == 0) { mcd_time.Show(); btn = 1; }
            else { mcd_time.Hide(); btn = 0; }
         }
        
        //点击结束时间事件
        private void btn_end_Click(object sender, EventArgs e)
        {
            //为0显示日历控件，否则隐藏日历控件
            if (btn == 0) { mcd_end.Show(); btn = 1; }
            else { mcd_end.Hide(); btn = 0; }
        }

        //显示全部按钮事件
        private void btn_whole_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询全部的操作记录");//插入操作记录

            string sql= "select * from V_Operation";//查询全部操作的sql语句
            databind(sql);//传递sql语句
        }

        //鼠标移出日历控件范围时的时间
        private void mcd_time_MouseLeave(object sender, EventArgs e)
        {
            mcd_time.Hide(); btn = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }
    }
}
