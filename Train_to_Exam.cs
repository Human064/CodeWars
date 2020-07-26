using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int W = Convert.ToInt32(Console.ReadLine());

            int count_accept, count_number = 0, num;

            for (int i = 0; i <= N; i++)
            {
                count_accept = 0;
                num = i;
                while (num >= B)
                {
                    if (num % B == W)
                        count_accept++;
                    num /= B;
                }

                if (num == W)
                    count_accept++;

                if (count_accept > 2)
                    count_number++;
            }

            Console.WriteLine(count_number);
            Console.ReadKey();
        }

        static void Test()
        {

            {
                Console.WriteLine("Выберите программу:  ");
                Console.WriteLine("1. Простота числа;");
                Console.WriteLine("2. Максимум в массиве;");
                Console.WriteLine("3. Поиск в массиве;");
                Console.WriteLine("4. Инвертирование массива;");
                Console.WriteLine("5. Циклический сдвиг эллементов массива влево / вправо на 1;");
                Console.WriteLine("6. Фильтрация эллементов массива, удовлетворяющих условию, в другой массив;");
                Console.WriteLine("7. Алгоритм сортировки;");
                Console.WriteLine("8. Бинарный поиск в отсортированном массиве;");
                Console.WriteLine("9. Слияние двух отсортированных массивов в один отсортированный.");

                int code = Convert.ToInt32(Console.ReadLine());

                switch (code)
                {
                    case 1:

                        Console.WriteLine("Введите число:");
                        int number = Convert.ToInt32(Console.ReadLine());

                        if (Natural(number))
                            Console.WriteLine("Число " + number + " натуральное.");
                        else
                            Console.WriteLine("Число " + number + " ненатуральное.");

                        break;
                    case 2:

                        int[] MyArray = Input_int_Array();

                        Console.WriteLine("Максимум массива = " + Max_of_Array(MyArray));

                        break;
                    case 3:

                        MyArray = Input_int_Array();

                        Console.WriteLine("Введите искомое число:");
                        int Number = Convert.ToInt32(Console.ReadLine());

                        int Position = First_position_of_Number_in_Array(MyArray, Number);

                        if (Position != -1)
                            Console.WriteLine("Позиция искомого числа в массиве = " + Position);
                        else
                            Console.WriteLine("Число отсутствует в массиве!");

                        break;
                    case 4:
                        MyArray = Input_int_Array();

                        MyArray = Revers(MyArray);

                        Output_int_Array(MyArray);

                        break;
                    case 5:
                        MyArray = Input_int_Array();

                        MyArray = Push(MyArray);

                        Output_int_Array(MyArray);

                        break;
                    case 6:

                        MyArray = Input_int_Array();

                        int[] Special_Array = Filter(MyArray);

                        Output_int_Array(MyArray);
                        Output_int_Array(Special_Array);

                        break;
                    case 7:
                        MyArray = Input_int_Array();

                        MyArray = Sort(MyArray);

                        Output_int_Array(MyArray);

                        break;
                    case 8:
                        MyArray = Input_int_Array();

                        Console.WriteLine("Введите искомое число:");
                        Number = Convert.ToInt32(Console.ReadLine());

                        Position = Binar_Search(MyArray, Number);

                        if (Position != -1)
                            Console.WriteLine("Позиция искомого числа в массиве = " + Position);
                        else
                            Console.WriteLine("Число отсутствует в массиве!");

                        break;
                    case 9:
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }

        //Ввод массива
        static int[] Input_int_Array()
        {
            Console.WriteLine("Введите объём массива:");
            int range = Convert.ToInt32(Console.ReadLine());

            int[] MyArray = new Int32[range];

            Console.WriteLine("Введите эллементы массива:");
            for (int i = 0; i < range; i++)
                MyArray[i] = Convert.ToInt32(Console.ReadLine());

            return MyArray;
        }

        //Вывод массива
        static void Output_int_Array(int[] MyArray)
        {
            Console.WriteLine("Эллементы массива:");
            for (int i = 0; i < MyArray.Length-1; i++)
                Console.Write(MyArray[i] + ", ");
            Console.WriteLine(MyArray[MyArray.Length - 1] + ".");
        }

        //Первая функция
        static bool Natural(int number)
        {
            bool natural = true; // Проверка на натуральность

            number = Math.Abs(number);

            for (int j = 2; j < number; j++)
            {
                //Console.WriteLine(j + "  " + number);
                if ((j != number) && (number % j == 0))
                {
                    natural = !natural;
                    number = j;
                }
            }

            return natural;
        }

        //Вторая функция
        static int Max_of_Array(int[] MyArray)
        {
            int Max = MyArray[0];
            for (int i = 1; i < MyArray.Length; i++)
                if (MyArray[i] > Max) Max = MyArray[i];
            return Max;
        }

        //Третья функция
        static int First_position_of_Number_in_Array(int[] MyArray, int Number)
        {
            int i = 0;
            while (i < MyArray.Length)
            {
                if (MyArray[i] == Number)
                    return i+1;
                i++;
            }

            return -1;
        }

        //Четвёртая функция
        static int[] Revers(int[] MyArray)
        {
            int[] Buffer=new Int32[MyArray.Length];
            int counter=0;
            for (int i = MyArray.Length-1; i >= 0; i--)
            {
                Buffer[counter] = MyArray[i];
                counter++;
            }

            return Buffer;
        }

        //Пятая функция
        static int[] Push(int[] MyArray)
        {

            Console.WriteLine("Введите сторону сдвига массива: 1 - вправо, 2 - влево");
            int side = Convert.ToInt32(Console.ReadLine());
            int SavePoint;

            bool Right_side = (side == 1) || (side == 2);
            

            while (!Right_side)
            {
                Console.WriteLine("Неверный идентификатор стороны, выберите другой из перечня: 1 - вправо, 2 - влево");
                side = Convert.ToInt32(Console.ReadLine());
                Right_side = (side == 1) || (side == 2);
            }

            switch (side)
            {
                case 1:
                    SavePoint = MyArray[0];
                    for (int i = 0; i < MyArray.Length - 1; i++)
                        MyArray[i] = MyArray[i + 1];
                    MyArray[MyArray.Length - 1] = SavePoint;
                    break;

                case 2:
                    SavePoint = MyArray[MyArray.Length-1];
                    for (int i = MyArray.Length-1; i > 0; i--)
                        MyArray[i] = MyArray[i - 1];
                    MyArray[0] = SavePoint;
                    break;
            }



            return MyArray;
        }

        //Шестая функция
        static int[] Filter(int[] MyArray)
        {
            int counter=0;

            int[] Buffer = new Int32[MyArray.Length];

            for (int i = 0; i < MyArray.Length; i++)
            {
                if (Natural(MyArray[i]))
                {
                    Buffer[counter] = MyArray[i];
                    counter++;
                }
            }

            Array.Resize<int>(ref Buffer, counter);

            return Buffer;
        }

        //Седьмая функция
        static int[] Sort(int[] MyArray)
        {
            int SavePoint;
            for (int i = 0; i < MyArray.Length; i++)
                for (int j = i; j < MyArray.Length; j++)
                    if (MyArray[i] > MyArray[j])
                    {
                        SavePoint = MyArray[i];
                        MyArray[i] = MyArray[j];
                        MyArray[j] = SavePoint;
                    }

            return MyArray;
        }

        //Восьмая функция
        static int Binar_Search(int[] MyArray, int Number)
        {
            int left = 0, right = MyArray.Length-1, pos = -1;
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (Number == MyArray[mid])
                {
                    pos = mid;
                    break;
                }

                if (Number > MyArray[mid])
                    left = mid+1;
                else
                    right = mid-1;
            }

            return pos;


        }
    }
}
