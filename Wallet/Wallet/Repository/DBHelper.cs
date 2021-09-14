using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Wallet.Repository
{
    public class DBHelper
    {
        private string connectionString;
        public static DBHelper instance = new DBHelper();

        private SqlConnection cnn;
        private SqlCommand cmd;
        
        private DBHelper()
        {
            connectionString = "Data Source=DESKTOP-JNO54S1\\SQLEXPRESS01;Database=WalletManagerDB;Integrated security=True;MultipleActiveResultSets=True";
        }

        public static DBHelper GetDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }


        public DataTable ConsultaSQL(string strSQL)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            DataTable dataTable = new DataTable();
            connection.ConnectionString = connectionString;
            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            dataTable.Load(command.ExecuteReader());
            this.CloseConnection(connection);
            return dataTable;

        }
        private void CloseConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public void Connect()
        {
            cnn = new SqlConnection();
            cmd = new SqlCommand();
            cnn.ConnectionString = connectionString;
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
        }
        public void CloseConnection()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

    }
}
