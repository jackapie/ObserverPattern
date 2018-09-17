using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern2
{
    public class WeatherData
    {
        private float Temperature;
        private float Humidity;
        private float Pressure;

        public WeatherData(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }

        public float GetTemperature
        {
            get { return Temperature; }
        }

        public float GetHumidity
        {
            get { return Humidity; }
        }

        public float GetPressure
        {
            get { return Pressure; }
        }
    }
}
