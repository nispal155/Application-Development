using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DateTime and TimeSpan Example ===\n");

            // 1. Create a DateTime variable representing your birthdate
            DateTime birthDate = new DateTime(2005, 4, 28); // Example: April 28, 2005

            // 2. Create another DateTime variable representing the current date and time
            DateTime currentDate = DateTime.Now;

            // 3. Calculate your age using TimeSpan
            TimeSpan ageDifference = currentDate - birthDate;
            double totalDays = ageDifference.TotalDays;
            int ageInYears = (int)(totalDays / 365.25); // Convert days to years approximately

            // 4. Print birthdate, current date, and age
            Console.WriteLine($"Your Birthdate : {birthDate.ToLongDateString()}");
            Console.WriteLine($"Current Date   : {currentDate.ToLongDateString()}");
            Console.WriteLine($"Your Age       : {ageInYears} years");

            // 5. Add 10 days to your birthdate and print the resulting date
            DateTime newDate = birthDate.AddDays(10);
            Console.WriteLine($"\nYour birthdate + 10 days = {newDate.ToLongDateString()}");

            Console.WriteLine("\n=== End of Program ===");
        }
    }
}
