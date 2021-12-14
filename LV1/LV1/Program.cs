using LV1.Classes;
using System;

namespace LV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Die[] dies = new Die[5];
            for(int i = 0; i < 5; i++)
            {
                dies[i] = new Die();
                dies[i].DieValue = 6;
            }

            YambChecker yamb = new YambChecker(dies);
            yamb.CheckForYamb();
            yamb.CheckForPoker();

            //-------------------------------------------------//
            Die[] pokerDie = new Die[5];
            for (int i = 0; i < 4; i++)
            {
                pokerDie[i] = new Die();
                pokerDie[i].DieValue = 5;
            }
            pokerDie[4] = new Die();
            pokerDie[4].DieValue = 6;

            YambChecker poker = new YambChecker(pokerDie);
            poker.CheckForYamb();
            poker.CheckForPoker();

            //----------------------------------------------------//
            Die[] testDie = new Die[5];
            for(int i = 0; i < testDie.Length; i++)
            {
                testDie[i] = new Die();
                testDie[i].DieValue = testDie[i].ThrowDie();
                Console.WriteLine(testDie[i].DieValue);
            }

            YambChecker testYamb = new YambChecker(testDie);
            testYamb.CheckForYamb();
            testYamb.CheckForPoker();

            Console.WriteLine();
        }
    }
}
