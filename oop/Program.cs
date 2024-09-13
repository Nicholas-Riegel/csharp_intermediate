using oop.Classes;
using oop.Structs;

// STRUCTS
// Rectangle rect1;
// rect1.length = 200;
// rect1.width = 50;

// Console.WriteLine("Area of rect1: {0}.", rect1.Area());

// Structs are value types, so they are passed as data, not references
// Rectangle rect2 = rect1;
// rect1.length = 33;

// Console.WriteLine(rect2.length); //= 200

// CLASSES
// Animal fox1 = new()
// {
//     name = "Fox1",
//     sound = "Reeeee"
// };

// Animal duck1 = new("Duck1", "Quack");

// Console.WriteLine(fox1.name);
// Console.WriteLine(duck1.name);
// fox1.MakeSound();
// duck1.MakeSound();
// Animal.GetNumOfAnimals();

// Console.WriteLine("Area of new rectangle is: {0}", ShapeMath.GetArea("rectangle", 5, 6));

// CLASSES CONT
// Animal animal1 = new("Foxy1");
// Console.WriteLine(animal1.name);
// Console.WriteLine(animal1.sound);
// Console.WriteLine("The number of animals created so far is {0}", Animal.GetNumOfAnimals());
// Animal2 animal2 = new();
// Console.WriteLine(animal2.name);
// Console.WriteLine(animal2.sound);
// Console.WriteLine(animal2.Owner);

// Animal2 cat = new();
// cat.SetName("Whiskers");
// cat.Sound = "Meow";

Animal3 Whiskers = new()
{
    Name = "Whiskers",
    Sound = "Meow"
};

Dog Grover = new()
{
    Name = "Grover",
    Sound = "Woof",
    Sound2 = "Grrrr"
};

Grover.Sound = "Wooooof";

Whiskers.MakeSound();
Grover.MakeSound();
Whiskers.SetAnimalIdInfo(123, "Sally Smith");
Whiskers.SetAnimalIdInfo(124, "Paul Brown");
Whiskers.GetAnimalIdInfo();
Animal3.AnimalHealth getHealth = new();
Console.WriteLine("Is my animal healthy? {0}", getHealth.HealthyWeight(11, 46));