using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Program
    {
        public abstract class Figure
        {
            public abstract void ShowInfo();
            public abstract void Area();

            public abstract void Perimeter();

          
        }

        //Создать производные классы: Rectangle (прямоугольник) со своими методами вычисления площади и периметра.
        class Rectangle : Figure
        {
            int a, b;

            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public override void ShowInfo()
            {
                Console.WriteLine($"Прямоугольник со сторонами {a} и {b}");
            }
            public override void Area() {

                Console.WriteLine($"Площадь прямоугольника={a * b}");
                }

            public override void Perimeter() {
                Console.WriteLine($"Периметр прямоугольника={(a + b) * 2}");
            }

            
        }

        //Создать производные классы: Triangle (треугольник) со своими методами вычисления площади и периметра.
        class Triangle : Figure
        {
            int a, b, c;

            public Triangle(int a, int b, int c)
            {
                this.a = a;
                this.c = c;
                this.b = b;
            }

            public override void ShowInfo()
            {
                Console.WriteLine("Треугольник со сторонами {0}, {1}, {2}", a, b, c);
            }

            public override void Perimeter() {
                Console.WriteLine($"Периметр треугольника={a + b + c}"); 
            }


            public override void Area()
            {
                double p = (a+b+c) / 2;
                Console.WriteLine($"Площадь треугольника равна={Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");
            }

            
        }

        //Создать производные классы: Circle (круг), со своими методами вычисления площади и периметра.
        class Circle : Figure
        {
            const double pi = 3.14;

            int r;

            public override void ShowInfo()
            {
                Console.WriteLine("Круг радиусом {0}", r);
            }
            public Circle(int r) { this.r = r; }

            public override void Area() {
                Console.WriteLine($"Площадь круга={pi * r * r}"); 
            }

            public override void Perimeter() {
                Console.WriteLine($"Периметр круга={2 * pi * r}");
            }

            
        }
        public static string ReadFile()
        {
            string str = string.Empty; //Представляет пустую строку. Это поле доступно только для чтения.

            try
            {
                StreamReader fin = new StreamReader(@"D:\zadanie13.txt");
                str = fin.ReadToEnd();
                fin.Close();
            }
            catch 
            {
                Console.WriteLine("Ошибка! Проверьте файлы!");
            }
            return str;
        }

        public static Figure[] GetArrayFigures()
        {
            string[] s = ReadFile().Split('\n');
            Figure[] array_fig = new Figure[s.Length];

            int a, b, c, r, i = 0, n = 0;

            while (i < s.Length)
            {
                string[] str = s[i].Split(' ');

                if (str[0] == "rectangle")
                {
                    a = Convert.ToInt32(str[1]);
                    b = Convert.ToInt32(str[2]);
                    array_fig[n] = new Rectangle(a, b);
                    n++;
                }
                if (str[0] == "circle")
                {
                    r = Convert.ToInt32(str[1]);
                    array_fig[i] = new Circle(r);
                    n++;
                }
                if (str[0] == "triangle")
                {
                    a = Convert.ToInt32(str[1]);
                    b = Convert.ToInt32(str[2]);
                    c = Convert.ToInt32(str[3]);
                    array_fig[i] = new Triangle(a, b, c);
                    n++;
                }
                i++;
            }
            return array_fig;
        }

       
        
        
        static void Main(string[] args)
        {
            Figure[] array_fig = GetArrayFigures();

            foreach (Figure fig in array_fig)
            {

            fig.ShowInfo();
            fig.Area();
            fig.Perimeter();
            Console.WriteLine();
            
            }
            Console.ReadKey();
        }

    }
}
