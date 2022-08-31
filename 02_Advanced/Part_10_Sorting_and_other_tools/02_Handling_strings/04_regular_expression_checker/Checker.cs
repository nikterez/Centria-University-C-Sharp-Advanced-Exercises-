using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04_regular_expression_checker
{
    public class Checker
    {

        public Checker()
        {
        }
        public bool DayOfWeek(string str)
        {
            Regex regex = new Regex("^(mon|tue|wed|thu|fri|sat|sun)$");
            return regex.IsMatch(str);
        }

        public bool AllVowels(string str)
        {
            Regex regex = new Regex("^[aeiou]+$");
            return regex.IsMatch(str);
        }

        public bool TimeOfDay(string str)
        {
            Regex regex = new Regex ("[0-1][1-9]|2[1-3]:[0-5][0-9]:[0-5][0-9]");
            return regex.IsMatch(str);
        }
    }
}