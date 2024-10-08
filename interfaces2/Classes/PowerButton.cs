using System;

namespace interfaces2.Classes;

public class PowerButton : ICommand
{
    IElectronicDevice _device;

    public PowerButton(IElectronicDevice device)
    {
        _device = device;
    }

    public void Execute()
    {
        _device.On();
    }

    public void Undo()
    {
        _device.Off();
    }
}
