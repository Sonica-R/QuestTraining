using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutKeywords
{

    internal class Program
    {
        /*static void DoThis(int num)
        {
            num = 0;
        }
        static void DoThis2(ref int num)
        {
            num = 1;
        }
        static void DoThis3(out int num)
        {
            num = 3;
        }*/

        static bool TrimString(ref string data)
        {
            if(data.Length > 5)
            {
                data = data.Substring(0, 5);
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            //Here no change in value as it is value type
            /*int num = 1;
            DoThis(num);
            Console.WriteLine(num);

            //Here num changes as it is passed as ref
            int num2 = 2;
            DoThis2(ref num2);
            Console.WriteLine(num2);

            //Here no need to initialize the num to any value as out keyword is used
            int num3;
            DoThis3(out num3);
            Console.WriteLine(num3);*/

            string name = "hello all";
            if(TrimString(ref name))
            {
                Console.WriteLine(name + "...");
            }
            else
            {
                Console.WriteLine(name);
            }

        }
    }
}
