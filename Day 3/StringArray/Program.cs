using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[3];
            Console.WriteLine(name[0]?.ToUpper());
        }
    }
}
