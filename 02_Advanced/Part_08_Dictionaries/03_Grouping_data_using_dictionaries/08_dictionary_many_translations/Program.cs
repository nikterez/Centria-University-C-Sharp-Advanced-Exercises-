using System;

namespace Exercise_008_dictionary_many_translations
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryOfMany dictionary = new DictionaryOfMany();
            dictionary.Add("lie", "maata");
            dictionary.Add("lie", "valehdella");

            dictionary.Add("bow", "jousi");
            dictionary.Add("bow", "kumartaa");

            foreach (string translation in dictionary.Translate("bow"))
            {
                Console.WriteLine(translation);
            }
            Console.WriteLine();

            foreach (string translation in dictionary.Translate("lie"))
            {
                Console.WriteLine(translation);
            }

            dictionary.Remove("bow");
            foreach (string translation in dictionary.Translate("bow"))
            {
                Console.WriteLine(translation);
            }

        }

    }
}
