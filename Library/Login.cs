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

namespace Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DButil dButil = new DButil();

        private void btn_dl_Click(object sender, EventArgs e)
        {
            String name=txt_name.Text.Trim();
            String password = txt_pass.Text.Trim();

            //以下用来判断学生是否为正式用户
            SqlConnection con = dButil.SqlOpen();
            SqlCommand com = new SqlCommand("select * from readers where r_id='" + txt_name.Text + "'", con);
            SqlDataAdapter dt = new SqlDataAdapter(com);   //
            DataSet ds = new DataSet();
            dt.Fill(ds);//调用，验证账号是否存在



            //判断管理员账号是否存在
            SqlCommand Man = new SqlCommand("select * from admin where a_name='" + txt_name.Text + "'", con);
            SqlDataAdapter man = new SqlDataAdapter(Man);
            DataSet Ma = new DataSet();
            man.Fill(Ma);//调用，验证账号是否存在


            //Log.log.value = txt_name.Text;  //TextBox1.Text储存到Log.cs中，再把数值传递到其他传统中
            //Log.log.comboBox = comboBox1.Text;

            if (txt_name.Text.Equals(""))
            {
                MessageBox.Show("用户名不能为空", "提示错误");
                txt_name.Focus();//输入光标移至用户框
                return;
            }
            if (txt_pass.Text == "")
            {
                MessageBox.Show("密码不能为空");//输入光标移至密码框
                txt_pass.Focus();
            }

            else
            {
                //判断登录方式是否为用户
                if (cmb_1.SelectedIndex==0)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show(this, "该账号或密码错误\n\r或登录方式错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txt_name.Focus();
                    }
                    else
                    {
                        SqlCommand comm = new SqlCommand("" + "" + txt_name.Text + "", con);
                        SqlParameter parm = new SqlParameter();  //这几条注释的是用来判断数据库中是否为正式用户
                        parm.ParameterName = "@stu_mem";         //储存至stu_mem字段中
                        parm.Value = "01";                       //
                        comm.Parameters.Add(parm);                //
                        comm.ExecuteNonQuery();                   //

                        SqlDataAdapter dj = new SqlDataAdapter(comm);
                        dj.Fill(ds, "dbo.Log_Stu");
                        DataTable da = ds.Tables[0];
                        string Member = da.Rows[0]["Member"].ToString().Trim();  //利用参数来储存查询中的值，然后再进行下面的判断


                        if (Checkuser(txt_name.Text.Trim(), txt_pass.Text.Trim()))
                        {
                            user.user_home user_Home = new user.user_home();//窗体实例化
                            user_Home.Activate();
                            user_Home.Show();// 显示窗体
                            this.Visible = false;  // 当前窗体不可见
                        }
                        else
                        {
                            MessageBox.Show("密码错误", "提示");
                            txt_pass.Focus();//清空密码文本框控件
                            txt_pass.SelectAll();//取得密码文本框焦点
                        }
                    }
                }

                //判断登录方式是否为管理员
                else if (cmb_1.SelectedIndex==1)
                {
                   if (Ma.Tables[0].Rows.Count == 0)//账号判断是否为空
                    {
                        MessageBox.Show(this, "该账号或密码错误\n\r或登录方式错误", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else if (CheckAdmin(txt_name.Text.Trim(), txt_pass.Text.Trim()))//传递参数至方法中进行真假判断
                    {
                        admin.admin_home admin_Home = new admin.admin_home();//窗体实例化
                        admin_Home.Show();//转到管理员的界面
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(this, "密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txt_pass.Focus();//清空密码文本框控件
                        txt_pass.SelectAll();//取得密码文本框焦点
                    }
                }
            }

        }

        /// <summary>
        ///进行管理员判断
        /// 利用查询语句查询账号和密码返回值来进行button按钮中的账号，密码核对
        /// </summary>
        /// <param name="admin">传递账号参数</param>
        /// <param name="pass">传递密码参数</param>
        /// <returns></returns>
        public bool CheckAdmin(string admin, string pass)
        {
            SqlConnection con = dButil.SqlOpen();
            string Man = "SELECT a_password FROM admin where a_name='" + admin + "'";//执行管理员查询语句
            SqlCommand command = new SqlCommand(Man, con);//链接数据库进行执行
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["a_password"].Equals(pass))
                {
                    con.Close();
                    return true;
                }
            }
            reader.Close();
            con.Close();
            return false;
        }

        /// <summary>
        /// 进行学生判断
        /// 利用查询语句查询账号和密码返回值来进行button按钮中的账号，密码核对
        /// </summary>
        /// <param name="user">传递账号参数</param>
        /// <param name="pass">传递密码参数</param>
        /// <returns></returns>
        public bool Checkuser(string user, string pass)
        {
            SqlConnection con = dButil.SqlOpen();
            string Tea = "SELECT r_password FROM readers where r_id='" + user + "';";//sql语句，查询用户账号
            SqlCommand command = new SqlCommand(Tea, con);//链接数据库进行执行
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["r_password"].Equals(pass))//进行判断用户密码
                {
                    con.Close();
                    return true;//密码真确返回为真
                }

            }
            reader.Close();
            con.Close();
            return false;//密码错误返回为假
        }

        /// <summary>
        /// 忘记密码按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            cmb_1.Items.Add("用户");//添加用户选项
            cmb_1.Items.Add("管理员");//添加管理员选项
            cmb_1.SelectedIndex = 0;//使用户为默认选项
        }
    }
}
