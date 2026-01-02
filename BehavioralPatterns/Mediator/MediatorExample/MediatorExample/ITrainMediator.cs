

using System.Diagnostics;

namespace MediatorExample;

public interface ITrainMediator
{
    void Notify(Train train, string action);
}
