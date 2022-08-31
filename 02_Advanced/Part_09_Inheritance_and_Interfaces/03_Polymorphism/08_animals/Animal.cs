using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08_animals
{
    public abstract class Animal
    {
        public string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public void Eat()
        {
            System.Console.WriteLine(this.name + " eats");
        }

        public void Sleep()
        {
            System.Console.WriteLine(this.name + " sleeps");
        }
    }
}
