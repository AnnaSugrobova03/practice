using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            DetectiveOffice detectiveOffice = new DetectiveOffice();
            detectiveOffice.Work();
        }
    }

    class DetectiveOffice
    {
        private List<Criminal> _criminals = new List<Criminal>()
        {
            new Criminal("Снегов Илья Игоревич", "Русский", 189, 90, false),
            new Criminal("Дмитров Дмитрий Дмитриевич", "Русский", 178, 78, true),
            new Criminal("Караул Роман Алексеевич", "Украинец", 172, 65, false),
            new Criminal("Шейко Олег Павлович", "Украинец", 190, 80, false),
            new Criminal("Иванов Иван Иванович", "Украинец", 170, 50, true)
        };

        public void Work()
        {
            string s;
            bool isWork = true;

            Console.WriteLine("Добро пожаловать в детективное агенство!");
            while (isWork)
            {
                Console.WriteLine("Выберите действие:\n1 - Найти преступника\n2 - Выйти");
                s = Console.ReadLine();

                switch (s)
                {
                    case "1":
                        FindCriminal();
                        break;
                    case "2":
                        isWork = false;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Вы вышли");
        }

        private void FindCriminal()
        {
            int weight;
            int height;
            string nationality;

            Console.Write("Введите данные о преступнике: ");

            Console.WriteLine();
            Console.Write("Рост: ");
            height = EnterNumber();

            Console.WriteLine();
            Console.Write("Вес: ");
            weight = EnterNumber();

            Console.WriteLine();
            Console.Write("Национальность: ");
            nationality = Console.ReadLine();

            Console.WriteLine();

            var filteredCriminals = from Criminal criminal in _criminals
                                    where criminal.Height == height && criminal.Weight == weight && criminal.Nationality == nationality && criminal.IsArrested == false
                                    select criminal;

            if (filteredCriminals.Count() == 0)
            {
                Console.WriteLine("Таких преступников нет!");
            }
            else
            {
                foreach (var criminal in filteredCriminals)
                {
                    Console.WriteLine(criminal.Name);
                }
            }
        }

        private int EnterNumber()
        {
            string number;
            int parsedNumber = 1;
            bool isParsed = false;

            while (isParsed == false)
            {
                number = Console.ReadLine();

                if (int.TryParse(number, out parsedNumber) && parsedNumber > 0)
                {
                    isParsed = true;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильно число!");
                }
            }

            return parsedNumber;
        }
    }

    class Criminal
    {
        public string Name { get; private set; }
        public string Nationality { get; private set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }
        public bool IsArrested { get; private set; }

        public Criminal(string name, string nationality, int height, int weight, bool isArrested)
        {
            Name = name;
            Nationality = nationality;
            Height = height;
            Weight = weight;
            IsArrested = isArrested;
        }
    }
}
