using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;


namespace _05_saveable_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveableDictionary dictionary = new SaveableDictionary("words.txt");
            dictionary.Load();

            Console.WriteLine(dictionary.Translate("apina"));
            Console.WriteLine(dictionary.Translate("monkey"));
            Console.WriteLine(dictionary.Translate("beer"));
            Console.WriteLine(dictionary.Translate("olut"));
            Console.WriteLine(dictionary.Translate("below"));
            Console.WriteLine(dictionary.Translate("alla oleva"));

            dictionary.Add("poista","remove");
            dictionary.Add("koira","dog");
            
            Console.WriteLine(dictionary.Translate("remove"));
            
            dictionary.Delete("remove");

            dictionary.Print();

            dictionary.Save();
        }
    }
}
