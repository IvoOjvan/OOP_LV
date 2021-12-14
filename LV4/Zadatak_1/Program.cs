using System;

namespace Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = { 
                new Circle(2.5),
                new Square(5),
            };

            foreach(IShape shape in shapes)
            {
                Console.WriteLine($"Area: {shape.CalculateArea()}\nExtent: {shape.CalculateExtent()}");
            }
        }
    }
}
