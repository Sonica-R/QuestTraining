using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{

    public class Printer : IPrinter, IScanner
    {
        public void Print()
        {
            System.Console.WriteLine("Printing...");
        }

        public void Scan()
        {
            System.Console.WriteLine("Scanning...");
        }
    }
}
