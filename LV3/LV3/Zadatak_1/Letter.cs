using System;
using System.Collections.Generic;
using System.Text;


namespace Zadatak_1
{
    public class Letter : Reward
    {
        #region Properties
        private int vowel;
        private int consonant;
        #endregion

        #region Constructor
        public Letter(string word) : base(word)
        {
            this.vowel = 5;
            this.consonant = 10;
        }
        #endregion

        #region Methods
        public override int CalculatePoints(string word)
        {
            int points = 0;
            string vowels = "aeiou";
            foreach(char character in word)
            {
                if (vowels.Contains(character)){
                    points += vowel;
                }
                else
                {
                    points += consonant; 
                }
            }

            return points;
        }
        #endregion
    }
}
