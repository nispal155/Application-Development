namespace task2;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car() { Brand = "Toyota", Speed = 120, Seats = 4 };
        Motorcycle bike = new Motorcycle() { Brand = "Yamaha", Speed = 180, CC = 150 };
        car.Start();
        car.DisplayInfo();
        car.Stop();
        
        bike.Start();
        bike.DisplayInfo();
        bike.Stop();
    }
}
