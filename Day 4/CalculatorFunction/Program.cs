using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFunction
{
    internal class Program
    {
        //Single Line Functions (Cursor on Function name and Press Ctrl + .)
        static int Add(int num1, int num2) => num1 + num2;
        
        static int Diff(int num1, int num2) => (num1 - num2);
       
        static int Mul(int num1, int num2) => (num1 * num2) ;
        
        static int Div(int num1, int num2) => (num1 / num2);

        static int Rem(int num1, int num2) => num1 / num2;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter two numbers and the operator to perform arithmetic calculation");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine() ;

            switch (op)
            {
                case "+":
                    {
                        int res = Add(num1, num2);
                        Console.WriteLine(res);
                        break;
                    }

                case "-":
                    {
                        int res = Diff(num1, num2);
                        Console.WriteLine(res);
                        break;
                    }

                case "*":
                    {
                        int res = Mul(num1, num2);
                        Console.WriteLine(res);
                        break;
                    }

                case "/":
                    {
                        int res = Div(num1, num2);
                        Console.WriteLine(res);
                        break;
                    }

                case "%":
                    {
                        int res = Rem(num1, num2);
                        Console.WriteLine(res);
                        break;
                    }
            }
        }
    }
}
