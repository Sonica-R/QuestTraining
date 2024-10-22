using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string[] PhoneNumber { get; set; }

            public Person()
            {
                PhoneNumber = new string[5];
            }

            public Person(string name, int PhnNumberCount)
            {
                Name = name;
                PhoneNumber = new string[PhnNumberCount];
            }
}

        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Adi", 4);
        }
    }
}
