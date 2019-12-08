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
        public string bookname;//储存原来的图书名称
        public SqlConnection con;//创建sql连接对象
        public SqlCommand cmd;//创建sql执行对象
        DButil dButil = new DButil();//实例化DButil类

        private void admin_BookEdit_Load(object sender, EventArgs e)
        {
            bookname = Log.log.b_name;//图书名
            text_isbn.Text = Log.log.b_isbn;//isbn编号
            text_author.Text = Log.log.b_author;//作者
            text_press.Text = Log.log.b_press;//出版社
            mtext_year.Text = Log.log.b_time;//出版年份
            text_price.Text = Log.log.b_price;//价格
            mtext_stocks.Text = Log.log.b_stocks;//数量
            text_book.Text = bookname;//赋值到图书名称框中显示
            BookType();//获得类别
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
            SqlDataAdapter sda = new SqlDataAdapter(sqltype, con);//创建sql适配器
            DataSet ds = new DataSet();//创建ds缓存
            sda.Fill(ds);//添加到ds缓存中
            cmb_type.DataSource = ds.Tables[0].DefaultView;//取出数据源填充到列表中
            cmb_type.DisplayMember = "t_name";//列表中显示的值对应的字段名
            string sql = "select t_id from [type] where t_name='" + Log.log.b_type + "'";
            cmd = new SqlCommand(sql, con);////储存需要执行的t_id语句
            int t_id = Convert.ToInt16(cmd.ExecuteScalar());//返回t_id值，用于这边选中，执行t_id语句
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
                    if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是不允许输入0-9数字  
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        //确认修改按钮
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (text_book.Text.Trim() == "" || text_author.Text.Trim() == "" || text_press.Text.Trim() == "" || text_price.Text.Trim() == "" || text_isbn.Text.Trim() == "" || mtext_stocks.Text.Trim() == "" || mtext_year.Text.Trim() == "" || cmb_type.Text == "")
            {
                MessageBox.Show("内容不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int year = Convert.ToInt16(mtext_year.Text);//获得年份
                if (year > DateTime.Now.Year)
                {
                    MessageBox.Show("输入的年份不符合要求", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    text_price.Text = string.Format("{0:#,##0.00}", Convert.ToDouble(text_price.Text)); //价格文本框必须显示2位小数点
                    DialogResult dialog = MessageBox.Show("确认修改为以下信息？\n图书名：" + text_book.Text + "\nISBN编号：" + text_isbn.Text + "\n图书类别：" + cmb_type.Text + "\n作者：" + text_author.Text + "\n出版社：" + text_press.Text + "\n出版年份：" + year + "\n价格：" + text_price.Text + "\n库存：" + mtext_stocks.Text, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult.OK == dialog)
                    {
                        //判断数量与之前相比是增加了还是减少了
                        int m = Convert.ToInt32(mtext_stocks.Text.Trim()) - Convert.ToInt32(Log.log.b_stocks);
                        if (m >= 0)
                        {
                            //插入语句
                            string sql_books = "insert into books values ('" + text_isbn.Text.Trim() + "','" + text_book.Text.Trim() + "',(select t_id from [type] where t_name='" + cmb_type.Text + "'),'" + text_author.Text.Trim() + "','" + text_press.Text.Trim() + "','" + year + "','" + text_price.Text.Trim() + "',1)";
                            int n = 0;//定义个局部变量用于判断是否成功执行sql语句
                            con = dButil.SqlOpen();//打开数据库
                            for (int i = 0; i < m; i++)
                            {
                                cmd = new SqlCommand(sql_books, con);
                                n = n + cmd.ExecuteNonQuery();
                            }
                            con.Close();//关闭数据库
                            if (n ==m)
                            {
                                //更新语句，先更新book表中的isbn再更新books表
                                string sql = "update [book] set b_stocks='" + mtext_stocks.Text.Trim() + "' where b_name='" + bookname + "'";
                                string sql_book = "update [books] set b_author='" + text_author.Text.Trim() + "',b_press='" + text_press.Text.Trim() + "',b_time='" + year + "',b_price='" + text_price.Text.Trim() + "',t_id=(select t_id from [type] where t_name='" + cmb_type.Text + "') where b_name='" + bookname + "'";
                                con = dButil.SqlOpen();//打开数据库
                                cmd = new SqlCommand(sql, con);//储存sql语句
                                n = cmd.ExecuteNonQuery();//执行sql语句，返回影响行
                                con.Close();//关闭数据库
                                if (n >0) //判断是否执行成功
                                {
                                    con = dButil.SqlOpen();//打开数据库
                                    cmd = new SqlCommand(sql_book, con);//储存sql语句
                                    n = cmd.ExecuteNonQuery();//执行sql语句，返回影响行
                                    con.Close();//关闭数据库
                                    if (n > 0)//判断是否执行成功
                                    {
                                        SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                        dbHelper.Operation("成功图书："+ bookname +"的数据");//插入操作记录

                                        //成功提示
                                        DialogResult result = MessageBox.Show("修改成功！点击确认按钮返回图书管理界面", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                        if (DialogResult.OK == result)
                                        {
                                            //返回图书管理界面
                                            btn_ret_Click(sender, e);
                                        }
                                    }
                                    else
                                    {
                                        SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                        dbHelper.Operation("修改图书名为：" + bookname + "的数据失败");//插入操作记录

                                        //失败提示
                                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                    dbHelper.Operation("修改图书名为：" + bookname + "的数据失败");//插入操作记录

                                    //失败提示
                                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                dbHelper.Operation("修改图书：" + bookname + "的数据失败");//插入操作记录

                                //失败提示
                                MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            m = -m;//转为正数
                            //查询是否有存在m条未借出的数据
                            string sql = "select count(*) from books where b_name='" + bookname + "' and b_lend=1";
                            con = dButil.SqlOpen();//打开数据库
                            cmd = new SqlCommand(sql, con);//储存sql语句
                            int n = Convert.ToInt16(cmd.ExecuteScalar());//赋值进行对比，执行sql语句，返回第一行第一列的值
                            con.Close();//关闭数据库
                            if (n >=m)
                            {
                                    //更新语句，先更新book表中的isbn再更新books表
                                    sql = "update [book] set b_stocks='" + mtext_stocks.Text.Trim() + "' where b_name='" + bookname + "'";
                                    string sql_book = "update [books] set b_author='" + text_author.Text.Trim() + "',b_press='" + text_press.Text.Trim() + "',b_time='" + year + "',b_price='" + text_price.Text.Trim() + "',t_id=(select t_id from [type] where t_name='" + cmb_type.Text + "') where b_name='" + bookname + "'";
                                    con = dButil.SqlOpen();//打开数据库
                                    cmd = new SqlCommand(sql, con);//储存语句
                                    n = cmd.ExecuteNonQuery();//，执行语句返回影响行
                                    con.Close();//关闭数据库
                                    if (n > 0) //判断是否执行成功
                                    {
                                    string sql_books = "set rowcount " + m + " delete books where b_name='" + bookname + "' and b_lend=1";
                                    con = dButil.SqlOpen();//打开数据库
                                    cmd = new SqlCommand(sql_books, con);//储存语句
                                    n = cmd.ExecuteNonQuery();//执行
                                    con.Close();//关闭数据库

                                    if (n > 0)
                                    {

                                        con = dButil.SqlOpen();//打开数据库
                                        cmd = new SqlCommand(sql_book, con);//储存语句
                                        n = cmd.ExecuteNonQuery();//执行语句，返回影响行
                                        con.Close();//关闭数据库
                                        if (n > 0)//判断是否执行成功
                                        {
                                            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                            dbHelper.Operation("成功修改图书：" + bookname + "的数据");//插入操作记录

                                            //成功提示
                                            DialogResult result = MessageBox.Show("修改成功！点击确认按钮返回图书管理界面", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                            if (DialogResult.OK == result)
                                            {
                                                //按确认键关闭该窗体
                                                btn_ret_Click(sender, e);
                                            }
                                        }
                                        else
                                        {
                                            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                            dbHelper.Operation("修改图书名为：" + bookname + "的数据失败");//插入操作记录

                                            //失败提示
                                            MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                        dbHelper.Operation("修改图书名为：" + bookname + "的数据失败");//插入操作记录

                                        //失败提示
                                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                                else
                                {
                                    SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                    dbHelper.Operation("修改图书名为：" + bookname + "的数据失败");//插入操作记录

                                    //失败提示
                                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                            else
                            {
                                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                dbHelper.Operation("修改图书名为：" + bookname + "的数据失败");//插入操作记录

                                //失败提示
                                MessageBox.Show("修改失败！可能存在用户正在借用该书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }               
                    }
                }
            }
        }

        //关闭
        private void btn_ret_Click(object sender, EventArgs e)
        {
            Close();
        }

        //添加新的后再次点击刷新下拉列表内部
        private void cmb_type_Click(object sender, EventArgs e)
        {
            BookType();
        }

        //库存输入的判断
        private void mtext_stocks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtext_stocks.Text.Trim().Length > 0)//判断内容长度大于0
            {
                mtext_stocks.Text = string.Format("{0:#,#}", Convert.ToDouble(mtext_stocks.Text.Trim()));
            }
        }
    }
}
