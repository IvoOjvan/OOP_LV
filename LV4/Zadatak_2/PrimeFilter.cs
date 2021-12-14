using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_2
{
    public class PrimeFilter : IFilter
    {
        public bool IsValid(int number)
        {
            return (number > 0) && (number % 1 == 0) && (number % number == 0);
        }
    }
}
