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
            cmd = new SqlCommand(sql, con); //储存sql语句
             sda = new SqlDataAdapter(cmd);//适配器及执行查询
            ds = new DataSet();//ds初始化
            sda.Fill(ds);//把查询内容添加到ds中
            bindingSource1.DataSource = ds.Tables[0];//封装数据
            bindingNavigator1.BindingSource = bindingSource1;//获得数据
            Dgv_borrow.DataSource = bindingSource1;//导出到dataGridView1中显示并用下列代码对于列名 
            for (int i = 0; i < 8; i++)//循环添加
                Dgv_borrow.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            con.Close();
        }

        //窗体加载
        private void user_BorrowPage_Load(object sender, EventArgs e)
        {
            //每次执行时，更新下数据
            string sql = "update borrow set bo_emeover= 1 where bo_rtnatl is NULL and datediff(day,bo_rtnatl,getdate())>0 and u_id='"+Log.log.u_id+"'";
            con = dButil.SqlOpen();//打开数据库
            cmd = new SqlCommand(sql, con);//储存sql语句
            cmd.ExecuteNonQuery();//执行sql语句
            con.Close();//关闭数据库

            //查询表内列名中的值的sql语句
            sql = "select * from V_Borrow where u_id='" + Log.log.u_id + "'";
            databind(sql);//传递sql语句
        }

        //查询按钮的单击事件
        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            if (tstext_book.Text.Trim() == "")//为空查询全部
            {
                //查询全部
                string sql = "select * from V_Borrow where u_id='" + Log.log.u_id + "'";
                databind(sql);//传递sql语句
            }
            else
            {
                //查询模糊图书名查询
                string sql = "select * from V_Borrow where u_id='" + Log.log.u_id + "' and b_name like '%" + tstext_book.Text.Trim() +"%'";
                databind(sql);//传递sql语句
            }
        }

        //查询全部按钮的事件
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            //查询全部
            string sql = "select * from V_Borrow where u_id='" + Log.log.u_id + "'";
            databind(sql);//传递sql语句
        }

        //显示还书失败或审核中记录按钮事件
        private void ts_borrow_Click(object sender, EventArgs e)
        {
            //查询bo_eme=1或bo_eme=0的记录
            string sql = "select * from V_Borrow where bo_eme in (0,1,3) and u_id='" + Log.log.u_id + "'";
            databind(sql);//传递sql语句
        }

        //显示还书失败或审核中记录按钮事件
        private void tsbtn_borrowNo_Click(object sender, EventArgs e)
        {
            //查询bo_eme=1或bo_eme=2的记录
            string sql = "select * from V_Borrow where bo_eme in (1,3) and u_id='" + Log.log.u_id + "'";
            databind(sql);//传递sql语句
        }

        private void Dgv_borrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                DialogResult dialog;//获得对话框的用户所按的返回值
                if (e.RowIndex >= 0)
                {
                    string bo_renew = Dgv_borrow.Rows[e.RowIndex].Cells["Cl_renew"].Value.ToString();//获得续借资格值
                    string bo_id = Dgv_borrow.Rows[e.RowIndex].Cells["Cl_id"].Value.ToString();//获得借书编号
                    string bo_eme = Dgv_borrow.Rows[e.RowIndex].Cells["Cl_eme"].Value.ToString();//获得借书状态
                    string bo_emeover = Dgv_borrow.Rows[e.RowIndex].Cells["Cl_emeover"].Value.ToString();//获得是否逾期一栏的值
                    if (Dgv_borrow.Columns[e.ColumnIndex].Name == "Cl_Renewal")//续借按钮
                    {
                        if (bo_renew == "无")
                        {
                            dialog = MessageBox.Show("抱歉，你该图书的续借资格已经没有了", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        else if (bo_emeover == "已逾期")
                        {
                            //错误提示
                            dialog = MessageBox.Show("所续借图书已经逾期，无法续借！\n点击确认跳转到逾期界面", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            if (DialogResult.OK == dialog)
                            {
                                //点击确认按钮跳转到逾期记录
                                user_OverduePage user_Overdue = new user_OverduePage();//实例化逾期记录界面
                                user_Overdue.ShowDialog();//以对话模式显示
                                                          //查询全部，这里等于返回该界面刷新
                                string sql = "select * from V_Borrow where u_id='" + Log.log.u_id + "'";
                                databind(sql);//传递sql语句
                            }
                        }
                        else if (bo_emeover == "审核中")
                            dialog = MessageBox.Show("所续借图书正在审核中，无法续借", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (bo_emeover == "缴费审核中")
                            dialog = MessageBox.Show("所续借图书逾期缴费正在审核中，无法续借！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (bo_eme == "还书成功")
                            dialog = MessageBox.Show("所续借图书已经归还，无法续借！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (bo_eme == "审核中")
                            dialog = MessageBox.Show("所续借图书正在审核，无法续借！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            dialog = MessageBox.Show("确定续借7天？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (DialogResult.OK == dialog)
                            {
                                //创建sql语句
                                string sql = "update borrow set bo_rtnatl=dateadd(day,7,bo_rtnatl),bo_renew='1' where bo_id='" + bo_id + "'";
                                con = dButil.SqlOpen();//打开数据库
                                cmd = new SqlCommand(sql, con);//储存sql语句
                                int n = cmd.ExecuteNonQuery();//执行sql语句，返回受影响的行数赋值到n中，用于判断
                                con.Close();//关闭数据库
                                if (n > 0)//进行成功判断
                                {
                                    //成功提示
                                    MessageBox.Show("续借成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //查询全部，这里等于刷新
                                    sql = "select * from V_Borrow where u_id='" + Log.log.u_id + "'";
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
                    if (Dgv_borrow.Columns[e.ColumnIndex].Name == "Cl_operation")//还书按钮
                    {
                        if (bo_emeover == "已逾期")
                        {
                            //错误提示
                            dialog = MessageBox.Show("所还图书已经逾期，无法还书！\n点击确认跳转到逾期界面", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            if (DialogResult.OK == dialog)
                            {
                                //点击确认按钮跳转到逾期记录
                                user_OverduePage user_Overdue = new user_OverduePage();//实例化逾期记录界面
                                user_Overdue.ShowDialog();//以对话模式显示
                                                          //查询全部，这里等于返回该界面刷新
                                string sql = "select * from V_Borrow where u_id='" + Log.log.u_id + "'";
                                databind(sql);//传递sql语句
                            }
                        }
                        else if (bo_emeover == "缴费审核中")
                            dialog = MessageBox.Show("所续借图书逾期缴费正在审核中，无法还书！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (bo_emeover == "缴费审核未通过")//判断缴费
                            dialog = MessageBox.Show("所续借图书逾期缴费审核未通过，无法还书！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (bo_eme == "还书成功")//判断缴费
                            dialog = MessageBox.Show("该书已经归还，无法再次进行还书！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (bo_eme == "审核中")//判断缴费
                            dialog = MessageBox.Show("该书正在审核，请勿再次提交审核！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (bo_emeover == "还书失败")
                        {
                            //错误提示
                            dialog = MessageBox.Show("所还图书未通过审核，是否再次申请？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            if (DialogResult.OK == dialog)
                            {
                                //创建sql语句
                                string sql = "update borrow set bo_rtnatl=getdate(),bo_eme=1 where bo_id='" + bo_id + "'";
                                con = dButil.SqlOpen();//打开数据库
                                cmd = new SqlCommand(sql, con);//储存sql语句
                                int n = cmd.ExecuteNonQuery();//执行sql语句，返回受影响的行数赋值到n中，用于判断
                                con.Close();//关闭数据库
                                if (n > 0)//进行成功判断
                                {
                                    //成功提示
                                    MessageBox.Show("重新提交审核成功，请耐心等待管理员审核！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //查询全部，这里等于刷新
                                    sql = "select * from V_Borrow where u_id='" + Log.log.u_id + "'";
                                    databind(sql);//传递sql语句
                                }
                                else
                                {
                                    //失败提示
                                    MessageBox.Show("提交失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            dialog = MessageBox.Show("确定归还该书？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (DialogResult.OK == dialog)
                            {
                                //创建sql语句
                                string sql = "update borrow set bo_rtnatl=getdate(),bo_eme=1 where bo_id='" + bo_id + "'";
                                con = dButil.SqlOpen();//打开数据库
                                cmd = new SqlCommand(sql, con);//储存sql语句
                                int n = cmd.ExecuteNonQuery();//执行sql语句，返回受影响的行数赋值到n中，用于判断
                                con.Close();//关闭数据库
                                if (n > 0)//进行成功判断
                                {
                                    //成功提示
                                    MessageBox.Show("提交审核成功，请耐心等待管理员审核！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //查询全部，这里等于刷新
                                    sql = "select * from V_Borrow where u_id='" + Log.log.u_id + "'";
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
}
