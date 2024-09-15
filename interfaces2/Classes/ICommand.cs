using System;

namespace interfaces2.Classes;

public interface ICommand
{
    void Execute();
    void Undo();
}
