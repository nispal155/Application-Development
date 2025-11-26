public abstract class Vehicle
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    public void Display()
    {
        Console.WriteLine("This is a vehicle");
    }
}
