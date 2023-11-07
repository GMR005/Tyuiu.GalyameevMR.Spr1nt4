using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint4.Task4.V8.Lib;

namespace Tyuiu.GalyameevMR.Sprint4.Task4.V8
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
            Console.WriteLine("* Задание #4                                                    ");
            Console.WriteLine("* Вариант #8                                                   ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов, заполненный" +
                " значениями с клавиатуры в диапазоне от 1 до 6. Заменить четные элементы массива на 1.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine();
            int[,] mtrx = new int[5, 5];
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    Console.Write($"Введите {i}, {j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Матрица: ");
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                        for (int j = 0; j < mtrx.GetLength(1); j++)
             {
                            Console.Write(mtrx[i, j] + "\t");
                        }
                        Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();
            int[,] result = DataService.Calculate(mtrx);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }



        }
    }
}

