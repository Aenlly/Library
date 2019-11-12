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
    public partial class user_Return : Form
    {
        public user_Return()
        {
            InitializeComponent();
        }

        SqlConnection con;//创建数据库连接对象
        SqlCommand cmd;//创建执行的sql语句对象
        SqlDataAdapter sda;//创建数据库适配器对象
        DataSet ds;
        DButil dButil = new DButil();

        //填充表内容的databind方法
        public void databind(string sql, object sender, EventArgs e)
        {
            Dgv_return.AutoGenerateColumns = false;//不自动生成列，从数据库可能取得很多列，使其不显示在DataGridView中
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();//ds初始化
            sda.Fill(ds);//把查询内容添加到ds中
            Dgv_return.DataSource = ds.Tables[0];//导出到dataGridView1中显示并用下列代码对于列名     
            Dgv_return.Columns[0].DataPropertyName = ds.Tables[0].Columns[0].ColumnName;
            Dgv_return.Columns[1].DataPropertyName = ds.Tables[0].Columns[1].ColumnName;
            Dgv_return.Columns[2].DataPropertyName = ds.Tables[0].Columns[2].ColumnName;
            Dgv_return.Columns[3].DataPropertyName = ds.Tables[0].Columns[3].ColumnName;
            Dgv_return.Columns[4].DataPropertyName = ds.Tables[0].Columns[4].ColumnName;
            Dgv_return.Columns[5].DataPropertyName = ds.Tables[0].Columns[5].ColumnName;
            Dgv_return.Columns[6].DataPropertyName = ds.Tables[0].Columns[6].ColumnName;
            Dgv_return.Columns[7].DataPropertyName = ds.Tables[0].Columns[7].ColumnName;
            con.Close();
        }

        /// <summary>
        /// 绑定ToolStripComboBox 的操作
        /// </summary>
        /// <param name="sqltype">数据库语句</param>
        /// <param name="type">表名</param>
        /// <param name="t_name">字段名</param>
        public void BookType()
        {
            con = dButil.SqlOpen();
            //初始化，comboBox1绑定客户表
            string sqltype = "select t_name from [type]";//查询有多少类别
            sda = new SqlDataAdapter(sqltype, con);
            sda.Fill(ds,"type");//添加到ds缓存中
            tscmb_type.ComboBox.DataSource = ds.Tables["type"].DefaultView;//取出数据源填充到列表中
            tscmb_type.ComboBox.DisplayMember = "t_name";//列表中显示的值对应的字段名
        }

        //窗体初始化加载事件
        private void user_Return_Load(object sender, EventArgs e)
        {
            //查询全部的sql语句
            string sql = "select bo_id,[books].b_name,[type].t_name,bo_borrow,bo_rtnatl,bo_day,bo_renewday,bo_renew=case bo_renew when 0 then '未续借' else '已续借' end,bo_eme=case bo_eme when 2 then '还书成功' end from borrow,[books],[type] where borrow.a_id=books.b_id and books.t_id=[type].t_id and bo_eme=2 and u_id='"+Log.log.name+"'";
            databind(sql, sender, e);//传递sql语句过去，并填充数据到表格中
            BookType();//填充到类型下拉列表中
        }

        //还书记录窗体查询按钮
        private void tsbtn_return_Click(object sender, EventArgs e)
        {
            if ("".Equals(tsbtn_book.Text.Trim()))
            {
                //为空时显示全部
                string sql = "select bo_id,[books].b_name,[type].t_name,bo_borrow,bo_rtnatl,bo_day,bo_renewday,bo_renew=case bo_renew when 0 then '未续借' else '已续借' end,bo_eme=case bo_eme when 2 then '还书成功' end from borrow,[books],[type] where borrow.a_id=books.b_id and books.t_id=[type].t_id and bo_eme=2 and u_id='" + Log.log.name + "'";
                databind(sql, sender, e);//传递sql语句过去，并填充数据到表格中
            }
            else
            {
                //再进行判断类别选择
                if (tscmb_type.SelectedIndex != 0)//判断是否选中了全部类别
                {
                    //否则查询输入的内容
                    string sql = "select bo_id,[books].b_name,[type].t_name,bo_borrow,bo_rtnatl,bo_day,bo_renewday,bo_renew=case bo_renew when 0 then '未续借' else '已续借' end,bo_eme=case bo_eme when 2 then '还书成功' end from borrow,[books],[type] where borrow.a_id=books.b_id and books.t_id=[type].t_id and bo_eme=2 and u_id='" + Log.log.name + "' and [books].b_name like '%" + tsbtn_book.Text.Trim() + "%'";
                    databind(sql, sender, e);//传递sql语句过去，并填充数据到表格中
                }
                else
                {
                    //否则查询输入的内容
                    string sql = "select bo_id,[books].b_name,[type].t_name,bo_borrow,bo_rtnatl,bo_day,bo_renewday,bo_renew=case bo_renew when 0 then '未续借' else '已续借' end,bo_eme=case bo_eme when 2 then '还书成功' end from borrow,[books],[type] where borrow.a_id=books.b_id and books.t_id=[type].t_id and bo_eme=2 and u_id='" + Log.log.name + "' and [books].b_name like '%" + tsbtn_book.Text.Trim() + "%' and [type].t_name='"+tscmb_type.Text+"'";
                    databind(sql, sender, e);//传递sql语句过去，并填充数据到表格中
                }
            }
        }

        //选择下拉列表时的查询显示
        private void tscmb_type_DropDownClosed(object sender, EventArgs e)
        {
            if (tscmb_type.SelectedIndex != 0)//判断是否选中了全部类别
            {
                //查询sql语句
                string sql = "select bo_id,[books].b_name,[type].t_name,bo_borrow,bo_rtnatl,bo_day,bo_renewday,bo_renew=case bo_renew when 0 then '未续借' else '已续借' end,bo_eme=case bo_eme when 2 then '还书成功' end from borrow,[books],[type] where borrow.a_id=books.b_id and books.t_id=[type].t_id and bo_eme=2 and u_id='" + Log.log.name + "' and [books].b_name='" + tsbtn_book.Text.Trim() + "'";
                databind(sql, sender, e);//传递sql语句过去，并填充数据到表格中
            }
            else
            {
                //查询类别的sql语句
                string sql = "select bo_id,[books].b_name,[type].t_name,bo_borrow,bo_rtnatl,bo_day,bo_renewday,bo_renew=case bo_renew when 0 then '未续借' else '已续借' end,bo_eme=case bo_eme when 2 then '还书成功' end from borrow,[books],[type] where borrow.a_id=books.b_id and books.t_id=[type].t_id and bo_eme=2 and u_id='" + Log.log.name + "' and [type].t_name='" + tscmb_type.Text.Trim() + "'";
                databind(sql, sender, e);//传递sql语句过去，并填充数据到表格中
            }
        }

        //显示全部按钮查询事件
        private void tsbtn_whole_Click(object sender, EventArgs e)
        {
            //查询sql语句
            string sql = "select bo_id,[books].b_name,[type].t_name,bo_borrow,bo_rtnatl,bo_day,bo_renewday,bo_renew=case bo_renew when 0 then '未续借' else '已续借' end,bo_eme=case bo_eme when 2 then '还书成功' end from borrow,[books],[type] where borrow.a_id=books.b_id and books.t_id=[type].t_id and bo_eme=2 and u_id='" + Log.log.name + "' and [books].b_name='" + tsbtn_book.Text.Trim() + "'";
            databind(sql, sender, e);//传递sql语句过去，并填充数据到表格中
        }
    }
}
