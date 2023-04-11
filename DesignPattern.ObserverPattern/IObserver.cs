using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern
{
    public interface IObserver
    {
        void Update(Observable observable);
    }
}
