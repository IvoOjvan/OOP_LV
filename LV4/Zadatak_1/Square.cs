using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_1
{
    class Square : IShape
    {
        public double SideLength { get; private set; }

        public Square(double sideLength) => SideLength = sideLength;

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }

        public double CalculateExtent()
        {
            return 4 * SideLength;
        }
    }
}
