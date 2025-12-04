using System;

namespace Task2_1
{
    
    public delegate double DiscountStrategy(double price);

    class Program
    {
        // Discount implementations
        public static double FestivalDiscount(double price) => price * 0.8;   
        public static double SeasonalDiscount(double price) => price * 0.9;  
        public static double NoDiscount(double price) => price;         

        // Calculate final price by applying the provided discount strategy delegate
        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
            => strategy(originalPrice);

        static void Main(string[] args)
        {

            double original = 2500.0;

            Console.WriteLine($"Original price: Rs {original:0.00}\n");

            // Call with named strategy methods
            double festival = CalculateFinalPrice(original, FestivalDiscount);
            double seasonal = CalculateFinalPrice(original, SeasonalDiscount);
            double none = CalculateFinalPrice(original, NoDiscount);

            Console.WriteLine($"FestivalDiscount (20% off): Rs {festival:0.00}");
            Console.WriteLine($"SeasonalDiscount (10% off): Rs {seasonal:0.00}");
            Console.WriteLine($"NoDiscount: Rs {none:0.00}");

            // Call with a lambda expression (30% discount)
            double lambda30 = CalculateFinalPrice(original, p => p * 0.7);
            Console.WriteLine($"Lambda 30% discount: Rs {lambda30:0.00}");

            // Another lambda example: flat Rs 500 off (but not negative)
            double flat500 = CalculateFinalPrice(original, p => Math.Max(0, p - 500));
            Console.WriteLine($"Lambda flat Rs 500 off: Rs {flat500:0.00}");

            Console.WriteLine("\nDone. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
