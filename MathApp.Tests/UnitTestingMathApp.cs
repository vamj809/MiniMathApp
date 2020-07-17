using NUnit.Framework;
using MathApp;

namespace MathApp.Tests
{
    public class Tests
    {
        [Test]
        public void Multiplication_of_2_and_2_returns_4()
        {
            Assert.AreEqual(4,MiniCalc.Multiply(2,2));
        }

        [Test]
        public void Multiplication_of_negative_4_and_755_returns_negative_3020()
        {
            Assert.AreEqual(-3020, MiniCalc.Multiply(-4, 755));
        }
    }
}