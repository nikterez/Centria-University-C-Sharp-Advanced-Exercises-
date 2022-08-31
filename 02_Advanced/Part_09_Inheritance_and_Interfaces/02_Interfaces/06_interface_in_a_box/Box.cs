using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_interface_in_a_box
{
    public class Box : IPackable
    {
        private int maxCapacity;
        private int curCapacity;
        private List<IPackable> items;

        public Box(int capacity)
        {
            this.maxCapacity = capacity;
            this.items = new List<IPackable>();
        }

        public void Add(IPackable item)
        {
            int weight = item.Weight()+this.curCapacity;
            
            if (weight <= this.maxCapacity)
            {
                this.items.Add(item);
                this.curCapacity += item.Weight();
            }
        }

        public int Weight()
        {
            return this.curCapacity;
        }

        public override string ToString()
        {
            return this.items.Count+" items, total weight "+this.curCapacity+" kg";
        }
    }
}