using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Агафонов_неделя_1_задание_1
{
    internal class Program
    {
        private static double readDouble()
        {
            do
            {   //Проверка на ввод данных
                double result;
                bool parsed = double.TryParse(Console.ReadLine(),out result);
                if (parsed) return result;
                else Console.Write("Введите корректное число p=");

            } while (true);


        }
        static void Main(string[] args)
        {



            Console.Write("Введите p=");
            double p = readDouble();
            double s = (Math.Pow(p/3,2)*Math.Sqrt(3))/4 ;
            Console.WriteLine("Площадь равностороннего треугольника=" + s);

        }
    }
}
