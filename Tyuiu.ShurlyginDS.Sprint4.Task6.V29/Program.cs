using Tyuiu.ShurlyginDS.Sprint4.Task6.V29.Lib;

namespace Tyuiu.ShurlyginDS.Sprint4.Task6.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 // Выполнил: Шурлыгин Д.С. // ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Шурлыгин Дмитрий Сергеевич // ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Весна\", \"Лето\", \"Осень\", \"Зима\"]  *");
            Console.WriteLine("* используя класс Array подсчитайте количество элементов,                 *");
            Console.WriteLine("* длина которых больше 4.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var seasons = new string[] { "Весна", "Лето", "Осень", "Зима" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= seasons.Length - 1; i++)
            {
                Console.WriteLine(seasons[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов, длина которых больше 4:");

            int nums = ds.Calculate(seasons);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
