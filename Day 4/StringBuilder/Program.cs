using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = "";
            res = string.Join(",", "Hello", "World");
            Console.WriteLine(res);

            res = string.Concat("1", "2", 3, true);
            Console.WriteLine(res);

            var concatArr = new string[] { "Hi", "From", "C#" };
            res = string.Format("{0}{1}{2}", concatArr);

            res = String.Format("{0} {1} {2}", "Hello", "c#", "world");
            Console.WriteLine(res);


            var sb = new StringBuilder();
            sb.AppendLine("Line 1");
            sb.AppendLine("Line 2");
            sb.Append("No new line");
            sb.Append(" Will be in same line");

            var text = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //sb.AppendFormat(

            foreach (var item in text)
            {
                sb.AppendFormat("{0}", item);
            }
            res = sb.ToString();
            Console.WriteLine(res);

            string[] names = new string[] { "A", "B", "C" };

            for (int i = 0; i < names.Length; i++)
            {
                sb.AppendFormat($"{names[i]} is {i} years old");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}


