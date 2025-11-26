namespace task4;

class Program
{
    static void Main(string[] args)
    {
        Car c = new Car();
        Bike b = new Bike();

        c.Display();
        c.StartEngine();
        c.StopEngine();

        b.Display();
        b.StartEngine();
        b.StopEngine();

    }
}
