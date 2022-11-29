using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Аgafonow_nedely_1_zadanie_3_3
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
                else Console.Write("Введите корректное число=");

            } while (true);


        }


        static void f(double x, out double y)
        {
            x=40.5;
            y=100.5;
            Console.WriteLine("Уху! x={0} y={1}", x, y);
        }
        static double f(double x)
        {
            x = 100 - 50;
            return x;
        }

        static void f(double x, double y)
        {
            Console.WriteLine("X={0} Y={1}",x, y);
           
        }



        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = readDouble();
            Console.Write("b=");
            double b = readDouble();

            Console.WriteLine("Перегрузка функции при out!");
            f(a, out b);

            Console.WriteLine("Перегрузка функции при одном аргументу!");
            Console.WriteLine("X={0}",f(a));

            Console.WriteLine("Перегрузка функции при двух аргументах!");
            f(a, b);

        }




    }
}
