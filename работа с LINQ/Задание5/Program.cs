using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание5
{
    class Program
    {
        class Tush
        {
            public string name;
            public int year;
            public int time;

            public Tush(string name_, int year_, int time_)
            {
                name = name_;
                year = year_;
                time = time_;
            }
        }
        static void Main(string[] args)
        {
            List<Tush> Tushlst = new List<Tush>()   {
                new Tush("Барс", 2022, 1),
                new Tush("Ермолино", 2019, 1),
                new Tush("Гродфуд", 2018, 2),
                new Tush("Йошкар-Олинский мясокомбинат", 2021, 2),
                new Tush("Высший сорт", 2022, 2)};

            IEnumerable<Tush> myquery = from Tush in Tushlst
                                        where Tush.year + Tush.time < 2022
                                        select Tush;
            Console.WriteLine("Просрочка: ");
            foreach (Tush a in myquery)
            {
                Console.WriteLine(a.name);
            }
            Console.ReadLine();
        }
    }
}
