using interfaces2.Classes;

IElectronicDevice TV = TVRemote.GetDevice();

PowerButton powBut = new(TV);

powBut.Execute();