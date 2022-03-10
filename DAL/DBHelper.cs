using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBHelper
    {
        /// <summary>
        /// 保存数据库连接字符串
        /// </summary>
        private static string connStr;  //  private：私有访问，只限于本类成员访问，子类、实例都不能访问。  public：公有访问，不受任何限制。
        static DBHelper()
        {
            /*ConfiguraionManager     访问客户端配置文件（app.config）
             <!--配置连接字符串-->>
              <connenctionStrings> 
                     <add name="connStr" connectionString="server=qyxydn.cn:3306;database=xydata;uid=xydata;pwd=a123456"/>
              </connenctionStrings>
            Connectionstring         连接字符串  */
            connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        }
        /// <summary>
        /// 增删改数据库访问函数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public static int Update(string sql, SqlParameter[] sqlParameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql); //SqlCommand 执行数据库里的sql语句的一个类
                    //判断sqlParameters不为NULL的时候添加参数
                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                    }
                    return cmd.ExecuteNonQuery();//返回行数，大于0，就等于操作成功
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        /// <summary>
        /// 连接式查询数据库访问函数
        /// </summary>
        public static SqlDataReader Query(string sql, SqlParameter[] sqlParameters)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql);
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
