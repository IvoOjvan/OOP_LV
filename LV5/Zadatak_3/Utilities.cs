using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_3
{
    public static class Utilities 
    {
        public static int CountSpikes<T>(T[] array) where T : IComparable<T>
        {
            int counter = 0;
            for (int i = 1; i < array.Length - 1; i++) 
            {
                if (array[i - 1].CompareTo(array[i]) < 0 && array[i + 1].CompareTo(array[i]) < 0) 
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
