public class Vehicle
{
    private double x, y, price, speed;
    private int year;

    public Vehicle(double x, double y, double price, double speed, int year)
    {
        this.x = x; 
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Координаты: ({x}, {y})");
        Console.WriteLine($"Цена: {price}");
        Console.WriteLine($"Скорость: {speed}");
        Console.WriteLine($"Год выпуска: {year}");
    }

}

public class Plane: Vehicle
{
    private double height;
    public int passengers;

    public Plane(double x, double y, double price, double speed, int year, double height, int passengers) : base(x, y, price, speed, year)
    {
        this.height = height;
        this.passengers = passengers;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Высота: {height}");
        Console.WriteLine($"Количество пассажиров: {passengers}");
    }
}

public class Ship: Vehicle
{
    private int passengers;
    private string port;

    public Ship(double x, double y, double price, double speed, int year, int passengers, string port):base(x, y, price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Количество пассажиров: {passengers}");
        Console.WriteLine($"Порт приписки: {port}");
    }
}

public class Car : Vehicle
{
    private string name;

    public Car(double x, double y, double price, double speed, int year, string name):base(x, y, price, speed, year)
    {
        this.name = name;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Название автомобиля: {name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Plane plane = new Plane(1, 2, 1000, 250, 1999, 10000, 15);
        plane.PrintInfo();

        Console.WriteLine();

        Car car = new Car(5, 10, 2500, 200, 2002, "Nissan Skyline");
        car.PrintInfo();

        Console.WriteLine();

        Ship ship = new Ship(17, 11, 1700, 100, 2000, 200, "Miami");
        ship.PrintInfo();
    }
}