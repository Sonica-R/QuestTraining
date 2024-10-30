using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cartItem = new Cart();

            while(true)
            {
                Console.WriteLine("Enter the choice 1: Add\n 2: Update\n 3: Display\n 4: Delete\n");
                var choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        cartItem.AddItems();
                        break;
                    case 2:
                        cartItem.Update();
                        break;
                    case 3:
                        cartItem.Display();
                        break;
                    case 4:
                        cartItem.Delete();
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
