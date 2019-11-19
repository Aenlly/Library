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
    public partial class user_BorrowPage : Form
    {
        public user_BorrowPage()
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
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();//ds初始化
            sda.Fill(ds);//把查询内容添加到ds中
            bindingSource1.DataSource = ds.Tables[0];//封装数据
            bindingNavigator1.BindingSource = bindingSource1;//获得数据
            Dgv_borrow.DataSource = bindingSource1;//导出到dataGridView1中显示并用下列代码对于列名 
            for (int i = 0; i < 7; i++)//循环添加
            {
                Dgv_borrow.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            }

            con.Close();
        }

        //窗体加载
        private void user_BorrowPage_Load(object sender, EventArgs e)
        {
            //查询表内列名中的值的sql语句
            string sql = "select bo_id,books.b_name,bo_borrow,bo_return,bo_renewday,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_dayover=case bo_dayover when 0 then '未逾期' else '已逾期' end from borrow,books where borrow.b_id=books.b_id and bo_eme=0 and u_id='" + Log.log.u_id + "'";
            databind(sql);//传递sql语句
        }

        //查询按钮的单击事件
        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            if (tstext_book.Text.Trim() == "")//为空查询全部
            {
                //查询全部
                string sql = "select bo_id,books.b_name,bo_borrow,bo_return,bo_renewday,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_dayover=case bo_dayover when 0 then '未逾期' else '已逾期' end from borrow,books where borrow.b_id=books.b_id and bo_eme=0 and u_id='" + Log.log.u_id + "'";
                databind(sql);//传递sql语句
            }
            else
            {
                //查询模糊图书名查询
                string sql = "select bo_id,books.b_name,bo_borrow,bo_return,bo_renewday,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_dayover=case bo_dayover when 0 then '未逾期' else '已逾期' end from borrow,books where borrow.b_id=books.b_id and bo_eme=0 and u_id='" + Log.log.u_id + "' and b_name like '%" + tstext_book.Text.Trim() +"%'";
                databind(sql);//传递sql语句
            }
        }

        //查询全部按钮的事件
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            //查询全部
            string sql = "select bo_id,books.b_name,bo_borrow,bo_return,bo_renewday,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_dayover=case bo_dayover when 0 then '未逾期' else '已逾期' end from borrow,books where borrow.b_id=books.b_id and bo_eme=0 and u_id='" + Log.log.u_id + "'";
            databind(sql);//传递sql语句
        }

        private void Dgv_borrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string bo_id = Dgv_borrow.Rows[e.RowIndex].Cells["Cl_id"].Value.ToString();//获得借书编号
                string bo_emeover = Dgv_borrow.Rows[e.RowIndex].Cells["Cl_emeover"].Value.ToString();//获得是否逾期一栏的值
                if (Dgv_borrow.Columns[e.ColumnIndex].Name == "Cl_Renewal")//续借按钮
                {
                    DialogResult dialog = MessageBox.Show("确定续借7天？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult.OK == dialog)
                    {
                        if (bo_emeover == "已逾期")
                        {
                            //错误提示
                            dialog = MessageBox.Show("所续借书籍已经逾期，无法续借！\n点击确认跳转到逾期界面", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            if (DialogResult.OK == dialog)
                            {
                                //点击确认按钮跳转到逾期记录
                                user_OverduePage user_Overdue = new user_OverduePage();//实例化逾期记录界面
                                user_Overdue.ShowDialog();//以对话模式显示
                                //查询全部，这里等于返回该界面刷新
                                string sql = "select bo_id,books.b_name,bo_borrow,bo_return,bo_renewday,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_dayover=case bo_dayover when 0 then '未逾期' else '已逾期' end from borrow,books where borrow.b_id=books.b_id and bo_eme=0 and u_id='" + Log.log.u_id + "'";
                                databind(sql);//传递sql语句
                            }
                        }
                        else
                        {
                            //创建sql语句
                            string sql = "update borrow set bo_rtnatl=dateadd(day,7,bo_rtnatl),bo_renew='1' where bo_id='" + bo_id + "'";
                            con = dButil.SqlOpen();//打开数据库
                            cmd = new SqlCommand(sql, con);//执行sql语句
                            int n = cmd.ExecuteNonQuery();//返回受影响的行数赋值到n中，用于判断
                            con.Close();//关闭数据库
                            if (n > 0)//进行成功判断
                            {
                                //成功提示
                                MessageBox.Show("续借成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //查询全部，这里等于刷新
                                sql = "select bo_id,books.b_name,bo_borrow,bo_return,bo_renewday,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_dayover=case bo_dayover when 0 then '未逾期' else '已逾期' end from borrow,books where borrow.b_id=books.b_id and bo_eme=0 and u_id='" + Log.log.u_id + "'";
                                databind(sql);//传递sql语句
                            }
                            else
                            {
                                //失败提示
                                MessageBox.Show("续借失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                if (Dgv_borrow.Columns[e.ColumnIndex].Name== "Cl_operation")//还书按钮
                {
                    DialogResult dialog = MessageBox.Show("确定归还该书？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult.OK == dialog)
                    {
                        if (bo_emeover == "已逾期")
                        {
                            //错误提示
                            dialog=MessageBox.Show("所还图书已经逾期，无法还书！\n点击确认跳转到逾期界面", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            if (DialogResult.OK == dialog)
                            {
                                //点击确认按钮跳转到逾期记录
                                user_OverduePage user_Overdue = new user_OverduePage();//实例化逾期记录界面
                                user_Overdue.ShowDialog();//以对话模式显示
                                //查询全部，这里等于返回该界面刷新
                                string sql = "select bo_id,books.b_name,bo_borrow,bo_return,bo_renewday,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_dayover=case bo_dayover when 0 then '未逾期' else '已逾期' end from borrow,books where borrow.b_id=books.b_id and bo_eme=0 and u_id='" + Log.log.u_id + "'";
                                databind(sql);//传递sql语句
                            }
                        }
                        else
                        {
                            //创建sql语句
                            string sql = "update borrow set bo_rtnatl=getdate(),bo_eme=1 where bo_id='" + bo_id + "'";
                            con = dButil.SqlOpen();//打开数据库
                            cmd = new SqlCommand(sql, con);//执行sql语句
                            int n = cmd.ExecuteNonQuery();//返回受影响的行数赋值到n中，用于判断
                            con.Close();//关闭数据库
                            if (n > 0)//进行成功判断
                            {
                                //成功提示
                                MessageBox.Show("还书成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //查询全部，这里等于刷新
                                sql = "select bo_id,books.b_name,bo_borrow,bo_return,bo_renewday,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_dayover=case bo_dayover when 0 then '未逾期' else '已逾期' end from borrow,books where borrow.b_id=books.b_id and bo_eme=0 and u_id='" + Log.log.u_id + "'";
                                databind(sql);//传递sql语句
                            }
                            else
                            {
                                //失败提示
                                MessageBox.Show("还书失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }                
            }
        }
    }
}
