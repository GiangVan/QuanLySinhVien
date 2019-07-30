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
        const string serverName = "GIANGVAN";
        const string databaseName = "Hutech_QLSV";
        const string userName = "user0";
        const string password = "123";
        public string stringConfig = "server=" + serverName + ";database=" + databaseName + ";uid=" + userName + ";pwd=" + password;
        public SqlConnection connection;
        public SqlCommand command;
        public DatabaseService()
        {
            connection = new SqlConnection(stringConfig);
        }
        public void OpenConnection()
        {
            if (connection != null && connection.State == ConnectionState.Closed)
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
    }
}
