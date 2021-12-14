using System;

namespace Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            Weather[] weathers = new Weather[numberOfElements];

            Console.WriteLine("Enter temperatures: ");
            for(int i = 0; i < numberOfElements; i++) 
            {
                int temperature = int.Parse(Console.ReadLine());
                weathers[i] = new Weather(temperature, "");
            }

            int numOfLeaps = Utilities.CountSpikes<Weather>(weathers);
            if(numOfLeaps == 0)
            {
                Console.WriteLine("No leaps!");
            }
            Console.WriteLine($"Leaps: {numOfLeaps}");
        }
    }
}
