using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_herds
{
    public class Organism:IMovable
    {
        int x;
        int y;

        public Organism(int x, int y)
        {
            this.x=x;
            this.y=y;
        }

        public override string ToString()
        {
            return "x: "+this.x+" y: "+this.y;
        }

        public void Move(int x, int y)
        {
            this.x+=x;
            this.y+=y;
        }
    }
}