using System;

namespace ValueRef
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine(ValMethod1());

            RefPMethod1();

            //Console.WriteLine(RefMethod1());

            ValPMethod1();
        }

        private static int ValMethod1()
        {
            int a = 1;
            ValMethod2(a);
            return a;
        }

        private static void ValMethod2(int a)
        {
            a = 2;
        }

        private static string RefMethod1()
        {
            string a = "1";
            RefMethod2(a);
            return a;
        }

        private static void RefMethod2(string a)
        {
            a = "2";
        }

        private static void RefPMethod1()
        {
            var a = new RefPoint();
            Console.WriteLine($"RefPMethod1 - start: x = {a.x}, y = {a.y}");
            RefPMethod2(a);
            Console.WriteLine($"RefPMethod1 - end: x = {a.x}, y = {a.y}");
        }

        private static void RefPMethod2(RefPoint a)
        {
            Console.WriteLine($"RefPMethod2 - start: x = {a.x}, y = {a.y}");
            a.x = 1;
            Console.WriteLine($"RefPMethod2 - end: x = {a.x}, y = {a.y}");
        }

        private static void ValPMethod1()
        {
            var a = new ValPoint();
            Console.WriteLine($"ValPMethod1 - start: x = {a.X}, y = {a.Y}");
            ValPMethod2(a);
            Console.WriteLine($"ValPMethod1 - end: x = {a.X}, y = {a.Y}");
        }

        private static void ValPMethod2(ValPoint a)
        {
            Console.WriteLine($"ValPMethod2 - start: x = {a.X}, y = {a.Y}");
            a = new ValPoint(1, a.Y);
            Console.WriteLine($"ValPMethod2 - end: x = {a.X}, y = {a.Y}");
        }
    }

    internal class RefPoint
    {
        public int x;
        public int y;
    }

    internal struct ValPoint
    {
        public ValPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
    }
}