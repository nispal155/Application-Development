namespace task6;

public class Program
{
    static void Main(string[] args)
    {
            ErrorHandling eh = new ErrorHandling();

            Console.WriteLine("=== Task 6: Try Catch Finally ===\n");
            eh.HandleNumberInput();
            eh.ValidatePassword();
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
}
