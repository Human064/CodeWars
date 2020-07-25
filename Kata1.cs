using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 3;
            Console.WriteLine(multiply(a, b));
            Console.ReadKey();
        }
        public static int multiply(int a, int b)
        {
            return a * b;
        }
    }
}