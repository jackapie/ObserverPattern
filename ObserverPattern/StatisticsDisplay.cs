using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float MaxTemp = 0.0f;
        private float MinTemp = 200;
        private float TempSum = 0.0f;
        private int NumReadings;
        private WeatherData WeatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            TempSum += temperature;
            NumReadings++;

            if(temperature > MaxTemp)
            {
                MaxTemp = temperature;
            }

            if(temperature < MinTemp)
            {
                MinTemp = temperature;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (TempSum / NumReadings)
            + "/" + MaxTemp + "/" + MinTemp);
        }
    }
}
