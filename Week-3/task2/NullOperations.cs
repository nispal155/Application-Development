using System;

namespace Workshop
{
    public class Program
    {
    
         static void Main(string[] args)
        {
            NullOperations nop = new NullOperations();
            nop.PerformNullChecks();
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }  
    }

