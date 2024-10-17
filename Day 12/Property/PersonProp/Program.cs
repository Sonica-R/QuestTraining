using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();

            p.Name = "New";
            p.Email = "newme@mail.com";


            p.Address = new List<Address>
            {
                new Address
                {
                    AddressType = "Home",
                    Address1 = "Kerala",
                    Address2 = "Tvm",
                    Pincode = 123456
                }              
            };

            Console.WriteLine($"Name : {p.Name}");
            Console.WriteLine($"Email : {p.Email}");
            Console.WriteLine(p.Address);
        }
    }
}
