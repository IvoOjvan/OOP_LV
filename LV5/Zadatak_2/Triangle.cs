using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_2
{
    public class Triangle
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;

            if (!(a + b > c && a + c > b && b + c > a)) 
            {
                throw new GeometryException(a, b, c, "Invalid Parameters!");
            } 
        }

        public Triangle() : this(1, 1, 1) { }

        public override string ToString()
        {
            return $"a = {SideA}\nb = {SideB}\nc = {SideC}\n";
        }
        public double CalculateExtent() 
        {
            return SideA + SideB + SideC;
        }
        public double CalculateArea() 
        {
            return SideA * SideB * SideC;
        }

        public bool IsRightTrinagle() 
        {
            double AScuared = Math.Pow(SideA, 2);
            double BScuared = Math.Pow(SideB, 2);
            double CScuared = Math.Pow(SideC, 2);

            return (AScuared == BScuared + CScuared) || (BScuared == AScuared + CScuared) || (CScuared == AScuared + BScuared);
        }
    }
}
