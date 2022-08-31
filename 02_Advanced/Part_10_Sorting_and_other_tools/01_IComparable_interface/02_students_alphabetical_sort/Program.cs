using System;
using System.Collections.Generic;

namespace _02_students_alphabetical_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student("zamo");
            Student second = new Student("jamo");
            Student third = new Student("bamo");
            Student fourth = new Student("jamo1");
            Student fifth = new Student("bamo");


            // Should print -1
            Console.WriteLine(first.CompareTo(second));
            System.Console.WriteLine("");

            List<Student> names = new List<Student> { first, second, third, fourth, fifth };
            names.Sort();

            names.ForEach(System.Console.WriteLine);
        }
    }
}
