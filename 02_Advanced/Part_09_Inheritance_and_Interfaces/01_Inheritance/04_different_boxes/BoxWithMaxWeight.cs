using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_different_boxes
{
    public class BoxWithMaxWeight:Box
    {
        public BoxWithMaxWeight(int capacity)
        {
            this.maxWeight=capacity;
            this.itemList = new List<Item>();
        }

        public override void Add(Item item)
        {
            if(item.itemWeight<=this.maxWeight)
            {
                this.itemList.Add(item);
                this.maxWeight-=item.itemWeight;
            }
        }

    }
}