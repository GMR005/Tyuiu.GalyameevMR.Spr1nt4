using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint4.Task1.V17.Lib;

namespace Tyuiu.GalyameevMR.Sprint4.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumInArray()
        {
            DataService DataService = new DataService();
            int[] array = { 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6 };
            int sum = DataService.Calculate(array);
            Assert.AreEqual(sum, 30);

        }
    }
}
