using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enum.Program;

namespace Enum
{
    internal class Program
    {
        public enum ConvertTo
        {
            Upper,
            Lower,
            SwapCase
        }

        public static void ConvertCasing(string text, ConvertTo targetType)
        {
            switch (targetType)
            {
                case ConvertTo.Upper:
                    Console.WriteLine(text.ToUpper());
                    break;
                case ConvertTo.Lower:
                    Console.WriteLine((text.ToLower());
                    break;

            }
        }

        static void Main(string[] args)
        {
            ConvertCasing("Hi", ConvertTo.Lower);

        }

    }
}
