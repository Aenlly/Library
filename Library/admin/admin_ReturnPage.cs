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
    public partial class admin_ReturnPage : Form
    {
        public admin_ReturnPage()
        {
            InitializeComponent();
        }

        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        SqlDataAdapter sda;//创建数据库适配器对象
        DataSet ds;//创建ds缓存
        DButil dButil = new DButil();//实例化DButil工具类

        //填充表内容的databind方法
        public void databind(string sql)
        {
            Dgv_return.AutoGenerateColumns = false;//不自动生成列，从数据库可能取得很多列，使其不显示在DataGridView中
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();//ds初始化
            sda.Fill(ds);//把查询内容添加到ds中
            bindingSource1.DataSource = ds.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;//连接数据源
            Dgv_return.DataSource = bindingSource1;//导出到dataGridView1中显示并用下列代码对于列名 
            for (int i = 0; i < 10; i++)
                Dgv_return.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            con.Close();
        }

        //加载事件
        private void admin_ReturnPage_Load(object sender, EventArgs e)
        {
            //查询表格全部内容
            string sql = "select * from V_AdminReturn";
            databind(sql);//传递sql语句
            mcd_time.Hide();//日历隐藏
            tscmb_type.SelectedIndex = 0;//让下拉列表的借书人为第一选项并显示
        }

        //输入框的单击事件
        private void tsbtn_book_Click(object sender, EventArgs e)
        {
            if (tscmb_type.Text == "还书时间" || tscmb_type.Text == "借书时间")
            {
                tsbtn_book.ReadOnly = true;//设置为不可输入
                mcd_time.Show();//显示日历控件
            }
            //设置为可输入，日历隐藏，清空文本框
            else {tsbtn_book.ReadOnly = false; mcd_time.Hide();tsbtn_book.Text = ""; }     
        }

        //日历的点击事件
        private void mcd_time_DateChanged(object sender, DateRangeEventArgs e)
        {
            //获得日历的值显示到输入框中
            tsbtn_book.Text = mcd_time.SelectionStart.ToShortDateString();
            mcd_time.Hide();//隐藏日历
        }

        private void tsbtn_return_Click(object sender, EventArgs e)
        {
            if (tscmb_type.Text == "借书人")
            {
                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                dbHelper.Operation("查询借书人：" + tsbtn_book.Text.Trim() +"的记录");//插入操作记录

                string sql= "select * from V_AdminReturn where u_name like '%" + tsbtn_book.Text.Trim()+"%'";
                databind(sql);
            }
            else if (tscmb_type.Text == "借书时间")
            {
                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                dbHelper.Operation("查询借书时间为"+ tsbtn_book.Text.Trim() + "的记录");//插入操作记录

                string sql = "select * from V_AdminReturn where bo_borrow = '" + tsbtn_book.Text.Trim() + "'";
                databind(sql);
            }
            else if (tscmb_type.Text == "还书时间")
            {
                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                dbHelper.Operation("查询还书时间为" + tsbtn_book.Text.Trim() + "的记录");//插入操作记录

                string sql = "select * from V_AdminReturn where bo_rtnatl = '" + tsbtn_book.Text.Trim() + "'";
                databind(sql);
            }
            else
                //提示警告
                MessageBox.Show("请选择查询类别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询全部数据记录");//插入操作记录
            //查询表格全部内容
            string sql = "select * from V_AdminReturn";
            databind(sql);//传递sql语句
        }
    }
}
