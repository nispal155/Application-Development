namespace task3;

class Program
{
    static void Main()
    {
        // object of parameterdemo class
        ParameterDemo pd = new ParameterDemo();

        int x = 5;
        Console.WriteLine("Before Increase: " + x);

        // Passing 'x' using ref – the method can change the original x
        pd.Increase(ref x);
        Console.WriteLine("After Increase: " + x);

         // Using 'out' – the method will give a value to 'name'
        pd.GetFullName(out string name);
        Console.WriteLine("Full name (out): " + name);
        // Passing multiple numbers because of 'params'
        int total = pd.SumAll(1, 2, 3, 4, 5);
        Console.WriteLine("SumAll(1..5) = " + total);
    }
}
