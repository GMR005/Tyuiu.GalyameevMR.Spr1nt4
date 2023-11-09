using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint4.Task7.V25.Lib;
namespace Tyuiu.GalyameevMR.Sprint4.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindCountsInString()
        {
            DataService DataService = new DataService();
            int n = 4;
            int m = 3;
            string value = "348561792486";
            int sum = 38;
            int calc = DataService.Calculate(n, m, value);
            Assert.AreEqual(calc, sum);
        }
    }
}
