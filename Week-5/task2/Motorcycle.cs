namespace task2;
public class Motorcycle : Vehicle
{
    public int CC { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Engine CC: " + CC);
    }
}

