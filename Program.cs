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

        Store store = new Store(new string[25], "Coffee beans", 100);
        MethodsAndFunctions methodsAndFunctions = new MethodsAndFunctions(["item1", "item2", "item3", "item4", "item5"]);

        store.PrintInventory();
        store.PrintPriceReduction();


        methodsAndFunctions.PrintAllItemsInList();

        methodsAndFunctions.UseLambdaExpression();



        TemperatureConverter temperatureConverter = new TemperatureConverter();

        Console.WriteLine("Enter a celsius or fahrenheit degree:\n C:<input celsius value> F: <input Fahrenheit value>");

        string? userInput = Console.ReadLine();

        string? doubleInput = Console.ReadLine();

        switch (userInput!.ToLower())
        {
            case "c":
                double c = Convert.ToDouble(doubleInput);
                temperatureConverter.ConvertToFahrenheit(c);
                break;
            case "f":
                double f = Convert.ToDouble(doubleInput);
                temperatureConverter.ConvertToCelsius(f);
                break;
            default:
                return;
        }

    }
}
