using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_3
{
    class FixTaksimetar : Taksimetar
    {
        public double FixedPrice { get; private set; }
        public int Km { get; private set; }

        public FixTaksimetar(double price, double fixedPrice, int km) : base(price)
        {
            this.FixedPrice = fixedPrice;
            this.Km = km;
        }

        public override double CalculatePrice(double km)
        {
            if(km < this.Km)
            {
                return FixedPrice;
            }

            return FixedPrice * km;
        }
    }
}
