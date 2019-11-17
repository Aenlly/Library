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
                    string sql_bookname = "select b_isbn from book where b_name='" + mtext_isbn.Text.Trim() + "'";
                    con = dButil.SqlOpen();//打开数据库
                    cmd = new SqlCommand(sql_isbn, con);
                    int n;//定义一个整型，用来判断是否修改数据库
                    string b_name = Convert.ToString(cmd.ExecuteScalar());
                    cmd = new SqlCommand(sql_bookname, con);
                    string b_isbn = Convert.ToString(cmd.ExecuteScalar());//获得第一列第一行的值
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
                        else if (b_name == text_book.Text.Trim() && b_name != "")
                        {
                            //提示对话框，并获得返回值到dialog上
                            dialog = MessageBox.Show("检测到数据库中存在，是否直接增加库存？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (DialogResult.OK == dialog)
                            {
                                //查询books表
                                string sql_book = "select * from books where b_name='" + b_name + "'";
                                con = dButil.SqlOpen();
                                cmd = new SqlCommand(sql_book, con);
                                SqlDataReader reader = cmd.ExecuteReader();
                                reader.Read();
                                //循环添加
                                for (int i = 0; i < stocks; i++)
                                {
                                    string sql_inserb = "insert into books values ('" + reader["b_isbn"] + "','" + reader["b_name"] + "','" + reader["t_id"] + "','" + reader["b_author"] + "','" + reader["b_press"] + "','" + reader["b_time"] + "','" + reader["b_price"] + "','1')";
                                    cmd = new SqlCommand(sql_inserb, con);
                                    con.Close();
                                    n = cmd.ExecuteNonQuery();
                                    if (n > 0)
                                    {
                                        MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("添加图书失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }

                            }
                            else if (b_isbn == mtext_isbn.Text.Trim() && b_isbn != "")
                            {
                                dialog = MessageBox.Show("检测到数据库中存在，是否直接增加库存？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (DialogResult.OK == dialog)
                                {
                                    string sql_book = "select * from books where b_isbn='" + b_isbn + "'";
                                    con = dButil.SqlOpen();
                                    cmd = new SqlCommand(sql_book, con);
                                    SqlDataReader reader = cmd.ExecuteReader();
                                    reader.Read();
                                    //循环添加
                                    for (int i = 0; i < stocks; i++)
                                    {
                                        string sql_inserb = "insert into books values ('" + reader["b_isbn"] + "','" + reader["b_name"] + "','" + reader["t_id"] + "','" + reader["b_author"] + "','" + reader["b_press"] + "','" + reader["b_time"] + "','" + reader["b_price"] + "','1')";
                                        cmd = new SqlCommand(sql_inserb, con);
                                        con.Close();
                                        n = cmd.ExecuteNonQuery();
                                        if (n > 0)
                                        {
                                            MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("添加图书失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }

                                }
                            }
                        }
                        else
                        {
                            //显示对话框并获得单击返回值
                            dialog = MessageBox.Show("确认添加为以下信息？\n图书名：" + text_book.Text + "\nISBN编号：" + mtext_isbn.Text + "\n图书类别：" + cmb_type.Text + "\n作者：" + mtext_isbn.Text + "\n出版社：" + mtext_isbn.Text + "\n出版年份：" + mtext_isbn.Text + "\n价格：" + mtext_isbn.Text + "\n库存：" + mtext_isbn.Text, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            //二次确认
                            if (DialogResult.OK == dialog)
                            {
                                string sql_b = "insert into book values('" + mtext_isbn.Text.Trim() + "','" + text_book.Text.Trim() + "','" + mtext_stocks.Text.Trim() + "')";
                                con = dButil.SqlOpen();
                                cmd = new SqlCommand(sql_b, con);
                                n = cmd.ExecuteNonQuery();
                                con.Close();
                                if (n > 0)
                                {
                                    n = 0;//重置n=0，以便修改循环内容的n
                                          //利用for循环，执行多次
                                    for (int i = 0; i < stocks; i++)
                                    {
                                        string sql_bs = "insert into books values ('" + mtext_isbn.Text.Trim() + "','" + text_book.Text.Trim() + "','" + index + "','" + text_author.Text.Trim() + "','" + text_press.Text.Trim() + "','" + year + "','" + text_price.Text.Trim() + "',1)";
                                        cmd = new SqlCommand(sql_bs, con);
                                        n = n + cmd.ExecuteNonQuery();
                                        con.Close();
                                    }
                                    if (n > 0)
                                    {
                                        MessageBox.Show("添加图书：" + text_book.Text.Trim() + "成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
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
    }
}
