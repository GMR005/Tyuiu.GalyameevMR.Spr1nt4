using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GalyameevMR.Sprint4.Task6.V22.Lib;

namespace Tyuiu.GalyameevMR.Sprint4.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckWordsInArray()
        {
            DataService DataService = new DataService();
            string[] array = { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };
            string[] newArray = new string[] { "Снег", "Град", "Туча" };
            string[] result = DataService.Calculate(array);
            CollectionAssert.AreEqual(result, newArray);
        }
    }
}
