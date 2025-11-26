namespace task3;

class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer();
        p.Print("Hello");
        p.Print(123);
        p.Print("Repeated", 3);
    }
}
