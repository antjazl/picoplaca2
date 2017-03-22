using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;
namespace UnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            bool expected = true;

            Picoplaca test = new Picoplaca("asc225", "2017-03-22", "8:00");
            bool actual = test.Check(test);


            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual, "error");
        }
    }
}
