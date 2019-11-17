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
        DataSet ds;//创建ds缓存
        DButil dButil = new DButil();//实例化DButil工具类
        //填充表内容的databind方法
        public void databind(string sql, object sender, EventArgs e)
        {
            Dgv_SeeBook.AutoGenerateColumns = false;//不自动生成列，从数据库可能取得很多列，使其不显示在DataGridView中
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds, "Book");//把查询内容添加到ds中，区别type类别换成
            bindingSource1.DataSource = ds.Tables["Book"];
            BindNavig.BindingSource = bindingSource1;
            Dgv_SeeBook.DataSource = bindingSource1;
            for (int i = 0; i < 8; i++)
            {
                Dgv_SeeBook.Columns[i].DataPropertyName = ds.Tables["Book"].Columns[i].ColumnName;
            }

            con.Close();
        }

        /// <summary>
        /// 绑定ToolStripComboBox 的操作
        /// </summary>
        /// <param name="sqltype">数据库语句</param>
        /// <param name="type">表名</param>
        /// <param name="t_name">字段名</param>
        public void BookType()
        {
            con = dButil.SqlOpen();
            //初始化，comboBox1绑定客户表
            string sqltype = "select t_name from [type]";//查询有多少类别
            sda = new SqlDataAdapter(sqltype, con);
            ds = new DataSet();
            sda.Fill(ds, "type");//添加到ds缓存中
            tscmb_type.ComboBox.DataSource = ds.Tables["type"].DefaultView;//取出数据源填充到列表中
            tscmb_type.ComboBox.DisplayMember = "t_name";//列表中显示的值对应的字段名
        }

        //加载窗体时的事件
        private void user_SeeBookPage_Load(object sender, EventArgs e)
        {
            string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
            databind(sql, sender, e);//填充到表格控件中
            BookType();//填充到类型下拉列表中
        }


        //查询按钮
        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            if ("".Equals(tstext_book.Text.Trim()))
            {
                string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
                databind(sql, sender, e);//填充到表格控件中
            }
            else
            {
                if (tscmb_type.SelectedIndex != 0)//判断是否选中了全部类别
                {
                    con = dButil.SqlOpen();//打开数据库
                    //查询输入框中的值，以及按类别联合查找
                    string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 and [book].b_name='" + tstext_book.Text.Trim() + "' union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 and [book].b_name like '%" + tstext_book.Text.Trim() + "%'";
                    databind(sql, sender, e);
                }
                else
                {
                    con = dButil.SqlOpen();//打开数据库
                    //查询输入框中的值，以及按类别联合查找
                    string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 and [book].b_name='" + tstext_book.Text.Trim() + "' union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 and [book].b_name like '%" + tstext_book.Text.Trim() + "%' and t_name='" + tscmb_type.Text + "'";
                    databind(sql, sender, e);
                }
            }
        }

        //查询全部按钮
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
            databind(sql, sender, e);//填充到表格控件中
        }

        //借书按钮
        private void tsbtn_borrow_Click(object sender, EventArgs e)
        {

        }

        //获取图书名称的值
        private void dGv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex用来定位到表中的一行
            if (e.RowIndex >= 0)
            {
                string b_name = Dgv_SeeBook.Rows[e.RowIndex].Cells["b_name"].Value.ToString(); //获取图书名称的值
                //判断是否点击了借书按钮
                if (Dgv_SeeBook.Columns[e.ColumnIndex].Name == "Cl_borrow")
                {
                    //打开数据库
                    con = dButil.SqlOpen();
                    //sql查询语句
                    string sql = "select [borrow].b_id from [borrow],[books] where [borrow].b_id=[books].b_id and bo_eme=0 and [books].b_name='" + b_name + "'";
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
        }

        //查询类别下拉列表框内容改变时
        private void tscmb_type_DropDownClosed(object sender, EventArgs e)
        {
            if (tscmb_type.SelectedIndex != 0)//判断是否选中了全部类别
            {
                //查询全部
                string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
                databind(sql, sender, e);//填充到表格控件中
            }
            else
            {
                //查询单独一个类型
                string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 and t_name like '%" + tscmb_type.Text + "%' union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 and t_name like '%" + tscmb_type.Text + "%'";
                databind(sql, sender, e);//填充到表格控件中
            }
        }
    }
}
