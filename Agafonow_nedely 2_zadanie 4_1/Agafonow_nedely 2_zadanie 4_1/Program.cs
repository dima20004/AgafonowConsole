using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_2_zadanie_4_1
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
                else Console.Write("Повторите попытку (введите целое число) n=");

            } while (true);
        }

            static int recurs(int n)
        {
            int b1 = -10;
            int b2 = 2;
            if (n <= 0)
                return 0;
            if (n == 1)
                return b1;
            if (n == 2)
                return b2;
            return Math.Abs(recurs(n - 2)) - 6 * recurs(n - 1);
    }

    static void Main(string[] args)
        {
            bool a = true;
            int n=0;
            while (a)
            {
                Console.Write("Введите n=");
                n = readInt();
                if (n < 1) Console.WriteLine("n>0!");
                else a = false;
            }
            Console.WriteLine("Значение={0}", recurs(n));

        }

    }
}
