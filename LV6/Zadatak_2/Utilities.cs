using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_2
{
    public static class Utilities
    {
        public static List<int> Filter(IEnumerable<int> list, Func<int, bool> funk) 
        {
            List<int> result = new List<int>();

            foreach (var item in list) 
            {
                if (funk(item) == true) 
                {
                    result.Add(item);
                }
            }

            return result;
        } 
    }
}
