using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_004_book_dictionary
{
    public class Book
    {
        public string name { get; set; }
        public string content { get; set; }
        public int published { get; set; }

        public Book(string name, int published, string content)
        {
            this.name = name;
            this.published = published;
            this.content = content;
        }

        public override string ToString()
        {
            return "Name: " + this.name + " (" + this.published + ")\n"
                + "Content: " + this.content;
        }
    }
}