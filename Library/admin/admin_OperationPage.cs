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
            Dgv_ort.Columns[0].DataPropertyName = ds.Tables[0].Columns[0].ColumnName;
            Dgv_ort.Columns[1].DataPropertyName = ds.Tables[0].Columns[1].ColumnName;
            Dgv_ort.Columns[2].DataPropertyName = ds.Tables[0].Columns[2].ColumnName;
            con.Close();//关闭数据库
        }

        //日历控件的单击事件
        private void mcd_time_DateChanged(object sender, DateRangeEventArgs e)
        {
            btn_time.Text = mcd_time.SelectionStart.ToShortDateString();//获得选中的时间传递到选择按钮上
            mcd_time.Hide();//隐藏日历
            btn = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }

        //窗体加载
        private void admin_OperationPage_Load(object sender, EventArgs e)
        {
            String sql = "select * from operation";//查询全部操作的sql语句
            mcd_time.Hide();//隐藏日历
            databind(sql);//传递sql语句
        }

        //点击查询按钮事件
        private void btn_select_Click(object sender, EventArgs e)
        {
            //sql语句按时间查询
            string sql = "select * from operation where o_time='" + btn_time.Text + "'";
            databind(sql);//传递sql参数
        }

        //点击选择时间事件
        private void btn_time_Click(object sender, EventArgs e)
        {
            //为0显示日历控件，否则隐藏日历控件
            if (btn == 0) { mcd_time.Show(); btn = 1; }
            else { mcd_time.Hide(); btn = 0; }
         }

        //显示全部按钮事件
        private void btn_whole_Click(object sender, EventArgs e)
        {
            string sql= "select * from operation";//查询全部操作的sql语句
            databind(sql);//传递sql语句
        }

        //鼠标移出日历控件范围时的时间
        private void mcd_time_MouseLeave(object sender, EventArgs e)
        {
            mcd_time.Hide(); btn = 0;//隐藏后把判断单击几次的设置为0，防止要点击2次
        }
    }
}
