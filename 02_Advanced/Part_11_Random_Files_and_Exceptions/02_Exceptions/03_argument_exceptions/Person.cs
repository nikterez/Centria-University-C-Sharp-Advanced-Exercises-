using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_argument_exceptions
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            if(name==null || name=="" || name.Length>40)
            {
                throw new ArgumentException();
            }
            this.name=name;

            if(age<0 || age> 120)
            {
                throw new ArgumentException();
            }
            this.age=age;

        }
    }
}