
using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Personal Info Formatter ===\n");

            Console.Write("Enter your full name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your address: ");
            string address = Console.ReadLine();

            Console.Write("Enter your contact number: ");
            string contact = Console.ReadLine();

            Console.Write("Enter your college name: ");
            string college = Console.ReadLine();

            Console.Write("Enter number of hobbies: ");
            int hobbyCount = Convert.ToInt32(Console.ReadLine());
            
            string[] hobbies = new string[hobbyCount];
            for (int i = 0; i < hobbyCount; i++)
            {
                Console.Write($"Enter hobby {i + 1}: ");
                hobbies[i] = Console.ReadLine();
            }

            Console.WriteLine("\n--- Formatted Personal Information ---");
            Console.WriteLine($"Name       : {name}");
            Console.WriteLine($"Address    : {address}");
            Console.WriteLine($"Contact    : {contact}");
            Console.WriteLine($"College    : {college}");
            Console.WriteLine("Hobbies    : " + string.Join(", ", hobbies));

            Console.WriteLine("\nThank you for using Personal Info Formatter!");
        }
    }
}