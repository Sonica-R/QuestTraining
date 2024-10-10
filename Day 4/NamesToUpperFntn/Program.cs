using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesToUpperFntn
{
    internal class Program
    {
        static void NamesToUpper(string[] names)
        {
            Console.WriteLine("Names in the array :");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            
        }
        static void ArrayCheck(string[] names,string check)
        {
            //Array.Contains(names, check, StringComparison.OrdinalIgnoreCase);
            foreach(var name in names)
            {
                if(name.Equals(check, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{check} is in the array.");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of names :");
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            Console.WriteLine("Enter the names");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            NamesToUpper(names);
            Console.WriteLine("Enter a name to be checked");
            string check = Console.ReadLine();
            ArrayCheck(names, check);

        }
    }
}
