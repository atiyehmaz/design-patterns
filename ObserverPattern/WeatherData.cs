using System;
using System.Collections;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void notifyObservers()
        {
            foreach (var item in observers)
            {
                IObserver observer = (IObserver)item;
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i > 0)
                observers.Remove(i);
        }       

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }
    }
}
