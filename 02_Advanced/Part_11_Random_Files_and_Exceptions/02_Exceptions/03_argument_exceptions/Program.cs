using System;
using System.Collections.Generic;
using System.IO;

namespace _03_argument_exceptions
{
    class Program
    {
        public static void Main(string[] args)
        {
            string x=null;
        
            Person p1 =  new Person("peter",21);

            Person p2 = new Person(x,21);
            //throws exception

            Person p3 = new Person("peter", 121);
            //throws exception

        }

    }
}

