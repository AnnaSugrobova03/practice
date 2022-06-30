using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class Program
    {
        static Dictionary<string, string> dossier = new Dictionary<string, string>();
        static void AddEmployee()
        {
            Console.Write("\nВведите ФИО: ");
            string name = Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
                name = name.Replace("  ", " ").Trim();

            Console.Write("\nВведите должность: ");
            string job = Console.ReadLine();

            for (int i = 0; i < job.Length; i++)
                job = job.Replace("  ", " ").Trim();

            dossier.Add(name, job);
        }

        static void ShowEmployee()
        {
            IDictionaryEnumerator de = dossier.GetEnumerator();
            int k = 1;
            while (de.MoveNext())
            {
                Console.WriteLine(k + " - " + Convert.ToString(de.Key).Replace(" ", " - ") + " - " + de.Value);
                k++;
            }
        }

        static void DeleteEmployee()
        {
            ShowEmployee();
            Console.WriteLine("\nВведите номер для удаления: ");
            int n = Convert.ToInt32(Console.ReadLine());
            IDictionaryEnumerator dos = dossier.GetEnumerator();
            int k = 1;
            while (dos.MoveNext() && k != n)
                k++;
            dossier.Remove(Convert.ToString(dos.Key));
        }

        static void SearchEmployee()
        {
            IDictionaryEnumerator dos = dossier.GetEnumerator();
            Console.WriteLine("\nВведите фамилию работника для поиска: ");
            string surname = Console.ReadLine();
            bool check = true;
            while (dos.MoveNext())
            {
                string word = Convert.ToString(dos.Key);
                if (word.Contains(surname))
                {
                    Console.WriteLine(word);
                    check = false;
                }
            }
            if (check)
            {
                Console.WriteLine("Работник не найден!");
            }
        }

        static void Main(string[] args)
        {
            int res = 1;
            while (res != 5)
            {
                Console.WriteLine("\nВыберите действия: \n1 - добавить досье \n2 - вывести все досье \n3 - удалить досье \n4 - поиск по фамилии \n5 - выход");
                try
                {
                    res = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("err0r");
                    continue;
                }

                try
                {
                    switch (res)
                    {
                        case 1:
                            AddEmployee();
                            break;
                        case 2:
                            ShowEmployee();
                            break;
                        case 3:
                            DeleteEmployee();
                            break;
                        case 4:
                            SearchEmployee();
                            break;
                        case 5:
                            Process.GetCurrentProcess().Kill();
                            break;
                        case 6:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("err0r");
                    continue;
                }
            }
        }
    }
}