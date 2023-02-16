using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(42145));
            Console.ReadKey();

        }
        public static int DescendingOrder(int num)
        {
            int res = num, counter = 0;

            while (res != 0)
            {
                res /= 10;
                counter++;
            }

            int[] arr = new int[counter];

            for (int i = 0; i < counter; i++)
            {
                arr[i] = num % 10;
                num /= 10;
            }

            Array.Sort(arr);

            for (int i = counter - 1; i >= 0; i--)
                res = res * 10 + arr[i];
            // Bust a move right here
            return res;
        }
    }
}