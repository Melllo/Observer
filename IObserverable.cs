using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IObserverable
    {
         void AddObserver(IObserver o);
         void RemoveObserver(IObserver o);
         void NotifyObservers();
    }
}
