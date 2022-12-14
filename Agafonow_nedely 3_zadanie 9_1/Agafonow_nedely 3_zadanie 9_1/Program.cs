using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_3_zadanie_9_1
{
    internal class Program
    {
        private static double readDouble()
        {
            do
            {   //Проверка на ввод данных
                double result;
                bool parsed = double.TryParse(Console.ReadLine(), out result);
                if (parsed) return result;
                else Console.Write("Введите корректную степень 3=");

            } while (true);

        }
            static void Main(string[] args)
        {
            bool a = true;
            double s = 0;
            while (a)
            {
                Console.Write("Введите степень числа 3: ");
                s = 0;
                s = readDouble();
                if (s < 0)
                {
                    Console.WriteLine("Введите корректную степень 3!");
                }
                else a = false;
            }

            if (s != 0)
            {
                using (StreamWriter sw = new StreamWriter(@"D:\zadanie9.bin"))
                {
                    for (double i = 0; i <= s; i++)
                    {
                        sw.WriteLine(Math.Pow(3, i));
                    }
                }
                using (StreamReader sr = new StreamReader(@"D:\zadanie9.bin"))
                {
                    while (!sr.EndOfStream)
                    {
                        string str;
                        
                        str = sr.ReadLine();
                        sr.ReadLine();
                        Console.WriteLine(str);
                        
                    }
                    
                }
            }

        }
    }
}
