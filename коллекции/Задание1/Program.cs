using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    class Program
    {
        public static void Words()
        {
            Dictionary<string, string> words2 = new Dictionary<string, string>();
            words.Add("Дежавю", "Ощущение того, что переживаемое в данный момент, уже происходило ранее");
            words.Add("Грусть", "Отрицательно окрашенная эмоция");
            words.Add("Cтресс", "Реакция человеческого организма, возникающая в ответ на действие раздражителя");
            words.Add("Кот", "Домашнее животное с повадками хищника из семейства кошачьих, самец кошки");
            words.Add("Неон", "Химический элемент 18-й группы");
            words.Add("Музыка", "Исполнение произведений на инструментах в отличие от вокального искусства");
            words.Add("Танцпол", "Площадка для танцев в ресторане, ночном клубе и тп");
            words.Add("Колбаса", "Пищевой продукт; классообразующий тип колбасных изделий, представляющий собой мясной фарш в продолговатой оболочке.");
            words.Add("Пиксель", "Представляет собой неделимый объект прямоугольной или круглой формы, характеризуемый определённым цветом");
            words.Add("Пульс", "Толчкообразные колебания стенок артерий, связанные с сердечными циклами");
            words.Add("Страдание", "Совокупность крайне неприятных, тягостных или мучительных ощущений живого существа, при котором оно испытывает физический и эмоциональный дискомфорт, горе, боль, стресс, муки");
            words.Add("Молчание", "Воздержание от речи, использования голоса");
            words.Add("Искусство", "Одна из наиболее общих категорий эстетики, искусствознания и художественной практики");
            words.Add("Бесконечность", "Категория человеческого мышления, используемая для характеристики безграничных, беспредельных, неисчерпаемых предметов и явлений, для которых невозможно указание границ или количественной меры");
            words.Add("Ожог", "Повреждение тканей организма, вызванное действием высокой температуры, действием некоторых химических веществ");
            words.Add("Децибел", "Дольная единица, равная одной десятой единицы бел. В основе единицы лежит десятичный логарифм. Единица названа в честь американского учёного Александра Белла");
            words.Add("Тополь", "Род двудомных листопадных быстрорастущих деревьев семейства Ивовые. Лес с преобладанием тополей называют тополёвником");
            words.Add("Доска", "Пиломатериал толщиной до 100 мм и шириной более двойной толщины. Доски изготовляются из брёвен или брусьев. Используются в строительстве, в мебельной промышленности, в производстве тары и др");
            words.Add("Наушники", "Головные телефоны, устройство для персонального прослушивания звуковой информации");
            words.Add("Близнецы", "Два или более потомка, рождённых в результате одной беременности через непродолжительное время друг за другом, у человека и тех млекопитающих, самки которых обычно рождают одного детёныша");
        }

        public static Dictionary<string, string> words = new Dictionary<string, string>();

        public static string Check(string str)
        {
            int k = 0;
            string near = null;
            int count = str.Length;

            IDictionaryEnumerator myEnumerator = words.GetEnumerator();

            while (myEnumerator.MoveNext())
            {
                string word = Convert.ToString(myEnumerator.Key);
                if (str.Length != word.Length)
                    continue;

                for (int i = 0; i < str.Length; i++)
                {
                    string a1 = Convert.ToString(str[i]);
                    string a2 = Convert.ToString(word[i]);
                    if (a1.ToLower() == a2.ToLower())
                    {
                        k++;
                    }
                }
                if (count - 1 <= k)
                {
                    near = word;
                }
                k = 0;
            }
            return near;
        }

        static void Main(string[] args)
        {
            Words();
            Console.Write("Введите слово: ");
            string text = Console.ReadLine().ToLower().Trim();
            while (text != "0")
            {
                string word;
                string opr;

                if (words.TryGetValue(text, out opr))
                    Console.WriteLine(opr);
                else
                {
                    word = Check(text);
                    if (word == null)
                        Console.WriteLine("Такое слово не найдено!");
                    else
                    {
                        Console.WriteLine("Найдено слово: \"" + word + "\"");
                        words.TryGetValue(word, out opr);
                        Console.WriteLine(opr);
                    }
                }
                Console.WriteLine("Введите слово или 0 для выхода");
                text = Console.ReadLine().ToLower().Trim();
            }
        }
    }
}
