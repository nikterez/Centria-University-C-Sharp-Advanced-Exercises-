using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_interface_in_a_box
{
    public class Book : IPackable
    {
        private string bookAuthor;
        private string bookName;
        private int bookYear;

        public Book(string author, string name, int year)
        {
            this.bookAuthor=author;
            this.bookName=name;
            this.bookYear=year;
        }

        public override string ToString()
        {
            return this.bookAuthor+": "+this.bookName+" ("+this.bookYear+")";
        }

        public int Weight()
        {
            return 1;
        }
    }
}