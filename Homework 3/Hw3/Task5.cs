using System;

public class Magazine
{
    public string Name { get; set; }
    public int YearFounded { get; set; }
    public string Description { get; set; }
    public string ContactPhone { get; set; }
    public string Email { get; set; }

    public void InputData()
    {
        Console.WriteLine("Enter magazine name: ");
        Name = Console.ReadLine();
        Console.WriteLine("Enter year founded: ");
        YearFounded = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter magazine description: ");
        Description = Console.ReadLine();
        Console.WriteLine("Enter contact phone: ");
        ContactPhone = Console.ReadLine();
        Console.WriteLine("Enter email: ");
        Email = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine($"Magazine Name: {Name}");
        Console.WriteLine($"Year Founded: {YearFounded}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Contact Phone: {ContactPhone}");
        Console.WriteLine($"Email: {Email}");
    }
}

public class Program_M
{
    public static void Main()
    {
        Magazine magazine = new Magazine();
        magazine.InputData();
        magazine.DisplayData();
    }
}
