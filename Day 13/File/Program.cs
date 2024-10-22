using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"E:\LearnDir";
            //if (Directory.Exists(path))
            //{
            //    Console.WriteLine("Path exists");
            //}
            //else
            //{
            //    Console.WriteLine("Path does not exist");
            //}

            var FileName = "data.txt";
            var filePath = Path.Combine(path, FileName);

            File.Create(filePath);
            File.WriteAllText(filePath, "New file created");

            File.AppendAllText(filePath, "New file created");
            File.AppendAllText(filePath, "New file created");
            File.AppendAllText(filePath, "New file created");

            var content = File.ReadAllText(filePath);
            string[] contentLines = File.ReadAllLines(content);

            Console.WriteLine(contentLines);

        }
    }
}
