namespace oop.Structs;

struct Rectangle(double l = 0, double w = 0)
{
    public double length = l;
    public double width = w;

    public readonly double Area()
    {
        return length * width;
    }
}