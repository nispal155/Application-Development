using System;
using System.Collections.Generic;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Generic Collections: List and Dictionary ===\n");
            List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };

            Console.WriteLine("Original list of fruits:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }

            fruits.Add("Orange");
            Console.WriteLine("\nAfter adding a new fruit (Orange):");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }

            fruits.Remove("Banana");
            Console.WriteLine("\nAfter removing one fruit (Banana):");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }

            Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
            {
                {1, "Mango"},
                {2, "Apple"},
                {3, "Orange"}
            };

            fruitDictionary.Add(4, "Pineapple");

            Console.WriteLine("\nFruits in the dictionary (ID - Name):");
            foreach (KeyValuePair<int, string> pair in fruitDictionary)
            {
                Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
            }

            Console.WriteLine("\n=== End of Program ===");
        }
    }
}
