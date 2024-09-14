using abstract_classes.Classes;

Shape[] shapes = [new Circle(5), new Rectangle(4, 5)];

foreach(Shape s in shapes)
{
    s.GetInfo();
    Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());

    if (s is Circle)
    {
        Console.WriteLine("This is a circle.");
    }
    else
    {
        Console.WriteLine("This isn't a circle.");
    }

    object circ1 = new Circle(4);
    Circle circ2 = (Circle)circ1;
    Console.WriteLine("The {0} area is {1:f2}", circ2.Name, circ2.Area());
}