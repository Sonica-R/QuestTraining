using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    interface IShape
    {
        double GetArea();
        double GetPerimeter();
    }
    class Circle : IShape
    {
        public double Radius { get; set; }
        public double GetArea () => Math.PI * Radius * Radius;
        public double GetPerimeter() => 2 * Math.PI * Radius;
    }

    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double GetArea() => Length * Width;
        public double GetPerimeter() => 2 * Length * Width;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>
            {
                new Circle
                {
                    Radius = 2
                },
                new Rectangle
                {
                    Width = 2,
                    Length = 2
                }
            };
            foreach (var item in shapes)
            {
                Console.WriteLine($"Area : {item.GetArea()} \n Perimeter : {item.GetPerimeter()}"); 
            }
        }
    }
}
