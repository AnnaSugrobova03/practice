using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\Desktop\Практика\ввод-вывод\test.txt";
            Console.WriteLine("Создание файла\n");
            StreamWriter file = new StreamWriter(path);
            Console.WriteLine("Введите текст к файлу");
            file.Write(Console.ReadLine());
            file.Close();

            StreamReader sr = new StreamReader(@"C:\Users\user\Desktop\Практика\ввод-вывод\test.txt");
            Console.WriteLine("\nСодержимое файла:");
            for (int i = 0; i < File.ReadAllLines(@"C:\Users\user\Desktop\Практика\ввод-вывод\test.txt").Length; i++)
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
