using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegrTest3;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() // Синус
        {
            Assert.AreEqual(Math.Round(Math.Sin(30 * Math.PI / 180), 4), Math.Round(IntegrTest3.Function.Function.Sin(30 * Math.PI / 180), 4));
        }

        [TestMethod]
        public void TestMethod2() //Косинус
        {
            Assert.AreEqual(Math.Round(Math.Cos(25 * Math.PI / 180), 4), Math.Round(IntegrTest3.Function.Function.Cos(25 * Math.PI / 180), 4));
        }

        [TestMethod]
        public void TestMethod3() //Модуль
        {
            Assert.AreEqual(Math.Abs(-9), IntegrTest3.Function.Function.Abs(-9));
        }

        [TestMethod]
        public void TestMethod4() //Возведение в степень
        {
            Assert.AreEqual(Math.Pow(7, 8), IntegrTest3.Function.Function.Power(7, 8));
        }

        [TestMethod]
        public void TestMethod5() //Тангенс
        {
            Assert.AreEqual(Math.Round(Math.Tan(60 * Math.PI / 180), 4), Math.Round(IntegrTest3.Function.Function.Tan(60 * Math.PI / 180), 4));
        }

        [TestMethod]
        public void TestMethod6() //Котангенс
        {
            Assert.AreEqual(Math.Round(1 / Math.Tan(6 * Math.PI / 180), 4), Math.Round(IntegrTest3.Function.Function.Ctan(6 * Math.PI / 180), 4));
        }

        [TestMethod]
        public void TestMethod7() //Факториал
        {
            Assert.AreEqual(120, IntegrTest3.Function.Function.Factorial(5));
        }

        [TestMethod]
        public void TestMethod8() //Секонс
        {
            Assert.AreEqual(Math.Round(1 / Math.Cos(160 * Math.PI / 180), 4), Math.Round(IntegrTest3.Function.Function.sec(160 * Math.PI / 180), 4));
        }
        [TestMethod]
        public void TestMethod9() // Логорифм 10
        {
            Assert.AreEqual(Math.Round(Math.Log10(5), 4), Math.Round(IntegrTest3.Function.Function.Ln(5), 4));
        }
        [TestMethod]
        public void TestMethod10() // Логорифм 
        {
            Assert.AreEqual(Math.Round(Math.Log(5, 5), 4), Math.Round(IntegrTest3.Function.Function.Log(5, 5), 4));
        }
    }
}
