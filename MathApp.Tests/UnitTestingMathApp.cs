using NUnit.Framework;

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

        [Test] //Above int.MaxValue
        public void Multiplication_of_2_billion_and_23_Throws_System_Overflow_Exception()
        {
            Assert.Throws<System.OverflowException>(() => MiniCalc.Multiply(2000000000, 23));
        }

        [Test] //Under int.MinValue
        public void Multiplication_of_negative_3500000_and_7589_Throws_OverflowException()
        {
            Assert.Throws<System.OverflowException>(() => MiniCalc.Multiply(-3500000, 7589));
        }
        
        [Test] //Under int.MinValue
        public void Multiplication_of_int_MIN_VALUE_and_2__Throws_OverflowException()
        {
            Assert.Throws<System.OverflowException>(() => MiniCalc.Multiply(int.MinValue, 2));
        }
        
        [Test] //Above int.MaxValue
        public void Multiplication_of_3_and_INT_MAX_VALUE_Throws_OverflowException()
        {
            Assert.Throws<System.OverflowException>(() => MiniCalc.Multiply(3, int.MaxValue));
        }
    }
}