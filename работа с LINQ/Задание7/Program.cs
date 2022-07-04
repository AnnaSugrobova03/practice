using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание7
{
    class Program
    {
        class Soldier
        {
            public string name;
            public string arming;
            public string rank;
            public int time;

            public Soldier(string name_, string arming_, string rank_, int time_)
            {
                name = name_;
                arming = arming_;
                rank = rank_;
                time = time_;
            }
        }
        static void Main(string[] args)
        {
            List<Soldier> Soldierlst1 = new List<Soldier>()   {
                new Soldier("Миронов Иван Павлович", "Авиационное", "Рядовой", 10),
                new Soldier("Елисеев Георгий Иванович", "Cтрелковое", "Генерал-лейтенант", 20),
                new Soldier("Блынский Игорь Иванович", "Авиационное", "Генерал-лейтенант", 20),
                new Soldier("Лаврентьев Сергей Николаевич", "Танковое", "Подполковник", 15),
                new Soldier("Шадрин Виталий Сергеевич", "Cтрелковое", "Майор", 18)};

            List<Soldier> Soldierlst2 = new List<Soldier>()   {
                new Soldier("Абашилов Игорь Миронович", "Cтрелковое", "Лейтенант", 12),
                new Soldier("Яковенко Сергей Андреевич", "Танковое", "Подполковник", 14),
                new Soldier("Кляпа Петр Иванович", "Авиационное", "Рядовой", 10),
                new Soldier("Римол Леонид Игнатович", "Cтрелковое", "Генерал-лейтенант", 36),
                new Soldier("Иванов Иван Иванович","Танковое","Рядовой", 5)};

            Console.WriteLine("Первый отряд до изменений:");
            foreach (Soldier a in Soldierlst1)
            {
                Console.WriteLine(a.name);
            }
            Console.WriteLine("\nВторой отряд до изменений:");
            foreach (Soldier a in Soldierlst2)
            {
                Console.WriteLine(a.name);
            }

            IEnumerable<Soldier> myquery = from soldier in Soldierlst1
                                           where soldier.name[0] == 'Б'
                                           select soldier;

            List<Soldier> query = new List<Soldier>();
            foreach (Soldier a in myquery)
            {
                query.Add(a);
            }

            foreach (Soldier a in query)
            {
                Soldierlst2.Add(a);
                Soldierlst1.Remove(a);
            }

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("\nПервый отряд после изменений:");
            foreach (Soldier a in Soldierlst1)
            {
                Console.WriteLine(a.name);
            }
            Console.WriteLine("\nВторой отряд после изменений:");
            foreach (Soldier a in Soldierlst2)
            {
                Console.WriteLine(a.name);
            }
            Console.ReadLine();
        }
    }
}
