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
    public partial class admin_BookAdd : Form
    {
        public admin_BookAdd()
        {
            InitializeComponent();
        }

        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        DButil dButil = new DButil();//实例化DButil工具类

        private void admin_BookAdd_Load(object sender, EventArgs e)
        {
            BookType();//填充类别在下拉框中
        }

        /// <summary>
        /// 绑定下拉列表，添加数据库中的类别
        /// </summary>
        /// <param name="sqltype">数据库语句</param>
        /// <param name="type">表名</param>
        /// <param name="t_name">字段名</param>
        public void BookType()
        {
            con = dButil.SqlOpen();//打开i数据库
            //初始化，comboBox1绑定客户表
            string sqltype = "select t_name from [type]";//查询有多少类别
            SqlDataAdapter sda = new SqlDataAdapter(sqltype, con);
            DataSet ds = new DataSet();//创建ds缓存
            sda.Fill(ds);//添加到ds缓存中
            cmb_type.DataSource = ds.Tables[0].DefaultView;//取出数据源填充到列表中
            cmb_type.DisplayMember = "t_name";//列表中显示的值对应的字段名
            string sql = "select t_id from [type] where t_name='" + cmb_type.Text + "'";//差类别第一个的列的id
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

        //添加按钮事件
        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult dialog;//创建对话按钮返回值
            if (text_book.Text.Trim() == "" || text_author.Text.Trim() == "" || text_press.Text.Trim() == "" || text_price.Text.Trim() == "" || mtext_isbn.Text.Trim() == "" || mtext_stocks.Text.Trim() == "" || mtext_year.Text.Trim() == "" || cmb_type.Text == "")
            {
                MessageBox.Show("内容不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //价格文本框必须显示2位小数点
                this.text_price.Text = string.Format("{0:#,##0.00}", Convert.ToDouble(text_price.Text));

                int index = cmb_type.SelectedIndex;//获得类别的索引值

                int year = Convert.ToInt16(mtext_year.Text);//年份转换，并与当前年份对比
                int stocks = Convert.ToInt16(mtext_stocks.Text.Trim());//获得添加的库存量
                if (mtext_year.Text.Trim().Length < 4 || year > DateTime.Now.Year)
                {
                    MessageBox.Show("输入的年份不符合要求", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ///查询内部是否存在该isbn值
                    string sql_isbn = "select b_name from book where b_isbn='" + mtext_isbn.Text.Trim() + "'";
                    string sql_bookname = "select b_isbn from book where b_name='" + text_book.Text.Trim() + "'";
                    con = dButil.SqlOpen();//打开数据库
                    int n = 0;//定义一个整型，用来判断是否修改数据库

                    cmd = new SqlCommand(sql_isbn, con);//查询isbn值
                    string b_name = Convert.ToString(cmd.ExecuteScalar());//获得isbn值
                    cmd = new SqlCommand(sql_bookname, con);//查询图书名
                    string b_isbn = Convert.ToString(cmd.ExecuteScalar());//获得第一列第一行的值即图书名
                    con.Close();//关闭数据库
                    //判断，数据库有没有该isbn值就直接循环
                    if (b_name != "" || b_isbn != "")
                    {
                        if (b_name != text_book.Text.Trim() && b_isbn == "")
                        {
                            //提示对话框
                            MessageBox.Show("ISBN编号与数据库中相同，图书名称不一样！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (b_isbn != mtext_isbn.Text.Trim() && b_name == "")
                        {
                            //提示对话框
                            MessageBox.Show("图书名称与数据库中相同，ISBN编号不一样！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (b_name == text_book.Text.Trim() && b_isbn == mtext_isbn.Text.Trim() && b_isbn != "" && b_name != "")
                        {
                            //提示对话框，并获得返回值到dialog上
                            dialog = MessageBox.Show("检测到数据库中存在，是否直接增加库存？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (DialogResult.OK == dialog)//单击确认
                            {
                                //查询books表
                                string sql_book = "select * from books where b_name='" + b_name + "'";
                                con = dButil.SqlOpen();//打开数据库
                                cmd = new SqlCommand(sql_book, con);//执行sql语句
                                SqlDataReader reader = cmd.ExecuteReader();//获得各列的值
                                reader.Read();
                                string isbn = reader["b_isbn"].ToString();//获得isbn值
                                string name= reader["b_name"].ToString();//获得图书名称
                                string id = reader["t_id"].ToString();//获得类别id
                                string author = reader["b_author"].ToString();//获得作者名
                                string press = reader["b_press"].ToString();//获得出版社名
                                string time = reader["b_time"].ToString();//获得出版年份
                                string price = reader["b_price"].ToString();//获得价格
                                con.Close();//关闭数据库

                                con = dButil.SqlOpen();//打开数据库
                                n = 0;
                                //循环添加
                                for (int i = 0; i < stocks; i++)
                                {
                                    string sql_inserb = "insert into books values ('" + b_isbn + "','" + name + "','" +id + "','" + author + "','" + press + "','" + time + "','" + price + "','1')";
                                    cmd = new SqlCommand(sql_inserb, con);//执行插入语句
                                    n = n + cmd.ExecuteNonQuery();//每次循环n加一
                                }
                                con.Close();

                                if (n== stocks)
                                {
                                    con = dButil.SqlOpen();//打开数据库
                                    string sql = "update book set b_stocks=(select count(*) from books where b_lend=1 and b_name='" + name + "') where b_isbn='" + b_isbn + "'";
                                    cmd = new SqlCommand(sql, con);
                                    n=cmd.ExecuteNonQuery();
                                    con.Close();
                                    if (n > 0)
                                    {
                                        SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                        dbHelper.Operation("图书：" + text_book.Text.Trim() + "的库存加" + stocks + "成功");//插入操作记录
                                        MessageBox.Show("库存添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                        dbHelper.Operation("图书：" + text_book.Text.Trim() + "的库存增加失败");//插入操作记录
                                        MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }                                   
                                }
                                else
                                {
                                    SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                    dbHelper.Operation("图书：" + text_book.Text.Trim() + "的books表增加信息失败");//插入操作记录
                                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }                        
                        
                        }
                    else
                    {
                        //显示对话框并获得单击返回值
                        dialog = MessageBox.Show("确认添加为以下信息？\n图书名：" + text_book.Text + "\nISBN编号：" + mtext_isbn.Text + "\n图书类别：" + index + "\n作者：" + text_author.Text.Trim() + "\n出版社：" + text_press.Text.Trim() + "\n出版年份：" + year + "\n价格：" + mtext_stocks.Text.Trim() + "\n库存：" + stocks, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        //二次确认
                        if (DialogResult.OK == dialog)
                        {
                            string sql_b = "insert into book values('" + mtext_isbn.Text.Trim() + "','" + text_book.Text.Trim() + "','" + mtext_stocks.Text.Trim() + "')";
                            con = dButil.SqlOpen();//打开数据库
                            cmd = new SqlCommand(sql_b, con);//执行sql语句
                            n = cmd.ExecuteNonQuery();//返回影响行
                            con.Close();//关闭数据库
                            if (n > 0)
                            {
                                n = 0;//重置n=0，以便修改循环内容的n

                                con = dButil.SqlOpen();//打开数据库
                                                       //利用for循环，执行多次
                                for (int i = 0; i < stocks; i++)
                                {
                                    string sql_bs = "insert into books values ('" + mtext_isbn.Text.Trim() + "','" + text_book.Text.Trim() + "','" + index + "','" + text_author.Text.Trim() + "','" + text_press.Text.Trim() + "','" + year + "','" + text_price.Text.Trim() + "',1)";
                                    cmd = new SqlCommand(sql_bs, con);
                                    n = n + cmd.ExecuteNonQuery();
                                }
                                con.Close();//关闭数据库
                                if (n > 0)
                                {
                                    SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                    dbHelper.Operation("添加新图书：" + text_book.Text.Trim() + "成功");//插入操作记录

                                    MessageBox.Show("添加图书：" + text_book.Text.Trim() + "成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                    dbHelper.Operation("添加新图书：" + text_book.Text.Trim() + "失败");//插入操作记录

                                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                dbHelper.Operation("添加新图书：" + text_book.Text.Trim() + "的ISBN值失败");//插入操作记录

                                MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        //添加新类别的按钮
        private void lkl_type_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_BookType bookType = new admin_BookType();
            bookType.ShowDialog();
            BookType();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
            admin_BookPage admin_BookPage = new admin_BookPage();
            admin_BookPage.Activate();
        }
    }
}
