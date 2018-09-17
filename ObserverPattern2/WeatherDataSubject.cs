using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern2
{
    public class WeatherDataSubject : IObservable<WeatherData>
    {

        List<IObserver<WeatherData>> observers;
        List<WeatherData> readings;

        public WeatherDataSubject()
        {

        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }
    }
}
