using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_006_same_date
{
    public class SimpleDate
    {
        public int day;

        public int month;

        public int year;

        public SimpleDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString()
        {
            return this.day + "/" + this.month + "/" + this.year;
        }

        public override bool Equals(object compared)
        {
            if (this == compared)
            {
                return true;
            }

            if (compared == null || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }

            SimpleDate compareDate = (SimpleDate)compared;

            return this.day == compareDate.day && this.month == compareDate.month && this.year == compareDate.year;
        }

        public override int GetHashCode()
        {
            if (this.year >= 1900 && this.year <= 2100)
            {
                return this.day + this.month;
            }
            return this.year;
        }
    }
}