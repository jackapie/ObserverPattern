using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserver
    {
        //All observers will implement the Update method
        //The arguements are the state values the observers get from the Subject when a weather measurement changes
        void Update(float temperature, float humidity, float pressure);
    }
}
