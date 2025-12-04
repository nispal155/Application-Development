// Program.cs  -- Task 5
using System;
using System.Collections.Generic;
using System.Linq;

record CashierSales(string CashierName, decimal Sales);
record Applicant(string Name, int Age);
record Song(string Title, int DurationSeconds);

class Program
{
    static void Main()
    {
        // --- Aggregation Operator (Cashier sales) ---
        var cashierSales = new List<CashierSales>
        {
            new("Asha", 1200m),
            new("Binod", 900m),
            new("Chitra", 1500m),
            new("Dipesh", 700m),
            new("Esha", 2000m)
        };

        int totalCashiers = cashierSales.Count();
        decimal totalSales = cashierSales.Sum(cs => cs.Sales);
        decimal highestSales = cashierSales.Max(cs => cs.Sales);
        decimal lowestSales = cashierSales.Min(cs => cs.Sales);
        double averageSales = (double)cashierSales.Average(cs => cs.Sales);

        Console.WriteLine("=== Cashier Sales Summary ===");
        Console.WriteLine($"Total cashiers: {totalCashiers}");
        Console.WriteLine($"Total sales: Rs. {totalSales}");
        Console.WriteLine($"Highest sales: Rs. {highestSales}");
        Console.WriteLine($"Lowest sales: Rs. {lowestSales}");
        Console.WriteLine($"Average sales: Rs. {averageSales:F2}");
        Console.WriteLine();

        // --- Quantifier Operators (Applicants) ---
        var applicants = new List<Applicant>
        {
            new("Rita", 19),
            new("Sujan", 17),
            new("Meera", 20),
            new("Kiran", 16)
        };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine("=== Applicant Check ===");
        Console.WriteLine($"Any applicant under 18? {anyUnder18}");
        Console.WriteLine($"All applicants above 16? {allAbove16}");
        Console.WriteLine();

        // --- Element Operators (Songs) ---
        var songs = new List<Song>
        {
            new("Intro", 120),          // 2:00
            new("Ballad", 300),         // 5:00
            new("Upbeat", 250),         // 4:10
            new("Long Journey", 720),   // 12:00
            new("Outro", 95)            // 1:35
        };

        var firstSong = songs.First(); // throws if empty
        var lastSong = songs.Last();   // throws if empty

        // First song with duration > 4 minutes (4 * 60 = 240 sec)
        var firstAbove4Min = songs.First(s => s.DurationSeconds > 4 * 60);

        // safe result: first longer than 10 minutes (600 sec) - might be null
        var firstAbove10MinOrNull = songs.FirstOrDefault(s => s.DurationSeconds > 10 * 60);

        Console.WriteLine("=== Song Queries ===");
        Console.WriteLine($"First song: {firstSong.Title} ({firstSong.DurationSeconds}s)");
        Console.WriteLine($"Last song: {lastSong.Title} ({lastSong.DurationSeconds}s)");
        Console.WriteLine($"First song > 4 minutes: {firstAbove4Min.Title} ({firstAbove4Min.DurationSeconds}s)");
        Console.WriteLine($"First song > 10 minutes (safe): {(firstAbove10MinOrNull is null ? "none" : $"{firstAbove10MinOrNull.Title} ({firstAbove10MinOrNull.DurationSeconds}s)")}");
    }
}
