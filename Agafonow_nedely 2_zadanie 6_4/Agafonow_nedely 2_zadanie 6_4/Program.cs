using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_2_zadanie_6_3
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
                else Console.Write("Введите целое число! Повторите попытку=");

            } while (true);
        }
        static void print(int[] a)
        {
            for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
            static int[,] input2(int n, int m)
        {
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = readInt();
                }
            return a;
        }

        static void print2(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0} ", a[i, j]);
        }

        static void finding(int[,] a, int n, int m, int[]b)
        {
            int s = 0;
            for (int j = 0; j < n; j++)
            {   int min = a[0, j];
                for (int i = 0; i < n; i++)
                {
                    
                    if (a[i,j] < min) {min=a[i,j];}
                }

                b[j] = min;

            }

        }





        static void Main(string[] args)
        {
            int n=0, m=0;
            bool krik = true;
            while (krik)
            {
                Console.WriteLine("Введите размерность массива");
                Console.Write("Количество строк n = ");
                n = readInt();
                Console.Write("Количество столбцов m = ");
                m = readInt();
                if (m < 1 || n < 1) { Console.WriteLine("Введите положительные числа!"); }
                if (m > 0 && n > 0) {krik = false;}
            }
            int[] myArr = new int[m];
            int[,] myArray = input2(n, m);
            Console.WriteLine("Исходный массив:");
            print2(myArray);
            finding(myArray, n, m, myArr);
            Console.WriteLine("Массив с минимальным элементом в каждом столбце:");
            print(myArr);



        }




    }
}
