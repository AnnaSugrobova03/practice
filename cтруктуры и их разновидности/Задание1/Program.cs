using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    public struct Train
    {
        string Name;
        public int Number;
        public DateTime Time;

        public Train(string name,int number,DateTime time)
        {
            this.Name = name;
            this.Number = number;
            this.Time = time;
        }
        public void Info()
        {
            Console.WriteLine("Название: " + this.Name + "\n Номер поезда: " + this.Number + "\n Время отправления: " + this.Time);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train[] poezd = new Train[2];

            for (int i = 0; i < poezd.Length; i++)//ввод данных
            {
                Console.WriteLine("Введите название поезда: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите номер поезда: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите время отправления (в формате чч:мм) : ");
                DateTime time = DateTime.Parse(Console.ReadLine());

                poezd[i] = new Train(name, number, time);
            }

            Train sort;
            for (int i = 0; i < poezd.Length - 1; i++)//сортировка
            {
                for (int j = i + 1; j < poezd.Length; j++)
                {
                    if (poezd[i].Number > poezd[j].Number)
                    {
                        sort = poezd[i];
                        poezd[i] = poezd[j];
                        poezd[j] = sort;
                    }
                }
            }
            for (int i = 0; i < poezd.Length; i++)
            {
                poezd[i].Info();
                Console.WriteLine();
            }

            Console.WriteLine("Введите номер поезда для поиска: ");
            int input = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < poezd.Length; i++)
            {
                if (poezd[i].Number == input)
                {
                    poezd[i].Info();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("NOT FOUND!");
            }
            Console.ReadKey();           
        }
    }
}
