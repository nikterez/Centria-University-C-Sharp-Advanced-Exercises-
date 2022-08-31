using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_students_alphabetical_sort
{
    public class Student : IComparable<Student>
    {
        string name;

        public Student(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }

        public int CompareTo(Student other)
        {
            return this.name.CompareTo(other.name);
        }
    }
}