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
    public partial class user_OverduePage : Form
    {
        public user_OverduePage()
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
            con = dButil.SqlOpen();//打开数据库
            cmd = new SqlCommand(sql, con);//执行sql语句
            sda = new SqlDataAdapter(cmd);//创建适配器
            ds = new DataSet();
            sda.Fill(ds);//把查询内容添加到ds中
            bindingSource1.DataSource = ds.Tables[0];//获得数据
            bindingNavigator1.BindingSource = bindingSource1;//连接数据源
            Dgv_overdue.DataSource = bindingSource1;//导出到dataGridView1中显示并用下列代码对于列名 
            for (int i = 0; i < 7; i++)
            {
                Dgv_overdue.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            }

            con.Close();//关闭数据库
        }

        private void user_OverduePage_Load(object sender, EventArgs e)
        {
            //加载该窗体时执行sql更新语句方法，实时更新逾期天数
            string sql_ovup = "update borrow set bo_dayover=datediff(day,bo_return,getdate()) where bo_emeover=1 or bo_emeover=4";
            con = dButil.SqlOpen();//打开数据库
            cmd = new SqlCommand(sql_ovup, con);//执行语句
            con.Close();//关闭数据库
            //执行查询全部语句
            string sql = "select bo_id,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '审核中' when 3 then '已缴费' else '审核不通过' end from borrow,[books] where borrow.b_id=books.b_id and bo_emeover!=0 and u_id='" + Log.log.u_id+"'";
            databind(sql);//传递语句填充到表格中
        }

        //查询按钮单击事件
        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            if (tstext_name.Text.Trim() == "")
            {
                //执行查询全部语句
                string sql = "select bo_id,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '审核中' when 3 then '已缴费' else '审核不通过' end from borrow,[books] where borrow.b_id=books.b_id and bo_emeover!=0 and u_id='" + Log.log.u_id + "'";
                databind(sql);//传递语句填充到表格中
            }
            else
            {
                //执行图书名称模糊查询
                string sql = "select bo_id,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '审核中' when 3 then '已缴费' else '审核不通过' end from borrow,[books] where borrow.b_id=books.b_id and bo_emeover!=0 and u_id='" + Log.log.u_id + "' and b_name like '%"+tstext_name.Text.Trim()"%'";
                databind(sql);//传递语句填充到表格中
            }
        }

        //显示全部按钮单击事件
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            //执行查询全部语句
            string sql = "select bo_id,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '审核中' when 3 then '已缴费' else '审核不通过' end from borrow,[books] where borrow.b_id=books.b_id and bo_emeover!=0 and u_id='" + Log.log.u_id + "'";
            databind(sql);//传递语句填充到表格中
        }

        private void Dgv_overdue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //判断是否点击了列的内容而不是标题，防止超出索引
            if (e.RowIndex >= 0)
            {
                string bo_id = Dgv_overdue.Rows[e.RowIndex].Cells["Cl_id"].Value.ToString();//获得借书编号
                string bo_state = Dgv_overdue.Rows[e.RowIndex].Cells["Cl_state"].Value.ToString();//获得逾期状态
                if(Dgv_overdue.Columns[e.ColumnIndex].Name== "Cl_examine")
                {
                    if (bo_state == "审核中")
                    {
                        MessageBox.Show("审核中，无法再次提交！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (bo_state == "已缴费")
                    {
                        MessageBox.Show("用户已缴费无法再次提交！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //获得弹窗按钮返回值
                        DialogResult dialog = MessageBox.Show("确认提交逾期审核？如未交逾期金额则会不通过", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        if (DialogResult.OK == dialog)//按下确认按钮
                        {
                            //sql更新语句
                            string sql = "update borrow set bo_emeover=2 where bo_id='" + bo_id + "'";
                            con = dButil.SqlOpen();//打开数据库
                            cmd = new SqlCommand(sql, con);//执行sql语句
                            int n = cmd.ExecuteNonQuery();//赋值受影响的行数到n上
                            con.Close();//关闭数据库
                            if (n > 0)
                            {
                                //成功提示
                                MessageBox.Show("提交审核成功！等待管理员审核中", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //执行查询全部语句，这里用做刷新
                                sql = "select bo_id,b_name,bo_borrow,bo_return,bo_dayover,bo_money=(bo_dayover*0.1),bo_emeover=case bo_emeover when 1 then '未缴费' when 2 then '待审核' when 3 then '已缴费' else '审核不通过' end from borrow,[books] where borrow.b_id=books.b_id and bo_emeover!=0 and u_id='" + Log.log.u_id + "'";
                                databind(sql);//传递语句填充到表格中
                            }
                            else
                            {
                                //失败提示
                                MessageBox.Show("提交审核失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
