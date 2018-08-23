using Weather;
using Weather.Displays;

namespace WeatherDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            
            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            var heatDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4F);
            weatherData.SetMeasurements(82, 70, 29.2F);
            weatherData.SetMeasurements(78, 90, 29.2F);
        }
    }
}
