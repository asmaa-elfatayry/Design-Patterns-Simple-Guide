
namespace MediatorExample;

public class TrainStation : ITrainMediator
{
    private List<Train> trains = new List<Train>();

    public void RegisterTrain(Train train)
    {
        trains.Add(train);
    }

    public void Notify(Train train, string action)
    {
        if (action == "RequestTrack")
        {
            Console.WriteLine($"Station: Train {train.Name} requests a track.");

            //  check if any other train occupies the track
            foreach (var t in trains)
            {
                if (t != train && t.IsOnTrack)
                {
                    Console.WriteLine($"Station: Track is busy because of Train {t.Name}.");
                    return;
                }
            }

            Console.WriteLine($"Station: Track is free. Train {train.Name} can go.");
            train.IsOnTrack = true;
        }
        else if (action == "LeaveTrack")
        {
            Console.WriteLine($"Station: Train {train.Name} has left the track.");
            train.IsOnTrack = false;
        }
    }
}
