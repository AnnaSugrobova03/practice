using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    class Program
    {
        class People
        {
            public string name;
            public int age;
            public string illness;

            public People(string name, int age, string illness)
            {
                this.name = name;
                this.age = age;
                this.illness = illness;
            }
        }

        static void Main(string[] args)
        {
            List<People> peopleLst = new List<People>() {
            new People("Абдулина Диана Игоревна", 21, "Гастрит"),
            new People("Миронов Иван Павлович", 44, "Сахарный диабет"),
            new People("Комиссарова Кристина Олеговна", 20, "Гепатит C"),
            new People("Елисеев Георгий Иванович", 56, "Гастрит"),
            new People("Абашилова Камилла Муратовна", 20, "Гепатит C"),
            new People("Князев Игорь Иванович", 80, "Гепатит C"),
            new People("Блынская Анастасия Андреевна", 17, "Гастрит"),
            new People("Лаврентьев Сергей Николаевич", 55, "Сахарный диабет"),
            new People("Шадрин Виталий Сергеевич", 44, "Гастрит"),
            new People("Ханова Юлия Аркадьевна", 28, "Гепатит C")
            };

            int s = 5;
            IEnumerable<People> myquery;

            while (s != 0)
            {
                Console.WriteLine("Выберите действие \n1 - Отсортировать по фио \n2 - Отсортировать по возрасту \n3 - Вывести больных с определенным заболеванием \n0 - Выйти");
                s = Convert.ToInt32(Console.ReadLine());
                if (s == 1)
                {
                    myquery = from People in peopleLst
                              orderby People.name
                              select People;
                }
                else if (s == 2)
                {
                    myquery = from human in peopleLst
                              orderby human.age
                              select human;
                }
                else if (s == 3)
                {
                    Console.Write("Введите название заболевания: ");
                    string name = Console.ReadLine().Trim();
                    myquery = from human in peopleLst
                              where human.illness == name
                              select human;
                }
                else
                    continue;
                foreach (People a in myquery)
                {
                    Console.WriteLine(a.name + " - " + a.age + " - " + a.illness);
                }
                Console.WriteLine();
            }
        }
    }
}
