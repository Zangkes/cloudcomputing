using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @" Data Source=DESKTOP-02NO87R; Initial Catalog=登录表; Integrated Security=True";//数据库连接字符串
            sc = new SqlConnection(str);//创建数据库连接对象
            sc.Open();//打开数据库
            return sc;//返回数据库连接对象
        }


        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }

        public int Execute(string sql)//更新操作
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)//读取操作
        {
            Console.WriteLine(sql);
            Console.WriteLine("\n\n\n\n\n");
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();//关闭数据库连接
        }
    }
}
