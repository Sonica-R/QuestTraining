using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int num =int.Parse(Console.ReadLine());
            Console.WriteLine(num.IsEvenOrOdd());
        }
    }
}
