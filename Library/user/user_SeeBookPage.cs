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
        public void databind(string sql)
        {
            Dgv_SeeBook.AutoGenerateColumns = false;//不自动生成列，从数据库可能取得很多列，使其不显示在DataGridView中
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);//储存sql语句
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

            con.Close();//关闭数据库
        }

        //加载窗体时的事件
        private void user_SeeBookPage_Load(object sender, EventArgs e)
        {
            string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id";
            databind(sql);//填充到表格控件中
        }


        //查询按钮
        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            if ("".Equals(tstext_book.Text.Trim()))
            {
                string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id";
                databind(sql);//填充到表格控件中
            }
            else
            {
                //查询输入框中的值，以及按类别联合查找
                string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id and [book].b_name like '%" + tstext_book.Text.Trim() + "%' union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id and [book].b_name like '%" + tstext_book.Text.Trim() + "%'";
                databind(sql);
            }
        }

        //查询全部按钮
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            string sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id";
            databind(sql);//填充到表格控件中
        }

        //获取图书名称的值
        private void dGv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex用来定位到表中的一行
            if (e.RowIndex >= 0)
            {
                string b_name = Dgv_SeeBook.Rows[e.RowIndex].Cells["b_name"].Value.ToString(); //获取图书名称的值
                string b_isbn = Dgv_SeeBook.Rows[e.RowIndex].Cells["b_isbn"].Value.ToString(); //获取图书的ISBN值
                string b_stocks = Dgv_SeeBook.Rows[e.RowIndex].Cells["b_stocks"].Value.ToString(); //获取图书的ISBN值
                //判断是否点击了借书按钮
                if (Dgv_SeeBook.Columns[e.ColumnIndex].Name == "Cl_borrow")
                {
                    if (b_stocks == "不可借")
                    {
                        //错误提示
                        MessageBox.Show("当前图书不可借！请选择其他图书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (tscmb_day.Text == "")
                    {
                        //错误提示
                        MessageBox.Show("请选择所借天数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        //打开数据库
                        con = dButil.SqlOpen();
                        //sql查询语句
                        string sql = "select [borrow].b_id from [borrow],[books],[user] where [borrow].u_id=[user].u_id and [borrow].b_id=[books].b_id and bo_eme!=2 and [books].b_name='" + b_name + "' and [borrow].u_id='"+Log.log.u_id+"'";
                        cmd = new SqlCommand(sql, con);//储存需要执行的语句
                        string b_id =Convert.ToString(cmd.ExecuteScalar());//执行，并返回第一行第一列内容
                        con.Close();//关闭数据库
                        if ("".Equals(b_id))//返回cmd查询的第一行第一列是否有值，进行对比
                        {
                            int u_number = Log.log.user_number;
                            if (u_number == 0)
                            {
                                //错误提示
                                MessageBox.Show("您的可借图书数量为0，无法进行借书！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DialogResult dialog = MessageBox.Show("确认借用图书：" + b_name + "？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (DialogResult.OK == dialog)
                                {
                                    int n = 0;
                                    //更新第一条数据，并且返回更新的b_id
                                    sql = "update top(1) books set  b_lend=0 output inserted.b_id where  b_name='" + b_name + "' and b_lend=1";//只更新一条
                                    con = dButil.SqlOpen();//打开数据库
                                    cmd = new SqlCommand(sql, con);//储存需要执行的语句
                                    string return_b_id = cmd.ExecuteScalar().ToString();//执行语句，返回更新的b_id，用做插入信息的数据
                                    con.Close();//关闭数据库

                                    if (tscmb_day.SelectedIndex == 0)//选中7天
                                    {
                                        string sql_borrow = "insert into borrow(b_id,b_isbn,u_id,bo_borrow,bo_return,bo_day) values ('" + return_b_id + "','" + b_isbn + "','" + Log.log.u_id + "','" + DateTime.Now.ToString("d") + "','" + DateTime.Now.AddDays(7).ToString("d") + "','" + 7 + "')";
                                        con = dButil.SqlOpen();//打开数据库
                                        cmd = new SqlCommand(sql_borrow, con);//储存需要执行的语句
                                        n = cmd.ExecuteNonQuery();//执行sql语句，返回受影响的行，用做判断成功

                                        //更新可借数量
                                        string sql_number = "update [user] set u_number=(u_number-1) where u_id='" + Log.log.u_id + "'";
                                        cmd = new SqlCommand(sql_number, con);//储存需要执行的语句
                                        cmd.ExecuteNonQuery();//执行更新可借数量语句

                                        //更新图书库存
                                        string sql_b_stocks = "update [book] set b_stocks=(b_stocks-1) where b_isbn='" + b_isbn + "'";
                                        cmd = new SqlCommand(sql_b_stocks, con);//储存需要执行的语句
                                        cmd.ExecuteNonQuery();//执行更新可借数量语句
                                        con.Close();//关闭数据库

                                    }
                                    else if (tscmb_day.SelectedIndex == 1)//选中15天
                                    {
                                        string sql_borrow = "insert into borrow(b_id,b_isbn,u_id,bo_borrow,bo_return,bo_day) values ('" + return_b_id + "','" + b_isbn + "','" + Log.log.u_id + "','" + DateTime.Now.ToString("d") + "','" + DateTime.Now.AddDays(15).ToString("d") + "','" + 15 + "')";
                                        con = dButil.SqlOpen();//打开数据库
                                        cmd = new SqlCommand(sql_borrow, con);//储存需要执行的语句
                                        n = cmd.ExecuteNonQuery();//执行sql语句，返回受影响的行，用做判断成功

                                        //更新可借数量
                                        string sql_number = "update [user] set u_number=(u_number-1) where u_id='" + Log.log.u_id + "'";
                                        cmd = new SqlCommand(sql_number, con);//储存需要执行的语句
                                        cmd.ExecuteNonQuery();//执行更新可借数量语句

                                        //更新图书库存
                                        string sql_b_stocks = "update [book] set b_stocks=(b_stocks-1) where b_isbn='" + b_isbn + "'";
                                        cmd = new SqlCommand(sql_b_stocks, con);//储存需要执行的语句
                                        cmd.ExecuteNonQuery();//执行更新可借数量语句
                                        con.Close();//关闭数据库
                                    }
                                    else//否则选中30天
                                    {
                                        string sql_borrow = "insert into borrow(b_id,b_isbn,u_id,bo_borrow,bo_return,bo_day) values ('" + return_b_id + "','" + b_isbn + "','" + Log.log.u_id + "','" + DateTime.Now.ToString("d") + "','" + DateTime.Now.AddDays(30).ToString("d") + "','" + 30 + "')";
                                        con = dButil.SqlOpen();//打开数据库
                                        cmd = new SqlCommand(sql_borrow, con);//执行sql语句
                                        n = cmd.ExecuteNonQuery();//返回受影响的行，用做判断成功

                                        //更新可借数量
                                        string sql_number = "update [user] set u_number=(u_number-1) where u_id='" + Log.log.u_id + "'";
                                        cmd = new SqlCommand(sql_number, con);//储存需要执行的语句
                                        cmd.ExecuteNonQuery();//执行更新可借数量语句

                                        //更新图书库存
                                        string sql_b_stocks = "update [book] set b_stocks=(b_stocks-1) where b_isbn='" + b_isbn + "'";
                                        cmd = new SqlCommand(sql_b_stocks, con);//储存需要执行的语句
                                        cmd.ExecuteNonQuery();//执行更新可借数量语句
                                        con.Close();//关闭数据库
                                    }

                                    if (n > 0)
                                    {
                                        //成功提示
                                        MessageBox.Show("借书成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        Log.log.user_number = Log.log.user_number - 1;//更新log类中的可借数量

                                        // 查询列表内容，这里等于刷新
                                        sql = "select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id union select book.b_isbn,[book].b_name,t_name,b_author,b_press,b_time,b_price,b_stocks=case b_stocks when 0 then '不可借' else '可借' end from books,book,[type] where books.b_isbn=book.b_isbn and [type].t_id=books.t_id";
                                        databind(sql);//填充到表格控件中
                                    }
                                    else
                                    {
                                        //错误提示
                                        MessageBox.Show("借书失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else
                        {
                            //提示已经借过一本书了
                            MessageBox.Show("你已经借了一本相同的书了！\n请先还书！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
