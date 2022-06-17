using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    public static class ColorType
    {
        enum Colors
        {
            Red = 1,
            Green = 2,
            Blue = 3,
            Yellow = 4,
            Violet = 5            
        }
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(stroka);
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("err0r!");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру от 1 до 5 для выбора цвета: \n1 - Красный, \n2 - Зелёный,\n3 - Синий,\n4 - Жёлтый,\n5 - Фиолетовый");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();

            ColorType.Print(str, col);
            Console.ReadKey();
        }
    }
}
