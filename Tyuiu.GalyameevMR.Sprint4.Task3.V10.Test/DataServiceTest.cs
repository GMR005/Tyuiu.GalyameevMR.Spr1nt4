using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Tyuiu.GalyameevMR.Sprint4.Task3.V10.Lib;
namespace Tyuiu.GalyameevMR.Sprint4.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindMaxCountInArray()
        {
            DataService DataService = new DataService();
            int[] array = { 8, 5, 7, 4, 7 };
            string x = $"Наибольшее число в строке матрицы = 8";
            string p = DataService.Calculate(array);
            Assert.AreEqual(p, x);
        }
    }
}
