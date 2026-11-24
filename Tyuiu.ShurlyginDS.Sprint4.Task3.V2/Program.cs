using Tyuiu.ShurlyginDS.Sprint4.Task3.V2.Lib;

namespace Tyuiu.ShurlyginDS.Sprint4.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5] { { 4, 3, 2, 8, 7 },
                                          { 4, 6, 5, 5, 7 },
                                          { 3, 8, 8, 3, 5 },
                                          { 5, 7, 5, 4, 4 },
                                          { 8, 8, 3, 7, 6 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #4 // Выполнил: Шурлыгин Д.С. // ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Шурлыгин Дмитрий Сергеевич // ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 8.                          *");
            Console.WriteLine("* Найдите максимальный элемент в первой строке массива.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Максимальный элемент в первой строке массива = " + res);
            Console.ReadKey();
        }
    }
}
