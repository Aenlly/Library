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

            public static String name;//登录传递的账号
            public static String pwd;//登录传递的密码
            public static string user_id;//admin_userpage界面传递过来的学号
        }
    }
}
