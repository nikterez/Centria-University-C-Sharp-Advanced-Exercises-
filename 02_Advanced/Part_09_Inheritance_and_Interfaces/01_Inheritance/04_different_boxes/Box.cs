using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_different_boxes
{
    public abstract class Box
    {
        public int maxWeight;

        public List<Item> itemList;

        public Box()
        {

        }
        public abstract void Add(Item item);

        public bool IsInBox(Item item)
        {
            return this.itemList.Contains(item);
        }

    }
}