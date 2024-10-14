using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    internal class Program
    {
        static List<Dictionary<string, string>> products = new List<Dictionary<string, string>>();

        static void AddProduct(List<Dictionary<string, string>> products)
        {
            var productId = Console.ReadLine();
            var productName = Console.ReadLine();
            var productPrice = Console.ReadLine();

            Dictionary<string, string> product = new Dictionary<string, string>
            {
                { "ProductID", productId },
                { "Name", productName },
                { "Price", productPrice }
            };

            products.Add(product);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Product details");
            while (true)
            {
                Console.WriteLine("1 : Add product");
                Console.WriteLine("2 : Update Stock");
                Console.WriteLine("3 : Get Product Details");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddProduct(products);
                        break;
                    /*case "2":
                        pdate Stock(products);
                        break;
                    case "3":
                        GetProductDetails(products);
                        break;*/

                }
            }
    }
}
