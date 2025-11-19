namespace task4;

class Program
{
    static void Main()
    {
        Player p1 = new Player(); // default
        // print defaults (they will be null/0 unless set)
        Console.WriteLine("Player1: {0}, Level: {1}, Health: {2}", p1.PlayerName ?? "null", p1.Level, p1.Health);

        Player p2 = new Player("Zara", 5, 85);
        Console.WriteLine("Player2: {0}, Level: {1}, Health: {2}", p2.PlayerName, p2.Level, p2.Health);
    }
}
