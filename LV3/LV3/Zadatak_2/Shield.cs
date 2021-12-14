using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_2
{
    class Shield : Item
    {
        public int Defence { get; private set; }

        public Shield(string name, int weight, int worth, int defence)
            : base(name, weight, worth)
        {
            this.Defence = defence;
        }

        public override string ToString()
        {
            return $"Shield: {Name}";
        }
    }
}
