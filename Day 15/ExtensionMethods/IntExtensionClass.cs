using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class IntExtensionClass
    {
        public static bool IsEvenOrOdd(this int num)
        {
            if(num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
