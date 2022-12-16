using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Agafonow_nedely_3_zadanie_11
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
                else Console.Write("Введите корректное число=");

            } while (true);
        }

        //Класс Point
        class Point
        {
            public int x;
            public int y;

            //Конструктор при нулевых параметрах
            public Point()
            {
                x = 0;
                y= 0;

            }
            //Конструктор при заданных параметрах
            public Point(int X, int Y)
            {
                x = X;
                y = Y;

            }

            //Метод вывода координат точек
            public void schowPoints()
            {
                Console.WriteLine($"x={x}, y={y}");
            }

            //Метод вывода расстояния от начала координат до точки 
            public void showCalculate()
            {
                double s;
                s=Math.Sqrt((x-0)*(x-0)+(y-0)*(y-0));
                Console.WriteLine($"Расстояние от начала координат до точки={s}");
            }

            //Метод вычесления и вывода координат точки после перемещения на вектор a,b
            public void Moving(int a, int b)
            {
                x = x + a;
                y = y + b;
                Console.WriteLine($"Координаты точки после перемещения на вектор (a,b) x={x}, y={y}");
            }
            //Свойства для записи и вывода координат точки
            public int X
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
                }

            }
            public int Y
            {
                get
                {
                    return y;
                }
                set
                {
                    y = value;
                }

            }
            //Свойство позволяющее вывести умножить координаты точки на скаляр
            public int SkalarX
            {
                set
                {
                    x = x * value;
                }
            }

            public int SkalarY
            {
                set
                {
                    y = y * value;
                }
            }

           
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленные координаты");
            Console.WriteLine("Введите x=");
            int x = readInt();
            Console.WriteLine("Введите y=");
            int y = readInt();

            Point point = new Point(x, y);
            Point emptyPoint = new Point();

            Console.WriteLine("Координаты точки:");
            Console.WriteLine("Координаты точки с нулевыми координтами:");
            emptyPoint.schowPoints();
            Console.WriteLine("Координаты точки с заданными координатами:");
            point.schowPoints();
            Console.WriteLine();

            Console.WriteLine("Tочка с заданными координатами:");
            point.showCalculate();
            Console.WriteLine("Tочка с нулевыми координатами:");
            emptyPoint.showCalculate();
            Console.WriteLine();

            Console.WriteLine("Перемещение точки на вектор");
            Console.WriteLine("Введите у вектора a=");
            int a=readInt();
            Console.WriteLine("Введите у вектора b=");
            int b = readInt();
            point.Moving(a, b);
            emptyPoint.Moving(a, b);
            Console.WriteLine("Tочка с заданными координатами:");
            point.schowPoints();
            Console.WriteLine("Tочка с нулевыми координатами:");
            emptyPoint.schowPoints();
            Console.WriteLine();

            Console.WriteLine("Получение и установление координаты точке через свойства");
            Console.WriteLine("Введите x=");
            int X = readInt();
            Console.WriteLine("Введите y=");
            int Y = readInt();
            point.X = X;
            point.Y = Y;
            Console.WriteLine("X="+point.X);
            Console.WriteLine("Y="+point.Y);
            Console.WriteLine();

            Console.WriteLine("Умножение координаты точки на скаляр");
            Console.WriteLine("Введите скаляр=");
            int SCA=readInt();
            point.SkalarX = SCA;
            point.SkalarY = SCA;
            Console.WriteLine("X="+point.X);
            Console.WriteLine("Y="+point.Y);
            Console.WriteLine();


        }



    }
}
