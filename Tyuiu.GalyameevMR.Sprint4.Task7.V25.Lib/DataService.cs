﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GalyameevMR.Sprint4.Task7.V25.Lib
{
    public class DataService : ISprint4Task7V25
    {
        public int Calculate(int n, int m, string value)
        {
            value = "348561792486";
            n = 4;
            m = 3;
            int sum = 0;
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(value[i * 3 + j].ToString());
                    if (array[i,j] % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;     
        }
    }
}
