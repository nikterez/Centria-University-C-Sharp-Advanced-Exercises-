using System;
using System.Collections.Generic;

namespace _03_literacy_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            while (true)
            {

                Console.WriteLine("Input the name of the book, empty stops:");
                string bName = Console.ReadLine();

                if (bName == "")
                {
                    break;
                }

                System.Console.WriteLine("Input the age recommendation:");
                int bAge = Convert.ToInt32(Console.ReadLine());

                books.Add(new Book(bName, bAge));
            }

            books.Sort();

            System.Console.WriteLine(books.Count+" in total.");
            System.Console.WriteLine(""+"\n"+"Books: ") ;
            books.ForEach(System.Console.WriteLine);
        }
    }
}
