using System;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Vector vector1 = RandomExtensions.GenerateVector(rand, 0,100);
            Vector vector2 = RandomExtensions.GenerateVector(rand, 0, 100);
            Vector vector3 = RandomExtensions.GenerateVector(rand, 0, 100);

            Console.WriteLine(vector1.ShowVector());
            Console.WriteLine(vector2.ShowVector());
            Console.WriteLine(vector3.ShowVector());

            Vector v4 = vector1 + vector2;
            Console.WriteLine(v4.ShowVector());

            Vector v5 = vector3 - vector2;
            Console.WriteLine(v5.ShowVector());

        }
    }
}
