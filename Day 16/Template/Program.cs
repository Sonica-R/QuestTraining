using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Person<TEmail> 
    {
        public string Name { get; set; }
        public TEmail Email { get; set; } //Template which can accept any type of data on compile time
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person<string[]>() { Name = "Anu" };
            var p2 = new Person<List<string>>() { Name = "Bob" };

            p1.Email = new string[] { "a.a@mail.com", "a.b@mail.com" };
            p2.Email = new List<string>() { "b@mail.com", "c@mail.com" };
        }
    }
}
