using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Array and Array Methods ===\n");

            // Create a single-dimensional integer array with 5 favorite numbers
            int[] favoriteNumbers = { 9, 2, 7, 4, 1 };

            // Display original array
            Console.WriteLine("Original Array:");
            foreach (int num in favoriteNumbers)
            {
                Console.Write(num + " ");
            }

            // Sort array in ascending order
            Array.Sort(favoriteNumbers);
            Console.WriteLine("\n\nArray in Ascending Order:");
            foreach (int num in favoriteNumbers)
            {
                Console.Write(num + " ");
            }

            // Reverse the sorted array
            Array.Reverse(favoriteNumbers);
            Console.WriteLine("\n\nArray in Descending Order:");
            foreach (int num in favoriteNumbers)
            {
                Console.Write(num + " ");
            }

            // Find the index of a specific number
            Console.WriteLine("\n\nEnter a number to find its position in the array:");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            int index = Array.IndexOf(favoriteNumbers, searchNumber);
            if (index != -1)
                Console.WriteLine($"The number {searchNumber} is at index {index} in the array.");
            else
                Console.WriteLine($"The number {searchNumber} was not found in the array.");

            Console.WriteLine("\n=== End of Program ===");
        }
    }
}
