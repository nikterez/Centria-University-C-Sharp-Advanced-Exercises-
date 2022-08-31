using System;

namespace Exercise_002_abbreviations
{
    class Program
    {
        static void Main(string[] args)
        {
            Abbreviations abbreviations = new Abbreviations();
            abbreviations.AddAbbreviation("e.g", "for example");
            abbreviations.AddAbbreviation("etc.", "and so on");
            abbreviations.AddAbbreviation("i.e", "more precisely");

            string text = "e.g i.e etc. lol";

            foreach (string part in text.Split(" "))
            {
                Console.WriteLine(abbreviations.FindExplanationFor(part));

            }
        }
    }
}