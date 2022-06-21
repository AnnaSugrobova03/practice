using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание5
{
    public class Invoice
    {
        public int account; //цена
        public string customer;//покупатель
        public string provider;//продавец
        public string article;//артикул
        public int quantity;//количество
        public Invoice(int account_, string customer_, string provider_, string article_)
        {
            this.account = account_;
            this.customer = customer_;
            this.provider = provider_;
            this.article = article_;
        }
        public Invoice() { }

        public void Show()
        {
            Console.WriteLine("Клиент: " + customer + "\nПоставщик: " + provider + "\nТовар: " + article + "\nЦена без НДС:" + GetSum() +"\nЦена с НДС: " + GetSumNDS());
        }
        public int GetSum()
        {
            return account * quantity;
        }
        public double GetSumNDS()
        {
            return (account * quantity * 0.13) + (account * quantity);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя покупателя: ");
            string customer = Console.ReadLine();
            Console.Write("Введите имя поставщика: ");
            string provider = Console.ReadLine();
            Console.Write("Введите название товара: ");
            string article = Console.ReadLine();
            Console.Write("Введите стоимость: ");
            int account = int.Parse(Console.ReadLine());

            Invoice inv = new Invoice(account, customer, provider,article);

            Console.Write("Введите количество товара: ");
            inv.quantity = Convert.ToInt32(Console.ReadLine());
            inv.Show();

            Console.ReadKey();
        }
    }
}
