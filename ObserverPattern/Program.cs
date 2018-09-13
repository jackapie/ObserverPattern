using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the weatherData object
            WeatherData weatherData = new WeatherData();

            //Create the 3 displays and pass them the weatherData object
            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            //Add the new heat index display
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            //Input data (from fictional weather station)
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            //Show display output in console
            Console.ReadLine();

         
        }
    }
}
