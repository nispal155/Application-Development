using System;

namespace task2
{
    // Class named Circle
    class Circle
    {
        // Declare a constant variable named PI
        public const double PI = 3.14;

        // Method to calculate area of the circle
        public double CalculateArea(double radius)
        {
            return PI * radius * radius;
        }

        // Method to calculate perimeter (circumference) of the circle
        public double CalculatePerimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            // Display the value of PI
            Console.WriteLine($"The value of PI is: {Circle.PI}");

            
            // Calculate and display area and perimeter
            double radius = 5.0;
            Console.WriteLine($"\nFor a circle with radius {radius}:");
            Console.WriteLine($"Area = {circle.CalculateArea(radius)}");
            Console.WriteLine($"Perimeter = {circle.CalculatePerimeter(radius)}");
        }
    }
}