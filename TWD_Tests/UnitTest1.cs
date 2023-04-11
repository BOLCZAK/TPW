using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TWD;

namespace TWD_Tests
{
    [TestClass]
    public class NumberAdderTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange

            TWD.NumberAdder adder = new TWD.NumberAdder();

            int number1 = 2;
            int number2 = 2;
            int result = adder.AddTwoNumbers(number1, number2);

            // Assert
            Assert.AreEqual(4, result);

        }
    }
}
