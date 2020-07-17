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

        [Test]
        public void Multiplication_of_negative_1_and_negative_50_returns_50()
        {
            Assert.AreEqual(50, MiniCalc.Multiply(-1, -50));
        }

        [Test]
        public void Multiplication_of_0_and_MAX_INT_returns_0()
        {
            Assert.AreEqual(0, MiniCalc.Multiply(0, int.MaxValue));
        }

        [Test]
        public void If_Multiplication_of_2_billion_and_23_Exceeds_MaxValue_Throws_System_Overflow_Exception()
        {
            Assert.Throws<System.OverflowException>(() => MiniCalc.Multiply(2000000000, 23));
        }
    }
}