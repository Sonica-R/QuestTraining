using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFunction
{
    internal class Program
    {
        static void Add(int num1, int num2)
        {
            int sum;
            sum = num1 + num2;
            Console.WriteLine($"Sum of the two numbers {sum}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers :");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Add(num1, num2);
        }
    }
}
