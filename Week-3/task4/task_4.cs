using System;

namespace task4
{
    public class DayChecker
    {
        public void CheckDay()
        {
            Console.Write("Enter a number (1–7): ");
            int dayNumber;

            bool isValid = int.TryParse(Console.ReadLine(), out dayNumber);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                return;
            }

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid number. Please enter a value between 1 and 7.");
                    break;
            }
        }
    }
}
