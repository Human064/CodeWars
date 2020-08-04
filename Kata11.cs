using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isDivisible(8, 3, 4));
            Console.ReadKey();

        }
        public static bool isDivisible(long n, long x, long y)
        {
            return (n % x == 0) && (n % y == 0);
        }
    }
}