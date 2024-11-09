using System;

public class Store
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string ProfileDescription { get; set; }
    public string ContactPhone { get; set; }
    public string Email { get; set; }

    public void InputData()
    {
        Console.WriteLine("Enter store name: ");
        Name = Console.ReadLine();
        Console.WriteLine("Enter store address: ");
        Address = Console.ReadLine();
        Console.WriteLine("Enter store profile description: ");
        ProfileDescription = Console.ReadLine();
        Console.WriteLine("Enter contact phone: ");
        ContactPhone = Console.ReadLine();
        Console.WriteLine("Enter email: ");
        Email = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine($"Store Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Profile Description: {ProfileDescription}");
        Console.WriteLine($"Contact Phone: {ContactPhone}");
        Console.WriteLine($"Email: {Email}");
    }
}

public class Program_store
{
    public static void Main()
    {
        Store store = new Store();
        store.InputData();
        store.DisplayData();
    }
}
