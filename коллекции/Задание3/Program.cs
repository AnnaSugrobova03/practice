using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            int a;
            int sum = 0;
            string s = "";
            Console.WriteLine($"Введите число, sum или exit: ");
            while (!s.Contains("exit"))
            {
                try
                {                   
                    s = Console.ReadLine();
                    if (s == "sum")
                    {
                        for (int i = 0; i < lst.Count; i++)
                        {
                            sum += lst[i];
                        }
                        Console.WriteLine($"Сумма: " + sum);
                        sum = 0;
                    }
                    else if (s == "" || !int.TryParse(s, out a))
                    {
                        Console.WriteLine($"Введите число, sum или exit: ");
                    }
                    else if (s == "exit")
                        break;
                    else
                    {
                        a = Convert.ToInt32(s);
                        lst.Add(a);
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка!");
                }               
            }
        }
    }
}
