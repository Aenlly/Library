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
            cmd = new SqlCommand(sql, con);//执行sql语句
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
            //查询全部内容的语句
            string sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 0 then '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme<2";
            databind(sql);//传递sql语句进行查询
        }

        private void Dgv_borrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //获取还书状态的值
                string b_eme = Dgv_borrow.Rows[e.RowIndex].Cells["Cl_eme"].Value.ToString();
                //获取借书人的值
                string u_name = Dgv_borrow.Rows[e.RowIndex].Cells["Cl_uid"].Value.ToString();
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
                    }else
                    {
                        //提示，并获取单击的返回值
                        DialogResult dialog=MessageBox.Show("确认通过用户："+ u_name + "的还书申请？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        //判断单击了确认按钮
                        if (DialogResult.OK == dialog)
                        {
                            //sql语句，更新为还书成功，并添加还书时间
                            string sql = "update borrow set bo_eme=2,bo_rtnatl='" + DateTime.Now.ToString() + "' where bo_id='" + bo_id + "'";
                            con = dButil.SqlOpen();//打开数据库
                            cmd = new SqlCommand(sql, con);//执行sql语句
                            int n = cmd.ExecuteNonQuery();//返回影响行数，并赋值给n用作判断
                            con.Close();//关闭数据库
                            if (n > 0)//判断是否执行成功并修改
                            {
                                //成功提示
                                MessageBox.Show("已通过用户：" + u_name + "的还书申请！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //查询全部内容的语句，该处用于刷新表
                                sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 0 then '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme<2";
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
            }
        }

        //查询按钮的单击事件
        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            //判断查询输入文本框内的值是否未空，为空则查询全部
            if (tstext_name.Text.Trim() == "")
            {
                //查询全部内容的语句
                string sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 0 then '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme<2";
                databind(sql);//传递sql语句进行查询
            }
            else
            {
                //查询指定借书人的内容的语句，模糊查询
                string sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 0 then '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme<2 and [user].u_name like '%" + tstext_name.Text.Trim() + "%'";
                databind(sql);//传递sql语句进行查询
            }
        }

        //显示全部按钮的单击事件
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            //查询全部内容的语句
            string sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 0 then '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme<2";
            databind(sql);//传递sql语句进行查询
        }

        //显示未还书记录的按钮的单击事件
        private void tsbtn_nortn_Click(object sender, EventArgs e)
        {
            //查询全部内容的语句
            string sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 0 then '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme=0";
            databind(sql);//传递sql语句进行查询
        }

        //显示待审核记录的按钮的单击事件
        private void tsbtn_eme_Click(object sender, EventArgs e)
        {
            //查询全部内容的语句
            string sql = "select bo_id,[user].u_name,[books].b_name,bo_borrow,bo_rtnatl,bo_day,bo_renew=case bo_renew when 0 then '有' else '无' end,bo_eme=case bo_eme when 1 then '待审核' when 0 then '未申请' end from borrow,[books],[user] where [user].u_id=borrow.u_id and borrow.b_id=books.b_id and bo_emeover=0 and bo_eme=1";
            databind(sql);//传递sql语句进行查询
        }
    }
}
