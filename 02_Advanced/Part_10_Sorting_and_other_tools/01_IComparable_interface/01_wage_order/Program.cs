using System;
using System.Collections.Generic;

namespace _01_wage_order
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            humans.Add(new Human("Merja", 500));
            humans.Add(new Human("Pertti", 80));
            humans.Add(new Human("Matti", 150000));

            // Sorts the list when your CompareTo works
            // Sort uses CompareTo internally
            humans.Sort();
            humans.ForEach(Console.WriteLine);
        }
    }
}
