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
    public partial class admin_BookPage : Form
    {
        public admin_BookPage()
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
            Dgv_adminBook.AutoGenerateColumns = false;//不自动生成列，从数据库可能取得很多列，使其不显示在DataGridView中
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();//ds初始化
            sda.Fill(ds);//把查询内容添加到ds中
            bindingSource1.DataSource = ds.Tables[0];
            bindNavig.BindingSource = bindingSource1;//连接数据源
            Dgv_adminBook.DataSource = bindingSource1;//导出到dataGridView1中显示并用下列代码对于列名  
            for (int i = 0; i < 8; i++)//循环填充到表中
            {
                Dgv_adminBook.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            }
            con.Close();
        }

        //窗体加载事件
        private void admin_BookPage_Load(object sender, EventArgs e)
        {
            string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
            databind(sql);//传递sql然后查询填充
        }

        //单击了表格内的列和行事件
        private void Dgv_adminBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //判断是否点击了表的内容而不是列标签
            if (e.RowIndex >= 0)
            {
                //判断是否点击了编辑按钮
                if (Dgv_adminBook.Columns[e.ColumnIndex].Name == "Cl_edit")
                {
                    admin_BookEdit admin_BookEdit = new admin_BookEdit();//实例化编辑界面

                    //把选中列的各个值传递到log类中
                    Log.log.b_isbn = Dgv_adminBook.Rows[e.RowIndex].Cells["b_isbn"].Value.ToString();
                    Log.log.b_name = Dgv_adminBook.Rows[e.RowIndex].Cells["b_name"].Value.ToString();
                    Log.log.b_type = Dgv_adminBook.Rows[e.RowIndex].Cells["t_name"].Value.ToString();
                    Log.log.b_author = Dgv_adminBook.Rows[e.RowIndex].Cells["b_author"].Value.ToString();
                    Log.log.b_press = Dgv_adminBook.Rows[e.RowIndex].Cells["b_press"].Value.ToString();
                    Log.log.b_time = Dgv_adminBook.Rows[e.RowIndex].Cells["b_time"].Value.ToString();
                    Log.log.b_price = Dgv_adminBook.Rows[e.RowIndex].Cells["b_price"].Value.ToString();
                    Log.log.b_stocks = Dgv_adminBook.Rows[e.RowIndex].Cells["b_stocks"].Value.ToString();


                    admin_BookEdit.ShowDialog();//显示编辑界面
                                                //查询全部的sql语句,实现刷新
                    string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
                    databind(sql);//传递sql然后查询填充
                }
                //单击了删除按钮
                if (Dgv_adminBook.Columns[e.ColumnIndex].Name == "Cl_delete")
                {
                    //弹窗提示
                    string book_name = Dgv_adminBook.Rows[e.RowIndex].Cells["b_name"].Value.ToString();
                    DialogResult dialog = MessageBox.Show("确认删除图书" + book_name + "?  该操作会将借书记录一同删除并无法还原！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)//点击了确定，执行删除语句
                    {
                        string sqlbo_select = "select * from [borrow],[books] where [borrow].b_id=[books].b_id and bo_eme!=2 and b_name='" + book_name + "'";
                        con = dButil.SqlOpen();
                        cmd = new SqlCommand(sqlbo_select, con);
                        int n = cmd.ExecuteNonQuery();
                        if (n == 0)
                        {
                            MessageBox.Show("有用户未还书，无法删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string strbor_del = "delete from [borrow] where  b_isbn='(select b_isbn from [book] where b_name='" + book_name + "'";
                            string strb_del = "delete from [books] where b_name='" + book_name + "'";
                            string strbs_del = "delete from [book] where b_name='" + book_name + "'";
                            con = dButil.SqlOpen();
                            cmd = new SqlCommand(strbor_del, con);//先删除借书表中的记录
                            cmd = new SqlCommand(strb_del, con);//再删除图书表中的记录
                            cmd = new SqlCommand(strbs_del, con);//最后删除isbn表中的记录
                            n = cmd.ExecuteNonQuery();
                            con.Close();
                            if (n > 0)
                            {
                                MessageBox.Show("删除图书:" + book_name + "成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //查询全部的sql语句,实现刷新
                                string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
                                databind(sql);//传递sql然后查询填充
                            }
                            else
                            {
                                MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }

        //查询按钮事件
        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            //判断是否输入了值，没有则查询全部
            if (tstext_book.Text.Trim() == "")
            {
                string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 and [book].b_name like '%" + tstext_book.Text.Trim() + "%' union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 and [book].b_name like '%" + tstext_book.Text.Trim() + "%'";
                databind(sql);
            }
            else
            {
                string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
                databind(sql);//传递sql然后查询填充
            }
        }

        //显示全部按钮事件
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
            databind(sql);//传递sql然后查询填充
        }

        //添加图书按钮事件
        private void tsbtn_bookadd_Click(object sender, EventArgs e)
        {
            admin_BookAdd admin_BookAdd = new admin_BookAdd();//实例化admin_BookAdd窗体
            admin_BookAdd.ShowDialog();//以对话框模式显示
            string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1 union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id  and b_lend=1";
            databind(sql);//传递sql然后查询填充
        }

        //添加新类别按钮事件
        private void tsbtn_type_Click(object sender, EventArgs e)
        {
            admin_BookType bookType = new admin_BookType();
            bookType.ShowDialog();
        }
    }
}
