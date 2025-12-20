using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    public class App
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NewUpdate(string version)
        {
            Console.WriteLine($"App released new version: {version}");
            Notify($"Version {version} is now available!");
        }

        private void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}
