using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        class SchoolStudent : IStudent
        {
            public string Name { get; set; }
            public const string SchoolName = "School X";

            public void Display()
            {
                Console.WriteLine($"Name : {Name}, School Name : {SchoolName}");
            }
        }
        static void Main(string[] args)
        {
            var students = new List<IStudent>()
            {
                new SchoolStudent
                {
                    Name = "Soni"
                }
            };
        }
    }
}

