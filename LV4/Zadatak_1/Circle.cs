using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_1
{
    class Circle : IShape
    {
        public double Radius { get; private set; }

        public Circle(double radius) => Radius = radius;

        public double CalculateArea()
        {
            return Math.Round(Radius * Radius * Math.PI, 2);
        }

        public double CalculateExtent()
        {
            return Math.Round(2 * Radius * Math.PI, 2);
        }
    }
}
