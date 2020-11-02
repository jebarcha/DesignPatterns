using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    // Some call this class as Observable (it is an object we can observe)
    public class PushSubject
    {
        private List<IPushObserver> observers = new List<IPushObserver>();
        public void addObserver(IPushObserver observer) 
        {
            observers.Add(observer);
        }
        public void removeObserver(IPushObserver observer)
        {
            observers.Remove(observer);
        }
        public void notifyObservers(int value)  // we can pass objects, but for simplicity we're using int type.
        {
            foreach (var observer in observers) 
            {
                observer.update(value);
            }
        }

    }
}
