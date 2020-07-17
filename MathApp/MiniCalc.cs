using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;

namespace MathApp
{
    public class MiniCalc
    {
        public static int Multiply(int a, int b)
        {
            try {
                return checked(a * b);
            } catch {
                throw new OverflowException("Multiplicacion excede los limites de tamaño del entero");
            }
        }
        public static string TestMyMain(string args)
        {
            Process MyMathApp = new Process();
            MyMathApp.StartInfo.FileName = "MathApp.exe";
            MyMathApp.StartInfo.Arguments = args;
            MyMathApp.StartInfo.UseShellExecute = false;
            MyMathApp.StartInfo.RedirectStandardOutput = true;
            MyMathApp.Start();
            MyMathApp.WaitForExit();

            return MyMathApp.StandardOutput.ReadToEnd();
        }
    }
}
