using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    class Program
    {
        Random r = new Random();

        int[] array = new int[10];

        public void Generate()//генерация массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 30);
            }
        }
        public void Print()//вывод массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }       

        public void Sort()  //сортировка
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int x = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = x;
                    }
                }
            }
        }

        static void Main()
        {
            Program sort = new Program();

            sort.Generate();
            sort.Sort();
            sort.Print();
            Console.ReadKey();
        }
    }
}
