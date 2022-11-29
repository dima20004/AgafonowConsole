using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_1_zadanie_3
{
    internal class Program
    {
        private static double readDouble()
        {
            do
            {   //Проверка на ввод данных
                double result;
                bool parsed = double.TryParse(Console.ReadLine(), out result);
                if (parsed) return result;
                else Console.Write("Введите корректное число =");

            } while (true);


        }

        private static double min(double a,double b)
        {
            if (a < b) { return a; }
            else if (b < a) { return b; }
            else return a;

        }


        static void Main(string[] args)
        {
            Console.Write("Введите a=");
            double a = readDouble();
            Console.Write("Введите b=");
            double b= readDouble();
            double c=min(a, b);
            Console.WriteLine("Минимальное число={0}",c);

            Console.Write("Введите первое число=");
            double d = readDouble();
            Console.Write("Введите второе число=");
            double e = readDouble();
            Console.Write("Введите третье число=");
            double j = readDouble();
            Console.Write("Введите четвертое=");
            double r = readDouble();
            double l = min(min(d, e), min(j, r));
            Console.WriteLine("Минимальное число из четырех чисел={0}", l);

        }




    }
}
