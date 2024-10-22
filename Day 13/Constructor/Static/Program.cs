using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        class Employee
        {
            public string Name { get; set; }
            public static string CompanyName { get; set; }

            public override string ToString()
            {
                return $"Name : {Name} Company Name : {CompanyName}";
            }
        }
        static void Main(string[] args)
        {
            Employee.CompanyName = "XYZ";
            Employee e1 = new Employee();
            e1.Name = "A";

            Employee e2 = new Employee();
            e2.Name = "B";
            Console.WriteLine(e1);
            Console.WriteLine(e2);

            Employee.CompanyName = "ABC";
            Console.WriteLine(e1);
            Console.WriteLine(e2);
        }
    }
}
