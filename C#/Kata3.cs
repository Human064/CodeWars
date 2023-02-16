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
            Console.WriteLine(CreatePhoneNumber(arr));
            Console.ReadKey();
        }
        public static string CreatePhoneNumber(int[] numbers)
        {
            string res = "(";

            for (int i = 0; i < numbers.Length; i++)
            {
                switch (i)
                {
                    case 2:
                        res += numbers[i] + ") ";
                        break;
                    case 5:
                        res += numbers[i] + "-";
                        break;
                    default:
                        res += numbers[i];
                        break;
                }
            }

            return res;
        }
    }
}