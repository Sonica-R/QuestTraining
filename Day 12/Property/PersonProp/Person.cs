using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProp
{
    internal class Person
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public List<Address> Address { get; set; } 

    }

    class Address
    {
        public string AddressType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int Pincode  { get; set; }

        public override string ToString()
        {
            return $"Address Type : {AddressType}, Address Line 1 : {Address1}, Address Line 2 : {Address2}, Pincode : {Pincode}";
        }
    }
}
