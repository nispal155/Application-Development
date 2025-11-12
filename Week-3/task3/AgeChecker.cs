namespace task3;

public class Program
{
   static void Main(string[] args)
   {
    AgeChecker ageChecker = new AgeChecker();
            ageChecker.CheckAge();
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
   }
}
