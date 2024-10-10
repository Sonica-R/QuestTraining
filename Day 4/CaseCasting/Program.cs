using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
           // string text = "HeLlO wOrLd";
            string output = "";

            foreach (var ch in text)
            {
                char res = char.IsLower(ch) ? char.ToUpper(ch) : char.ToLower(ch);
                output += res;
            }

            Console.WriteLine(output);
        }
    }
}
