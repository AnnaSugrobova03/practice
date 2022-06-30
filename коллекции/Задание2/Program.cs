using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<int> ls = new List<int>();
            int sum = 0;
            int N = r.Next(1, 10);

            for (int i = 0; i < N; i++)
            {
                ls.Add(r.Next(1, 1000));
            }

            for (int i = 0; i < N; i++)
            {
                sum += ls[i];
                Console.WriteLine($"\nНомер клиента: {i + 1}\nСумма заказа: {ls[i]}\nСостояние счёта: {sum}");
                Console.ReadKey();
            }
        }
    }
}
