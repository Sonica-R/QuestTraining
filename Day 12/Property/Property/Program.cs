using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stud = new Student
            {
                Name = "New",

                Age = 21
            };

            Console.WriteLine(stud.Name);
            Console.WriteLine(stud.Age);
          
        }
    }
}
