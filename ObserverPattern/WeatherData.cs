using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //WeatherData implements the Subject interface
    public class WeatherData : ISubject
    {
        //A list holds the Observers (one subject to many observers); it is created in the constructor
        private List<IObserver> observers;

        private float Temperature;
        private float Humidity;
        private float Pressure;

        //Constructor, here the list of observers is created
        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        //Adds an observer to the end of the list
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        //Removes an observer from the list
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        //Notifies all observers of the state of the Subject via the Update method all observers have
        //This is implemented via the next method, MeasurementsChanged()
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        //Called when the station has new measurements. This then calls the NotifyObserver method
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        //As I don't have a real weather station, this sets the data to test the display elements.
        //Note the calling of MeasurementsChanged 
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
