using System;
using System.Collections.Generic;

namespace Exercise_004_book_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Book> books = new Dictionary<string, Book>();
            Book senseAndSensibility = new Book("Sense and Sensibility", 1811, "...");
            Book prideAndPrejudice = new Book("Pride and Prejudice", 1813, "....");
            books.Add(senseAndSensibility.name, senseAndSensibility);
            books.Add(prideAndPrejudice.name, prideAndPrejudice);

            PrintValues(books);
            Console.WriteLine("-- -- -- --");
            PrintValueIfNameContains(books, "prejud");
        }

        public static void PrintValues(Dictionary<string, Book> dictionary)
        {
            foreach (var item in dictionary)
            {
                System.Console.WriteLine(item.Value);
            }
        }

        public static void PrintValueIfNameContains(Dictionary<string, Book> dictionary, string text)
        {
            foreach (var item in dictionary)
            {
                if (item.Value.name.ToLower().Contains(text.ToLower()))
                {
                    System.Console.WriteLine(item.Value);
                }
            }
        }
    }
}
