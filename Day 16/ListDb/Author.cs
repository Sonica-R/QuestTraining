using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDb
{
    internal class Author
    {   
        static void Main(string[] args)
        {
            var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sonic\OneDrive\Documents\QuestDb.mdf;Integrated Security=True;Connect Timeout=30";
            var conn = new SqlConnection(connStr);
            //conn.Open();
            


            /*var createTableQuery = @"CREATE TABLE AUTHORS(
                                     Id INT IDENTITY(1, 1) PRIMARY KEY,
                                     Name VARCHAR(30),
                                     Country VARCHAR(30))";
            var command = new SqlCommand(createTableQuery, conn);
            command.ExecuteNonQuery();
            conn.Close();*/
            var authors = new List<Authors>()
            {
                new Authors()
                {
                    Name = "J.K. Rowling",
                    Country = "United Kingdom"
                },
                new Authors()
                {
                    Name = "George R.R. Martin",
                    Country = "United States"
                },
                new Authors()
                {
                    Name = "Haruki Murakami",
                    Country = "Japan"
                }
            };

            using (var conn2 = new SqlConnection(connStr))
            {
                conn2.Open();
                foreach (var item in authors)
                {
                    var insert = @"INSERT INTO AUTHORS (Name, Country) VALUES
                                    (@Name, @Country)";
                    using(var command2 = new SqlCommand(insert, conn2))
                    {
                        command2.Parameters.AddWithValue("@Name", item.Name);
                        command2.Parameters.AddWithValue("@Country", item.Country);
                        command2.ExecuteNonQuery();
                    }
                }
                Console.WriteLine("Successfull");
            }
            //conn.Open();
            //conn.Close();*/

        }
    }
}
