using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_person_and_subclasses
{
    public class Student:Person
    {
        private int credits;
        public Student(string name, string address):base(name,address)
        {
            this.credits=0;
        }

        public override string ToString()
        {
            return base.ToString()+" credits: "+this.credits;
        }

        public void Study()
        {
            this.credits++;
        }
    }
}