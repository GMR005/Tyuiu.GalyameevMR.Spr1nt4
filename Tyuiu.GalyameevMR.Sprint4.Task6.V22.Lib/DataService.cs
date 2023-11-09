using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GalyameevMR.Sprint4.Task6.V22.Lib
{
    public class DataService : ISprint4Task6V22
    {
        public string[] Calculate(string[] array)
        {
            array = new string[] { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };

            int count = 0;
            foreach (string item in array)
            {
                if (item.Length == 4)
                {
                    count++;
                }
            }
            string[] newArray = new string[count];
            int i = 0;
            foreach (string item in array)
            {
                if (item.Length == 4)
                {
                    newArray[i] = item;
                    i++;
                }
            }
            return newArray;
        }
    }
}
