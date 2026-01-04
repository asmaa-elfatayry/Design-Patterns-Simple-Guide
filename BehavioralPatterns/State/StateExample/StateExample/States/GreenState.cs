

namespace StateExample.States;

public class GreenState:ITrafficLightState
{
    public void Handle(TrafficLightContext trafficLight)
    {
        Console.WriteLine("Green Light 🟢 → Go");
        trafficLight.SetState(new YellowState());
    }
}
