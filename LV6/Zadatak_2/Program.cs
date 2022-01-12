using System;
using System.Collections.Generic;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            List<int> testList = new List<int>();
            Random rand = new Random();

            do
            {
                Console.WriteLine("Unesi pozitivan broj: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            for (int i = 0; i < n; i++) 
            {
                testList.Add(rand.Next(-10, 11));
            }

            Console.WriteLine(string.Join(", ", testList));

            Func<int, bool> fun1 = new Func<int, bool>(it => it % 3 == 0 && it != 0);
            Func<int, bool> fun2 = new Func<int, bool>(it => it > -5 && it < 5);

            Console.WriteLine(string.Join(", ", Utilities.Filter(testList, fun1)));
            Console.WriteLine(string.Join(", ", Utilities.Filter(testList, fun2)));
        }
    }
}
