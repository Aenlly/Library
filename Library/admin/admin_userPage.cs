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
    public partial class admin_userPage : Form
    {
        public admin_userPage()
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
            Dgv_user.AutoGenerateColumns = false;//不自动生成列，从数据库可能取得很多列，使其不显示在DataGridView中
            con = dButil.SqlOpen();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();//ds初始化
            sda.Fill(ds);//把查询内容添加到ds中
            bindingSource1.DataSource = ds.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;//连接数据源
            Dgv_user.DataSource = bindingSource1;//导出到dataGridView1中显示并用下列代码对于列名  
            for (int i = 0; i < 9; i++)
            {
                Dgv_user.Columns[i].DataPropertyName = ds.Tables[0].Columns[i].ColumnName;
            }
            con.Close();
        }

        private void admin_userPage_Load(object sender, EventArgs e)
        {
            tscmb_type.Items.Add("学号");//添加学号
            tscmb_type.Items.Add("姓名");//添加姓名
            tscmb_type.Items.Add("身份证");//添加身份证
            tscmb_type.SelectedIndex = 0;//默认为学号查询
            //查询全部的sql语句
            string sql = "select u_id,u_name,u_sex,u_card,u_college,u_tel,u_position,u_book,u_overdue from [user]";
            databind(sql);//传递sql然后查询填充
        }

        //显示全部按钮
        private void ts_whole_Click(object sender, EventArgs e)
        {
            //查询全部的sql语句
            string sql = "select u_id,u_name,u_sex,u_card,u_college,u_tel,u_position,u_book,u_overdue from [user]";
            databind(sql);//传递sql然后查询填充
        }

        private void tsbtn_select_Click(object sender, EventArgs e)
        {
            //判断前面的查询类别选择，分别执行不同的查询语句
            if (tscmb_type.Text == "学号")
            {
                string sql = "select u_id,u_name,u_sex,u_card,u_college,u_tel,u_position,u_book,u_overdue from [user] where u_id like '%" + tstext.Text.Trim() + "%'";
                databind(sql);
            }
            else if (tscmb_type.Text == "姓名")
            {
                string sql = "select u_id,u_name,u_sex,u_card,u_college,u_tel,u_position,u_book,u_overdue from [user] where u_name like '%" + tstext.Text.Trim() + "%'";
                databind(sql);

            }
            else if(tscmb_type.Text=="身份证")
            {
                string sql = "select u_id,u_name,u_sex,u_card,u_college,u_tel,u_position,u_book,u_overdue from [user] where u_card like '%" + tstext.Text.Trim() + "%'";
                databind(sql);
            }
            //文本框内容为空则显示全部
            if(tstext.Text=="")
            {
                //查询全部的sql语句
                string sql = "select u_id,u_name,u_sex,u_card,u_college,u_tel,u_position,u_book,u_overdue from [user]";
                databind(sql);//传递sql然后查询填充
            }
        }

        //单击表格时的操作判断
        private void Dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//判断是否点击了表的内容而不是列标签
            {
                //判断是否点击了编辑按钮
                if (Dgv_user.Columns[e.ColumnIndex].Name == "Cl_edit")
                {
                    admin_userEdit admin_UserEdit = new admin_userEdit();//实例化编辑界面
                    Log.log.user_id = Dgv_user.Rows[e.RowIndex].Cells["Cl_id"].Value.ToString();//把当前列的id传递到log类中
                    admin_UserEdit.ShowDialog();//显示编辑界面
                                                //查询全部的sql语句,实现刷新
                    string sql = "select u_id,u_name,u_sex,u_card,u_college,u_tel,u_position,u_book,u_overdue from [user]";
                    databind(sql);//传递sql然后查询填充
                }
                //单击了Schumacher按钮
                if (Dgv_user.Columns[e.ColumnIndex].Name == "Cl_delete")
                {
                    //弹窗提示
                    DialogResult dialog = MessageBox.Show("确认删除用户" + Dgv_user.Rows[e.RowIndex].Cells["Cl_id"].Value.ToString() + "?  删除后不可还原！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)//点击了确定，执行删除语句
                    {
                        string sql = "delete from [user] where u_id='" + Dgv_user.Rows[e.RowIndex].Cells["Cl_id"].Value.ToString() + "'";
                        con = dButil.SqlOpen();
                        cmd = new SqlCommand(sql, con);//执行删除语句
                        int n = cmd.ExecuteNonQuery();//返回执行影响的行数，判断是否删除了内容
                        con.Close();
                        if (n > 0)//大于0删除了内容
                        {
                            //成功提示
                            MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //查询全部的sql语句,实现刷新
                            sql = "select u_id,u_name,u_sex,u_card,u_college,u_tel,u_position,u_book,u_overdue from [user]";
                            databind(sql);//传递sql然后查询填充
                        }
                        //失败提示
                        else MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //添加用户按钮的显示事件
        private void tsbtn_add_Click(object sender, EventArgs e)
        {
            admin_userAdd userAdd = new admin_userAdd();
            userAdd.ShowDialog();
            //查询全部的sql语句,实现刷新
            string sql = "select u_id,u_name,u_sex,u_card,u_college,u_tel,u_position,u_book,u_overdue from [user]";
            databind(sql);//传递sql然后查询填充
        }
    }
}
