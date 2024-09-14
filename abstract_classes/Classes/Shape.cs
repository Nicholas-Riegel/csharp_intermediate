using System;

namespace abstract_classes.Classes;

public abstract class Shape
{
    public string Name {get;set;} = "No Name.";

    // has a default behavior and can be overridden or not.
    public virtual void GetInfo()
    {
        Console.WriteLine($"This is a {Name}.");
    }

    // An abstract method has no implementation in the base class and must be overridden in any non-abstract derived class.
    public abstract double Area();
}
