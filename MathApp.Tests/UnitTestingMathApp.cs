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
    }
}