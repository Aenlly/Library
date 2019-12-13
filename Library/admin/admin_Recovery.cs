using System;
using System.Collections;
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
    public partial class admin_Recovery : Form
    {
        public admin_Recovery()
        {
            InitializeComponent();
        }

        private void Btn_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                text_path.Text = openFileDialog1.FileName;//获得文件路径
            }
        }

        //还原方法
        private bool RestoreDatabase(string pathstr)
        {
            SqlConnection con = new SqlConnection
            {
                //连接master数据库而不是LibraryMS数据库
                ConnectionString = "Data Source=.;Initial Catalog=master;Integrated Security=sspi"
            };

            con.Open();//打开数据库

            //检查该还原数据库是否发生阻塞
            string sql = "select spid from sysprocesses ,sysdatabases where sysprocesses.dbid=sysdatabases.dbid and sysdatabases.Name='LibraryMS'";

            SqlCommand cmd1 = new SqlCommand(sql, con);//执行sql语句
            SqlDataReader dr;//创建dr读取
            //杀死进程
            ArrayList list = new ArrayList();//创建ArrayList储存值，后面一步步杀死进程

            try
            {
                dr = cmd1.ExecuteReader();//dr获得内容
                while (dr.Read())//一个个添加进入
                {
                    list.Add(dr.GetInt16(0));//填入ArrayList中
                }
                dr.Close();//关闭
            }
            catch (SqlException eee)
            {
                //失败异常
                MessageBox.Show(eee.ToString());
            }
            for (int i = 0; i < list.Count; i++)//一个个取出
            {
                cmd1 = new SqlCommand(string.Format("KILL {0}", list[i].ToString()), con);
                cmd1.ExecuteNonQuery();
            }

            //这里一定要是master数据库，而不能是要还原的数据库，因为这样便变成了有其它进程
            //占用了数据库。
            string BACKUP = String.Format("restore database LibraryMS  from DISK = '{0}' with replace", pathstr);//利用with replace来只覆盖该日志内容
            SqlCommand cmd = new SqlCommand(BACKUP, con);
            //异常处理
            try
            {
                cmd.ExecuteNonQuery();//返回执行影响消息
                return true;//返回true成功
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());//弹出异常错误信息
                return false;//返回false失败
                throw (ee);
            }
            finally
            {
                con.Close();//关闭数据库
            }
        }

        //确定按钮提示
        private void Btn_ok_Click(object sender, EventArgs e)
        {
            if (text_path.Text == "")
            {
                //警告提示
                MessageBox.Show("请先选择恢复文件!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //传递数据库文件路径，判断返回值
                if (RestoreDatabase(text_path.Text))
                {
                    //成功提示
                    MessageBox.Show("还原成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    //错误提示
                    MessageBox.Show("还原失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //取消按钮事件
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Close();//关闭窗体
        }
    }
}
