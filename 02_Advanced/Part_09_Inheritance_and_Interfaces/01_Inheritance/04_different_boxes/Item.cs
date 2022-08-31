using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_different_boxes
{
    public class Item
    {
        public string itemName;
        public int itemWeight;

        public Item(string name):this(name,0)
        {
        }

        public Item(string name,int weight)
        {
            this.itemName=name;
            this.itemWeight=weight;
        }

        public override bool Equals(object compared)
        {
            if(this==compared)
            {
                return true;
            }

            if(compared==null || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }

            Item comparedItem = (Item)compared;

            return this.itemName==comparedItem.itemName;
        }

        public override int GetHashCode()
        {
            return this.itemName.GetHashCode();
        }
    }
}