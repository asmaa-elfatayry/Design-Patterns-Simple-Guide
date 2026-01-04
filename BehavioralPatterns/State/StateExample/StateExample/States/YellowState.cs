
namespace StateExample.States;

public class YellowState : ITrafficLightState
{
    public void Handle(TrafficLightContext trafficLight)
    {
        Console.WriteLine("Yellow Light 🟡 → Get Ready");
        trafficLight.SetState(new RedState());
    }
}
