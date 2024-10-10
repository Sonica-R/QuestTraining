using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Q2
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            //Q3
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); 
                }
                Console.WriteLine();

            }
        }
    }
}
