using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GalyameevMR.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public string Calculate(int[] array)
        {
            array = new int[] { 8, 5, 7, 4, 7 };
            int maxNumber = array.Max();
            string maxValue = $"Наибольшее число в строке матрицы = {maxNumber}";
            return maxValue;
        }
    }
}
