using System;

namespace FunctionalAddition
{
    public static class Kata
    {
        public static Func<double, double> Add(double n) => x => x + n;
    }
}