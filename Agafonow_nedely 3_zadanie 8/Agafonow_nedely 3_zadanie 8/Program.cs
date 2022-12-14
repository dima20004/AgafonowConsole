using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Agafonow_nedely_3_zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введите сообщение: ");
            string x = Console.ReadLine();
            Console.Write("Введите слово: ");
            string words = Console.ReadLine();
            Regex r = new Regex(@"\b" + words + @"\b", RegexOptions.IgnoreCase);
            //Определяет, входит ли шаблон регулярного выражения во входной текст,
            //с помощью метода Regex.IsMatch.


            if (r.IsMatch(x))   //Метод Указывает на то, обнаружино ли регулярное выражение
                                //во входной строке.
            {
                Console.WriteLine("Сообщение содержит заданное слово");
            }
            else
            {
                Console.WriteLine("Сообщение не содержит заданное слово");
            }

        }






    }
    }

