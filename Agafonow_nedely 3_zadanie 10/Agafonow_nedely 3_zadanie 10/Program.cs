using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agafonow_nedely_3_zadanie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(@"D:\temp"))         //Если эта папка не существует
            {
                Directory.CreateDirectory(@"D:\temp"); //Создает папку temp
            }
            Directory.CreateDirectory(@"D:\temp\K1");  //Создает папку K1

            Directory.CreateDirectory(@"D:\temp\K2");  //Создает папку K2


            StreamWriter sw = new StreamWriter(@"D:\temp\K1\t1.txt");//Создает в K1 t1.txt

            sw.Write("Агафонов Дмитрий Александрович, 1965 года рождения, место жительства г. Владимир");//Записывает в К1

            sw.Close();

            sw = new StreamWriter(@"D:\temp\K1\t2.txt"); //Создает в K2 t2.txt

            sw.Write("Агафонов Дмитрий Александрович, 1966 года рождения, место жительства г.Гусь-Хрустальный");//Записывает в K2

            sw.Close();

            sw = new StreamWriter(@"D:\temp\K2\t3.txt");//Создает в K2 t3.txt

            StreamReader sr = new StreamReader(@"D:\temp\K1\t1.txt");

            sw.WriteLine(sr.ReadToEnd());              //Записывает в t3 содержимое t1

            sr.Close();


            sr = new StreamReader(@"D:\temp\K1\t2.txt");


            sw.WriteLine(sr.ReadToEnd());//Записывает в t3 содержимое t2

            sr.Close();

            sw.Close();

            DirectoryInfo adinf = new DirectoryInfo(@"D:\temp\K1");//Создаем объект папки ALL
            FileInfo[] afinf = adinf.GetFiles();//GetFiles возвращает список файлов из текущего каталога

            foreach (FileInfo fi in afinf)
            {
                Console.WriteLine(fi.FullName.ToString());
                Console.WriteLine(fi.CreationTime.ToString());
                Console.WriteLine($"{fi.Length.ToString()} байт");
                //Выводим в консоль полный путь файлов
            }


            DirectoryInfo adinfa = new DirectoryInfo(@"D:\temp\K2");//Создаем объект папки ALL
            FileInfo[] afinfa = adinfa.GetFiles();//GetFiles возвращает список файлов из текущего каталога

            foreach (FileInfo fi in afinfa)
            {
                Console.WriteLine(fi.FullName.ToString());
                Console.WriteLine(fi.CreationTime.ToString());
                Console.WriteLine($"{fi.Length.ToString()} байт");
                //Выводим в консоль полный путь файлов
            }

            File.Move(@"D:\temp\K1\t2.txt", @"D:\temp\K2\t2.txt");//Перемещаем t2 в K2

            File.Copy(@"D:\temp\K1\t1.txt", @"D:\temp\K2\t1.txt");//Копируем t1 в K2

            Directory.Move(@"D:\temp\K2", @"D:\temp\ALL");//Перемеиновываем K2 d ALL

            Directory.Delete(@"D:\temp\K1", true);//Удаляем K1

            DirectoryInfo dinf = new DirectoryInfo(@"D:\temp\ALL");//Создаем объект папки ALL
            FileInfo[] finf = dinf.GetFiles();//GetFiles возвращает список файлов из текущего каталога

            foreach (FileInfo fi in finf)
            {
                Console.WriteLine(fi.FullName.ToString());
                Console.WriteLine(fi.CreationTime.ToString());
                Console.WriteLine($"{ fi.Length.ToString()} байт") ;
                //Выводим в консоль полный путь файлов
            }





        }






    }
}
