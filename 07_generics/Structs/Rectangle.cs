using System.ComponentModel;
using System.Transactions;

namespace _07_generics.Structs;

public struct Rectangle<T>
{
    public T Length {get;set;}
    public T Width {get;set;}

    public Rectangle(T l, T w)
    {
        Length = l;
        Width = w;
    }

    public void GetArea()
    {
        double dw = Convert.ToDouble(Width);
        double dl = Convert.ToDouble(Length);
        Console.WriteLine($"The area is: {dl * dw}");
    }
}
