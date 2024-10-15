using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cc = new CreditCard();

            Console.WriteLine("Enter the credit card number");
            cc.CardNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Expiry date");
            cc.Expiry = Console.ReadLine();

            Console.WriteLine("Enter the CCV");
            cc.CVC = int.Parse(Console.ReadLine());

            //cc.DisplayDetails();
            Console.WriteLine(cc);
        }
    }
}
