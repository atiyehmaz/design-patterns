using ObserverPattern.Observer;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay =new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            Console.WriteLine("\n");
            Console.WriteLine("*************************");

            weatherData.setMeasurements(82, 70, 29.2f);
            Console.WriteLine("\n");
            Console.WriteLine("*************************");

            weatherData.setMeasurements(78, 90, 29.2f);
            Console.WriteLine("\n");
            Console.WriteLine("*************************");


            Console.ReadKey();
        }
    }
}
