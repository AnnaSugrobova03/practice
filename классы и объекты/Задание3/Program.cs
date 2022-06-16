using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    class Program
    {
        class Converter
        {
            private double _rub, _usd, _eur;

            public Converter(double usd, double eur, double rub)
            {
                _rub = rub;
                _usd = eur;
                _eur = eur;
            }


            public double ConvertTo(string valuta)
            {
                valuta = valuta.ToLower().Trim();
                switch (valuta)
                {
                    case "rub":
                        return _rub * 0.52;
                    case "usd":
                        return _usd * 29.54;
                    case "eur":
                        return _eur * 30.83;
                    default:
                        return 0;
                }
            }

            public double ConvertFrom(double grivna, string valuta)
            {
                valuta = valuta.ToLower().Trim();
                switch (valuta)
                {
                    case "rub":
                        return grivna * 1.92;
                    case "usd":
                        return grivna * 0.034;
                    case "eur":
                        return grivna * 0.032;
                    default:
                        return 0;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму в рублях:");
            double rub = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сумму в долларах:");
            double usd = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сумму в евро:");
            double eur = Convert.ToDouble(Console.ReadLine());

            Converter con = new Converter(usd, eur, rub);
            Console.WriteLine("Перевод из гривны - 1\nПеревод в гривны - 2");
            string res = Console.ReadLine();
            while (res == "1" || res == "2")
            {
                if (res == "1")
                {
                    Console.WriteLine("Введите количество гривен:");
                    double g = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Выберите валюту: введите rub, usd или eur");
                    Console.WriteLine(con.ConvertFrom(g, Console.ReadLine()));
                }
                if (res == "2")
                {
                    Console.WriteLine("Выберите валюту: введите rub, usd или eur");
                    Console.WriteLine(con.ConvertTo(Console.ReadLine()));
                }
                Console.WriteLine("Перевод из гривны - 1\nПеревод в гривны - 2");
                res = Console.ReadLine();
            }
        }
    }
}