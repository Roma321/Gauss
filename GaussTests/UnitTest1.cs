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
        [TestMethod]
        public void MultiplyTestMethod()
        {
            Fraction f1 = new Fraction(-1, 5);
            Fraction f2 = new Fraction(6, 5);
            Fraction f3 = f1 * f2;
            Assert.AreEqual(f3.Numerator, -6);
            Assert.AreEqual(f3.Denominator, 25);
        }
        [TestMethod]
        public void MultiplyTestMethod2()
        {
            Fraction f1 = new Fraction(-7, 5);
            Fraction f2 = new Fraction(5, 14);
            Fraction f3 = f1 * f2;
            Assert.AreEqual(f3.Numerator, -1);
            Assert.AreEqual(f3.Denominator, 2);
        }

        [TestMethod]
        public void MultiplyTestMethod3()
        {
            Fraction f1 = new Fraction(-1, 5);
            Fraction f2 = new Fraction(0, 5);
            Fraction f3 = f1 * f2;
            Assert.AreEqual(f3.Numerator, 0);
            Assert.AreEqual(f3.Denominator, 1);
        }
        [TestMethod]
        public void MultiplyTestMethod4()
        {
            Fraction f1 = new Fraction(-1, 5);
            
            Fraction f3 = f1 * (-5);
            Assert.AreEqual(f3.Numerator, 1);
            Assert.AreEqual(f3.Denominator, 1);
        }

        [TestMethod]
        public void SubtractionTestMethod()
        {
            Fraction f1 = new Fraction(-1, 5);
            Fraction f2 = new Fraction(0, 5);
            Fraction f3 = f1 - f2;
            Assert.AreEqual(f3.Numerator, -1);
            Assert.AreEqual(f3.Denominator, 5);
        }

        [TestMethod]
        public void SubtractionTestMethod2()
        {
            Fraction f1 = new Fraction(-1, 5);
            Fraction f2 = new Fraction(-6, 5);
            Fraction f3 = f1 - f2;
            Assert.AreEqual(f3.Numerator, 1);
            Assert.AreEqual(f3.Denominator, 1);
        }

        [TestMethod]
        public void SubtractionTestMethod3()
        {
            Fraction f1 = new Fraction(7, 12);
            Fraction f2 = new Fraction(38, 24);
            Fraction f3 = f1 - f2;
            Assert.AreEqual(f3.Numerator, -1);
            Assert.AreEqual(f3.Denominator, 1);
        }

        [TestMethod]
        public void DivisionTestMethod()
        {
            Fraction f1 = new Fraction(-1, 5);
            Fraction f2 = new Fraction(-6, 5);
            Fraction f3 = f1 / f2;
            Assert.AreEqual(f3.Numerator, 1);
            Assert.AreEqual(f3.Denominator, 6);
        }

        [TestMethod]
        public void DivisionTestMethod2()
        {
            Fraction f1 = new Fraction(-1, 5);
            Fraction f2 = new Fraction(6, 5);
            Fraction f3 = f1 / f2;
            Assert.AreEqual(f3.Numerator, -1);
            Assert.AreEqual(f3.Denominator, 6);
        }
    }
}
