using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_3
{
    public abstract class Taksimetar
    {
        public double PricePerKm { get; private set; }

        protected Taksimetar(double pricePerKm)
        {
            this.PricePerKm = pricePerKm;
        }

        public bool IsNightRide(DateTime ride)
        {
            return ride.Hour > 20 && ride.Hour < 6;
        }
        public abstract double CalculatePrice(double km);
    }
}
