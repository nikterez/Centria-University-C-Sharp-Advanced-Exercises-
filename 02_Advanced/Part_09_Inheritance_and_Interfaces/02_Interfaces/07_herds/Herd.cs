using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_herds
{
    public class Herd:IMovable
    {
        private List<IMovable> list;

        public Herd()
        {
            this.list= new List<IMovable>();
        }

        public void AddToHerd(IMovable mov)
        {
            this.list.Add(mov);
        }

        public void Move(int dx, int dy)
        {
            foreach (var i in this.list)
            {
                i.Move(dx,dy);
            }
        }

        public override string ToString()
        {
            string coords="";
            foreach (var i in this.list)
            {
                coords+= i.ToString()+"\n";
            }
            return coords;

        }
    }
}