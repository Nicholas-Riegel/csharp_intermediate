namespace oop.Classes;

public class Animal
{
    public string name;
    public string sound;
    public static int numOfAnimals = 0;

    public Animal()
    {
        name = "No name.";
        sound = "No sound.";
        numOfAnimals++;
    }
    
    public Animal(string name = "No name.")
    {
        // this refers to the object's name
        this.name = name;
        this.sound = "No sound.";
        numOfAnimals++;
    }
    
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

    public static void GetNumOfAnimals()
    {
        Console.WriteLine("The number of animals created is: {0}", numOfAnimals);
    }
}
