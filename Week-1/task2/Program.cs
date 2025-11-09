using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== My Personal Information ===\n");

            // Declare and assign variables
            string fullName = "Nispal Bhattarai";
            string address = "Itahari, Nepal";
            string contactNumber = "9842147190";
            string collegeName = "Itahari International College, Itahari";

            // Display stored personal details
            Console.WriteLine($"Name          : {fullName}");
            Console.WriteLine($"Address       : {address}");
            Console.WriteLine($"Contact Number: {contactNumber}");
            Console.WriteLine($"College       : {collegeName}");

            Console.WriteLine("\nThank you for viewing my details!");

            // Create an object of the Quote class
            Quote quoteObj = new Quote();

            // Call the method to display the quote
            quoteObj.ShowQuoteOfTheDay();

            // Pause console before closing (optional)
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    class Quote
    {
        public void ShowQuoteOfTheDay()
        {
            string quote = "The only way to do great work is to love what you do. — Steve Jobs";
            Console.WriteLine("\n--- Quote of the Day ---");
            Console.WriteLine(quote);
            Console.WriteLine("------------------------");
        }
    }
}
