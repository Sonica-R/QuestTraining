using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cart
{
    public class Cart : ICartOperations
    {
        private List<CartItems> items = new List<CartItems>();
        public void AddItems()
        {
            Console.WriteLine("Enter pdt name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter quantity");
            double qty =double.Parse(Console.ReadLine());

            Console.WriteLine("Enter price");
            double price = double.Parse(Console.ReadLine());

            items.Add(new CartItems(name, qty, price));

            Console.WriteLine("Succesfully added");
        }

        public void Update()
        {
            Console.Write("Enter the name of the pdt to be updated: ");
            var itemName = Console.ReadLine();

            foreach (var item in items)
            {
                if (item.Name == itemName)
                {
                    Console.Write("Enter the qty to be added : ");
                    double qty = double.Parse(Console.ReadLine());

                    Console.Write("Enter the price : ");
                    double price = double.Parse(Console.ReadLine());

                    item.Quantity += qty;
                    item.Price += price;
                }
                else
                {
                    AddItems();
                }
                Console.WriteLine("Updated successfully");
            }
        }
        public void Display()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Name : {item.Name}\n Quantity : {item.Quantity}\n Price : {item.Price}");
            }
        }
        public void Delete()
        {
            Console.Write("Enter the name of the pdt : ");
            var itemName = Console.ReadLine();

            foreach (var item in items)
            {
                if (item.Name == itemName)
                {
                    items.Remove(item);
                    Console.WriteLine("Removed successfully");
                }
                else
                {
                    Console.WriteLine("Item doesn't exist");
                }
            }
        }
        
    }
}
