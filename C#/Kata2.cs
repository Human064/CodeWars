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
            Console.WriteLine(Sabb("Why are you shouting?", 7, 2));
            Console.ReadKey();
        }
        public static string Sabb(string x, int val, int happ)
        {
            int Count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                switch (x[i])
                {
                    case 's':
                        Count++;
                        break;
                    case 'S':
                        goto case 's';
                    case 'a':
                        Count++;
                        break;
                    case 'A':
                        goto case 'a';
                    case 'b':
                        Count++;
                        break;
                    case 'B':
                        goto case 'b';
                    case 't':
                        Count++;
                        break;
                    case 'T':
                        goto case 't';
                    case 'i':
                        Count++;
                        break;
                    case 'I':
                        goto case 'i';
                    case 'c':
                        Count++;
                        break;
                    case 'C':
                        goto case 'c';
                    case 'l':
                        Count++;
                        break;
                    case 'L':
                        goto case 'l';
                    default:
                        break;
                }
            }

            if ((Count + val + happ) > 22)
                return "Sabbatical! Boom!";
            else
                return "Back to your desk, boy.";
        }
    }
}