using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLineFntns
{
    internal class Program
    {
        static void Add(int a, int b) => Console.WriteLine(a + b);
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Add(a, b);

        }
    }
}
