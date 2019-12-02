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
    public partial class admin_OverduePage : Form
    {
        public admin_OverduePage()
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
            Dgv_overdue.AutoGenerateColumns = false;//不自动生成列，从数据库可能取得很多列，使其不显示在DataGridView中
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);//储存需要执行的语句
            sda = new SqlDataAdapter(cmd);//创建适配器实例，并执行查询
            ds = new DataSet();//ds初始化
            sda.Fill(ds);//把查询内容添加到ds中
            bindingSource1.DataSource = ds.Tables[0];//获取数据源到bindingSource1中
            bindingNavigator1.BindingSource = bindingSource1;//连接数据源
            Dgv_overdue.DataSource = bindingSource1;//导出到dataGridView1中显示并用下列代码对于列名 
            for (int i = 0; i < 8; i++)//循环添加到表中
            {
                Dgv_overdue.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            }
            con.Close();
        }

        //窗体加载
        private void admin_OverduePage_Load(object sender, EventArgs e)
        {
            //加载该窗体时执行sql更新语句方法，实时更新逾期天数,要求：必须是未还书或者是还书失败，以及已逾期或逾期审核不通过的用户
            string sql_ovup = "update borrow set bo_dayover=datediff(day,bo_return,getdate()) where bo_emeover=1 or bo_emeover=4  and bo_eme=0 or bo_eme=3";
            con = dButil.SqlOpen();//打开数据库
            cmd = new SqlCommand(sql_ovup, con);//储存需要执行的sql语句
            cmd.ExecuteNonQuery();//执行语句
            con.Close();//关闭数据库

            //查询语句
            string sql = "select bo_id,u_name,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '待审核' when 3 then '已缴费' else '审核不通过' end from borrow,[user],[books] where borrow.u_id=[user].u_id and borrow.b_id=books.b_id and bo_emeover!=0";
            databind(sql);//传递语句填充到表格中
        }

        //表格内的单击事件
        private void Dgv_overdue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //判断是否点击了列的内容
            if (e.RowIndex >= 0)
            {
                //判断单击了操作审核通过的按钮
                if (Dgv_overdue.Columns[e.ColumnIndex].Name == "Cl_examine")
                {
                    //获得状态一栏的值
                    string bo_state = Dgv_overdue.Rows[e.RowIndex].Cells["Cl_state"].Value.ToString();
                    if (bo_state == "未缴费")//判断是未缴费用户
                    {
                        //提示
                        MessageBox.Show("用户未缴费！无法进行通过审核！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (bo_state == "已缴费")
                    {
                        //提示
                        MessageBox.Show("用户已缴费无需再次通过审核！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (bo_state == "审核不通过")
                    {
                        //提示
                        MessageBox.Show("用户审核未通过并未再次申请，无法通过！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //弹窗询问，并获取返回值
                        DialogResult dialog = MessageBox.Show("确认通过逾期缴费审核？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (DialogResult.OK == dialog)//判断是否点击了确认按钮
                        {
                            //获取借书编号
                            string bo_id = Dgv_overdue.Rows[e.RowIndex].Cells["Cl_id"].Value.ToString();
                            //获取借书人
                            string u_name = Dgv_overdue.Rows[e.RowIndex].Cells["Cl_name"].Value.ToString();
                            //创建sql更新语句
                            string sql = "update borrow set bo_emeover=3 where bo_id=" + bo_id + "";
                            //打开数据库
                            con = dButil.SqlOpen();
                            //储存需要执行的语句
                            cmd = new SqlCommand(sql, con);
                            //获取受影响的行数，执行sql语句
                            int n = cmd.ExecuteNonQuery();
                            //判断是否成功
                            if (n > 0)
                            {
                                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                dbHelper.Operation(u_name+"的缴费审核已通过");//插入操作记录

                                //成功提示
                                MessageBox.Show("用户：" + u_name + "的缴费审核通过！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //执行查询语句刷新
                                sql = "select bo_id,u_name,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '待审核' when 3 then '已缴费' else '审核不通过' end from borrow,[user],[books] where borrow.u_id=[user].u_id and borrow.b_id=books.b_id and bo_emeover!=0";
                                databind(sql);//传递语句填充到表格中
                            }
                            else
                            {
                                //失败提示
                                MessageBox.Show("通过失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                if (Dgv_overdue.Columns[e.ColumnIndex].Name == "Cl_examineNo")
                {
                    //获得状态一栏的值
                    string bo_state = Dgv_overdue.Rows[e.RowIndex].Cells["Cl_state"].Value.ToString();
                    if (bo_state == "已缴费")
                    {
                        //提示
                        MessageBox.Show("用户已缴费无法执行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (bo_state == "审核不通过")
                    {
                        //提示
                        MessageBox.Show("用户已未重新申请审核，无法再次不通过！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //弹窗询问，并获取返回值
                        DialogResult dialog = MessageBox.Show("确认不通过该用户的逾期缴费审核？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (DialogResult.OK == dialog)//判断是否点击了确认按钮
                        {
                            //获取借书编号
                            string bo_id = Dgv_overdue.Rows[e.RowIndex].Cells["Cl_id"].Value.ToString();
                            //获取借书人
                            string u_name = Dgv_overdue.Rows[e.RowIndex].Cells["Cl_name"].Value.ToString();
                            //创建sql更新语句
                            string sql = "update borrow set bo_emeover=4 where bo_id=" + bo_id + "";
                            //打开数据库
                            con = dButil.SqlOpen();
                            //储存sql语句
                            cmd = new SqlCommand(sql, con);
                            //执行sql语句，获取受影响的行数
                            int n = cmd.ExecuteNonQuery();
                            //判断是否成功
                            if (n > 0)
                            {
                                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                                dbHelper.Operation("不通过"+ u_name+ "的缴费审核");//插入操作记录

                                //成功提示
                                MessageBox.Show("用户：" + u_name + "的缴费审核已不通过！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //执行查询语句刷新
                                sql = "select bo_id,u_name,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '待审核' when 3 then '已缴费' else '审核不通过' end from borrow,[user],[books] where borrow.u_id=[user].u_id and borrow.b_id=books.b_id and bo_emeover!=0";
                                databind(sql);//传递语句填充到表格中
                            }
                            else
                            {
                                //失败提示
                                MessageBox.Show("操作失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
            }
        }

        //查询按钮的单击事件
        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            if (tstext_name.Text.Trim() == "")
            {
                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                dbHelper.Operation("查询全部数据记录");//插入操作记录

                //执行全部查询语句
                string sql = "select bo_id,u_name,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '待审核' when 3 then '已缴费' else '审核不通过' end from borrow,[user],[books] where borrow.u_id=[user].u_id and borrow.b_id=books.b_id and bo_emeover!=0";
                databind(sql);//传递语句填充到表格中
            }
            else
            {
                SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
                dbHelper.Operation("查询借书人为："+ tstext_name.Text.Trim()+ "记录");//插入操作记录

                //执行查询借书人语句
                string sql = "select bo_id,u_name,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '待审核' when 3 then '已缴费' else '审核不通过' end from borrow,[user],[books] where borrow.u_id=[user].u_id and borrow.b_id=books.b_id and bo_emeover!=0 and u_name like '%" + tstext_name.Text.Trim() + "%'";
                databind(sql);//传递语句填充到表格中
            }
        }

        //显示全部按钮单击事件
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询全部数据记录");//插入操作记录

            //执行全部查询语句
            string sql = "select bo_id,u_name,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '待审核' when 3 then '已缴费' else '审核不通过' end from borrow,[user],[books] where borrow.u_id=[user].u_id and borrow.b_id=books.b_id and bo_emeover!=0";
            databind(sql);//传递语句填充到表格中
        }

        //显示未缴费用户按钮单击事件
        private void tsbtn_no_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询未缴费用户数据记录");//插入操作记录

            //执行未缴费用户查询语句
            string sql = "select bo_id,u_name,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '待审核' when 3 then '已缴费' else '审核不通过' end from borrow,[user],[books] where borrow.u_id=[user].u_id and borrow.b_id=books.b_id and bo_emeover=1";
            databind(sql);//传递语句填充到表格中
        }

        //显示待审核用户按钮的单击事件
        private void tsbtn_examine_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询待审核用户数据记录");//插入操作记录

            //执行待审核用户查询语句
            string sql = "select bo_id,u_name,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '待审核' when 3 then '已缴费' else '审核不通过' end from borrow,[user],[books] where borrow.u_id=[user].u_id and borrow.b_id=books.b_id and bo_emeover=2";
            databind(sql);//传递语句填充到表格中
        }

        //显示已缴费用户按钮的单击事件
        private void tsbtn_yes_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询已缴费用户数据记录");//插入操作记录

            //执行已缴费用户查询语句
            string sql = "select bo_id,u_name,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '待审核' when 3 then '已缴费' else '审核不通过' end from borrow,[user],[books] where borrow.u_id=[user].u_id and borrow.b_id=books.b_id and bo_emeover=3";
            databind(sql);//传递语句填充到表格中
        }

        //显示未通过用户按钮的单击事件
        private void tsbtn_nopass_Click(object sender, EventArgs e)
        {
            SqlDbHelper dbHelper = new SqlDbHelper();//实例化SqlDbHelper类
            dbHelper.Operation("查询未通过用户数据记录");//插入操作记录

            //执行未通过用户查询语句
            string sql = "select bo_id,u_name,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '待审核' when 3 then '已缴费' else '审核不通过' end from borrow,[user],[books] where borrow.u_id=[user].u_id and borrow.b_id=books.b_id and bo_emeover=4";
            databind(sql);//传递语句填充到表格中
        }
    }
}
