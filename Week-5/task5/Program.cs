namespace task5;

class Program
{
    static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        Laptop l1 = new Laptop("Dell", 90000);
        Smartphone s1 = new Smartphone("Samsung", 45000);

        store.AddDevice(l1);
        store.AddDevice(s1);

        store.ShowAllDeviceDetails();

    }
}
