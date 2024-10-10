using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAdjacentSwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            int n = int.Parse(Console.ReadLine());
            int [] arr = new int[n];
            int[] swap = new int[n];
            int len = arr.Length;
            int mid = arr.Length / 2;

            Console.WriteLine("Enter array elements :");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            if ((len % 2 != 0))
            {
                for (int i = 0; i < mid; i += 2)
                {
                    int temp;
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
                for (int j = mid + 1; j < len; j += 2)
                {
                    int temp;
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
                Console.WriteLine("Swapped array :");
                for (int k = 0; k < len; k++)
                {
                    Console.WriteLine(arr[k]);
                }
            }

            else
            {


                //for (int j = 0; j < len; j += 2)
                //{
                //    int temp;
                //    temp = arr[j];
                //    arr[j] = arr[j + 1];
                //    arr[j + 1] = temp;
                //}
                //Console.WriteLine("Swapped array :");
                //for (int k = 0; k < len; k++)
                //{
                //    Console.WriteLine(arr[k]);
                //}

            }
        }
        
    }
}
