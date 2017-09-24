using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    public class NUnitSub
    {
        Calculator calc = new Calculator();

        [Test]
        public void SubPositive()
        {            
            Assert.AreEqual(-10, calc.Sub(5, 15));
        }

        [Test]
        public void SubNegative()
        {            
            Assert.AreEqual(10, calc.Sub(-5, -15));
        }

        [Test]
        public void SubZero()
        {            
            Assert.AreEqual(5, calc.Sub(5, 0));
        }

        [Test]
        public void SubPositiveNegative()
        {            
            Assert.AreEqual(20, calc.Sub(5, -15));
        }

        [Test]
        public void SubMaxValue()
        {            
            Assert.AreEqual(0, calc.Sub(double.MaxValue, double.MaxValue));
        }
    }
}
