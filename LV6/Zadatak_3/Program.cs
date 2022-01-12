using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>(Networking.GetUsedCars());

            var manufacturers = cars.Select(cars => cars.Make).Distinct();
            Console.WriteLine(string.Join("\n", manufacturers));

            Console.WriteLine("\nMax distance: ");
            var maxDistance = cars.Aggregate((c1, c2) => c1.Km > c2.Km ? c1 : c2);
            Console.WriteLine(maxDistance.Make);

            Console.WriteLine("\nDacia average age: ");
            double age = cars.Where(it => it.Make == "Dacia").Average(it => DateTime.Now.Year - it.Year);
            Console.WriteLine(age);

            Console.WriteLine("\nYears range: ");
            string minYear = cars.Min(it => it.Year).ToString();
            string maxYear = cars.Max(it => it.Year).ToString();

            Console.WriteLine(minYear + "-" + maxYear);
            
            
        }
    }
}
