using System;

namespace Задание4
{
    enum Employees
    {
        Junior_Developer = 100, 
        Developer = 150,
        Senior_Developer = 200, 
        Team_leader = 250,
        Project_Manager = 300
    }

    class Accauntant
    {
        public bool AskForBonus(Employees PostWorker, int hours)
        {
            if ((int)PostWorker < hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accauntant a = new Accauntant();
            Console.WriteLine(a.AskForBonus(Employees.Junior_Developer, 100));
            Console.WriteLine(a.AskForBonus(Employees.Developer, 200));
            Console.WriteLine(a.AskForBonus(Employees.Senior_Developer, 235));
            Console.WriteLine(a.AskForBonus(Employees.Team_leader, 225));
            Console.WriteLine(a.AskForBonus(Employees.Project_Manager, 340));
        }
    }
}
