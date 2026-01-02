using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample;

public class Train
{
    public string Name { get; }
    private ITrainMediator mediator;
    public bool IsOnTrack { get; set; } = false;

    public Train(string name, ITrainMediator mediator)
    {
        Name = name;
        this.mediator = mediator;
    }

    public void RequestTrack() //كل قطار يرسل طلبه فقط ل mediator
    {
        Console.WriteLine($"{Name}: requesting track...");
        mediator.Notify(this, "RequestTrack");
    }

    public void LeaveTrack()
    {
        Console.WriteLine($"{Name}: leaving track...");
        mediator.Notify(this, "LeaveTrack");
    }
}
