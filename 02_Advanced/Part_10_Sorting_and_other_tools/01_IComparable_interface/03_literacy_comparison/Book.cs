using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_literacy_comparison
{
    public class Book : IComparable<Book>
    {
        string name;

        int recAge;

        public Book(string name, int recAge)
        {
            this.name = name;
            this.recAge = recAge;
        }

        public override string ToString()
        {
            return this.name + " (recommended for " + this.recAge + " years olds or older)";
        }

        public int CompareTo(Book other)
        {
            if (this.recAge == other.recAge)
            {
                return this.name.CompareTo(other.name);
            }
            else
            {
                return this.recAge.CompareTo(other.recAge);
            }


        }
    }
}