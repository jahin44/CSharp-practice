using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace ADONETDataBase
{
    class Program
    {
       // private const string CONNECTION_STRING = "Server=DESKTOP-9UKEJ28\\SQLEXPRESS;Database=CSharpData;User Id = admin; Password=123456;";
        static void Main(string[] args)               
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            // RunInsertCommand(connection);
            // RunReadExecution(connection);
           // DataTableReadExample(connection);

        }

            private static void CommandExexution(SqlConnection connection,string commandText,Dictionary<string,object> values)
        {
            connection.Open();


            SqlCommand command = new SqlCommand(commandText, connection);
            foreach(var itam in values)
            {
                command.Parameters.AddWithValue(itam.Key, itam.Value);
            }

            command.ExecuteNonQuery();
            connection.Close();
            command.Dispose();
            connection.Dispose(); 

        }
            private static void RunInsertCommand(SqlConnection connection)
        {
            var name = Console.ReadLine();
            var dob = Console.ReadLine();
            var address = Console.ReadLine();

            var insert = "insert into Student (Name,DathOfBirth,Address) values(@Name,@DOB,@Address )";
            CommandExexution(connection, insert, new Dictionary<string, object>
            {   {"@Name",name},
                {"@DOB",DateTime.Parse(dob) },
                {"@Address", address}

            });

        }
        
         private static void RunReadExecution(SqlConnection connection)
        {
            var selectText = "Select * from Student";
            ReadExecution(connection, selectText);
        }
        private static void ReadExecution(SqlConnection connection,string commandText)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(commandText, connection);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var name = (string)reader["Name"];
                var dob = (DateTime)reader["DathOfBirth"];
                var address = (string)reader["Address"];
                Console.WriteLine($"Name :{name},DOB:{dob},Address:{address}");

            }
            connection.Close();
            command.Dispose();
            connection.Dispose();


        }

        private static void DataTableReadExample(SqlConnection connection)
        {
            connection.Open();

            DataTable student = new DataTable("student");
            student.Columns.Add("Name", typeof(string));
            student.Columns.Add("DateOfBirth", typeof(DateTime));
            student.Columns.Add("Address", typeof(string));

            var selectText = "Select * from Student";

            SqlDataAdapter adapter = new SqlDataAdapter(selectText, connection);
            adapter.Fill(student);

            for (var i = 0; i < student.Rows.Count; i++)
            {
                var name = (string)student.Rows[i][0];
                var dob = (DateTime)student.Rows[i][1];      // DateTime not takeing as perameter fix it 
                var address = (string)student.Rows[i][2];

                Console.WriteLine($"Name: {name}, DOB: {dob}, Address: {address}");
            }

            adapter.Dispose();
        }


    }
}
