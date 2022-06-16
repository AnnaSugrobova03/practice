using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public Rectangle() { }

        double AreaCalc()
        {
            return side1 * side2;
        }

        double PerimeterCalc()
        {
            return 2 * (side1 + side2);
        }

        public double Area { get { return this.AreaCalc(); } }
        public double Perimeter { get { return this.PerimeterCalc(); } }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введите сторону a прямоугольника: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double side1 = x;

            Console.Write("Введите сторону b прямоугольника: ");
            int y = Convert.ToInt32(Console.ReadLine());
            double side2 = y;

            Rectangle ab = new Rectangle(side1, side2);

            Console.WriteLine("Периметр = {0}", ab.Perimeter);
            Console.WriteLine("Площадь = {0}", ab.Area);

            Console.ReadKey();
        }
    }
}
