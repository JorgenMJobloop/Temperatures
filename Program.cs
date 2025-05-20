namespace Temperatures;

class Program
{
    static void Main(string[] args)
    {
        /*
        IOHandler iOHandler = new IOHandler();
        string output = iOHandler.ReadFileContent("my_text.json");
        Console.WriteLine(output);
        */

        TemperatureConverter temperatureConverter = new TemperatureConverter();

        double c = 17;
        double f = 62.6;
        temperatureConverter.ConvertToFahrenheit(c);

        temperatureConverter.ConvertToCelsius(f);

        Console.WriteLine("Enter a celsius or fahrenheit degree:");

    }
}
