using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint4.Task1.V17.Lib;

namespace Tyuiu.GalyameevMR.Sprint4.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 4. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #4                                                     ");
            Console.WriteLine("* Тема: Одномерные массивы (печатный ввод)                      ");
            Console.WriteLine("* Задание #1                                                    ");
            Console.WriteLine("* Вариант #17                                                   ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Дан одномерный целочисленный массив на 14 элементов, заполненный значениями " +
                "с клавиатуры, в диапазоне от 1 до 7 подсчитать сумму четных элементов массива. " +
                "С клавиатуры: 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6 ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("*Введите размер массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] array = new int[len];
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine($"Введите значение элемента {i}: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Значение элемента {i}: {x} \n");
                array[i] = x;
            }
            Console.Write("Массив: \n");
            for (int i = 0; i < len; i++){
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            int sum = DataService.Calculate(array);
            Console.WriteLine(sum);
           
        }
    }
}
