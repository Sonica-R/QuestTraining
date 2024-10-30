using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "This is a   string";
            string[] spiltStr = text.Split(' ');
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(spiltStr[i]);
            }
        }
    }
}
