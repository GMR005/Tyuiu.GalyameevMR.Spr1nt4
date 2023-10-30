using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint4.Task0.V29.Lib;

namespace Tyuiu.GalyameevMR.Sprint4.Task0.V29.Test
{ 
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumInArrayValid()
        {
            DataService DataService = new DataService();
            int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int sum = DataService.GetSumOddArrEl(array);
            Assert.AreEqual(sum, 32);
        }
    }
}
