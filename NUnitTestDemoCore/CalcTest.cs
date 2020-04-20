using DemoCore.Application;
using DemoCore.Interface;
using DemoCore.Service;
using NUnit.Framework;

namespace NUnitTestDemoCore
{
    public class CalcTest
    {
        private Calc calc;

        [SetUp]
        public void Setup()
        {
            this.calc = new Calc();
        }

        [Test]
        public void Sum2Plus2()
        {
            int expected = 4;
            int result = this.calc.Sum(2,2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Sum2Minus2()
        {
            int expected = 0;
            int result = this.calc.Sub(2, 2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Mult2times2()
        {
            int expected = 4;
            int result = this.calc.Mult(2, 2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Div2Obleus2()
        {
            int expected = 1;
            int result = this.calc.Div(2, 2);
            Assert.AreEqual(expected, result);
        }
    }
}