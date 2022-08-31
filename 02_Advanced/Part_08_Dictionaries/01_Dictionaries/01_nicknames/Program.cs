using System;
using System.IO;
using System.Collections.Generic;

namespace Exercise_001_nicknames
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> names =new Dictionary<string, string>();
            
            names.Add("Matthew","Mat");
            names.Add("Michael","Mike");
            names.Add("Arthur","Artie");

            foreach (KeyValuePair<string,string> i in names)
            {
                System.Console.WriteLine("{0}'s nickname is {1}",i.Key,i.Value);
            }
        }
    }
}
