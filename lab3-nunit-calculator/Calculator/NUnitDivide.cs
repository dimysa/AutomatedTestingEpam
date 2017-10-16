using NUnit.Framework;

namespace Calculator
{
    class NUnitDivide
    {
        Calculator calc = new Calculator();

        [Test]
        public void DividePositive()
        {            
            Assert.AreEqual(15, calc.Divide(30, 2));
        }

        [Test]
        public void DivideNegative()
        {            
            Assert.AreEqual(15, calc.Divide(-30, -2));            
        }

        [Test]
        public void DivideTwoZero()
        {            
            Assert.IsNaN(calc.Divide(0, 0));            
        }

        [Test]
        public void DivideZero()
        {            
            Assert.AreEqual(0, calc.Divide(0, 15));
        }

        [Test]
        public void DivideByZero()
        {            
            Assert.AreEqual(double.PositiveInfinity, calc.Divide(double.MaxValue, 0));
        }
    }
}
