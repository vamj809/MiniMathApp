using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace MathApp.Tests
{
    [TestFixture]
    class UI_Class
    {
        [Test]
        public void Multiplication_of_2_by_2_equals_4()
        {
            Assert.IsTrue(MiniCalc.TestMyMain("2 2").Contains("2x2=4"));
        }
    }
}
