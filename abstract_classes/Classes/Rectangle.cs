using System;

namespace abstract_classes.Classes;

public class Rectangle : Shape
{
    public double Length {get; set;}
    public double Width {get; set;}

    public Rectangle(double length, double width)
    {
        Name = "Rectangle";
        Length = length;
        Width = width;
    }

    public override double Area()
    {
        return Length * Width;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine("It has a length of {0} and a width of {1}.", Length, Width);
    }
}
