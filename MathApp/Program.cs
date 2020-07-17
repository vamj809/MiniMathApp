using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Markup;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("--- Hello World! I'm a Mini-Calculator! ---");
            Console.WriteLine("-------------------------------------------\n");

            if (args.Length == 2) {
                Console.WriteLine($"{args[0]}x{args[1]}=" +
                $"{ MiniCalc.Multiply(int.Parse(args[0]), int.Parse(args[1]))}");
            }
            else { 
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
}
