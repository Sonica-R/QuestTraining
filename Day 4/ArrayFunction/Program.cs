using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayFunction
{
    internal class Program
    {
        static void Greet() // Function is made static as we are accesing t from a static main function
        {
            Console.WriteLine("Welcome to Day 4");
        }
        static void GreetByName(string fname, string lname)
        {
            Console.WriteLine($"Welcome {fname} {lname}");
        }
        static void GreetByName(string name1, string name2, string name3)
        {
            Console.WriteLine($"Welcome {name1}, {name2} and {name3}");
        }

        static void Main(string[] args)
        {
            Greet();
            GreetByName("Soni", "R");
            GreetByName("Adi", "Rinu", "Cyan"); //Method Overriding

        }
    }
}
