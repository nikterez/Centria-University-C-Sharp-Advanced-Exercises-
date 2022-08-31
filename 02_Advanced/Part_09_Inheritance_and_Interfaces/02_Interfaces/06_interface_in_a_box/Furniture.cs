using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_interface_in_a_box
{
    public class Furniture:IPackable
    {
        private string fType;

        private string fColor;
        public int fWeight;

        public Furniture(string type, string color, int weight)
        {
            this.fType=type;
            this.fColor=color;
            this.fWeight=weight;
        }

        public override string ToString()
        {
            return this.fColor+" "+this.fType+" - weight "+this.fWeight+" kg";
        }

        public int Weight()
        {
            return this.fWeight;
        }
    }
}