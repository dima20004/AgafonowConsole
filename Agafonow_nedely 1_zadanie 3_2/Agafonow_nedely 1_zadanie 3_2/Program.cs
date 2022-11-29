using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_1_zadanie_3_2
{
    internal class Program
    {
        static double f(double x)
        {
            double y;
            if (Math.Abs(x) < Math.PI/2) y =Math.Sin(x);
            else if (Math.Abs(x) > Math.PI) y = 0;
            else y = Math.Cos(x);
            return y;
        }

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


        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = readDouble();
            Console.Write("b=");
            double b = readDouble();
            Console.Write("h=");
            double h = readDouble();

            for (double i = a; i < b; i =i + h)
            {
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
            }





        }
    }
}
