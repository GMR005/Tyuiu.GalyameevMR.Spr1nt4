using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint4.Task2.V20.Lib;

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
            Console.WriteLine("* Тема: Случайные массивы                                       ");
            Console.WriteLine("* Задание #2                                                    ");
            Console.WriteLine("* Вариант #20                                                   ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Дан одномерный целочисленный массив на 16 элементов, заполненный" +
                " случайными числами, в диапазоне от 2 до 7 подсчитать сумму четных элементов массива. ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Random rand = new Random();
            Console.WriteLine("*Введите размер массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(2, 7);
            }
            Console.Write("Массив: \n");
            for (int i = 0; i < len; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            int sum = DataService.Calculate(array);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
    
}
