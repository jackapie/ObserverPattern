using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface ISubject
    {
        //The following 2 methods take an observer as an arguement (that to be registered/removed)
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        //This method is called to notify all observers that the Subject's state has changed
        void NotifyObservers();

    }
}
