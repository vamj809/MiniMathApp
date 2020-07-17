using System;
using System.Collections.Generic;
using System.Text;
using MathApp;
using NUnit.Framework;

namespace MathApp.Tests
{
    class UI_Class
    {
        [Test]
        public void Multiplication_of_2_by_2_equals_4()
        {
            Assert.IsTrue(MiniCalc.TestMyMain("2 2").Contains("=4"));
        }
    }
}
