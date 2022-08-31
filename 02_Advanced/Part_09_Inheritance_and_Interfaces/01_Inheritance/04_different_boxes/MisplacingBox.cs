using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_different_boxes
{
    public class MisplacingBox:Box
    {
        public MisplacingBox()
        {
            this.itemList=new List<Item>();
        }

        public override void Add(Item item)
        {
            this.itemList.Add(item);
            this.itemList.Clear();
        }
    }
}