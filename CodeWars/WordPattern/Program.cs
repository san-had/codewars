using System;

namespace WordPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var wordPattern = Kata.WordPattern("Hippopotomonstrosesquippedaliophobia");
            Console.WriteLine("H.i.p.p.o.p.o.t.o.m.o.n.s.t.r.o.s.e.s.q.u.i.p.p.e.d.a.l.i.o.p.h.o.b.i.a");
            var expectedPattern = "0.1.2.2.3.2.3.4.3.5.3.6.7.4.8.3.7.9.7.10.11.1.2.2.9.12.13.14.1.3.2.0.3.15.1.13";
            Console.WriteLine(expectedPattern);
            Console.WriteLine(wordPattern);
            Console.WriteLine(expectedPattern == wordPattern);
        }
    }
}