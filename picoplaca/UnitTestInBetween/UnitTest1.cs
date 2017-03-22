using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;
namespace UnitTestInBetween
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodInBetween()
        { Picoplaca tst = new Picoplaca();
            DateTime prueba = new DateTime(2017,03,22,8,00,00);
            DateTime iniciom = new DateTime(2017, 03, 22, 7, 0, 0);
            DateTime finm = new DateTime(2017, 03, 22, 9, 30, 0);
            DateTime iniciot = new DateTime(2017, 03, 22, 16, 0, 0);
            DateTime fint = new DateTime(2017, 03, 22, 19, 30, 0);
            bool expected = true;

            bool actual = tst.IsBetween(prueba,iniciom,finm,iniciot,fint);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual, "ERROR");
        }
    }
}
