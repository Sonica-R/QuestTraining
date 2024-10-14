using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int[] dupArr = new int[6];
            var elements = new int[] { 10, 2, 3, 4, 5 };
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Copy(dupArr, arr, 6);
            Console.WriteLine("Copied Array:");
            for (int j = 0; j < dupArr.Length; j++)
            {
                Console.WriteLine(dupArr[j]);
            }
            Array.Sort(arr);
            for (int j = 0; j < dupArr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Array.Reverse(arr);
            var desc = elements.OrderByDescending(x => x).ToArray();
            var text = "  Hello World  ";
            Console.WriteLine(text.Length);
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());

            Console.WriteLine(text.Trim());
            Console.WriteLine(text.TrimStart());

            Console.WriteLine(text.Replace(" ", "-"));
            Console.WriteLine(text.Remove(0, 7));

            Console.WriteLine(text.Contains("Hello"));

            Console.WriteLine(text.StartsWith("    "));
            Console.WriteLine(text.StartsWith("hello", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(text.EndsWith("d"));
            char[] chars = text.ToCharArray();
            Console.WriteLine(string.Join(",", chars));

            Console.WriteLine();
        }

    }
}
