using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint4.Task5.V26.Lib;
namespace Tyuiu.GalyameevMR.Sprint4.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChangeValuesInMatrix()
        {
            DataService DataService = new DataService();
            int[,] matrix = { { 1, 3, 2, 2, 5 }, { -6, 1, 5, 5, 2 }, { 1, 5, -4, 1, 4 }, { 4, 1, -4, 4, 5 }, { 4, 6, -1, 1, 4 } };
            int[,] waitMatrix = { { 1, 1, 1, 1, 1 }, { -6, 1, 1, 1, 1 }, { 1, 1, -4, 1, 1}, { 1, 1, -4, 1, 1 }, { 1, 1, -1, 1, 1 } };
            int[,] result = DataService.Calculate(waitMatrix);
            CollectionAssert.AreEqual(result, waitMatrix);
        }
    }
}
