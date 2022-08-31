using System;

namespace _07_herds
{
    class Program
    {
        static void Main(string[] args)
        {
            Herd herd = new Herd();
            herd.AddToHerd(new Organism(57, 66));
            herd.AddToHerd(new Organism(73, 56));
            herd.AddToHerd(new Organism(46, 52));
            herd.AddToHerd(new Organism(19, 107));
            Console.WriteLine(herd);
            herd.Move(2, 2);
            Console.WriteLine(herd);
        }

    }
}
