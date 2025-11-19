namespace task2
{
    class Program
    {
        static void Main()
        {   
            // Calculator object
            Calculator calc = new Calculator();

            // Call the welcome message method
            calc.PrintWelcome();

            // Call Add method passing value 5 and 7
            int sum = calc.Add(5, 7);
            Console.WriteLine("Add(5,7) = " + sum);

            // Call Multiply method with two numbers
            int prod1 = calc.Multiply(6, 4);

            // Call Multiply method with only one number (uses default value num2 = 1)
            int prod2 = calc.Multiply(6);

            // Print results
            Console.WriteLine("Multiply(6,4) = " + prod1);
            Console.WriteLine("Multiply(6) = " + prod2);
        }
    }
}
