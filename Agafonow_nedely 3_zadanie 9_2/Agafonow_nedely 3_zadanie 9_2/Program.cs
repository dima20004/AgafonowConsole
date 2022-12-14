using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Agafonow_nedely_3_zadanie_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\dop.txt");

            string line = sr.ReadLine();

            int k = 0;

            char[] chars=line.ToCharArray();

            while (line != null)
            { chars=line.ToCharArray();
                char buf = char.ToUpper(chars[0]);
                char buf2 = char.ToUpper(chars[chars.Length - 1]);
                if (buf==buf2) k++;
                line = sr.ReadLine();
            };

            sr.Close();
            
            Console.WriteLine("Количество строк, которые начинаются и заканчиваются на одну и ту же букву=" + k);
            Console.ReadKey();

        }
    }
}
