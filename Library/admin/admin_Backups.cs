using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library.utils;

namespace Library.admin
{
    public partial class admin_Backups : Form
    {
        public admin_Backups()
        {
            InitializeComponent();
        }

        SqlConnection con;
        string path = "";//储存文件名

        //数据库备份方法，传递路径过来
        public bool DataBakeup(string path)
        {
            con = new DButil().SqlOpen();//打开数据库
            string backupstr = "backup database LibraryMS to disk='" + path + "';";//数据库备份语句

            SqlCommand command = new SqlCommand(backupstr, con);//执行
            try//异常处理
            {
                command.ExecuteNonQuery();//是否执行成功
                return true;//返回成功
            }
            catch (Exception ex)//执行发生错误则执行下列语句
            {
                MessageBox.Show(ex.ToString());//弹出异常错误信息
                return false;//返回false失败
            }
            finally//无论是否发生错误都执行以下方法
            {
                con.Close();//数据库关闭
                con.Dispose();//释放数据库资源
            }
        }

        //确认按钮事件
        private void Btn_ok_Click(object sender, EventArgs e)
        {
            if (path == "" || text_path.Text == "")//判断是否选择了路径
            {
                //错误提示
                MessageBox.Show("请先选择备份路径!","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (DataBakeup(path))
                    MessageBox.Show("备份成功!", "提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    MessageBox.Show("备份失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //浏览按钮事件
        private void Btn_browse_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)//点击了选择路径中的确认
            {
                path = saveFileDialog1.FileName;//获得文件路径
                text_path.Text = path;//显示在文本框中
            }
        }

        //取消按钮事件
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Close();//关闭当前窗体
        }
    }
}
