﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("display StatisticsDisplay:" + temperature +
                              "F degrees and " + humidity + " %humidity");
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
    }
}
