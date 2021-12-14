using System;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] items = new Item[5];

            items[0] = new Sword("Saber", 2, 10, 5);
            items[1] = new Sword("Katana", 4, 20, 10);
            items[2] = new Shield("Great shield", 10, 15, 10);
            items[3] = new Shield("Buckler shield", 2, 5, 5);
            items[4] = new Shield("Templar shield", 5, 25, 15);

            Console.WriteLine($"Average worth: {Iventory.CalculateAverage(items)}");

            foreach(Item item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
