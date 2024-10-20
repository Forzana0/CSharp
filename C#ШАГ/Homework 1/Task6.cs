using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("Choose the conversion type:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");

        Console.Write("Enter your choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());

        double temperature;

        switch (choice)
        {
            case 1:
                Console.Write("Enter temperature in Fahrenheit: ");
                temperature = double.Parse(Console.ReadLine());
                double celsius = (temperature - 32) * 5 / 9;
                Console.WriteLine($"{temperature}°F is {celsius:F2}°C");
                break;

            case 2:
                Console.Write("Enter temperature in Celsius: ");
                temperature = double.Parse(Console.ReadLine());
                double fahrenheit = (temperature * 9 / 5) + 32;
                Console.WriteLine($"{temperature}°C is {fahrenheit:F2}°F");
                break;

            default:
                Console.WriteLine("Error: Invalid choice. Please enter 1 or 2.");
                break;
        }
    }
}
