using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_2_zadanie_4_2
{


    internal class Program
    {
       

        private static double readDoule()
        {
            do
            {   //Проверка на ввод данных
                double result;
                bool parsed = double.TryParse(Console.ReadLine(), out result);
                if (parsed) return result;
                else Console.Write("Введите число заново=");

            } while (true);
        }


        static void Rec(double n, ref double x, double d, ref double s)
        {
            if (n > 0)
            {
                s += x;
                x += d;

                Rec(n - 1, ref x, d, ref s);
            }
        }

       

        static void Main(string[] args)
        {
            Console.Write("Введите первый член арифметической прогрессии:");
            double n1 = readDoule();
            Console.Write("Введите разность арифметической прогрессии:");
            double d = readDoule();
            bool r = true;

            double n=0;
            while (r)
            {
                Console.Write("Введите n-й член прогрессии:");
                n = readDoule();
                if (n < 1) Console.WriteLine("n>1!");
                if (n >= 1) r = false;
            }
       

           
            double s = 0;
            Rec(n, ref n1, d, ref s);
            Console.WriteLine($"{n}-й член прогрессии={n1-d}, сумма {n} первых членов прогрессии s={s}");

        }
    }
}
