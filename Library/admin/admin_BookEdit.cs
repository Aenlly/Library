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
    public partial class admin_BookEdit : Form
    {
        public admin_BookEdit()
        {
            InitializeComponent();
        }
        public string bookname;
        public SqlConnection con;
        public SqlCommand cmd;
        DButil dButil = new DButil();

        private void admin_BookEdit_Load(object sender, EventArgs e)
        {
            bookname = Log.log.b_name;
            mtext_isbn.Text = Log.log.b_isbn;
            text_author.Text = Log.log.b_author;
            text_press.Text = Log.log.b_press;
            mtext_year.Text = Log.log.b_time;
            text_price.Text = Log.log.b_price;
            mtext_stocks.Text = Log.log.b_stocks;
            text_book.Text = bookname;
            BookType();
        }

        /// <summary>
        /// 绑定下拉列表，添加数据库中的类别
        /// </summary>
        /// <param name="sqltype">数据库语句</param>
        /// <param name="type">表名</param>
        /// <param name="t_name">字段名</param>
        public void BookType()
        {
            con = dButil.SqlOpen();
            //初始化，comboBox1绑定客户表
            string sqltype = "select t_name from [type]";//查询有多少类别
            SqlDataAdapter sda = new SqlDataAdapter(sqltype, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);//添加到ds缓存中
            cmb_type.DataSource = ds.Tables[0].DefaultView;//取出数据源填充到列表中
            cmb_type.DisplayMember = "t_name";//列表中显示的值对应的字段名
            string sql = "select t_id from [type] where t_name='" + Log.log.b_type + "'";
            cmd = new SqlCommand(sql, con);//执行查询t_id语句
            int t_id = Convert.ToInt16(cmd.ExecuteScalar());//返回t_id值，用于这边选中
            cmb_type.SelectedIndex = t_id;//设置索引为t_id
            con.Close();//关闭数据库
        }

        /// <summary>
        /// 价格的输入事件
        /// 价格只能输入数字和.，其他一律不行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if (e.KeyChar != '.')//允许使用.符合
                {
                    if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (text_book.Text.Trim() == "" || text_author.Text.Trim() == "" || text_press.Text.Trim() == "" || text_price.Text.Trim() == "" || mtext_isbn.Text.Trim() == "" || mtext_stocks.Text.Trim() == "" || mtext_year.Text.Trim() == "" || cmb_type.Text == "")
            {
                MessageBox.Show("内容不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int year = Convert.ToInt16(mtext_year.Text);
                if (year > DateTime.Now.Year)
                {
                    MessageBox.Show("输入的年份不符合要求", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.text_price.Text = string.Format("{0:#,##0.00}", Convert.ToDouble(text_price.Text)); //价格文本框必须显示2位小数点
                    DialogResult dialog = MessageBox.Show("确认修改为以下信息？\n图书名：" + text_book.Text + "\nISBN编号：" + mtext_isbn.Text + "\n图书类别：" + cmb_type.Text + "\n作者：" + mtext_isbn.Text + "\n出版社：" + mtext_isbn.Text + "\n出版年份：" + mtext_isbn.Text + "\n价格：" + mtext_isbn.Text + "\n库存：" + mtext_isbn.Text, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult.OK == dialog)
                    {
                        //判断数量与之前想比是增加了还是减少了
                        int m = Convert.ToInt32(mtext_stocks.Text.Trim()) - Convert.ToInt32(Log.log.b_stocks);
                        if (m > 0)
                        {
                            //插入语句
                            string sql_books = "insert into books vaules ('" + mtext_isbn.Text.Trim() + "','" + text_book.Text.Trim() + "',(select t_id from [type] where t_name='" + cmb_type.Text + "'),'" + text_author.Text.Trim() + "','" + text_press.Text.Trim() + "','" + mtext_year.Text.Trim() + "','" + text_price.Text.Trim() + "',1)";
                            int n = 0;//定义个局部变量用于判断是否成功执行sql语句
                            con = dButil.SqlOpen();//打开数据库
                            for (int i = 0; i < m; i++)
                            {
                                cmd = new SqlCommand(sql_books, con);
                                n = n + cmd.ExecuteNonQuery();
                            }
                            con.Close();
                            if (n ==m)
                            {
                                //更新语句，先更新book表中的isbn再更新books表
                                string sql = "update [book] set b_name='" + text_book.Text.Trim() + "',b_isbn='" + mtext_isbn.Text.Trim() + "',b_stocks='" + mtext_stocks.Text.Trim() + "' where b_name='" + bookname + "'";
                                string sql_book = "update [books] set b_name='" + text_book.Text.Trim() + "',b_isbn='" + mtext_isbn.Text.Trim() + "',b_author='" + text_author.Text.Trim() + "',b_press='" + text_press.Text.Trim() + "',b_time='" + mtext_year.Text.Trim() + "',b_price='" + text_price.Text.Trim() + "',t_id=(select t_id from [type] where t_name='" + cmb_type.Text + "') where b_name='" + bookname + "'";
                                con = dButil.SqlOpen();//打开数据库
                                cmd = new SqlCommand(sql, con);//执行语句
                                n = cmd.ExecuteNonQuery();//返回影响行
                                if (n >0) //判断是否执行成功
                                {
                                    cmd = new SqlCommand(sql_book, con);//执行语句
                                    n = cmd.ExecuteNonQuery();//返回影响行
                                    if (n > 0)//判断是否执行成功
                                    {
                                        //成功提示
                                        DialogResult result = MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        if (DialogResult.OK == result)
                                        {
                                            //
                                            btn_ret_Click(sender, e);
                                        }
                                    }
                                    else
                                    {
                                        //失败提示
                                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    //失败提示
                                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                con.Close();
                            }
                            else
                            {
                                //失败提示
                                MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            m = -m;//转为正数
                            string sql_books = "delete books top "+m+" where b_name='"+bookname+"' and b_lend!=0";
                            int n = 0;//定义个局部变量用于判断是否成功执行sql语句
                            con = dButil.SqlOpen();//打开数据库
                            cmd = new SqlCommand(sql_books, con);
                            n = cmd.ExecuteNonQuery();
                            con.Close();
                            if (n ==m)
                            {
                                //更新语句，先更新book表中的isbn再更新books表
                                string sql = "update [book] set b_name='" + text_book.Text.Trim() + "',b_isbn='" + mtext_isbn.Text.Trim() + "',b_stocks='" + mtext_stocks.Text.Trim() + "' where b_name='" + bookname + "'";
                                string sql_book = "update [books] set b_name='" + text_book.Text.Trim() + "',b_isbn='" + mtext_isbn.Text.Trim() + "',b_author='" + text_author.Text.Trim() + "',b_press='" + text_press.Text.Trim() + "',b_time='" + mtext_year.Text.Trim() + "',b_price='" + text_price.Text.Trim() + "',t_id=(select t_id from [type] where t_name='" + cmb_type.Text + "') where b_name='" + bookname + "'";
                                con = dButil.SqlOpen();//打开数据库
                                cmd = new SqlCommand(sql, con);//执行语句
                                n = cmd.ExecuteNonQuery();//返回影响行
                                if (n > 0) //判断是否执行成功
                                {
                                    cmd = new SqlCommand(sql_book, con);//执行语句
                                    n = cmd.ExecuteNonQuery();//返回影响行
                                    if (n > 0)//判断是否执行成功
                                    {
                                        //成功提示
                                        DialogResult result = MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        if (DialogResult.OK == result)
                                        {
                                            //
                                            btn_ret_Click(sender, e);
                                        }
                                    }
                                    else
                                    {
                                        //失败提示
                                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    //失败提示
                                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                con.Close();
                            }
                            else
                            {
                                //失败提示
                                MessageBox.Show("修改失败！可能存在用户正在借用该书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }               
                    }
                }
            }
        }

        private void btn_ret_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
