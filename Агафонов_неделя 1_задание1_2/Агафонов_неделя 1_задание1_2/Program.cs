using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Агафонов_неделя_1_задание1_2
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
                    else Console.Write("Введите целое число=");

                } while (true);


            }

        static void Main(string[] args)
        {
            Console.Write("Введите целое число=");
            int a = readInt();
            string s = "четным ";
            string p = "нечетным ";
            bool boll = true;


            a = a % 2;
          
            if (a != 0) boll = false; 



            if (boll==true) { 
            Console.Write("Число является " + s);
        }
         if (boll==false) { 
    Console.Write("Число является " + p);
        }

        }





    }
}
