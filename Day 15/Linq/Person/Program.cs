using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public int Age { get; set; }
            public override string ToString()
            {
                return $"{Name} {Country}"; 
            }
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

            var groups = data.GroupBy(p => p.Country);
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");
                foreach (var person in group)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}
