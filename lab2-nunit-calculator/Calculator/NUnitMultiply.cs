using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    class NUnitMultiply
    {
        Calculator calc = new Calculator();

        [Test]
        public void MultiplyPositive()
        {            
            Assert.AreEqual(15, calc.Multiply(5, 3));
        }

        [Test]
        public void MultiplyNegative()
        {            
            Assert.AreEqual(15, calc.Multiply(-5, -3));
        }

        [Test]
        public void MultiplyZero()
        {            
            Assert.AreEqual(0, calc.Multiply(5, 0));
        }

        [Test]
        public void MultiplyPositiveNegative()
        {            
            Assert.AreEqual(-15, calc.Multiply(5, -3));
        }

        [Test]
        public void MultiplyMaxValue()
        {            
            Assert.AreEqual(double.PositiveInfinity, calc.Multiply(double.MaxValue, double.MaxValue));
        }
    }
}
