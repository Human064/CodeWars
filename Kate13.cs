using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Litres(3));
            Console.ReadKey();

        }
        public static int Litres(double time)
        {
            return Convert.ToInt32(Math.Floor(time * 0.5));
        }
    }
}