using System;
using System.Collections.Generic;
//using System.Data.OleDb;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
//using Microsoft.EntityFrameworkCore;
//using Pomelo.EntityFrameworkCore;


using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPCoreServer
{
    public class DB 
    {
        public static string connectString = "server=localhost;port=8889;user=root;password=root;database=db"; // строка для обеспечения соединения к базе данных
        MySqlConnection connection = new MySqlConnection(connectString); // создание соединения с базой данных

        // метод для открытия соединения с базой данных
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        // метод для закрытия соединения с базой данных
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        // метод для получения соединения с базой данных
        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}
