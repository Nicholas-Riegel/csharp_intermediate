namespace oop.Classes;

public class Animal2
{
    private string name = "";
    private string sound = "";
    public static int numOfAnimals = 0;
    public const string SHELTER = "Derek's shelter for animals.";
    // readonly is set by the constructor and then can't change
    public readonly int id;


    public Animal2(string name, string sound, int id)
    {
        SetName(name);
        Sound = sound;
        NumOfAnimals = 1;
        this.id = id;
    }

    // default constructors
    public Animal2() : this("No name.", "No sound", -1) {}
    
    public Animal2(string name) : this(name, "No sound", -1) {}

    public void MakeSound()
    {
         Console.WriteLine("{0} says {1}.", name, sound);
    }
    
    // Getters and Settters
    public void SetName(string name)
    {
        if (!name.Any(char.IsDigit))
        {
            this.name = name;
        }
        else
        {
            this.name = "No Name";
            Console.WriteLine("Name cannot contain numbers.");
        }
    }

    public string GetName()
    {
        return name;
    }

    // property
    public string Sound
    {
        get {return sound;}
        set
        {
            if (value.Length > 10)
            {
                sound = "No Sound";
                Console.WriteLine("Sound is too long");
            }
            else
            {
                sound = value;
            }
        }
    }

    public string Owner { get; set; } = "No owner";
    
    public static int NumOfAnimals
    {
        get { return numOfAnimals; }
        set { numOfAnimals += value; }
    }
}
