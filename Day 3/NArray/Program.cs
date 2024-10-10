using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data, index = 0;
            int[] arr = new int[0];
            if(arr.Length < 2)
            {
                Array.Resize(ref arr, arr.Length + 1);
                Console.WriteLine($"Enter the {arr.Length} number :");
                arr[index] = int.Parse(Console.ReadLine());
                index++;
            }
            

            Console.WriteLine("Enter the second number :");
            
            data = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("PLease enter a number or press q to exit");
                data = int.Parse(Console.ReadLine());
                if (data != 'q')
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    int arr[i] = int.Parse(Console.ReadLine());
                    i++;
                }
            }

        }
    }
}
