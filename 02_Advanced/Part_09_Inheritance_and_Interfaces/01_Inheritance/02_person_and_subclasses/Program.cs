using System;

namespace _02_person_and_subclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ada Lovelace", "24 Maddox St. London W1S 2QN");
            Person p2 = new Person("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki");
            
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            System.Console.WriteLine("");

            Student s1 = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
            
            Console.WriteLine(s1);
            
            s1.Study();
           
            Console.WriteLine(s1);
            System.Console.WriteLine("");

            Teacher t1 = new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200);
            Teacher t2 = new Teacher("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki", 5400);
            
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
    }
}
