using System;

namespace _01_abc
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.APrint();
            b.BPrint();
            c.CPrint();

            Console.WriteLine();

            c.APrint();
            c.BPrint();
            c.CPrint();
        }
    }
}
