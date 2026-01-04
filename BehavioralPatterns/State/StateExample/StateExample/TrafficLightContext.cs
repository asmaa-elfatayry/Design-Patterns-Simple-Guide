

namespace StateExample;

public class TrafficLightContext
{
    private ITrafficLightState _state;

    public TrafficLightContext(ITrafficLightState state)
    {
        _state = state;
    }

    public void SetState(ITrafficLightState state)
    {
        _state = state;
    }

    public void Change()
    {
        _state.Handle(this);
    }
}
