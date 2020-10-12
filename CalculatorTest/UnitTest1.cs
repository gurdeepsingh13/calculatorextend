using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System.IO;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethodWithTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            string opr = "a";
            double d1 = 4.0;
            double d2 = 8.0;
            double expected = d1 + d2;
            double result = calculator.DoOperation(d1, d2, opr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSubtractMethodWithTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            string opr = "s";
            double d1 = 9.0;
            double d2 = 4.0;
            double expected = d1 - d2;
            double result = calculator.DoOperation(d1, d2, opr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMultiplyMethodWithTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            string opr = "m";
            double d1 = 12.0;
            double d2 = 10.0;
            double expected = d1 * d2;
            double result = calculator.DoOperation(d1, d2, opr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDivideMethodWithTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            string opr = "d";
            double d1 = 9.0;
            double d2 = 3.0;
            double expected = d1 / d2;
            double result = calculator.DoOperation(d1, d2, opr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDivideMethodWithTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            string opr = "d";
            double d1 = -12.0;
            double d2 = -3.0;
            double expected = d1 / d2;
            double result = calculator.DoOperation(d1, d2, opr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMultiplyMethodWithTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            string opr = "m";
            double d1 = -5.0;
            double d2 = -9.0;
            double expected = d1 * d2;
            double result = calculator.DoOperation(d1, d2, opr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSubtractMethodWithTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            string opr = "s";
            double d1 = -7.0;
            double d2 = -8.0;
            double expected = d1 - d2;
            double result = calculator.DoOperation(d1, d2, opr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAddMethodWithTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            string opr = "a";
            double d1 = -1.0;
            double d2 = -3.0;
            double expected = d1 + d2;
            double result = calculator.DoOperation(d1, d2, opr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMultiplyMethodWithOnePositiveNumber()
        {
            Calculator calculator = new Calculator();
            string opr = "m";
            double d1 = 6.0;
            double d2 = -8.0;
            double expected = d1 * d2;
            double result = calculator.DoOperation(d1, d2, opr);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAddMethodWithOnePositiveNumber()
        {
            Calculator calculator = new Calculator();
            string opr = "a";
            double d1 = 7.0;
            double d2 = -3.0;
            double expected = d1 + d2;
            double result = calculator.DoOperation(d1, d2, opr);
            Assert.AreEqual(expected, result);
        }

    }
}
