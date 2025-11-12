namespace Workshop3
{
     class Operators
     {
        public void Addition(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        public void Subtractation(int a, int b)
        {
            Console.WriteLine("Difference: " + (a - b));
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine("Product: " + (a * b));
        }

        public void Divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine("Division Result: " + ((double)a / b));
            else
                Console.WriteLine("Error: Division by zero is not allowed.");
        }

        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }
        
     }
}