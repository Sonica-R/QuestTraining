using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneClass
{
    internal class SmartPhone
    {
        public string Name;
        public string Manufacturer;
        public List<int> RAMSizes;

        public void Display()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Manufacturer : {Manufacturer}");

            foreach (var item in RAMSizes)
            {
                Console.WriteLine($"Ram sizes availabe are : {item}");
            }
        }
    }
}
