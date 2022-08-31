using System;

namespace _01_dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice die = new Dice(6);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(die.ThrowDie());
            }
        }
    }
}
