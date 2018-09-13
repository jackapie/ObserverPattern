using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float CurrentPressure = 29.92f;
        private float LastPressure;
        private WeatherData WeatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            LastPressure = CurrentPressure;
            CurrentPressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Forecast: ");
            if(CurrentPressure > LastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            if(CurrentPressure == LastPressure)
            {
                Console.WriteLine("More of the same.");
            }
            if(CurrentPressure < LastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather!");
            }

        }
    }
}
