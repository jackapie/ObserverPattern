using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //This class is one of the three displays. It implements both interfaces
    //IObserver allows it to get changes from the WeatherData object
    //IDisplayElement is also required by all display elements
    public class CurrentConditionDisplay : IObserver, IDisplayElement 
    {
        private float Temperature;
        private float Humidity;
        private ISubject WeatherData;

        //Constructor. This is passed the subject (WeatherData) which is used to register the display as an observer
        public CurrentConditionDisplay(ISubject weatherData)
        {
            WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        //Save the temperature and humidity and call the display
        public void Update(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            Display();
        }

        public void Display()
        {
            //Print the most recent temperaature and humidity
            Console.WriteLine("Current conditions: " + Temperature + "F degrees and " + Humidity + "% humidity");
           
        }
    }
}
