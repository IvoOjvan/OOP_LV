using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_1
{
    public class Reward
    {
        #region Properties
        public int Points { get; private set; }

        #endregion

        #region Constructor
        public Reward(string word)
        {
            this.Points = CalculatePoints(word);
        }
        #endregion

        #region Methods
        public virtual int CalculatePoints(string word)
        {
            return word.Length;
        }
        #endregion
    }
}
