using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_2
{
    public static class RandomExtensions
    {
        public static Vector GenerateVector(Random rand, int lowerBound, int upperBound)
        {
            
            double i = rand.Next(lowerBound, upperBound);
            double j = rand.Next(lowerBound, upperBound);
            double k = rand.Next(lowerBound, upperBound);
            
            return new Vector(i, j, k);
        }
    }
}
