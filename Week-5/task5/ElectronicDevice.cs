public abstract class ElectronicDevice
{
    private string brand;
    private double price;

    public string Brand { get => brand; set => brand = value; }
    public double Price { get => price; set => price = value; }

    public ElectronicDevice(string brand, double price)
    {
        Brand = brand;
        Price = price;
    }

    public abstract void ShowInfo();
}
