using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var classofliblary = new ArithmaticClass();
            Assert.AreEqual(classofliblary.z_func1(1, 2, 2), 8.375);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var classofliblary = new ArithmaticClass();
            Assert.AreEqual(classofliblary.z_func2(1, 1, 1), 22);
        }
    }
}
