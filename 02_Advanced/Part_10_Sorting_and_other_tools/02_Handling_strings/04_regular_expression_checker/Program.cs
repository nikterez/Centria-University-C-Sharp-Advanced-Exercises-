using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_regular_expression_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            Checker check = new Checker();

            Console.WriteLine(check.DayOfWeek("tue"));
            Console.WriteLine(check.DayOfWeek("tues"));

            Console.WriteLine(check.AllVowels("aeiouaaeeioiouoiaoueaiaeiou"));
            Console.WriteLine(check.AllVowels("aeiouaaeeioiouoKiaoueaiaeiou"));

            Console.WriteLine(check.TimeOfDay("23:23:59"));
            Console.WriteLine(check.TimeOfDay("00:00:60"));

        }
    }

}