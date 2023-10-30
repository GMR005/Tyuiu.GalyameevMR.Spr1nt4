using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint4.Task2.V20.Lib;

namespace Tyuiu.GalyameevMR.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumInRandArray()
        {
            DataService DataService = new DataService();
            int[] arrayTest = { 2, 4, 6, 8, 7 };
            int sum = DataService.Calculate(arrayTest);
            Assert.AreEqual(20, sum);
        }
    }
}
