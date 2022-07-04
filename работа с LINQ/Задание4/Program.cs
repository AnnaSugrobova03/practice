using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4
{
    class Program
    {
        class People
        {
            public string name;
            public int level;
            public int force;


            public People(string name, int level, int force)
            {
                this.name = name;
                this.level = level;
                this.force = force;
            }
        }
        static void Main(string[] args)
        {
            List<People> peopleLst = new List<People>() {
            new People("Абдулина Диана Игоревна", 21,190 ),
            new People("Миронов Иван Павлович", 44,300),
            new People("Комиссарова Кристина Олеговна", 20,193),
            new People("Елисеев Георгий Иванович", 56, 100 ),
            new People("Абашилова Камилла Муратовна", 20, 65),
            new People("Князев Игорь Иванович", 80, 121),
            new People("Блынская Анастасия Андреевна", 17,54 ),
            new People("Лаврентьев Сергей Николаевич", 55,99 ),
            new People("Шадрин Виталий Сергеевич", 44,45 ),
            new People("Ханова Юлия Аркадьевна", 28,34 )
            };


            Console.WriteLine("Топ 3 игроков по уровню: ");

            IEnumerable<People> myquery = from People in peopleLst
                                         orderby People.level descending
                                         select People;
            foreach (People a in myquery.Take(3))
            {
                Console.WriteLine(a.name + "\t" + a.level + "\t" + a.force);
            }

            Console.WriteLine("\nТоп 3 игроков по силе: ");

            myquery = from People in peopleLst
                      orderby People.force descending
                      select People;

            foreach (People a in myquery.Take(3))
            {
                Console.WriteLine(a.name + "\t" + a.level + "\t" + a.force);
            }

            Console.ReadLine();
        }
    }
}
