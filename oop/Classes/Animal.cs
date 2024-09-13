namespace oop.Classes;

public class Animal
{
    public string name;
    public string sound;
    public static int numOfAnimals = 0;

    public Animal(string name = "No name.", string sound = "No sound.")
    {
        this.name = name;
        this.sound = sound;
        numOfAnimals++;
    }

    public void MakeSound()
    {
        Console.WriteLine("{0} says {1}", name, sound);
    }

    public static int GetNumOfAnimals()
    {
        return numOfAnimals;
    }
}
