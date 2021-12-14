using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Zadatak_3
{
    class Weather : IComparable<Weather>
    {
        public double TemeperatureInC { get; private set; }

        public string Summary { get; private set; }

        public Weather(double temperature, string summary)
        {
            TemeperatureInC = temperature;
            Summary = summary;
        }

        public override string ToString()
        {
            return $"Temperature: {TemeperatureInC}°C\nSummary: {Summary}.";
        }

        public int CompareTo([AllowNull] Weather other)
        {
            if (this.TemeperatureInC > other.TemeperatureInC) 
            {
                return 1;
            }
            else if(this.TemeperatureInC == other.TemeperatureInC)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
