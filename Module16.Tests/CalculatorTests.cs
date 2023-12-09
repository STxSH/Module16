using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalShouldReturnSum()
        {
            var calculator = new Calculator();

            int result = calculator.Additional(3, 5);

            ClassicAssert.AreEqual(8, result);
        }

        [Test]
        public void SubtractionShouldReturnDifference()
        {
            var calculator = new Calculator();

            int result = calculator.Subtraction(10, 4);

            ClassicAssert.AreEqual(6, result);
        }

        [Test]
        public void MultiplicationShouldReturnProduct()
        {
            var calculator = new Calculator();

            int result = calculator.Multiplication(2, 6);

            ClassicAssert.AreEqual(12, result);
        }

        [Test]
        public void DivisionShouldReturnQuotient()
        {
            var calculator = new Calculator();

            int result = calculator.Division(8, 2);

            ClassicAssert.AreEqual(4, result);
        }

        [Test]
        public void DivisionShouldThrowExceptionWhenDividingByZero()
        {
            var calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }
    }
}
