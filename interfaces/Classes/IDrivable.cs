using System;

namespace interfaces.Classes;

// interfaces are contracts
// start with I and are adjectives
interface IDrivable
{
    int NumWheels {get;set;}
    double Speed {get;set;}

    void Move();
    void Stop();
}
