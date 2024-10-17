using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Sound {  get; set; }
        public void MethodA() => Console.WriteLine("I'm an animal");
    }

    class Cat : Animal
    {
        new public void MethodA()
        {
            base.MethodA();
        }
        public void MethodB() => Console.WriteLine("Meoww");

    }
}
