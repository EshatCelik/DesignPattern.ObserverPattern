using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern
{
    public abstract class Observable
    {
        private List<IObserver> observerList;
        public Observable()
        {
            observerList = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            observerList.Add(observer);
        }
        public void DeleteObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (IObserver  observer in observerList)
            {
                observer.Update( this);
            }
        }
    }
}
