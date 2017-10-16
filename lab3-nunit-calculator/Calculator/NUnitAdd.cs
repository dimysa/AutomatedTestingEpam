using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    public class NUnitAdd
    {
        Calculator calc = new Calculator();

        [Test]
        public void AddPositive()
        {            
            Assert.AreEqual(20, calc.Add(5, 15));
        }

        [Test]
        public void AddNegative()
        {            
            Assert.AreEqual(-20, calc.Add(-5, -15));
        }

        [Test]
        public void AddZero()
        {            
            Assert.AreEqual(5, calc.Add(5, 0));
        }

        [Test]
        public void AddPositiveNegative()
        {            
            Assert.AreEqual(-10, calc.Add(5, -15));
        }

        [Test]
        public void AddMaxValue()
        {            
            Assert.AreEqual(double.PositiveInfinity, calc.Add(double.MaxValue, double.MaxValue));
        }
    }
}
