using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание6
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
            List<Soldier> Soldierlst = new List<Soldier>()   {
                new Soldier("Миронов Иван Павлович", "Авиационное", "Рядовой", 6),
                new Soldier("Елисеев Георгий Иванович", "Cтрелковое", "Генерал-лейтенант", 25),
                new Soldier("Князев Игорь Иванович", "Авиационное", "Генерал-лейтенант", 26),
                new Soldier("Лаврентьев Сергей Николаевич", "Танковое", "Подполковник", 20),
                new Soldier("Шадрин Виталий Сергеевич", "Cтрелковое", "Майор", 19)};

            IEnumerable<string> myquery = from Soldier in Soldierlst
                                          select Soldier.name + " - " + Soldier.rank;

            Console.WriteLine("Имя и звание солдата: ");
            foreach (string a in myquery)
            {
                Console.WriteLine(a);
            }
            Console.Read();
        }
    }
}
