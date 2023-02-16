using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
            Console.ReadKey();
        }
        public static int[] MoveZeroes(int[] arr)
        {
            int[] Buff = arr;
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != 0)
                {
                    Buff[j] = arr[i];
                    j++;
                }

            while (j != Buff.Length)
            {
                Buff[j] = 0;
                j++;
            }

            return Buff;

            // TODO: Program me
        }
    }
}