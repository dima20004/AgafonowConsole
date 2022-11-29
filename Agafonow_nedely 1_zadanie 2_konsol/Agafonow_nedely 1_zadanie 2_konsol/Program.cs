using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_1_zadanie_2_konsol
{
    internal class Program
    {
        private static int readInt()
        {
            do
            {   //Проверка на ввод данных
                int result;
                bool parsed = int.TryParse(Console.ReadLine(), out result);
                if (parsed) return result;
                else Console.Write("Порядковый номер целочисленный, повторите попытку n=");

            } while (true);

        }

        static void Main(string[] args)
        {

            //первая программа задание 1
            Console.Write("x=");
            int x = readInt();
            Console.Write("y=");
            int y = readInt();
            if (x * x + y * y < 81 && x > 0)
                Console.WriteLine("Точка находится нутри области");
            else if (x * x + y * y > 81 || x < 0)
                Console.WriteLine("Точка находится вне области");
            else Console.WriteLine("Точка находится на границах области");

            //вторая программа задание 2
            int n = 0;
            bool a = true;
            while (a)
            {
                Console.Write("Введите Ваш порядковый номер месяца n=");
                n = readInt();
                if (n > 12 || n < 0) Console.WriteLine("Вы ввелие некорректный порядковый номер месяца");
                if (n <= 12 && n >= 0) a = false;

            }

            switch (n)
            {
                case 0: Console.WriteLine("Осталось 12 месяцев до конца года"); break;
                case 1: Console.WriteLine("Осталось 11 месяцев до конца года"); break;
                case 2: Console.WriteLine("Осталось 10 месяцев до конца года"); break;
                case 3: Console.WriteLine("Осталось 9 месяцев до конца года"); break;
                case 4: Console.WriteLine("Осталось 8 месяцев до конца года"); break;
                case 5: Console.WriteLine("Осталось 7 месяцев до конца года"); break;
                case 6: Console.WriteLine("Осталось 6 месяцев до конца года"); break;
                case 7: Console.WriteLine("Осталось 5 месяцев до конца года"); break;
                case 8: Console.WriteLine("Осталось 4 месяцев до конца года"); break;
                case 9: Console.WriteLine("Осталось 3 месяцев до конца года"); break;
                case 10: Console.WriteLine("Осталось 2 месяцев до конца года"); break;
                case 11: Console.WriteLine("Осталось 1 месяцев до конца года"); break;
                case 12: Console.WriteLine("Осталось 0 месяцев до конца года"); break;
                default: Console.WriteLine("ВЫ ОШИБЛИСЬ"); break;
            }
            Console.ReadLine();
            //третья программа задание 3
            int q = 60;
            bool w = true;
            while (w)
            {

                Console.WriteLine(q);
                if (q == 10)
                {
                    w = false;
                    break;
                }
                q = q - 2;


            }
            Console.ReadLine();
            int e = 60;
            bool r = true;
            do
            {
                Console.WriteLine(e);
                if (e == 10)
                {
                    r = false;
                    break;
                }
                e = e - 2;



            } while (r);

            Console.ReadLine();
            for (int i = 60; i != 8; i = i - 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();



            //четвертая программа задание 4
            for (int j = 1; j < 5; j++)
            {
                for (int i = 1; i < 11; i++)
                {

                    Console.Write(i + " ");


                }
                Console.WriteLine();
            }





        }
    }
}


    

