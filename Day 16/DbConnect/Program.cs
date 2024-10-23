using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace BooksDb
{
    public class Books
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // List of books to insert
            var list = new List<Books>()
            {
                new Books {  Name = "Book1", Author = "Author 1", Price = 2000 },
                new Books {  Name = "Book3", Author = "Author 3", Price = 150 },
                new Books {  Name = "Book5", Author = "Author 5", Price = 250 },
                new Books {  Name = "Book7", Author = "Author 7", Price = 300 },
                new Books {  Name = "Book9", Author = "Author 9", Price = 500 },
            };

            //var createTableQuery = @"
            //CREATE TABLE BOOKS (
            //id INT IDENTITY(1, 1) PRIMARY KEY, 
            //name VARCHAR(50), 
            //author VARCHAR(50), 
            //price INT
            //)";

            // Connection string to your local database
            var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\sonic\OneDrive\Documents\QuestDb.mdf; Integrated Security=True; Connect Timeout=30";
            //var conn = new SqlConnection(connStr);
            //conn.Open();
            // Open a connection to the database
            using (var connect = new SqlConnection(connStr))
            {
                connect.Open(); // Open the connection

                // Insert each book in the list into the Books table
                foreach (var item in list)
                {
                    var insertQ = "INSERT INTO Books(name, author, price) VALUES(@name, @author, @price)";
                    using (var command = new SqlCommand(insertQ, connect))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@name", item.Name);
                        command.Parameters.AddWithValue("@author", item.Author);
                        command.Parameters.AddWithValue("@price", item.Price);

                        // Execute the query to insert the data
                        command.ExecuteNonQuery();
                    }
                } 
            } 
            Console.WriteLine("Books inserted successfully.");
        }
    }
}

