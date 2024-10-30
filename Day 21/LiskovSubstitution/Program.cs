using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class Program
    {
        interface IFlyable
        {
            void Fly();
        }

        public class Bird
        {
            public string Name { get; set; }
        }

        class Pigeon : Bird, IFlyable
        {
            public void Fly() => Console.WriteLine("Pigeon is flying");
        }

        class Penguin : Bird
        {

        }
    }
}

