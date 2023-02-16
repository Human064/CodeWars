using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"));
            Console.ReadKey();

        }
        public static string NoSpace(string input)
        {
            string buf = "";
            for (int i = 0; i < input.Length; i++)
                if (input[i] != ' ')
                    buf += input[i];

            return buf;
        }
    }
}