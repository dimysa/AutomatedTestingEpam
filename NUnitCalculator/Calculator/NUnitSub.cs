using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    [TestFixture]
    public class NUnitSub
    {
        [Test]
        public void SubPositive()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(-10, calc.Sub(5, 15));
        }

        [Test]
        public void SubNegative()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(10, calc.Sub(-5, -15));
        }

        [Test]
        public void SubZero()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(5, calc.Sub(5, 0));
        }

        [Test]
        public void SubPositiveNegative()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(20, calc.Sub(5, -15));
        }

        [Test]
        public void SubMaxValue()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(0, calc.Sub(double.MaxValue, double.MaxValue));
        }
    }
}
