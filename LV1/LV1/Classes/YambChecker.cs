using System;
using System.Collections.Generic;
using System.Text;

namespace LV1.Classes
{
    class YambChecker
    {
        #region Properties
        public Die[] Dies { get; set; } = new Die[5];
        #endregion

        #region Constructor
        public YambChecker(Die[] Dies)
        {
            this.Dies = Dies;
        }
        #endregion

        #region Methods
        public void CheckForYamb()
        {
            if(CheckSames(5) == 5)
                Console.WriteLine("YAMB!");
            else
                Console.WriteLine("No yamb!");
        }

        public void CheckForPoker()
        {
            if (CheckSames(4) == 4)
                Console.WriteLine("POKER!");
            else
                Console.WriteLine("No poker!");
        }

        private int CheckSames(int value)
        {
            int[] counters = { 0, 0, 0, 0, 0, 0 };
            for(int i = 0; i < 5; i++)
            {
                switch (this.Dies[i].DieValue)
                {
                    case 1: counters[0]++; break;
                    case 2: counters[1]++; break;
                    case 3: counters[2]++; break;
                    case 4: counters[3]++; break;
                    case 5: counters[4]++; break;
                    case 6: counters[5]++; break;
                    default: break;
                }
            }

            for(int i = 0; i < 6; i++)
            {
                if (counters[i] == value) return counters[i];
            }

            return 0;
        }
        #endregion

    }
}
