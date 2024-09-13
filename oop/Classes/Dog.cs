using System;

namespace oop.Classes;

public class Dog : Animal3
{
    public string Sound2 {get;set;} = "Grrr.";

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says {Sound} and {Sound2}.");
    }

    public Dog(string name = "No name", string sound = "No sound", string sound2 = "No sound 2") : base (name, sound)
    {
        Sound2 = sound2;
    }
}
