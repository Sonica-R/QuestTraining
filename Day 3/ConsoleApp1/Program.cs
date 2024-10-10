using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int sum = 0;
            //Console.WriteLine(numbers[0]);

            Console.WriteLine("Please enter five numbers");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Array datas are :");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(2 * array[i] + "");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2== 0)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine($"Sum of even numbers in array is {sum}");
            
        }
    }
}
