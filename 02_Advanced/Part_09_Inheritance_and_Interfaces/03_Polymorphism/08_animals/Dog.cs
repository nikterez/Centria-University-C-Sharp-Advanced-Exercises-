using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08_animals
{
    public class Dog:Animal,INoiseCapable
    {
        public Dog(string name):base(name)
        {
        }

        public Dog():base("Dog")
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

        public void Bark()
        {
            System.Console.WriteLine(this.name+" barks");
        }

        public void MakeNoise()
        {
            this.Bark();
        }


    }
}