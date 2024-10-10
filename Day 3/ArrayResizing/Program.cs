using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayResizing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            Array.Resize(ref arr, arr.Length * 2);
            arr[3] = 4;
            arr[4] = 5;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]); //Here 6th element will be 0
            }

        }
    }
}
