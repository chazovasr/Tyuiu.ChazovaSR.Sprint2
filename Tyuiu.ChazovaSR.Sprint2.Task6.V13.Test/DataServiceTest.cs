using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint2.Task6.V13.Lib;


namespace Tyuiu.ChazovaSR.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 2005;
            int m = 5;
            int n = 28;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "2005527";
            Assert.AreEqual(wait, res);
        }
    }
}
