namespace task5;

public class Program
{
     static void Main(string[] args)
        {
            LoopTasks loopTasks = new LoopTasks();git branch -M main
            Console.WriteLine("=== Task 5: Loops ===\n");
            loopTasks.SumFromOneToN();
            loopTasks.WhileLoopDemo();
            loopTasks.ArraySum();

            Console.WriteLine("All loop tasks executed successfully!");
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
}
