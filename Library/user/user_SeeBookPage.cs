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
    public partial class user_SeeBookPage : Form
    {
        public user_SeeBookPage()
        {
            InitializeComponent();
        }
        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        SqlDataAdapter sda;//创建数据库适配器对象
        SqlCommandBuilder scb;//创建数据库表对象
        DataSet ds=new DataSet();
        DButil dButil = new DButil();
        private bool OkClick = false;
        private string value_book;
        //填充表内容的databind方法
        public void databind(string sql,object sender, EventArgs e)
        {
            dGv.AutoGenerateColumns = false;//不自动生成列，从数据库可能取得很多列，使其不显示在DataGridView中
            con=dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            scb = new SqlCommandBuilder(sda);
            sda.Fill(ds);//把查询内容添加到ds中
            BindSoure.DataSource = ds.Tables[0];//获得ds内储存的值
            dGv.DataSource = BindSoure;//导出到dataGridView1中显示并用下列代码对于列名     
            dGv.Columns[0].DataPropertyName = ds.Tables[0].Columns[0].ColumnName;
            dGv.Columns[1].DataPropertyName = ds.Tables[0].Columns[1].ColumnName;
            dGv.Columns[2].DataPropertyName = ds.Tables[0].Columns[2].ColumnName;
            dGv.Columns[3].DataPropertyName = ds.Tables[0].Columns[3].ColumnName;
            dGv.Columns[4].DataPropertyName = ds.Tables[0].Columns[4].ColumnName;
            dGv.Columns[5].DataPropertyName = ds.Tables[0].Columns[5].ColumnName;
            dGv.Columns[6].DataPropertyName = ds.Tables[0].Columns[6].ColumnName;
            dGv.Columns[7].DataPropertyName = ds.Tables[0].Columns[7].ColumnName;
            con.Close();
        }

        /// <summary>
        /// 绑定ToolStripComboBox 的操作
        /// </summary>
        /// <param name="sqltype">数据库语句</param>
        /// <param name="type">表名</param>
        /// <param name="t_name">字段名</param>
        public void BookType(){
            con = dButil.SqlOpen();
            //初始化，comboBox1绑定客户表
            string sqltype = "select t_name from [type]";//查询有多少类别
            sda = new SqlDataAdapter(sqltype, con);
            sda.Fill(ds);//添加到ds缓存中
            tscmb_type.ComboBox.DataSource = ds.Tables[0].DefaultView;//取出数据源填充到列表中
            tscmb_type.ComboBox.DisplayMember = "t_name";//列表中显示的值对应的字段名
        }

        //加载窗体时的事件
        private void user_SeeBookPage_Load(object sender, EventArgs e)
        {
            //查询全部的sql语句
            string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
            databind(sql, sender,e);//填充到表格控件中
            BookType();//填充到类型下拉列表中
        }

        //查询类别下拉列表框内容改变时
        private void tscmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            OkClick = true;
            if (OkClick==true) {
                //查询单独一个类型
                string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 and t_name='" + tscmb_type.Text + "' union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 and t_name='" + tscmb_type.Text + "'";
                databind(sql, sender, e);//填充到表格控件中
            }
            else
            {
                //查询全部
                string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
                databind(sql, sender, e);//填充到表格控件中
            }
        }

        //查询按钮
        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            //查询输入框中的值，以及按类型联合查找
            string sql = "select book.b_isbn,b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 and b_name='" + tstext_book.Text.Trim() + "' union select book.b_isbn,b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 and b_name='" + tstext_book.Text.Trim() + "' and t_name='"+tscmb_type.Text+"'";
            databind(sql, sender, e);//填充到表格控件中
        }

        //查询全部按钮
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
            databind(sql, sender, e);
        }

        //借书按钮
        private void tsbtn_borrow_Click(object sender, EventArgs e)
        {
            if ("".Equals(tstext_bookname.Text))
            {
                MessageBox.Show("请选择所借图书！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                //打开数据库
                con = dButil.SqlOpen();
                //sql查询语句
                string sql = "select [borrow].b_id from [borrow],[books] where [borrow].b_id=[books].b_id and bo_eme=0 and [books].b_name='" + tstext_bookname.Text.Trim() +"'";
                cmd = new SqlCommand(sql, con);//执行查询语句
                if ("".Equals(cmd.ExecuteScalar().ToString()))//返回cmd查询的第一行第一列是否有值，进行对比
                {
                    //写弹出借书窗体的事件
                }
                else
                {
                    //提示已经借过一本书了
                    MessageBox.Show("你已经借了一本相同的书了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                con.Close();
            }
        }

        //获取图书名称的值
        private void dGv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //定义应该参数rowindx，用来定位到表中的一行
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                value_book = dGv.Rows[rowindex].Cells["b_name"].Value.ToString(); //获取图书名称的值
                tstext_bookname.Text = value_book;
            }
            else { }
        }
    }
}
