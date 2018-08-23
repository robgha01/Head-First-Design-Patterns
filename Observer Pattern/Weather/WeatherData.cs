using System.Collections.Generic;
using Weather.Interfaces;

namespace Weather
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            if(!_observers.Contains(o))
            {
                _observers.Add(o);
            }
        }

        public void RemoveObserver(IObserver o)
        {
            if(o != null && _observers.Contains(o))
            {
                _observers.Remove(o);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            MeasurementsChanged();
        }
    }
}
