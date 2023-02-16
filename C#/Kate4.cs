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
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
            Console.ReadKey();
        }
        public static string HighAndLow(string numbers)
        {
            string num = "";
            int max = 0, min = 0;
            bool first = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != ' ')
                    num += numbers[i];

                if ((numbers[i] == ' ') || (i == numbers.Length - 1))
                {
                    if (first)
                    {
                        max = Convert.ToInt32(num);
                        min = Convert.ToInt32(num);
                        first = !first;
                    }
                    else
                    {
                        if (max < Convert.ToInt32(num))
                            max = Convert.ToInt32(num);
                        if (min > Convert.ToInt32(num))
                            min = Convert.ToInt32(num);
                    }

                    num = "";
                }
            }

            return max + " " + min;
        }
    }
}