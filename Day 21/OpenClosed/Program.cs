using System;

namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new DiscountCalculator();
            var res = calculator.CalculateDiscount(new GoldDiscount());
            Console.WriteLine($"Gold Discount Amount:{res}");
        }

        class DiscountCalculator
        {
            public int CalculateDiscount(Discount discount)
            {
                return discount.GetDiscount();
            }
        }

        public abstract class Discount
        {
            public abstract int GetDiscount();
        }

        public class SilverDiscount : Discount
        {
            public override int GetDiscount()
            {
                Console.WriteLine("Silver Discount");
                return 10; 
            }
        }

        public class GoldDiscount : Discount
        {
            public override int GetDiscount()
            {
                Console.WriteLine("Gold Discount");
                return 20;
            }
        }
    }
}


