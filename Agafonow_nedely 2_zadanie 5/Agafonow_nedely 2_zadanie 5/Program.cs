using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_2_zadanie_5
{
    internal class Program
    {

        static double f(double x)
        {
            try
            {
                //если х не попадает в область определения, то генерируется исключение 
                if (x == -1||x==1) throw new Exception();
                else return  1/(x*x-1) ;
            }
            catch
            {
                throw;
            }
        }

        private static double readDouble()
        {
            do
            {   //Проверка на ввод данных
                double result;
                bool parsed = double.TryParse(Console.ReadLine(), out result);
                if (parsed) return result;
                else Console.Write("Неверный формат введите число еще раз=");

            } while (true);


        }


        static void Main(string[] args)
        {

            try
            {
                Console.Write("Введите a=");
                double a = readDouble();
                Console.Write("Введите b=");
                double b = readDouble();
                Console.Write("Введите h=");
                double h = readDouble();
                for (double i = a; i <= b; i += h)
                    try
                    {
                        Console.WriteLine("y({0})={1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y({0})=Не имеeт значения", i);
                    }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }





        }
    }
}
