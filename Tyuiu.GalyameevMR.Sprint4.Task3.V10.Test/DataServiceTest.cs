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
            int [,] array = new int[,] {   {5, 7, 6, 6, 5},
                               { 5, 5, 5, 4, 6},
                               { 8, 5, 7, 4, 7},
                               { 7, 6, 7, 4, 7},
                               { 5, 8, 7, 8, 8}    };
            int maxValue = 8;
            int result = DataService.Calculate(array);
            Assert.AreEqual(result, maxValue);
        }
    }
}
