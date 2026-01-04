using StateExample;
using StateExample.States;

TrafficLightContext trafficLight =
    new TrafficLightContext(new RedState());

trafficLight.Change(); // Red → Green
trafficLight.Change(); // Green → Yellow
trafficLight.Change(); // Yellow → Red
trafficLight.Change(); // Red → Green

// without pattern
//if (_state == "Red")
//{
//    Console.WriteLine("Red Light 🔴 → Stop");
//    _state = "Green";
//}
//else if (_state == "Green")
//{
//    Console.WriteLine("Green Light 🟢 → Go");
//    _state = "Yellow";
//}
//else if (_state == "Yellow")
//{
//    Console.WriteLine("Yellow Light 🟡 → Get Ready");
//    _state = "Red";
//}