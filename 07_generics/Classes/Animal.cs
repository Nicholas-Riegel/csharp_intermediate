using System;

namespace _07_generics.Classes;

public class Animal
{
    public string Name {get;set;}
    public Animal(string name = "No name.") {Name = name;}

    // Generic
    // public static void GetSum(object num1, object num2) // this works just as well, but why be simple?
    public static void GetSum<X, Y>(ref X input1, ref Y input2)
    {
        double d1 = Convert.ToDouble(input1);
        double d2 = Convert.ToDouble(input2);
        Console.WriteLine($"{d1} plus {d2} equals {d1 + d2}.");
    }
}
