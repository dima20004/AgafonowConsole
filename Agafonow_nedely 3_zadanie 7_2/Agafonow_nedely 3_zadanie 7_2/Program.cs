using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_3_zadanie_7_2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string a=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Исходная строка: " + Convert.ToString(a));

            Console.WriteLine("Введите количество символов n:");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] myStrings;
            myStrings = a.Split(' ');
            for (int i = 0; i < myStrings.Length; i++)
            {
                if (myStrings[i].Length > n)
                {

                }
                else
                {
                    Console.WriteLine(myStrings[i]);
                }

            }


        }
    }
}
