using System;

public class Website
{
    public string Name { get; set; }
    public string Path { get; set; }
    public string Description { get; set; }
    public string IpAddress { get; set; }

    public void InputData()
    {
        Console.WriteLine("Enter website name: ");
        Name = Console.ReadLine();
        Console.WriteLine("Enter website path: ");
        Path = Console.ReadLine();
        Console.WriteLine("Enter website description: ");
        Description = Console.ReadLine();
        Console.WriteLine("Enter website IP address: ");
        IpAddress = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine($"Website Name: {Name}");
        Console.WriteLine($"Path: {Path}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"IP Address: {IpAddress}");
    }
}

public class Program
{
    public static void Main()
    {
        Website website = new Website();
        website.InputData();
        website.DisplayData();
    }
}
