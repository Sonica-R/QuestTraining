using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string s = "a";
            int res1 = Convert.ToInt32(s);
            Console.WriteLine(res1);

            int res2 = int.Parse(s);
            Console.WriteLine(res2);

            string s2 = null;
            int res3 = Convert.ToInt32(s2);
            Console.WriteLine(res3);

            int res4 = int.Parse(s2);
            Console.WriteLine(res4); // throws an error
            */
            string str = "a";
            if(int.TryParse(str, out int res1))
            {
                Console.WriteLine(res1);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
