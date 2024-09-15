using System;

namespace interfaces2.Classes;

public class Television : IElectronicDevice
{
    int Volume {get; set;}

    public void On()
    {
        Console.WriteLine("The TV is on.");
    }

    public void Off()
    {
        Console.WriteLine("The TV is off.");
    }

    public void VolumeUP()
    {
        if (Volume != 10) Volume++;
        Console.WriteLine($"The volume is at {Volume}");
    }
    
    public void VolumeDown()
    {
        if (Volume != 0) Volume--;
        Console.WriteLine($"The volume is at {Volume}");
    }

}
