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
            char[] ar = new[] { 'O', 'Q', 'R', 'S' };
            Console.WriteLine(FindMissingLetter(ar));
            Console.ReadKey();
        }

        public static char FindMissingLetter(char[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((int)array[i] + 1 != (int)array[i + 1])
                    return (char)((int)array[i] + 1);
            }
            return ' ';
        }
    }
}