using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint4.Task0.V29.Lib;

namespace Tyuiu.GalyameevMR.Sprint4.Task0.V29
{
    class Program
    {
        static void Main(string[] args) 
        {
            DataService DataService = new DataService(); 
            Console.Title = "Спринт 4. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #4                                                     ");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                   ");
            Console.WriteLine("* Задание #0                                                    ");
            Console.WriteLine("* Вариант #29                                                   ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Дан одномерный целочисленный массив на 10 элементов, заполненный" +
                " статическими значениями, в диапазоне от 0 до 9 подсчитать сумму нечетных элементов массива. ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Массив = {7, 4, 3, 2, 1, 5, 9, 8, 7, 4}");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int sum = DataService.GetSumOddArrEl(array);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
