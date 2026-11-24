using Tyuiu.ShurlyginDS.Sprint4.Task7.V6.Lib;

namespace Tyuiu.ShurlyginDS.Sprint4.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];

            string str = "458963214789";

            DataService ds = new DataService();

            Console.Title = "Спринт #4 // Выполнил: Шурлыгин Д.С. // ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Шурлыгин Дмитрий Сергеевич // ИБКСб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"458963214789\". Преобразуйте ее     *");
            Console.WriteLine("* в матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows, columns, str);

            Console.WriteLine("Сумма нечетных элементов = " + res);
            Console.ReadKey();
        }
    }
}
