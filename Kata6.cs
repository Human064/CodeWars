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
            int[] ar = ArrayDiff(new int[] {1, 2, 2 }, new int[] { });

            for (int i = 0; i < ar.Length; i++)
                Console.Write(ar[i] + " ");
            //Console.WriteLine();
            Console.ReadKey();
        }
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            int j,count = -1;
            bool Not_del;
            for (int i = 0; i < a.Length; i++)
            {
                j = 0; Not_del = true;
                while ((Not_del)&&(j<b.Length))
                {
                    if (a[i] == b[j])
                        Not_del = !Not_del;
                    j++;
                }

                if (Not_del)
                {
                    count++;
                    a[count] = a[i];
                }
            }
            
            int[] Buff = new int[count+1];
            for (int i = 0; i < count + 1; i++) Buff[i] = a[i];
            return Buff;
        }
    }
}