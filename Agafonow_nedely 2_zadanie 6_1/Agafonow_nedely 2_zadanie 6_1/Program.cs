using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_2_zadanie_6_1
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
       

        static int[] input()
        {
            bool flag=true;
            int n=0;
            while (flag)
            {
                Console.Write("Введите размерность массива=");
                n = readInt();
                if (n < 1) { Console.WriteLine("Введите корректный размер массива!"); }
                if (n > 0) { flag = false; }
            }
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] =readInt();
            }
            return a;
        }

        static void print(int[] a)
        {
            for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }


        static void сhange(int[] a,int b)
        {
            for (int i = 0; i < a.Length; ++i)
                if (a[i] < b) a[i] = b;
        }

       //Двумерный массив
        static int[,] input2(out int n, out int m)
        {
            Console.WriteLine("Введите размерность массива");
            Console.Write("Количество строк n = ");
            n = readInt();
            Console.Write("Количество столбцов m = ");
            m = readInt();
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }

        static void print2(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }

        static void change2(int[,] a,int b)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                    if (a[i, j] <b) a[i, j] = b;
        }




        static void Main(string[] args)
        {
            int[] myArray = input();
            Console.WriteLine("Исходный массив:");
            print(myArray);
            Console.Write("Задайте число=");
            int a = readInt();
            сhange(myArray,a);
            Console.WriteLine("Измененный массив:");
            print(myArray);

            //Двумерный массив
            int n, m;
            int[,] myArray2 = input2(out n, out m);
            Console.WriteLine("Исходный массив:");
            print2(myArray2);
            change2(myArray2,a);
            Console.WriteLine("Измененный массив:");
            print2(myArray2);


        }

    }
}
