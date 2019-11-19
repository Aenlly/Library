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
        public class log{

            public static string u_id;//登录传递的账号,即学号
            public static string pwd;//登录传递的密码

            public static string user_fid;//user_feedbackRecord界面传递的反馈编号

            public static string user_id;//admin_userpage界面传递过来的学号

            public static string b_name;//admin_bookpage界面传递的书名
            public static string b_isbn;//admin_bookpage界面传递的isbn编号
            public static string b_type;//admin_bookpage界面传递的类别
            public static string b_author;//admin_bookpage界面传递的作者
            public static string b_press;//admin_bookpage界面传递的出版社
            public static string b_time;//admin_bookpage界面传递的出版时间
            public static string b_price;//admin_bookpage界面传递的价格
            public static string b_stocks;//admin_bookpage界面传递的库存

            public static string f_id;//admin_feedbackpage界面传递的反馈编号
            public static string f_btn;//admin_feddbackpage界面中点击的查看还是回复
        }
    }
}
