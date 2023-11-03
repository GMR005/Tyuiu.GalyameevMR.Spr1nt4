using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint4.Task3.V10.Lib;

namespace Tyuiu.GalyameevMR.Sprint4.Task2.V20
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
            Console.WriteLine("* Задание #3                                                    ");
            Console.WriteLine("* Вариант #10                                                   ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями" +
                " в диапазоне от 4 до 8. Найдите максимальный элемент в третьей строке массива. ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine();
            int[,] mtrx = {   {5, 7, 6, 6, 5},
                               { 5, 5, 5, 4, 6},
                               { 8, 5, 7, 4, 7},
                               { 7, 6, 7, 4, 7},
                               { 5, 8, 7, 8, 8}    };
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
            Console.WriteLine("Необходимая строка в матрице: ");
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    if (i == 2)
                    {
                        Console.Write(mtrx[i, j] + "\t");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();
            int[] ourArray = { 8, 5, 7, 4, 7 };
            string p = DataService.Calculate(ourArray);
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
