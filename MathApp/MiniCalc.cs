using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MathApp
{
    public class MiniCalc
    {
        public static int Multiply(int a, int b)
        {
            checked { 
                return a*b;
            }
        }
    }
}
