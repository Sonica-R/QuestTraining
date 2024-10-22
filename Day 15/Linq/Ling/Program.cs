using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            var data = new List<Person>()
            {
                new Person
                {
                    Name = "Person 1",
                    Country = "US",
                    Age = 20
                },
                new Person
                {
                    Name = "Person 2",
                    Country = "US",
                    Age = 30
                },
                new Person
                {
                    Name = "Person 3",
                    Country = "IN",
                    Age = 40
                }
            };

            var minAge = data.Where(p => p.Country == "US").Min(p => p.Age);
            var res = data.Where(p => p.Country == "US" && p.Age == minAge).FirstOrDefault();
            Console.WriteLine(res);
        }
    }
}
