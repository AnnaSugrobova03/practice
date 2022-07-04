using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    public class Prisoners
    {
        public string fio;
        public string prest;

        public static ArrayList GetPrisoners()
        {
            ArrayList al = new ArrayList();
            al.Add(new Prisoners { fio = "Абдулина Диана Игоревна", prest = "Антиправительственное" });
            al.Add(new Prisoners { fio = "Миронов Иван Павлович", prest = "Правительственное" });
            al.Add(new Prisoners { fio = "Комиссарова Кристина Олеговна", prest = "Правительственное" });
            al.Add(new Prisoners { fio = "Елисеев Георгий Иванович", prest = "Правительственное" });
            al.Add(new Prisoners { fio = "Абашилова Камилла Муратовна", prest = "Антиправительственное" });
            return (al);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = Prisoners.GetPrisoners();
            var gg = from Prisoners prisoners in al
                     where prisoners.prest != "Антиправительственное"
                     select prisoners;

            Console.WriteLine("До амнистии: ");
            Console.WriteLine();
            foreach (Prisoners c in al)
            {                
                Console.WriteLine(c.fio);
                Console.WriteLine(c.prest);
                Console.WriteLine("-----------------------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("После амнистии: ");
            foreach (var criminal in gg)
            {
                Console.WriteLine(criminal.fio);
                Console.WriteLine("-----------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
