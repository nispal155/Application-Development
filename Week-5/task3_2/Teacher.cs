namespace task3_2;
public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    public sealed void SalaryInfo()
    {
        Console.WriteLine("This method cannot be overridden");
    }
}