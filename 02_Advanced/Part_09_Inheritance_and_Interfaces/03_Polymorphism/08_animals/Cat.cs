using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08_animals
{
    public class Cat : Animal, INoiseCapable
    {
        public Cat(string name) : base(name)
        {

        }
        public Cat() : base("Cat")
        {

        }
        new public void Eat()
        {
            base.Eat();
        }

        new public void Sleep()
        {
            base.Sleep();
        }

        public void Purr()
        {
            System.Console.WriteLine(this.name + " purrs");
        }

        public void MakeNoise()
        {
            this.Purr();
        }
    }
}