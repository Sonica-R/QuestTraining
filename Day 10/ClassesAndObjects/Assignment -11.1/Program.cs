using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardDetails cc = new CardDetails();

            while (true)
            {
                Console.WriteLine("1 : Add into list");
                Console.WriteLine("2 : Search for card by card number");
                Console.WriteLine("3 : Update a card");
                Console.WriteLine("4 : Delete a card");
                Console.WriteLine("0 : To stop");

                int input = int.Parse(Console.ReadLine());

                if ((input >= 1) && (input <= 4))
                {
                    switch (input)
                    {
                        case 1:
                            Console.Write("Enter number of details to be enterd :");
                            int num = int.Parse(Console.ReadLine());
                            cc.AddDetails(num);
                            input = 0;
                            break;
                        case 2:
                            cc.SearchCard();
                            break;
                        case 3:
                            cc.Update();
                            break;
                    }
                }
                else
                {
                    break;
                }
            }
            
        }
    }
}
