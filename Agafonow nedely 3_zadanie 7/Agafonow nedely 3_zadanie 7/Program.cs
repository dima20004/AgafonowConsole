using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_3_zadanie_7
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Исходная строка: " + a);

           
            for (int i = 0; i < a.Length-1; i=i+2)
            {
                if (a[i] == ' ' || a[i + 1] == ' ')
                {
                    i=i - 1;
                }
                else
                {
                    char buf = a[i];
                    buf = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = buf;
                }
               
            }
               
            Console.WriteLine("Измененная строка: " + a);
        }

    }
}

