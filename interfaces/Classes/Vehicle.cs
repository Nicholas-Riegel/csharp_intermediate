using System;

namespace interfaces.Classes;

public class Vehicle : IDrivable
{
    public int NumWheels {get;set;}
    public double Speed {get;set;}
    public string Brand {get;set;}

    public Vehicle(string brand = "No brand.", int numWheels = 0, double speed = 0)
    {
        Brand = brand;
        NumWheels = numWheels;
        Speed = speed;
    }

    public void Move()
    {
        Console.WriteLine($"The {Brand} moves at {Speed}mph.");
    }
    
    public void Stop()
    {
        Console.WriteLine($"The {Brand} stops.");
        Speed = 0;
    }
}
