using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a rectangle object
            Rectangle r = new Rectangle(5, 3);

            Console.WriteLine("Length: " + r.Length);
            Console.WriteLine("Breadth: " + r.Breadth);
            Console.WriteLine("Area: " + r.Area);
            Console.WriteLine("Perimeter: " + r.Perimeter());
        }
    }
}
