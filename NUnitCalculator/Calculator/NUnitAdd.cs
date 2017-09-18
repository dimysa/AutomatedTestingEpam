using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    public class NUnitAdd
    {
        [Test]
        public void AddPositive()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(20, calc.Add(5, 15));
        }

        [Test]
        public void AddNegative()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(-20, calc.Add(-5, -15));
        }

        [Test]
        public void AddZero()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(5, calc.Add(5, 0));
        }

        [Test]
        public void AddPositiveNegative()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(-10, calc.Add(5, -15));
        }

        [Test]
        public void AddMaxValue()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(double.PositiveInfinity, calc.Add(double.MaxValue, double.MaxValue));
        }
    }
}
