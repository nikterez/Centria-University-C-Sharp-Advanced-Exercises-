using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_different_boxes
{
    public class OneItemBox:Box
    {
        public OneItemBox()
        {
            this.itemList = new List<Item>();
        }

        public override void Add(Item item)
        {
            if(this.itemList.Count==0)
            {
                this.itemList.Add(item);
            }
        }

    }
}