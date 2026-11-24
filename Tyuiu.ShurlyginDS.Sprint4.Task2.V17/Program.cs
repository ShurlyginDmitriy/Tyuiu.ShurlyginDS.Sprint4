using Tyuiu.ShurlyginDS.Sprint4.Task2.Lib;

namespace Tyuiu.ShurlyginDS.Sprint4.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 // Выполнил: Шурлыгин Д.С. // ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Шурлыгин Дмитрий Сергеевич // ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 9 элементов заполненный          *");
            Console.WriteLine("* случайными в диапазоне от 3 до 9 подсчитать произведение нечетных       *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(3, 10);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Произведение нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
