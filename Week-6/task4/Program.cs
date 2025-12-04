using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    public class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Squaring numbers
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var squared = numbers.Select(n => n * n).ToList();
            Console.WriteLine("Original numbers: " + string.Join(", ", numbers));
            Console.WriteLine("Squared numbers:  " + string.Join(", ", squared));
            Console.WriteLine();

            // 2. Filtering books above Rs.1000
            var books = new List<Book>
            {
                new Book { Title = "C# In Depth", Price = 1200 },
                new Book { Title = "Intro to Python", Price = 800 },
                new Book { Title = "Design Patterns", Price = 1500 },
                new Book { Title = "Small Algorithms", Price = 950 },
                new Book { Title = "Algorithms", Price = 950 }
            };

            var premiumBooks = books.Where(b => b.Price > 1000).ToList();
            Console.WriteLine("Books priced above Rs.1000:");
            foreach (var b in premiumBooks)
                Console.WriteLine($"- {b.Title} (Rs {b.Price})");
            Console.WriteLine();

            // 3. Sorting students alphabetically
            var students = new List<Student>
            {
                new Student { Name = "Ravi" },
                new Student { Name = "Safal" },
                new Student { Name = "Sanskar" },
                new Student { Name = "Saksham" },
                new Student { Name = "Nispal" }
            };

            var alphabetic = students.OrderBy(s => s.Name).ToList();
            Console.WriteLine("Students sorted alphabetically:");
            foreach (var s in alphabetic)
                Console.WriteLine("- " + s.Name);

            Console.WriteLine("\n=== End of Task 4 demo ===");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
