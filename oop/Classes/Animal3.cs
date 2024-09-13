namespace oop.Classes;
public class Animal3
{
    protected string name = "";
    protected string sound = "";
    // is-a vs has-a relationship
    // Delegate
    protected AnimalIdInfo animalIdInfo = new();

    public void SetAnimalIdInfo(int Id, string owner)
    {
        animalIdInfo.IDNum = Id;
        animalIdInfo.Owner = owner;
    }

    public void GetAnimalIdInfo()
    {
        Console.WriteLine($"{Name} has the Id of {animalIdInfo.IDNum} and is owned by {animalIdInfo.Owner}");
    }

    public Animal3(string name, string sound)
    {
        Name = name;
        Sound = sound;
    }

    // default constructors
    public Animal3() : this("No name.", "No sound") {}
    
    public Animal3(string name) : this(name, "No sound") {}

    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} says {Sound}.");
    }

    // property
    public string Name
    {
        get {return name;}
        set
        {
            if (value.Any(char.IsDigit))
            {
                name = "No Name";
                Console.WriteLine("Name cannot contain digits.");
            }
            else
            {
                name = value;
            }
        }
    }
    
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

    public class AnimalHealth
    {
        public bool HealthyWeight(double height, double weight)
        {
            double calc = height / weight;
            if ( (calc >= .18) && (calc <= .27) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }   
}
