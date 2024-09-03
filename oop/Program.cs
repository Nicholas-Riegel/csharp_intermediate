using oop.Classes;
using oop.Structs;

// STRUCTS
Rectangle rect1;
rect1.length = 200;
rect1.width = 50;

// Console.WriteLine("Area of rect1: {0}.", rect1.Area());

// Structs are value types, so they are passed as data, not references
Rectangle rect2 = rect1;
rect1.length = 33;

// Console.WriteLine(rect2.length); //= 200

// CLASSES
Animal fox1 = new()
{
    name = "Fox1",
    sound = "Reeeee"
};

Animal duck1 = new("Duck1", "Quack");

// Console.WriteLine(fox1.name);
// Console.WriteLine(duck1.name);
// fox1.MakeSound();
// duck1.MakeSound();
// Animal.GetNumOfAnimals();

// Console.WriteLine("Area of new rectangle is: {0}", ShapeMath.GetArea("rectangle", 5, 6));

// NULLABLE TYPES