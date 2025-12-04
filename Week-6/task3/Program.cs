using System;

namespace Task3
{
    class Program
    {
        
        public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (var n in numbers)
            {
                if (condition(n))
                    Console.WriteLine(n);
            }
        }

        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 10, 11, 18, 21 };

            Console.WriteLine("All numbers:");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

            Console.WriteLine("Even numbers:");
            ProcessNumbers(numbers, n => n % 2 == 0);
            Console.WriteLine();

            Console.WriteLine("Numbers greater than 10:");
            ProcessNumbers(numbers, n => n > 10);
            Console.WriteLine();

            // Additional examples to demonstrate reusability
            Console.WriteLine("Numbers that are multiples of 3:");
            ProcessNumbers(numbers, n => n % 3 == 0);
            Console.WriteLine();

            Console.WriteLine("Done. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
