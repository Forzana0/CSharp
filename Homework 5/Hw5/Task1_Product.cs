using System;

public class Product
{
    public string Name { get; set; }
    public Money Price { get; set; }

    public Product(string name, int dollars, int cents)
    {
        Name = name;
        Price = new Money(dollars, cents);
    }

    public void Discount(int dollars, int cents)
    {

        int totalCentsToSubtract = (dollars * 100) + cents;
        int totalCents = (Price.Dollars * 100 + Price.Cents) - totalCentsToSubtract;

        Price.Dollars = totalCents / 100;
        Price.Cents = totalCents % 100;

        Console.WriteLine($"Ціна після знижки: {Price.Dollars} доларів, {Price.Cents} центів");
    }

    public void ShowProductInfo()
    {
        Console.WriteLine($"Продукт: {Name}");
        Price.DisplayAmount();
    }
}
