using System;
using System.Collections.Generic;

namespace Exercise_003_print_dictionary_keys
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("f.e", "for example");
            dict.Add("etc.", "and so on");
            dict.Add("i.e", "more precisely");

            PrintKeys(dict);
            Console.WriteLine("---");
            PrintKeysWhere(dict, "i");
            Console.WriteLine("---");
            PrintValuesOfKeysWhere(dict, ".e");
        }

        public static void PrintKeys(Dictionary<string, string> dict)
        {
            foreach (var item in dict)
            {
                System.Console.WriteLine(item.Key);
            }
        }
        public static void PrintKeysWhere(Dictionary<string, string> dict, string text)
        {
            foreach (var item in dict)
            {
                if (item.Key.Contains(text))
                {
                    System.Console.WriteLine(item.Key);
                }
            }
        }

        public static void PrintValuesOfKeysWhere(Dictionary<string, string> dict, string text)
        {
            foreach (var item in dict)
            {
                if (item.Key.Contains(text))
                {
                    System.Console.WriteLine(item.Value);
                }

            }
        }

        
    }
}
