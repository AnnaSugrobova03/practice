using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    class MyMatrix
    {
        private int a, b, c, d;
        public MyMatrix(int a, int b)
        {
            Random r = new Random();
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    Matrix[i, j] = r.Next(-100, 100);
        }
        public int[,] Matrix = new int[100, 100];

        public void OutputM(int c, int d) //вывод матрицы
        {          
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                    Console.Write(Matrix[i, j] + "\t");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
    class podmatrix
    {
        public podmatrix(ref int[,] matr, int a, int b)
        {
            A = a; B = b;
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    Array[i, j] = matr[i, j]; //передача элементов в подматрицу
        }

        private int A, B; 
        private int[,] Array = new int[300, 300]; 

        public void OutputPodM() //вывод подматрицы
        {
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                    Console.Write(Array[i, j] + "\t");
                Console.Write("\n");
            }
        }
    }
    class MainMainov
    {
        public static void Main()
        {
            int a, b, c, d;
            Console.WriteLine("Матрица:");
            Console.Write("Введите количество строк = ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов = ");
            b = Int32.Parse(Console.ReadLine());
            MyMatrix arr = new MyMatrix(a, b);
            arr.OutputM(a, b);

            Console.WriteLine("Подматрица:");
            Console.Write("Введите количество строк подматрицы = ");
            c = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов подматрицы = ");
            d = Int32.Parse(Console.ReadLine());

            podmatrix A = new podmatrix(ref arr.Matrix, c, d);
            A.OutputPodM();
            Console.ReadKey();

        }
    }
}
