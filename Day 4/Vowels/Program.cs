using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello All";
            //string[] vowels = new string[] {"a", "e", "i", "o", "u" };
            string vowels =  "a, e, i, o ,u";


            foreach (var ch in  text)
            {
                if (vowels.Contains(ch))  
                {
                    Console.WriteLine($"Vowel found: {ch}");
                }
            }

        }
    }
}
