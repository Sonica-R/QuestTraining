using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day_17
{
   class A
   {
        private int Age = 21;
        protected string Name = "Helen";
        protected void Display()
        {
            Console.WriteLine(Name);
        }
        private void DisplayAge()
        {
            Console.WriteLine(Age);
        }
   }
    class B : A
    {
        public void ShowName()
        {
            Display();
        }
        public void ShowAge()
        {
            //DisplayAge();
            // can't be accessed as this method is private in base class
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            B b = new B();
            b.ShowName();
            b.ShowAge();
        }
    }
}
