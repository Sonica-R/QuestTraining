using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[6];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());  
            }

            int[] reversedArray = new int[6];
            Console.WriteLine("Reversed array");
            for(int j = 0; j < arr.Length; j++ )
            {
                reversedArray[j] = arr[arr.Length - 1 - j];             
                Console.WriteLine(reversedArray[j]);
            }
        }
    }
}
