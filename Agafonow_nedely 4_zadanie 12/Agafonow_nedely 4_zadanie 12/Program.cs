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
                else Console.Write("Введите число=");

            } while (true);
        }

        class Point
        {
            public int x;
            public int y;

            public Point()
            {
                x = 0;
                y = 0;

            }

            public Point(int X, int Y)
            {
                x = X;
                y = Y;

            }


            public void schowPoints()
            {
                Console.WriteLine($"x={x}, y={y}");
            }

            public void showCalculate()
            {
                double s;
                s = Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0));
                Console.WriteLine($"Расстояние от начала координат до точки={s}");
            }

            public void Moving(int a, int b)
            {
                x = x + a;
                y = y + b;
                Console.WriteLine($"Координаты точки после перемещения на вектор (a,b) x={x}, y={y}");
            }

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


            // Перегрузка операций ++ и -- и +
            public static Point operator --(Point Ad)
            {
                Ad.x -= 1;
                Ad.y -= 1;
                return Ad;
            }

            public static Point operator ++(Point Ad)
            {
                Ad.x += 1;
                Ad.y += 1;
                return Ad;
            }

            // перегрузка true или false, если они не равны, то false, иначе true
            public static bool operator false(Point Ad)
            {
                if (Ad.x != Ad.y)
                    return false;
                return true;
            }

            public static bool operator true(Point Ad)
            {
                if (Ad.x == Ad.y)
                    return true;
                return false;
            }
            public static Point operator +(Point Ad, int skalar)
            {
                Ad.x = Ad.x + skalar;
                Ad.y = Ad.y + skalar;
                return Ad;
            }

            public static Point operator -(Point Ad, int skalar)
            {
                Ad.x = Ad.x + skalar;
                Ad.y = Ad.y + skalar;
                return Ad;
            }

            public static Point operator +(int skalar, Point Ad)
            {
                Ad.x = Ad.x + skalar;
                Ad.y = Ad.y + skalar;
                return Ad;
            }

            public static Point operator -(int skalar, Point Ad)
            {
                Ad.x = Ad.x + skalar;
                Ad.y = Ad.y + skalar;
                return Ad;
            }

            // Индексаторы 0=x, 1=y, если не 0 и 1, то ошибка
            public int this[int index]
            {
                get
                {
                    if (index == 0) return x;
                    if (index == 1) return y;
                    else
                        throw new Exception("Ошибка");// в противном случае ошибка
                }
            }


            // преобразования типа Point в string (и наоборот).
            public static explicit operator String(Point obj)
            {
                return obj.x + ", " + obj.y;
            }

            public static explicit operator Point(string str)
            {
                string[] q = str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                Point obj = new Point();
                obj.x = int.Parse(q[0]);
                obj.y = int.Parse(q[1]);
                return obj;
            }

        }







        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленные координаты");
            Console.Write("Введите x=");
            int x = readInt();
            Console.Write("Введите y=");
            int y = readInt();

            Point point = new Point(x, y);
            Point zeroPoint = new Point();

            Console.WriteLine("Координаты точки:");
            Console.WriteLine("Координаты точки с нулевыми координтами:");
            zeroPoint.schowPoints();
            Console.WriteLine("Координаты точки с заданными координатами:");
            point.schowPoints();
            Console.WriteLine();

            Console.WriteLine("Tочка с заданными координатами:");
            point.showCalculate();
            Console.WriteLine("Tочка с нулевыми координатами:");
            zeroPoint.showCalculate();
            Console.WriteLine();

            Console.WriteLine("Перемещение точки на вектор");
            Console.Write("Введите У вектора A=");
            int a = readInt();
            Console.Write("Введите У вектора B=");
            int b = readInt();
            point.Moving(a, b);
            zeroPoint.Moving(a, b);
            Console.WriteLine("Tочка с заданными координатами:");
            point.schowPoints();
            Console.WriteLine("Tочка с нулевыми координатами:");
            zeroPoint.schowPoints();
            Console.WriteLine();

            Console.WriteLine("Получение и установление координаты точке через свойства");
            Console.Write("Введите x=");
            int X = readInt();
            Console.Write("Введите y=");
            int Y = readInt();
            point.X = X;
            point.Y = Y;
            Console.Write("X=" + point.X+" ");
            Console.Write("Y=" + point.Y+" ");
            Console.WriteLine();

            Console.WriteLine("Умножение координаты точки на скаляр");
            Console.Write("Введите скаляр=");
            int SCA = readInt();
            point.SkalarX = SCA;
            point.SkalarY = SCA;
            Console.WriteLine("X=" + point.X);
            Console.WriteLine("Y=" + point.Y);
            Console.WriteLine();

            Console.WriteLine("при ++ значение координат увеличивается на 1");
            point++;
            point.schowPoints();
            Console.WriteLine();
            Console.WriteLine("при -- значение координат уменьшается на 1");
            point--;
            point.schowPoints();
            Console.WriteLine();

            Console.WriteLine("При + значение координат увеличивается на скаляр ");
            point = point + SCA;
            point.schowPoints();
            Console.WriteLine();

            Console.WriteLine("При - значение координат уменьшается на скаляр ");
            point = point - SCA;
            point.schowPoints();
            Console.WriteLine();

            Console.WriteLine("При + значение координат увеличивается на скаляр ");
            point = SCA + point;
            point.schowPoints();
            Console.WriteLine();

            Console.WriteLine("Если x и y равны, то true, иначе false");

            if (point)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            Console.WriteLine();

            Console.WriteLine("Преобразования типа Point в string:");
            string str = (string)point;
            Console.WriteLine("Переменная типа string: ");
            Console.WriteLine(str);
            Console.WriteLine();

            Console.WriteLine("Преобразования типа string в Point:");
            point = (Point)str;
            point.schowPoints();
            Console.WriteLine();

            Console.WriteLine("Обращение по индексу!");
            Console.WriteLine($"x={zeroPoint[0]} y={zeroPoint[1]}");
            Console.WriteLine($"x={point[0]} y={point[1]}");
            

        }



    }
}
