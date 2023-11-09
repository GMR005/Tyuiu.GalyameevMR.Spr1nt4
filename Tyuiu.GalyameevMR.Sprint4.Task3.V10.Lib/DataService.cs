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

        public int Calculate(int[,] array)
        {
            array = new int [,] {   {5, 7, 6, 6, 5},
                               { 5, 5, 5, 4, 6},
                               { 8, 5, 7, 4, 7},
                               { 7, 6, 7, 4, 7},
                               { 5, 8, 7, 8, 8}    };
            int maxValue = array[2, 0];
            for (int i = 2; i < 3; i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maxValue)
                    {
                        array[i, j] = maxValue;
                    }
                }
            }
            return maxValue;

        }
    }
}
