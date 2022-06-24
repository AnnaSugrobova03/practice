using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Directory.CreateDirectory($@"C:\\Folder_{i}");
            }
            Console.WriteLine("Директории созданы!");
            Console.WriteLine("Удалить директории?\n1. Да\n2. Нет");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                for (int i = 0; i < 100; i++)
                {
                    Directory.Delete($@"C:\\Folder_{i}");
                }
                Console.WriteLine("Директории удалены");
            }
            else if (n == 2)
                Console.WriteLine("Директории на месте");
        }
    }
}
