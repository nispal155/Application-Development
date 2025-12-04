// Program.cs  -- Task 6
using System;
using System.Collections.Generic;
using System.Linq;

record TourBooking(string CustomerName, string Destination, decimal Price, int DurationInDay, bool IsInternational);

class ReportItem
{
    public string CustomName { get; set; } = "";
    public string Destination { get; set; } = "";
    public string Category { get; set; } = ""; 
    public decimal Price { get; set; }
    public int Duration { get; set; }
}

class Program
{
    static void Main()
    {
        var bookings = new List<TourBooking>
        {
            new("Anil", "Pokhara", 8000m, 3, false),
            new("Dev", "Kathmandu-Pokhara", 12000m, 6, false),
            new("Carlos", "Bangkok", 25000m, 7, true),
            new("Deepa", "Chitwan", 11000m, 5, false),
            new("Evan", "Paris", 95000m, 10, true),
            new("Fiza", "Lumbini", 7000m, 2, false),
            new("Gopal", "Dubai", 45000m, 5, true)
        };

       
        var filtered = bookings
            .Where(b => b.Price > 10000m && b.DurationInDay > 4);

        
        var projected = filtered
            .Select(b => new ReportItem
            {
                CustomName = $"{b.CustomerName} ({b.DurationInDay}d)",
                Destination = b.Destination,
                Category = b.IsInternational ? "International" : "Domestic",
                Price = b.Price,
                Duration = b.DurationInDay
            });

        var sorted = projected
            .OrderBy(item => item.Category == "International") 
            .ThenBy(item => item.Price);

        Console.WriteLine("=== Tour Summary Report (price>10,000 & duration>4 days) ===");
        foreach (var r in sorted)
        {
            Console.WriteLine($"Name: {r.CustomName}");
            Console.WriteLine($"  Destination: {r.Destination}");
            Console.WriteLine($"  Category: {r.Category}");
            Console.WriteLine($"  Price: Rs. {r.Price}");
            Console.WriteLine($"  Duration (days): {r.Duration}");
        }
    }
}
