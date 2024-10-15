using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneClass
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone();
            smartPhone.Name = "Google Pixel 8";
            smartPhone.Manufacturer = "Google";
            smartPhone.RAMSizes = new List<int>() { 8, 16 };

            //We can also give in the datas without specifying the name of th e object
            SmartPhone smartPhone2 = new SmartPhone()
            {
                Name = "Samsung Galaxy S23",
                Manufacturer = " Samsung",
                RAMSizes = new List<int>() { 8, 16, 32 }
            };

            smartPhone.Display();
        }
    }
}
