using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_3
{
    class StandardTaksimetar : Taksimetar
    {
        public double StartPrice { get; private set; }

        public StandardTaksimetar(double price, double startPrice) 
            : base(price)
        {
            this.StartPrice = startPrice;
        }

        public override double CalculatePrice(double km)
        {
            return StartPrice + (PricePerKm * km);
        }
    }
}
