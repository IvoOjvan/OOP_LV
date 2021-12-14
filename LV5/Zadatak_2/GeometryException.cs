using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_2
{
    class GeometryException : Exception
    {

        private double a, b, c;

        public GeometryException(double A, double B, double C, string message) : base(message)
        {
            this.a = A;
            this.b = B;
            this.c = C;
        }


    }
}
