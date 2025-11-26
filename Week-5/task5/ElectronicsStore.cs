public class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
    }

    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
    }

    public void ShowAllDeviceDetails()
    {
        foreach (var d in devices)
        {
            d.ShowInfo();

            if (d is Laptop laptop)
                laptop.TurnOnBattery();

            if (d is Smartphone phone)
                phone.EnableCamera();

            Console.WriteLine("-----------------------");
        }
    }
}
