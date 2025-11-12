using System;

namespace task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            DayChecker dayChecker = new DayChecker();
            dayChecker.CheckDay();
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
