using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint4.Task4.V8.Lib;

namespace Tyuiu.GalyameevMR.Sprint4.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChangeIndexInMatrix()
        {
            DataService DataService = new DataService();
            int [,] matrix = { { 1, 3, 2, 2, 5 }, { 6, 1, 5, 5, 2 }, { 1, 5, 4, 1, 4 }, { 4, 1, 4, 4, 5 }, { 4, 6, 1, 1, 4 } };
            int[,] waitMatrix = { { 1, 3, 1, 1, 5 }, { 1, 1, 5, 5, 1}, { 1, 5, 1, 1, 1 }, { 1, 1, 1, 1, 5 }, { 1, 1, 1, 1, 1 } };
            int[,] wait = DataService.Calculate(matrix);
            CollectionAssert.AreEqual(waitMatrix, wait);
        }
    }
}
