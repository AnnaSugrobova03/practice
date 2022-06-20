using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    class Article
    {
        private string name;
        private string provider;
        private double price;

        public Article(string name_,string provider_,double price_)
        {
            this.name = name_;
            this.provider = provider_;
            this.price = price_;
        }
        public string Name { get { return name; } }
        public string Provider { get { return provider; } }
        public double Price { get { return price; } }
    }
    class Store
    {
        private Article[] products;
        public void Array(int count)
        {
            products = new Article[count];
        }
        public void Articles(int id, Article a)
        {
            products[id] = a;
        }
        public void GetInfoArticle(int index)
        {
            Console.WriteLine("Название товара: " + products[index].Name + "\nНазвание магазина: " + products[index].Provider + "\nЦена товара: " + products[index].Price);
        }
        public void GetInfoName(string name)
        {
            bool f = true;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name)
                {
                    GetInfoArticle(i);
                    f = false;
                    break;
                }
            }
            if (f)
            {
                Console.WriteLine("Товара с таким названием нет");
            }               
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Store st = new Store();

            Console.Write("Введите количество товаров: ");
            int count = Convert.ToInt32(Console.ReadLine());
            st.Array(count);

            for (int i = 0; i < count; i++)
            {
                Console.Write("\nВведите название товара: ");
                string prod_name = Console.ReadLine();
                Console.Write("Введите название магазина: ");
                string shop_name = Console.ReadLine();
                Console.Write("Введите цену товара: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Article art = new Article(prod_name, shop_name, price);
                st.Articles(i, art);
            }
            Console.Write("\nВведите номер товара: ");
            st.GetInfoArticle(Convert.ToInt32(Console.ReadLine()));
            Console.Write("\nВведите название товара: ");
            st.GetInfoName(Console.ReadLine());
            Console.Read();
        }
    }
}
