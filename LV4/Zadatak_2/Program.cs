using System;
using System.Collections.Generic;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            IFilter perfectFilter = new PerfectFilter();
            IFilter primeFilter = new PrimeFilter();
            List<int> randomList = new List<int>();

            for (int i = 0; i < 100; i++) 
            {
                randomList.Add(rand.Next(-501, 501));
            }

            List<int> perfectList = FilterList(randomList, perfectFilter);
            List<int> primeList = FilterList(randomList, primeFilter);

            Console.WriteLine(perfectList.Count + " " + primeList.Count);

            string result = primeList.Count > perfectList.Count ? $"Prime list: {primeList.Count}" : $"Perfect list: {perfectList.Count}";
            Console.WriteLine(result);

        }

        public static List<int> FilterList(List<int> numbers, IFilter filter) 
        {
            List<int> filteredList = new List<int>();

            foreach (int number in numbers) 
            {
                if (filter.IsValid(number)) 
                {
                    filteredList.Add(number);
                }
            }

            return filteredList;
        }
    }
}
