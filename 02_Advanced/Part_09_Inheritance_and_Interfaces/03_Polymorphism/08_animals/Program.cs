using System;

namespace _08_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Eat();
            dog.Sleep();

            Dog fido = new Dog("Fido");
            fido.Bark();

            Cat cat = new Cat();
            cat.Purr();
            cat.Eat();
            cat.Sleep();

            Cat garfield = new Cat("Garfield");
            garfield.Purr();

            INoiseCapable doggy = new Dog();
            doggy.MakeNoise();

            INoiseCapable catty = new Cat("Garfield");
            catty.MakeNoise();

            Cat c = (Cat)catty;
            c.Purr();
        }

    }
}
