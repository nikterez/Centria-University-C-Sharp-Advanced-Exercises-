using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_wage_order
{
    public class Human : IComparable<Human>
    {
        public string humanName;

        public int humanWage;

        public Human(string name, int wage)
        {
            this.humanName = name;
            this.humanWage = wage;
        }

        public override string ToString()
        {
            return this.humanName + " " + this.humanWage;
        }

        public int CompareTo(Human other)
        {
            return other.humanWage - this.humanWage;
        }
    }
}