using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_person_and_subclasses
{
    public class Person
    {
        protected string name;
        protected string address;

        public Person(string name, string address)
        {
            this.name=name;
            this.address=address;
        }

        public override string ToString()
        {
            return this.name + ", " + this.address;
        }
    }
}