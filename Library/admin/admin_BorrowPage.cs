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
    public partial class admin_BorrowPage : Form
    {
        public admin_BorrowPage()
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
            Dgv_borrow.AutoGenerateColumns = false;//不自动生成列，从数据库可能取得很多列，使其不显示在DataGridView中
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);//储存sql语句
            sda = new SqlDataAdapter(cmd);//创建适配器实例
            ds = new DataSet();//ds初始化
            sda.Fill(ds);//把查询内容添加到ds中
            bindingSource1.DataSource = ds.Tables[0];//获取数据源到bindingSource1中
            bindingNavigator1.BindingSource = bindingSource1;//连接数据源
            Dgv_borrow.DataSource = bindingSource1;//导出到dataGridView1中显示并用下列代码对于列名 
            for (int i = 0; i < 8; i++)//循环添加到表中
            {
                Dgv_borrow.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            }
            con.Close();
        }

        //窗体加载
        private void admin_BorrowPage_Load(object sender, EventArgs e)
        {
            //每次执行时，更新下数据
            string sql = "update borrow set bo_eme=1 where bo_rtnatl is NULL and datediff(day,bo_rtnatl,getdate())>0";
            con = dButil.SqlOpen();//打开数据库
            cmd = new SqlCommand(sql, con);//储存sql语句
            cmd.ExecuteNonQuery();//执行sql语句
            con.Close();//关闭数据库
            //查询全部内容的语句
            sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 0 then '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme!=2";
            databind(sql);//传递sql语句进行查询
        }

        private void Dgv_borrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //获取还书状态的值
                string b_eme = Dgv_borrow.Rows[e.RowIndex].Cells["Cl_eme"].Value.ToString();
                //获取借书人的值
                string u_name = Dgv_borrow.Rows[e.RowIndex].Cells["Cl_u_name"].Value.ToString();
                //获得借书编号
                string bo_id = Dgv_borrow.Rows[e.RowIndex].Cells["Cl_id"].Value.ToString();
                //判断是否点击了还书按钮
                if (Dgv_borrow.Columns[e.ColumnIndex].Name == "Cl_btnrtn")
                {
                    //判断是否申请了
                    if (b_eme == "未申请")
                    {
                        //未申请提示
                        MessageBox.Show("该用户未申请还书！无法进行确认还书操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (b_eme == "未通过")
                    {
                        //未申请提示
                        MessageBox.Show("该用户未通过还书审核！无法进行确认还书操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else//通过
                    {
                        //提示，并获取单击的返回值
                        DialogResult dialog=MessageBox.Show("确认通过用户："+ u_name + "的还书申请？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        //判断单击了确认按钮
                        if (DialogResult.OK == dialog)
                        {

                            //更新图书表中的一条数据，使数量变成+1
                            string sql = "update top(1) books set  b_lend=1 output inserted.b_id where  b_name='" + Dgv_borrow.Rows[e.RowIndex].Cells["Cl_name"].Value.ToString() + "' and b_lend=0";//只更新一条
                            con = dButil.SqlOpen();//打开数据库
                            cmd = new SqlCommand(sql, con);//储存需要执行的语句
                            cmd.ExecuteNonQuery();//执行sql语句，返回影响行数

                            //sql语句，更新为还书成功，并添加还书时间,添加管理员id
                            sql = "update borrow set bo_eme=2,bo_rtnatl='" + DateTime.Now.ToString() + "',a_id='"+Log.log.a_id+"' where bo_id='" + bo_id + "'";
                            cmd = new SqlCommand(sql, con);//储存sql语句
                            int n = cmd.ExecuteNonQuery();//执行sql语句，返回影响行数，并赋值给n用作判断

                            //更新该用户的可借数量,总借书数量
                            string sql_number = "update [user] set u_number=(u_number+1),u_book=(u_book+1) where u_id=(select u_id from borrow where bo_id='" + bo_id + "')";
                            cmd = new SqlCommand(sql_number, con);//储存sql语句
                            cmd.ExecuteNonQuery();//执行更新数量语句

                            //isbn表中的数量储存
                            string sql_b_stocks = "update [book] set b_stocks=(b_stocks+1) where b_isbn=(select b_isbn from borrow where bo_id='" + bo_id + "')";
                            cmd = new SqlCommand(sql_b_stocks, con);//储存sql语句
                            cmd.ExecuteNonQuery();//执行更新数量语句
                            con.Close();//关闭数据库
                            if (n > 0)//判断是否执行成功并修改
                            {
                                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                dbHelper.Operation("通过用户：" + u_name + "的还书申请");//插入操作记录

                                //成功提示
                                MessageBox.Show("已通过用户：" + u_name + "的还书申请！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //查询全部内容的语句，该处用于刷新表
                                sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 3 then '未通过' else '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme!=2";
                                databind(sql);//传递sql语句进行查询
                            }
                            else
                            {
                                //失败提示
                                MessageBox.Show("通过申请操作失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                //点击了不通过按钮
                if (Dgv_borrow.Columns[e.ColumnIndex].Name == "Cl_btnNo")
                {
                    //判断是否申请了
                    if (b_eme == "未申请")
                    {
                        //未申请提示
                        MessageBox.Show("该用户未申请还书！无法进行不通过审核操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (b_eme == "未通过")
                    {
                        //未申请提示
                        MessageBox.Show("该用户已未通过还书审核！无法再次进行不通过审核操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //提示，并获取单击的返回值
                        DialogResult dialog = MessageBox.Show("确认不通过用户：" + u_name + "的还书申请？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        //判断单击了确认按钮
                        if (DialogResult.OK == dialog)
                        {
                            //sql语句，更新为还书失败，并添加还书时间和管理员id
                            string sql = "update borrow set bo_eme=3,a_id='"+Log.log.a_id+"' where bo_id='" + bo_id + "'";
                            con = dButil.SqlOpen();//打开数据库
                            cmd = new SqlCommand(sql, con);//储存sql语句
                            int n = cmd.ExecuteNonQuery();//执行sql语句，返回影响行数，并赋值给n用作判断
                            con.Close();//关闭数据库
                            if (n > 0)//判断是否执行成功并修改
                            {
                                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                dbHelper.Operation("不通过用户："+u_name+"的还书申请");//插入操作记录

                                //成功提示
                                MessageBox.Show("已不通过用户：" + u_name + "的还书申请！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //查询全部内容的语句，该处用于刷新表
                                sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 3 then '未通过' else '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme!=2";
                                databind(sql);//传递sql语句进行查询
                            }
                            else
                            {
                                //失败提示
                                MessageBox.Show("不通过申请操作失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        //查询按钮的单击事件
        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            //判断查询输入文本框内的值是否未空，为空则查询全部
            if (tstext_name.Text.Trim() == "")
            {
                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                dbHelper.Operation("查询全部的借书记录");//插入操作记录

                //查询全部内容的语句
                string sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 3 then '未通过' else '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme!=2";
                databind(sql);//传递sql语句进行查询
            }
            else
            {
                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                dbHelper.Operation("查询借书人为："+ tstext_name.Text.Trim()+ "的借书记录");//插入操作记录

                //查询指定借书人的内容的语句，模糊查询
                string sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 3 then '未通过' else '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme!=2 and [user].u_name like '%" + tstext_name.Text.Trim() + "%'";
                databind(sql);//传递sql语句进行查询
            }
        }

        //显示全部按钮的单击事件
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询全部的借书记录");//插入操作记录

            //查询全部内容的语句
            string sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 3 then '未通过' else '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme!=2";
            databind(sql);//传递sql语句进行查询
        }

        //显示未还书记录的按钮的单击事件
        private void tsbtn_nortn_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询未还书的借书记录");//插入操作记录

            //查询全部内容的语句
            string sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 3 then '未通过' else '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme in (0,3)";
            databind(sql);//传递sql语句进行查询
        }

        //显示待审核记录的按钮的单击事件
        private void tsbtn_eme_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询待审核的借书记录");//插入操作记录

            //查询全部内容的语句
            string sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 3 then '未通过' else '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme=1";
            databind(sql);//传递sql语句进行查询
        }
    }
}
