using System;

namespace interfaces2.Classes;

public class TVRemote
{
    public static IElectronicDevice GetDevice()
    {
        return new Television(); 
    }
}
