using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_person_and_subclasses
{
    public class Teacher:Person
    {   
        private int salary;

        public Teacher(string name,string address, int salary):base(name,address)
        {
            this.salary=salary;
        }

        public override string ToString()
        {
            return base.ToString()+" salary "+this.salary+" per month";
        }
    }
}