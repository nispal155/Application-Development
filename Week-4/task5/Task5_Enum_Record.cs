using System;
namespace task5;

enum DayType { Weekday, Weekend }

record Book(string Title, string Author, double Price);

class ProgramTask5
{
    static void Main()
    {
        Console.Write("Enter day (e.g. Sunday): ");
        string input = Console.ReadLine()?.Trim() ?? "";
        string dayLower = input.ToLower();

        // weekend if Friday or Saturday (per instruction)
        if (dayLower == "friday" || dayLower == "saturday")
        {
            Console.WriteLine("It is: Weekend");
        }
        else
        {
            Console.WriteLine("It is: Weekday");
        }

        // Records
        Book b1 = new Book("The Alchemist", "Paulo Coelho", 9.99);
        Book b2 = b1 with { Title = "The Alchemist - Special", Price = 12.99 };

        Console.WriteLine("Original book: " + b1);
        // Deconstruct b2
        var (title, author, price) = b2;
        Console.WriteLine($"Deconstructed b2 -> Title: {title}, Author: {author}, Price: {price}");
    }
}
