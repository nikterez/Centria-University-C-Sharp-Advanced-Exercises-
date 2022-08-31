using System;

namespace Exercise_006_same_date
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleDate d = new SimpleDate(1, 2, 2000);
            SimpleDate e = new SimpleDate(12, 2, 2001);

            Console.WriteLine(d.Equals("heh"));
            Console.WriteLine(d.Equals(new SimpleDate(5, 2, 2012)));
            Console.WriteLine(d.Equals(new SimpleDate(1, 2, 2000)));

            System.Console.WriteLine(d.GetHashCode().Equals(new SimpleDate(1, 2, 2000).GetHashCode()));

            System.Console.WriteLine(d.GetHashCode());
            System.Console.WriteLine(e.GetHashCode());



        }
    }
}
