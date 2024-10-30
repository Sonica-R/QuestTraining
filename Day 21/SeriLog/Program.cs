using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var date = DateTime.Now;
            //Console.WriteLine(date);
            //var ci = new CultureInfo("en-US");
            var price = 100;
            var formattedPrice = price.ToString("G4");
            Console.WriteLine(formattedPrice);
        }
    }
}
