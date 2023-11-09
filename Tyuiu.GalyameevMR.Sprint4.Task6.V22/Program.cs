using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalyameevMR.Sprint4.Task6.V22.Lib;

namespace Tyuiu.GalyameevMR.Sprint4.Task6.V22
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
            Console.WriteLine("* Задание #6                                                    ");
            Console.WriteLine("* Вариант #22                                                   ");
            Console.WriteLine("* Выполнил: Галямеев М.Р. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Дан строковый массив данных, используя класс Array, выведите элементы массива, " +
                "длина которых равна 4 символам.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            string[] array = { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Элементы с 4 символами: ");
            string[] newArray = DataService.Calculate(array);
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + "\t");
                
            }
            Console.ReadKey();
        }
    }
}
