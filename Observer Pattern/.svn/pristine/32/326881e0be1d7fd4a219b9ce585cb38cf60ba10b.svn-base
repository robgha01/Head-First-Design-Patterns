using Weather.Interfaces;

namespace Weather.Displays
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private readonly ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;

            Display();
        }

        public void Display()
        {
            System.Console.WriteLine(string.Format("Current conditions: {0} F degress and {1} % humidity", _temperature, _humidity));
        }
    }
}
