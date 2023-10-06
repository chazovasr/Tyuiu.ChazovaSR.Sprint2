using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint2.Task4.V13.Lib;

namespace Tyuiu.ChazovaSR.Sprint2.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 41.5;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 16;
            double y = 17;
            double res = ds.Calculate(x, y);
            double wait = 0.906;
            Assert.AreEqual(wait, res);

        }
    }
}
