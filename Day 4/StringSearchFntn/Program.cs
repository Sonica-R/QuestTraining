using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearchFntn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Aditi", "Aditya", "Ram Adith" };
            var toSearch = Console.ReadLine().ToLower().Trim();

            for (int i = 0; i < names.Length; i++)
            {
                var n = names[i].ToLower();
                if (n.Contains(toSearch))
                {
                    Console.WriteLine("Name found");
                    break;
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

        }
    }
//var names = new string[] { "Aditi rao", "Adithya" };
//var toSearch = Console.ReadLine().ToLower().Trim('*');

