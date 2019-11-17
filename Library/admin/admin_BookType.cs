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
    public partial class admin_BookType : Form
    {
        public admin_BookType()
        {
            InitializeComponent();
        }


        private void btn_type_Click(object sender, EventArgs e)
        {
            if (text_type.Text.Trim() == "")
            {
                MessageBox.Show("类别不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con;
                DButil dButil = new DButil();
                con = dButil.SqlOpen();
                string sql = "insert into type values (null,'" + text_type.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    MessageBox.Show("添加类别:" + text_type.Text.Trim() + "成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加类别失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
