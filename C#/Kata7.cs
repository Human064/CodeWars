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
            Console.WriteLine(IsPangram("ABCDEFGHIJKLMNOPQRSTUVWXYZ."));
            Console.ReadKey();
        }
        public static bool IsPangram(string str)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int[] ar = new int[alphabet.Length];
            for (int i = 0; i < ar.Length; i++)
                ar[i] = 0;

            int res = 0;

            str = str.ToUpper();

            for (int i=0;i<str.Length;i++)
                for (int j = 0; j < alphabet.Length; j++)
                    if (str[i] == alphabet[j])
                        ar[j]++;

            for (int i = 0; i < ar.Length; i++)
                if (ar[i] == 1)
                    res++;

            return res==26;
        }
    }
}