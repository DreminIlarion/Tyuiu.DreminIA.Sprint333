using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DreminIa.Sprint3.Task3.V22.Lib;

namespace Tyuiu.DreminIa.Sprint3.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            char str = 'b';
            DataService service1 = new DataService();
            Assert.AreEqual(7, service1.GetMaxCharCount("tbtbbb dsfbg bbg", str));
        }
    }
}