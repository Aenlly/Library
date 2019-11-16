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
            {
                Dgv_return.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            }
            con.Close();
        }

        //加载事件
        private void admin_ReturnPage_Load(object sender, EventArgs e)
        {
            //查询表格全部内容
            string sql = "select bo_id,[user].u_name,[books].b_name,[type].t_name,bo_borrow,bo_rtnatl,bo_day,bo_renewday,bo_renew=case bo_renew when 0 then '未续借' else '已续借' end,bo_eme=case bo_eme when 2 then '还书成功' end from borrow,[books],[user],[type] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and books.t_id=[type].t_id and bo_eme=2";
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
                string sql= "select bo_id,[user].u_name,[books].b_name,[type].t_name,bo_borrow,bo_rtnatl,bo_day,bo_renewday,bo_renew=case bo_renew when 0 then '未续借' else '已续借' end,bo_eme=case bo_eme when 2 then '还书成功' end from borrow,[books],[user],[type] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and books.t_id=[type].t_id and bo_eme=2 and u_name like '%" + tsbtn_book.Text.Trim()+"%'";
                databind(sql);
            }
            else if (tscmb_type.Text == "借书时间")
            {
                string sql = "select bo_id,[user].u_name,[books].b_name,[type].t_name,bo_borrow,bo_rtnatl,bo_day,bo_renewday,bo_renew=case bo_renew when 0 then '未续借' else '已续借' end,bo_eme=case bo_eme when 2 then '还书成功' end from borrow,[books],[user],[type] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and books.t_id=[type].t_id and bo_eme=2 and bo_borrow = '" + tsbtn_book.Text.Trim() + "'";
                databind(sql);
            }
            else if (tscmb_type.Text == "还书时间")
            {
                string sql = "select bo_id,[user].u_name,[books].b_name,[type].t_name,bo_borrow,bo_rtnatl,bo_day,bo_renewday,bo_renew=case bo_renew when 0 then '未续借' else '已续借' end,bo_eme=case bo_eme when 2 then '还书成功' end from borrow,[books],[user],[type] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and books.t_id=[type].t_id and bo_eme=2 and bo_rtnatl = '" + tsbtn_book.Text.Trim() + "'";
                databind(sql);
            }
        }

        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            //查询表格全部内容
            string sql = "select bo_id,[user].u_name,[books].b_name,[type].t_name,bo_borrow,bo_rtnatl,bo_day,bo_renewday,bo_renew=case bo_renew when 0 then '未续借' else '已续借' end,bo_eme=case bo_eme when 2 then '还书成功' end from borrow,[books],[user],[type] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and books.t_id=[type].t_id and bo_eme=2";
            databind(sql);//传递sql语句
        }
    }
}
