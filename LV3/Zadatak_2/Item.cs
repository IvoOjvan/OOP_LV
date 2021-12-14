using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_2
{
    public class Item
    {
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int Worth { get; private set; }

        public Item(string name, int weight, int worth)
        {
            this.Name = name;
            this.Weight = weight;
            this.Worth = worth;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
