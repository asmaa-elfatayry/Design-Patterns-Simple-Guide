

namespace StateExample.States;

public class RedState : ITrafficLightState
{
    public void Handle(TrafficLightContext trafficLight)
    {
        Console.WriteLine("Red Light 🔴 → Stop");
        trafficLight.SetState(new GreenState());
    }
}
