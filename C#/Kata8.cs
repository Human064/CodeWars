using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(is_valid_IP("12.34.56 .1"));
            Console.ReadKey();
        }
        public static bool is_valid_IP(string ipAddres)
        {
            int i = 0, current=0;
            string num = "";
            while (i <= ipAddres.Length)
            {
                if ((i != ipAddres.Length) && (ipAddres[i] >= '0') && (ipAddres[i] <= '9'))
                    num += ipAddres[i];
                else if ((i == ipAddres.Length) || (ipAddres[i] == '.'))
                {
                    if ((num.Length > 1) && (num[0] == '0'))
                        return false;

                    if (int.TryParse(num, out int numb) && (numb >= 0) && (numb <= 255))
                    {
                        current++;
                        num = "";
                    }
                    else return false;
                }
                else return false;

                i++;
            }
            

            if (current == 4)
                return true;
            else
                return false;
        }
    }
}