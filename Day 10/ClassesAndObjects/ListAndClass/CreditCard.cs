using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndClass
{
    internal class CreditCard
    {
        public int CardNumber;
        public string Expiry;
        public int CVC;

        public void EnterDetails()
        {
            Console.WriteLine("Enter ");
        }
        //public void DisplayDetails()
        //{
        //    Console.WriteLine("Credit card details are :");
        //    Console.WriteLine($"Card Number : {CardNumber}");
        //    Console.WriteLine($"Expiry : {Expiry}");
        //    Console.WriteLine($"CVC : {CVC}");
        //}

        public override string ToString()
        {
            return "$Number : {CardNumber} Date : {Expiry} CVC : {CVC}";
        }
    }
}
