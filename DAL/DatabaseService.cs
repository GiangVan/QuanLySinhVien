using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DatabaseService
    {
        const string serverName = "ADMIN-PC";
        const string databaseName = "QL_SinhVien";
        const string userName = "sa";
        const string password = "1296080612";
        public string stringConfig = "server=" + serverName + ";database=" + databaseName + ";uid=" + userName + ";pwd=" + password;
        public SqlConnection connection;
        public SqlCommand command;
        public DatabaseService()
        {
            connection = new SqlConnection(stringConfig);
        }
        public void OpenConnection()
        {
            if (connection != null && connection.State == ConnectionState.Closed)//5
                connection.Open();
        }
        public  void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }
        public SqlDataReader ReadData(string sql)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public bool WriteData(string sql, SqlParameter[] pars)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            command.Parameters.AddRange(pars);
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
    }
}
