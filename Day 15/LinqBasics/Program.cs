using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var res = data.Skip(3).Take(5).Where(x => x % 2 == 0).Sum();
            Console.WriteLine($"Sum is {res}");
        }
    }
}
