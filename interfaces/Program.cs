using interfaces.Classes;

Vehicle car1 = new("Buick", 4, 180);

if (car1 is IDrivable)
{
    car1.Move();
    car1.Stop();
}
else
{
    Console.WriteLine($"The {car1.Brand} cannot be driven.");
}