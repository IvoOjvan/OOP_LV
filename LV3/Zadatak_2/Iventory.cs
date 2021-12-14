using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_2
{
    public static class Iventory
    {  
        public static double CalculateAverage(Item[] items)
        {
            int value = 0;
            foreach(Item item in items)
            {
                value += item.Worth;
            }

            return value / items.Length;
        }
    }
}
