using System;

namespace task5
{
    public class LoopTasks
    {
        public void SumFromOneToN()
        {
            Console.Write("Enter a number (N): ");
            int n;

            if (int.TryParse(Console.ReadLine(), out n))
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"Sum from 1 to {n} is: {sum}\n");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.\n");
            }
        }

        // 2️⃣ Using WHILE loop: Print 1–20, skip multiples of 4, stop at 15
        public void WhileLoopDemo()
        {
            Console.WriteLine("Numbers from 1 to 20 (skip multiples of 4, stop at 15):");

            int i = 1;
            while (i <= 20)
            {
                if (i % 4 == 0)
                {
                    i++;
                    continue; 
                }

                if (i == 15)
                {
                    Console.WriteLine("Reached 15, breaking loop!");
                    break; 
                }

                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine("\n");
        }

        public void ArraySum()
        {
            int[] numbers = { 5, 10, 15, 20, 25 };
            int sum = 0;

            Console.Write("Array elements: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
                sum += num;
            }

            Console.WriteLine($"\nSum of all elements = {sum}\n");
        }
    }
}
