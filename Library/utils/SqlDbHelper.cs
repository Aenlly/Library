using Library.utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Library
{
    class SqlDbHelper
    {
        DButil dButil = new DButil();
        SqlConnection con;//创建数据库连接对象

        /// <summary>
        /// 修改密码事件
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool EditPwd(String sql)
        {
            con = dButil.SqlOpen();//打开数据库
            int n;//定义个n判断
            SqlCommand command = new SqlCommand(sql, con);//查询传递过来的sql语句
            n = command.ExecuteNonQuery();//返回受影响的记录行
            con.Close();//关闭数据库
            if (n > 0)//判断是否存在受影响的行
            {
                return true;//返回true为修改成功
            }
            return false;//false为失败
        }


        /// <summary>
        /// 进行用户判断
        /// 利用查询语句查询账号和密码返回值来进行button按钮中的账号，密码核对
        /// </summary>
        /// <param name="user">传递账号参数</param>
        /// <param name="pass">传递密码参数</param>
        /// <returns></returns>
        public int Checkuser(String sql, string pwd)
        {

            con = dButil.SqlOpen();//打开数据库
            SqlCommand command = new SqlCommand(sql, con);//链接数据库进行执行
            SqlDataReader reader = command.ExecuteReader();//创建只读储存结果集
            while (reader.Read())//判断是否存在内容
            {
                if (reader["u_password"].Equals(pwd))//进行判断用户密码
                {
                    con.Close();//关闭数据库
                    return 2;//2代表密码正确
                }
                else
                {
                    con.Close();//关闭数据库
                    return 1;//1代表密码错误
                }
            }
            reader.Close();//关闭结果集
            con.Close();//关闭数据库
            return 0;//0代表账号错误
        }

        /// <summary>
        /// 进行管理员查询
        /// 利用查询语句查询账号和密码返回值来进行button按钮中的账号，密码核对
        /// </summary>
        /// <param name="user">传递账号参数</param>
        /// <param name="pass">传递密码参数</param>
        /// <returns></returns>
        public int Checkadmin(String sql, string pwd)
        {
            con = dButil.SqlOpen();
            SqlCommand command = new SqlCommand(sql, con);//链接数据库进行执行
            SqlDataReader reader = command.ExecuteReader();//创建只读储存结果集
            while (reader.Read())//判断是否存在内容
            {
                if (reader["a_password"].Equals(pwd))//进行判断用户密码
                {
                    con.Close();//关闭数据库
                    return 2; //2代表密码正确
                }
                {
                    con.Close();//关闭数据库
                    return 1;//1代表密码错误
                }
            }
            reader.Close();//关闭结果集
            con.Close();//关闭数据库
            return 0;//0代表账号错误
        }

        //创建身份证判断
        public int Checkcard(String sql, string card)
        {
            con = dButil.SqlOpen();//打开数据库
            SqlCommand command = new SqlCommand(sql, con);//查询sql语句
            SqlDataReader reader = command.ExecuteReader();//创建只读储存结果集
            while (reader.Read())//判断是否存在内容
            {
                if (reader["u_card"].Equals(card))//进行传递的身份证与数据库内的身份证进行对比
                {
                    con.Close();//关闭数据库
                    return 2;//身份证、账号正确
                }
                else
                {
                    con.Close();//关闭数据库
                    return 1;//身份证错误
                }
            }
            con.Close();//关闭数据库
            return 0;//账号不存在
        }

        //添加操作记录方法
        public void Operation(string ort)
        {
            //添加操作记录的sql语句
            string sql = "insert operation(o_ort,o_time) values ('"+ort+"',getdate())";
            con = dButil.SqlOpen();//打开数据库
            SqlCommand cmd = new SqlCommand(sql, con);//执行sql语句
            int n=cmd.ExecuteNonQuery();//返回是否成功
            con.Close();//关闭数据库
        }
    }
}
