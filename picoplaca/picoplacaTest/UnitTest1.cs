using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;
namespace picoplacaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool expected = false;

            Picoplaca test = new Picoplaca("ascec222","2017-03-22","10:00");
            bool actual = test.Check(test);


            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual, "error");
        }
    }
}
