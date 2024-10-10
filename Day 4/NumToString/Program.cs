using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"};
            string input = " One, 2, Three, 2" ;

            var inpItems = input.Replace(" ", "").Split(',');
            var sb = new StringBuilder();

            foreach (var inpItem in inpItems)
            {
                if(inpItem.Length <= 2)
                {
                    int num = int.Parse(inpItem);
                    string text = numbers[num - 1];
                    sb.Append(text);
                    sb.Append(" ");
                }
                else
                {
                    sb.Append(inpItem);
                    sb.Append(" ");
                }
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
