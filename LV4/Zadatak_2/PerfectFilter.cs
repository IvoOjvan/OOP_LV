using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_2
{
    class PerfectFilter : IFilter
    {
        public bool IsValid(int number)
        {
            if (number > 0) 
            {
                int sum = 0;
                for (int i = 1; i < number; i++) 
                {
                    if (number % i == 0) 
                    {
                        sum += i;
                    }
                }

                if (number == sum) 
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
