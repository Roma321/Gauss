using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Gauss;

namespace GaussTests
{
    [TestClass]
    public class FractionTests
    {
        /// <summary>
        /// Сложение целых чисел
        /// </summary>
        [TestMethod]
        public void PlusTestMethod1()
        {
            Fraction f1 = new Fraction(5);
            Fraction f2 = new Fraction(2);
            Fraction f3 = f1 + f2;
            Assert.AreEqual(f3.Numerator, 7);
            Assert.AreEqual(f3.Denominator, 1);
        }
        /// <summary>
        /// Сложение дробей с одинаковым знаменателем
        /// </summary>
        [TestMethod]
        public void PlusTestMethod2()
        {
            Fraction f1 = new Fraction(1,5);
            Fraction f2 = new Fraction(2,5);
            Fraction f3 = f1 + f2;
            Assert.AreEqual(f3.Numerator, 3);
            Assert.AreEqual(f3.Denominator, 5);
        }
        /// <summary>
        /// Сложение дробей с разным знаменателем
        /// </summary>
        [TestMethod]
        public void PlusTestMethod3()
        {
            Fraction f1 = new Fraction(1,6);
            Fraction f2 = new Fraction(2,9);
            Fraction f3 = f1 + f2;
            Assert.AreEqual(f3.Numerator, 7);
            Assert.AreEqual(f3.Denominator, 18);
        }
        /// <summary>
        /// Сокращение дробей
        /// </summary>
        [TestMethod]
        public void PlusTestMethod4()
        {
            Fraction f1 = new Fraction(1,5);
            Fraction f2 = new Fraction(4,5);
            Fraction f3 = f1 + f2;
            Assert.AreEqual(f3.Numerator, 1);
            Assert.AreEqual(f3.Denominator, 1);
        }
        /// <summary>
        /// Работа с отрицательными дробями
        /// </summary>
        [TestMethod]
        public void PlusTestMethod5()
        {
            Fraction f1 = new Fraction(-1, 5);
            Fraction f2 = new Fraction(6, 5);
            Fraction f3 = f1 + f2;
            Assert.AreEqual(f3.Numerator, 1);
            Assert.AreEqual(f3.Denominator, 1);
        }
    }
}
