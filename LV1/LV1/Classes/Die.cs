using System;
using System.Collections.Generic;
using System.Text;

namespace LV1.Classes
{
    class Die
    {
        #region Properties
        private int dieValue;
        public int DieValue
        {
            get { return this.dieValue; }
            set { this.dieValue = value; }
        }

        private Random randomValue;
        public Random RandomValue
        {
            get { return this.randomValue; }
            set { this.randomValue = value; }
        }
        #endregion

        #region Constructor
        public Die()
        {
            this.RandomValue = new Random();
            this.DieValue = this.RandomValue.Next(1, 7);
        }
        #endregion

        #region Methods
        public int ThrowDie()
        {
            return RandomValue.Next(1,7);
        }
        #endregion
    }
}
