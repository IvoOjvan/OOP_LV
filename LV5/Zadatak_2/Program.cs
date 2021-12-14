using System;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Triangle t1 = new Triangle(1, 1, 1);
                Console.WriteLine(t1.CalculateArea());

                Triangle t2 = new Triangle(4, 4, 2);
                Console.WriteLine(t2.CalculateArea());

                Triangle t3 = new Triangle(3, 4, 5);
                Console.WriteLine(t3.CalculateArea());

            }
            catch (GeometryException e) 
            {
                Console.WriteLine(e.Message);
            }

            try 
            {
                Triangle t4 = new Triangle(1, 2, 3);
                Console.WriteLine(t4.CalculateArea());
            }
            catch(GeometryException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
