using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_2
{
    class Sword : Item
    {
        public int Strength { get; private set; }

        public Sword(string name, int weight, int worth, int strength) 
            : base(name, weight, worth)
        {
            this.Strength = strength;
        }

        public override string ToString()
        {
            return $"Sword: {Name}";
        }
    }
}
