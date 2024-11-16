 using System;

public class Car
{
    public string X { get; set; } // Make
    public string Model { get; set; }
    public double Speed { get; private set; }
    public double Fuel { get; private set; }
    public double MaxFuel { get; private set; }
    public string SeatColor { get; set; } 

    public Car(string x, string model, double maxFuel, string seatColor)
    {
        X = x;         
        Model = model; 
        Speed = 0;
        MaxFuel = maxFuel;
        Fuel = maxFuel;
        SeatColor = seatColor; 
    }

    public void Status()
    {
        Console.WriteLine($"Car Status: Make: {X}, Model: {Model}, Speed: {Speed} km/h, Fuel: {Fuel:F2}/{MaxFuel} L, Seat Color: {SeatColor}");
    }

    public void Acceleration(double amount)
    {
        Speed += amount;
        Fuel -= amount * 0.05;

        Console.WriteLine($"{X} {Model} accelerates: Speed {Speed} km/h, Fuel left: {Fuel:F2} L");
    }
}

public class Program
{
    public static void Main()
    {
        Car car = new Car("Mercedes", "c200", 70, "Blue"); // Added seat color

        car.Status();       
        car.Acceleration(40); 
    }
}
