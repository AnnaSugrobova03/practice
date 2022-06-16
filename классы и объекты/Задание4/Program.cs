using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4
{
    class Employee
    {
        public string name { get; }
        public string surname { get; }
        public double experience { get; set; }

        private string post;
        public static List<string> ListPost
        {
            get
            {
                return new List<string> { "Junior Developer", "Middle Developer", "Senior Developer" };
            }
        }

        public Employee(string n, string s)
        {
            name = n;
            surname = s;
        }

        public string Post
        {
            get
            {
                return post;
            }
            set
            {
                post = ListPost[Convert.ToInt32(value) - 1];
            }
        }

        public double Salary
        {
            get
            {
                switch (post)
                {
                    case "Junior Developer":
                        return experience * 30000;
                    case "Middle Developer":
                        return experience * 70000;
                    case "Senior Developer":
                        return experience * 100000;
                    default:
                        return 0;
                }
            }
        }

        public double Tax(double percent)
        {
            return Salary * percent / 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя сотрудника:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию сотрудника:");
            string surname = Console.ReadLine();

            Employee emp = new Employee(name, surname);

            Console.WriteLine("Введите цифру, соответствующую должности сотрудника:");
            for (int i = 0; i < Employee.ListPost.Count; i++)
                Console.WriteLine(i + 1 + " - " + Employee.ListPost[i]);
            emp.Post = Console.ReadLine();

            Console.WriteLine("Введите стаж сотрудника:");
            emp.experience = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите процент налога:");
            double per = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Фамилия и имя сотрудника: " + emp.surname + " " + emp.name + "\nДолжность: " + emp.Post + "\nОклад: " + emp.Salary + "\nНалоговый сбор: " + emp.Tax(per));
            Console.Read();
        }
    }
}
