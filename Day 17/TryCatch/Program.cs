using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 2 numbers: ");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if(num2 == 0)
                {
                    throw new DivideByZeroException("Second number should not be zero");
                }
                Console.WriteLine(num1 / num2);
            }

            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("Divide by zero");
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            catch(Exception e)
            {
                //Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
                Console.WriteLine("Error occured");
            }
            finally
            {
                Console.WriteLine("Fnally");
            }
            Console.WriteLine("Finally Outside");
        }
    }
}
