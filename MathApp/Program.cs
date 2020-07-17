using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 1) {
                string[] input = args[0].Split(' ');
                Console.WriteLine($"{input[0]}x{input[1]}=" +
                $"{ MiniCalc.Multiply(int.Parse(input[0]), int.Parse(input[1]))}");
            }
            else if (args.Length == 2) {
                Console.WriteLine($"{args[0]}x{args[1]}=" +
                $"{ MiniCalc.Multiply(int.Parse(args[0]), int.Parse(args[1]))}");
            }
            else {
                Console.WriteLine("-------------------------------------------");
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
}
