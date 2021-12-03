using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;

namespace FlowerShop.method
{
    class SqlHelper
    {

        public static readonly string connStr = ConfigurationManager.ConnectionStrings["mssql"].ConnectionString;

        /// <summary>
        /// 连接获取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] parameter)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand(sql, conn);
            if (parameter != null)
            {
                comm.Parameters.AddRange(parameter);
            }
            conn.Open();
            //CommandBehavior.CloseConnection 当reader关闭时自动关闭对应的connection
            SqlDataReader reader = comm.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
        /// <summary>
        /// 断开时获取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static DataTable GetTable(string sql, params SqlParameter[] parameter)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr);
            DataTable dt = new DataTable();
            if (parameter != null)
            {
                adapter.SelectCommand.Parameters.AddRange(parameter);
            }
            adapter.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 获取单行数据的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static DataRow GetRow(string sql, params SqlParameter[] parameter)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr);
            DataTable dt = new DataTable();
            if (parameter != null)
            {
                adapter.SelectCommand.Parameters.AddRange(parameter);
            }
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }
        /// <summary>
        /// 获取单个数据的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] parameter)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand(sql, conn);
            if (parameter != null)
            {
                comm.Parameters.AddRange(parameter);
            }
            conn.Open();
            object obj = comm.ExecuteScalar();
            conn.Close();
            return obj;
        }
        /// <summary>
        /// 执行增加删除修改的sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static int ExecuteUpdate(string sql, params SqlParameter[] parameter)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand(sql, conn);
            if (parameter != null)
            {
                comm.Parameters.AddRange(parameter);
            }
            conn.Open();
            int ret = comm.ExecuteNonQuery();
            conn.Close();
            return ret;
        }
    }

}
