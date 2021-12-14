using LinearAlgebra;
using System;

namespace LinearAlgebra
{
    public class Vector
    {
        #region Properties
        public double iComponent { get; set; }
        public double jComponent { get; private set; }
        public double kComponent { get; private set; }
        #endregion

        #region Constructor
        public Vector(double i, double j, double k)
        {
            iComponent = i;
            jComponent = j;
            kComponent = k;
        }

        public Vector() : this(0, 0, 0) { }
        #endregion

        #region Methods
        public override string ToString()
        {
            string jSign = jComponent >= 0 ? "+" : "";
            string kSign = kComponent >= 0 ? "+" : "";
            return $"{iComponent}i{jSign} {jComponent}j {kSign} {kComponent}k";
        }

        public double CalculateNorm() 
        {
            return System.Math.Round(System.Math.Sqrt(iComponent*iComponent + jComponent*jComponent + kComponent*kComponent), 2);
        }
        #endregion
    }
}

namespace LinearAlgebra.Math 
{
    public static class VectorMath 
    {
        public static double CalculateDotProduct(Vector a, Vector b) 
        {
            return System.Math.Round(System.Math.Sqrt(a.iComponent * b.iComponent + a.jComponent * b.jComponent + a.kComponent * b.kComponent), 2);
        }

        public static double CalculateAngle(Vector a, Vector b) 
        {
            double dotProduct = CalculateDotProduct(a, b);
            double norm = a.CalculateNorm() * b.CalculateNorm();

            return System.Math.Round(System.Math.Acos(dotProduct / norm), 2);
        }
    }
}

namespace Test 
{
    public static class Test 
    {
        public static void ExecuteTest()
        {
            Vector a = new Vector(2, 5, 6);
            Vector b = new Vector(1, 7, 1);
            a.iComponent = 13;
            b.iComponent = 17;

            Console.WriteLine("Angle: " + LinearAlgebra.Math.VectorMath.CalculateAngle(a, b));
            
        }
    }
    
}