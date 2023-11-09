using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint4.Task7.V25.Lib;

namespace Tyuiu.GalyameevMR.Sprint4.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 4. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #4                                                     ");
            Console.WriteLine("* Тема: Двумерные массивы                                       ");
            Console.WriteLine("* Задание #7                                                    ");
            Console.WriteLine("* Вариант #25                                                   ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Дана строка из одноразрядных цифр 348561792486. Преобразуйте " +
                "ее в матрицу 4 на 3 и подсчитайте сумму четных чисел.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                            *\n");
            int[,] array = new int[4, 3];
            string value = "348561792486";
            Console.WriteLine("Матрица 4 на 3:\n");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = int.Parse(value[i * 3 + j].ToString());
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************\n");
            int p = DataService.Calculate(4, 3, value);
            Console.WriteLine(p);
        }
    }
}
