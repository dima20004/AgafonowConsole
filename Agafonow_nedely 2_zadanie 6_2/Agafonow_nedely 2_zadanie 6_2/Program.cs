using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_2_zadanie_6_2
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
            bool flag = true;
            int n=0;
            while (flag)
            {
                Console.Write("Введите размерность массива=");
                n = readInt();
                if (n < 1) { Console.WriteLine("Введите корректный размер массива!"); }
                else flag=false;
            }
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = readInt();
            }
            return a;
        }

        static void print(int[] a)
        {
            for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        static void printIlement(int[] a, int min)
        {
            int j = 1;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] == min)
                {
                    Console.WriteLine("Минимальный элемент по номером {0} ", i);
                    
                }

            } 
        }

        static int min(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; ++i)
                if (a[i] < min) min = a[i];
            return min;
        }

        static void Main(string[] args)
        {
            int[] myArray = input();
            Console.WriteLine("Исходный массив:");
            print(myArray);
            printIlement(myArray, min(myArray));
           
            
        }





    }
}
