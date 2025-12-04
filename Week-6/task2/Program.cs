using System;

namespace Task2
{

    public delegate int Calculate(int a, int b);

    class Program
    {
        
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;

        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 2: Custom Delegate (Calculate) ===\n");

            
            Calculate calcAdd = Add;
            Calculate calcSub = Subtract;

            // Use delegate to call methods
            int a = 12, b = 5;
            Console.WriteLine($"Add({a}, {b}) = {calcAdd(a, b)}");
            Console.WriteLine($"Subtract({a}, {b}) = {calcSub(a, b)}");

    
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
