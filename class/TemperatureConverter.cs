public class TemperatureConverter
{
    public void ConvertToFahrenheit(double celsius)
    {
        double convertToFahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine($"Degrees Celsius {celsius}\nDegrees Fahreneheit {convertToFahrenheit}");
    }

    public void ConvertToCelsius(double fahrenheit)
    {
        double convertToCelsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Degrees Fahrenheit: {fahrenheit}\nDegrees Celsius {convertToCelsius}");
    }
}