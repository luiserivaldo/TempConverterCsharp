Console.WriteLine("Enter the temperature Unit: [C]elcius, [F]ahrenheit, [K]elvin:");
string userInputAsUnit = Console.ReadLine();
switch (userInputAsUnit)
{
    case "c":
        Console.WriteLine("Enter the temperature in Celcius: \n");
        float userInputCelcius = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your temperature in Fahrenheit is " + ((userInputCelcius * 9 / 5) + 32) + "F");
        Console.WriteLine("Your temperature in Kelvin is " + (userInputCelcius + 273.15) + "K");
        break;
    case "f":
        Console.WriteLine("Enter the temperature in Fahrenheit: \n");
        float userInputFahrenheit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your temperature in Celsius is " + ((userInputFahrenheit - 32) * 5 / 9) + "C");
        Console.WriteLine("Your temperature in Kelvin is " + (((userInputFahrenheit - 32) * 5 / 9 ) + 273.15) + "K");
        break;
    case "k":
        Console.WriteLine("Enter the temperature in Kelvin: \n");
        float userInputKelvin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your temperature in Celsius is " + (userInputKelvin - 273.15) + "C");
        Console.WriteLine("Your temperature in Fahrenheit is " + ((userInputKelvin - 273.15) * 9 / 5) + "F");
        break;
    default:
        Console.WriteLine("Incorrect input.");
        break;
}