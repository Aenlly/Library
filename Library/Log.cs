using Library.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Library
{
    class Log
    {
        private string name,pwd;
        private Boolean boolean;

        DButil dButil = new DButil();
        SqlConnection con;
        public Log()
        {

        }

        public String Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public String Pwd
        {
            get { return pwd; }
            set { this.pwd = value; }
        }


        public bool EditPwd(String sql)
        {
            con = dButil.SqlOpen();
            int n;
            SqlCommand command = new SqlCommand(sql, con);
            n=command.ExecuteNonQuery();
            con.Close();
            if (n > 0)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// 进行学生判断
        /// 利用查询语句查询账号和密码返回值来进行button按钮中的账号，密码核对
        /// </summary>
        /// <param name="user">传递账号参数</param>
        /// <param name="pass">传递密码参数</param>
        /// <returns></returns>
        public bool Checkuser(String sql, string pwd)
        {
            
            SqlConnection con = dButil.SqlOpen();
            SqlCommand command = new SqlCommand(sql, con);//链接数据库进行执行
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["u_password"].Equals(pwd))//进行判断用户密码
                {
                    con.Close();
                    return true;//密码正确返回为真
                }

            }
            reader.Close();
            con.Close();
            return false;//密码错误返回为假
        }

        /// <summary>
        /// 进行管理员查询
        /// 利用查询语句查询账号和密码返回值来进行button按钮中的账号，密码核对
        /// </summary>
        /// <param name="user">传递账号参数</param>
        /// <param name="pass">传递密码参数</param>
        /// <returns></returns>
        public bool Checkadmin(String sql, string pwd)
        {
            con = dButil.SqlOpen();
            SqlCommand command = new SqlCommand(sql, con);//链接数据库进行执行
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["a_password"].Equals(pwd))//进行判断用户密码
                {
                    con.Close();
                    return true;//密码正确返回为真
                }

            }
            reader.Close();
            con.Close();
            return false;//密码错误返回为假
        }
    }
}
