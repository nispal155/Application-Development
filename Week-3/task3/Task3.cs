using System;

namespace task3
{
    public class AgeChecker
    {
        public void CheckAge()
        {
            Console.Write("Enter your age: ");
            int age;

            bool isValid = int.TryParse(Console.ReadLine(), out age);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            if (age < 13)
            {
                Console.WriteLine("You are a Child.");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a Teenager.");
            }
            else if (age >= 20)
            {
                Console.WriteLine("You are an Adult.");
            }
            else
            {
                Console.WriteLine("Invalid age range.");
            }
        }
    }
}
