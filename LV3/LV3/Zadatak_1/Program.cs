using System;

namespace Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[3];
            Reward[] rewards = new Reward[3];
            Letter[] letters = new Letter[3];

            for(int i = 0; i < words.Length; i++)
            {
                do
                {
                    words[i] = Console.ReadLine();
                } while (words[i].Length < 3);

                rewards[i] = new Reward(words[i]);
                letters[i] = new Letter(words[i]);

                Console.WriteLine($"Calculated by base class: {rewards[i].CalculatePoints(words[i])}");
                Console.WriteLine($"Calculated by inherited class: {letters[i].CalculatePoints(words[i])}");
            }
        }
    }
}
