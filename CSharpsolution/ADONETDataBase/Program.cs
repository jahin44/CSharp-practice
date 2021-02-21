using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace ADONETDataBase
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=DESKTOP-9UKEJ28\\SQLEXPRESS;Database=CSharpData;User Id = admin; Password=123456;";
        static void Main(string[] args)               
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            var insert = "insert into Student (Name,DathOfBath,Address) values('maream','3/3/20','Dhaka' )";

            SqlCommand command = new SqlCommand(insert, connection);
            command.ExecuteNonQuery();
            connection.Close();
            command.Dispose();
            connection.Dispose();
        }
    }
}
