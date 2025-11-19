using System;

namespace task2
{
    public class Calculator
    {
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the calculator");
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Multiply with a default value for num2 = 1 so that we  can call Multiply(6) or Multiply(6,4)
        public int Multiply(int num1, int num2 = 1)
        {
            return num1 * num2;
        }
    }
}
