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
    public partial class user_Return : Form
    {
        public user_Return()
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
            cmd = new SqlCommand(sql, con);//储存sql语句
            sda = new SqlDataAdapter(cmd);//创建sql适配器
            ds = new DataSet();//ds初始化
            sda.Fill(ds);//把查询内容添加到ds中
            bindingSource1.DataSource= ds.Tables[0];//封装数据
            bindingNavigator1.BindingSource = bindingSource1;//获得数据
            Dgv_return.DataSource = bindingSource1;//导出到dataGridView1中显示并用下列代码对于列名 
            for(int i = 0; i < 9; i++)//循环取值
            {
                Dgv_return.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            }
            con.Close();//关闭数据库
        }

        //窗体初始化加载事件
        private void user_Return_Load(object sender, EventArgs e)
        {
            //查询全部的sql语句
            string sql = "select * from V_Return where u_id='"+Log.log.u_id+"'";
            databind(sql);//传递sql语句过去，并填充数据到表格中
        }

        //还书记录窗体查询按钮
        private void tsbtn_return_Click(object sender, EventArgs e)
        {
            if ("".Equals(tsbtn_book.Text.Trim()))
            {
                //为空时显示全部
                string sql = "select * from V_Return where u_id='" + Log.log.u_id + "'";
                databind(sql);//传递sql语句过去，并填充数据到表格中
            }
            else
            {
                //否则查询输入的内容
                string sql = "select * from V_Return where u_id='" + Log.log.u_id + "' and [books].b_name like '%" + tsbtn_book.Text.Trim() + "%'";
                databind(sql);//传递sql语句过去，并填充数据到表格中
            }
        }

        //显示全部按钮查询事件
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            //查询sql语句
            string sql = "select * from V_Return where u_id='" + Log.log.u_id + "'";
            databind(sql);//传递sql语句过去，并填充数据到表格中
        }
    }
}
