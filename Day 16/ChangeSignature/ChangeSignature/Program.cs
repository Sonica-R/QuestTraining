using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeSignature
{
    internal class Program
    {
        static int Add(bool doAddition, int b, int a)
        {
            return doAddition ? a + b : a - b;
        }
        static void Main(string[] args)
        {
            var res = Add(true, 3, 2);
        }
    }
}
