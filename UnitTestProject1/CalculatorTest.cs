using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CanInstantiateCalculator()
        {
            Calculator calc = new Calculator();
        }
        [TestMethod]
        public void OnePlusOne()
        {
            Calculator calc = new Calculator();
            int result = calc.Calculate("1+1");
            Assert.AreEqual(2, result);
        }
    }
}
