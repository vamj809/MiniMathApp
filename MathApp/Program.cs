using System;
using System.Threading;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Hello World! I'm a Mini-Calculator! ---");
            Console.WriteLine("-------------------------------------------\n");

            Console.WriteLine("Write two integers:");
            Console.Write("- A:");
            if(!int.TryParse(Console.ReadLine(), out int a)) {
                Console.WriteLine("That's not an integer. Try again.");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            Console.Write("- B:");
            if (!int.TryParse(Console.ReadLine(), out int b)) {
                Console.WriteLine("That's not an integer. Try again.");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            Console.WriteLine($"\n- Result: {MiniCalc.Multiply(a,b)}");
        }
    }
}
